using SimuHeap.Data;
using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Services
{
    public class HeapSimulator
    {
        public byte[] Memoria { get; }
        public LinkedList<BlocoDeMemoria> Blocos { get; }
        public int TamanhoHeap => Memoria.Length;
        private int proximoId = 1;

        public bool UsarSplit { get; set; }
        public bool UsarCoalescing { get; set; }

        public HeapSimulator(int tamanhoHeap)
        {
            Memoria = new byte[tamanhoHeap];
            Blocos = new LinkedList<BlocoDeMemoria>();

            Resetar();
        }

        public void Resetar()
        {
            //Array.Clear(Memoria); // inicializa com 00
            Random.Shared.NextBytes(Memoria); // inicializa com conteudo indeterminado
            Blocos.Clear();

            proximoId = 1;

            BlocoDeMemoria blocoInicial = BlocoDeMemoria.CriarLivre(GerarNovoId(), 0, TamanhoHeap, Color.FromArgb(40, 140, 70));
            Blocos.AddLast(blocoInicial);

            EscreverMetadadosBloco(blocoInicial);
        }

        public BlocoDeMemoria? Malloc(int tamanhoSolicitado, TiposDeVariaveis tipo, Color cor, AlgoritmosDeAlocacao algoritmo, Action<EstadoPassoSimulacao>? aoGerarPasso = null)
        {
            if(tamanhoSolicitado <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tamanhoSolicitado), "O tamanho solicitado deve ser maior que zero.");
            }

            int tamanhoTotalNecessario = Configuracoes.CalcularTamanhoTotalBloco(tamanhoSolicitado);

            LinkedListNode<BlocoDeMemoria>? blocoLivre = BuscarBlocoLivre(tamanhoTotalNecessario, algoritmo, aoGerarPasso);

            if (blocoLivre == null) return null; // ocorreu uma falha de alocação (bloco livre nao encontrado)

            int tamanhoRestante = blocoLivre.Value.TamanhoTotal - tamanhoTotalNecessario;

            // verifica se split está habilitado e se tem espaço para o bloco minimo valido
            if(UsarSplit && tamanhoRestante >= Configuracoes.TAM_MIN_BLOCO)
            {
                return DividirBloco(blocoLivre, tamanhoSolicitado, tipo, cor);
            }

            // se o split nao estiver habilitado, todo o bloco livre sera utilizado
            return OcuparBlocoInteiro(blocoLivre, tamanhoSolicitado, tipo, cor);
        }

        public BlocoDeMemoria Calloc()
        {
            throw new NotImplementedException();
        }

        public BlocoDeMemoria Realloc()
        {
            throw new NotImplementedException();
        }

        public bool Free(int idBloco, Action<EstadoPassoSimulacao>? aoGerarPasso = null)
        {
            LinkedListNode<BlocoDeMemoria>? atual = Blocos.First;

            while(atual is not null)
            {
                BlocoDeMemoria bloco = atual.Value;

                if(!bloco.EstaLivre && bloco.Id == idBloco)
                {
                    int enderecoInicio = bloco.EnderecoInicio;
                    int tamanhoTotal = bloco.TamanhoTotal;
                    BlocoDeMemoria blocoLivre = BlocoDeMemoria.CriarLivre(bloco.Id, enderecoInicio, tamanhoTotal, Color.FromArgb(40, 140, 70));
                    atual.Value = blocoLivre;

                    EscreverMetadadosBloco(blocoLivre);

                    aoGerarPasso?.Invoke(new EstadoPassoSimulacao
                    {
                        Descricao = $"Bloco #{blocoLivre.Id} sendo liberado.",
                        EnderecoBlocoEmAnalise = blocoLivre.EnderecoInicio
                    });

                    if (UsarCoalescing)
                    {
                        UnirBlocosLivres(atual, aoGerarPasso);
                    }

                    return true;
                }

                atual = atual.Next;
            }
            return false;
        }

        private BlocoDeMemoria DividirBloco(LinkedListNode<BlocoDeMemoria> noLivre, int tamanhoSolicitado, TiposDeVariaveis tipo, Color cor) 
        {
            BlocoDeMemoria blocoOriginal = noLivre.Value;

            BlocoDeMemoria blocoOcupado = BlocoDeMemoria.CriarOcupado(blocoOriginal.Id, blocoOriginal.EnderecoInicio, tamanhoSolicitado, tipo, cor);

            int tamanhoRestante = blocoOriginal.TamanhoTotal - blocoOcupado.TamanhoTotal;

            int enderecoNovoBlocoLivre = blocoOcupado.EnderecoFim + 1;

            BlocoDeMemoria novoBlocoLivre = BlocoDeMemoria.CriarLivre(GerarNovoId(), enderecoNovoBlocoLivre, tamanhoRestante, Color.FromArgb(40, 140, 70));

            noLivre.Value = blocoOcupado;
            Blocos.AddAfter(noLivre, novoBlocoLivre);

            EscreverMetadadosBloco(blocoOcupado);
            EscreverMetadadosBloco(novoBlocoLivre);

            return blocoOcupado;
        }

        private void UnirBlocosLivres(LinkedListNode<BlocoDeMemoria> noAtual, Action<EstadoPassoSimulacao>? aoGerarPasso = null)
        {
            // Primeiro tenta unir com o bloco anterior.
            if (noAtual.Previous is not null && noAtual.Previous.Value.EstaLivre)
            {
                LinkedListNode<BlocoDeMemoria> noAnterior = noAtual.Previous;

                BlocoDeMemoria blocoAnterior = noAnterior.Value;

                BlocoDeMemoria blocoAtual = noAtual.Value;

                int tamanhoTotal = blocoAnterior.TamanhoTotal +  blocoAtual.TamanhoTotal;

                // Mantém o ID do bloco mais à esquerda.
                BlocoDeMemoria blocoUnido = BlocoDeMemoria.CriarLivre(
                                                            blocoAnterior.Id,
                                                            blocoAnterior.EnderecoInicio,
                                                            tamanhoTotal,
                                                            Color.FromArgb(40, 140, 70));

                noAnterior.Value = blocoUnido;

                // O bloco atual deixou de existir.
                Blocos.Remove(noAtual);

                // Agora o "bloco atual" passa a ser o anterior unido.
                noAtual = noAnterior;

                EscreverMetadadosBloco(blocoUnido);

                aoGerarPasso?.Invoke(new EstadoPassoSimulacao
                {
                    Descricao = $"Unindo blocos livres #{noAnterior.Value.Id} e {noAtual.Value.Id}.",
                    EnderecoBlocoEmAnalise = noAtual.Value.EnderecoInicio
                });
            }

            // Depois tenta unir com o próximo.
            if (noAtual.Next is not null && noAtual.Next.Value.EstaLivre)
            {
                LinkedListNode<BlocoDeMemoria> noProximo = noAtual.Next;

                BlocoDeMemoria blocoAtual = noAtual.Value;

                BlocoDeMemoria blocoProximo = noProximo.Value;

                int tamanhoTotal = blocoAtual.TamanhoTotal + blocoProximo.TamanhoTotal;

                BlocoDeMemoria blocoUnido = BlocoDeMemoria.CriarLivre(
                                                            blocoAtual.Id,
                                                            blocoAtual.EnderecoInicio,
                                                            tamanhoTotal,
                                                            Color.FromArgb(40, 140, 70));

                noAtual.Value = blocoUnido;

                // O bloco da direita deixa de existir.
                Blocos.Remove(noProximo);

                EscreverMetadadosBloco(blocoUnido);

                aoGerarPasso?.Invoke(new EstadoPassoSimulacao
                {
                    Descricao = $"Blocos unidos. #{blocoUnido.Id} agora possui {blocoUnido.TamanhoTotal} bytes.",
                    EnderecoBlocoEmAnalise = blocoUnido.EnderecoInicio
                });
            }
        }

        private int GerarNovoId() 
        { 
            return proximoId++; 
        }

        private LinkedListNode<BlocoDeMemoria>? BuscarBlocoLivre(int tamanhoNecessario, AlgoritmosDeAlocacao algoritmo, Action<EstadoPassoSimulacao>? aoGerarPasso)
        {
            switch (algoritmo)
            {
                case AlgoritmosDeAlocacao.FirstFit:
                    return BuscarFirstFit(tamanhoNecessario, aoGerarPasso);
                case AlgoritmosDeAlocacao.BestFit:
                    return BuscarBestFit(tamanhoNecessario);
                case AlgoritmosDeAlocacao.WorstFit:
                    return BuscarWorstFit(tamanhoNecessario);
                default:
                    throw new ArgumentOutOfRangeException(nameof(algoritmo), "Algoritmo de alocação inválido");
            }
        }

        private LinkedListNode<BlocoDeMemoria>? BuscarFirstFit(int tamanhoNecessario, Action<EstadoPassoSimulacao>? aoGerarPasso)
        {
            LinkedListNode<BlocoDeMemoria>? atual = Blocos.First;

            while (atual != null)
            {
                BlocoDeMemoria bloco = atual.Value;

                if (bloco.EstaLivre)
                {
                    aoGerarPasso?.Invoke(new EstadoPassoSimulacao
                    {
                        Descricao = $"Analisando bloco livre de {bloco.TamanhoTotal} bytes.",
                        EnderecoBlocoEmAnalise = bloco.EnderecoInicio,
                        EnderecoMelhorBloco = null
                    });

                    if(bloco.TamanhoTotal >= tamanhoNecessario)
                    {
                        aoGerarPasso?.Invoke(new EstadoPassoSimulacao
                        {
                            Descricao = $"Bloco de {bloco.TamanhoTotal} bytes selecionado pelo First-Fit.",
                            EnderecoBlocoEmAnalise = null,
                            EnderecoMelhorBloco = bloco.EnderecoInicio
                        });

                        return atual;
                    }
                }

                atual = atual.Next;
            }

            return null;
        }

        private LinkedListNode<BlocoDeMemoria>? BuscarBestFit(int tamanhoNecessario)
        {
            throw new NotImplementedException();
        }

        private LinkedListNode<BlocoDeMemoria>? BuscarWorstFit(int tamanhoNecessario)
        {
            throw new NotImplementedException();
        }

        private BlocoDeMemoria OcuparBlocoInteiro(LinkedListNode<BlocoDeMemoria> noLivre, int tamanhoSolicitado, TiposDeVariaveis tipo, Color cor)
        {
            BlocoDeMemoria blocoLivre = noLivre.Value;

            BlocoDeMemoria blocoOcupado = BlocoDeMemoria.CriarOcupadoComBlocoInteiro(blocoLivre.Id, blocoLivre.EnderecoInicio, tamanhoSolicitado, blocoLivre.TamanhoTotal, tipo, cor);

            noLivre.Value = blocoOcupado;

            EscreverMetadadosBloco(blocoOcupado);

            return blocoOcupado;
        }

        private void EscreverMetadadosBloco(BlocoDeMemoria bloco)
        {
            uint tamanho = (uint)bloco.TamanhoTotal;

            uint valorHeader = bloco.EstaLivre ? tamanho : tamanho | Configuracoes.FLAG_OCUPADO;

            uint valorFooter = tamanho;

            BinaryPrimitives.WriteUInt32LittleEndian(Memoria.AsSpan(bloco.EnderecoHeader, Configuracoes.TAM_HEADER), valorHeader);

            BinaryPrimitives.WriteUInt32LittleEndian(Memoria.AsSpan(bloco.EnderecoFooter, Configuracoes.TAM_FOOTER), valorFooter);
        }
    }
}
