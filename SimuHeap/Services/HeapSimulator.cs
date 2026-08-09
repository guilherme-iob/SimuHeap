using SimuHeap.Data;
using SimuHeap.Enums;
using SimuHeap.Models;
using System;
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
            Array.Clear(Memoria);
            Blocos.Clear();

            Blocos.AddLast(BlocoDeMemoria.CriarLivre(0, TamanhoHeap, Color.FromArgb(40, 140, 70)));
            proximoId = 1;
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

        public bool Free(int idBloco)
        {
            LinkedListNode<BlocoDeMemoria>? atual = Blocos.First;

            while(atual is not null)
            {
                BlocoDeMemoria bloco = atual.Value;

                if(!bloco.EstaLivre && bloco.Id == idBloco)
                {
                    int enderecoInicio = bloco.EnderecoInicio;
                    int tamanhoTotal = bloco.TamanhoTotal;
                    atual.Value = BlocoDeMemoria.CriarLivre(enderecoInicio, tamanhoTotal, Color.FromArgb(40, 140, 70));
                }

                if (UsarCoalescing)
                {
                    UnirBlocosLivres();
                }

                atual = atual.Next;
            }
            return false;
        }

        private BlocoDeMemoria DividirBloco(LinkedListNode<BlocoDeMemoria> noLivre, int tamanhoSolicitado, TiposDeVariaveis tipo, Color cor) 
        {
            BlocoDeMemoria blocoOriginal = noLivre.Value;

            BlocoDeMemoria blocoOcupado = BlocoDeMemoria.CriarOcupado(GerarNovoId(), blocoOriginal.EnderecoInicio, tamanhoSolicitado, tipo, cor);

            int tamanhoRestante = blocoOriginal.TamanhoTotal - blocoOcupado.TamanhoTotal;

            int enderecoNovoBlocoLivre = blocoOcupado.EnderecoFim + 1;

            BlocoDeMemoria novoBlocoLivre = BlocoDeMemoria.CriarLivre(enderecoNovoBlocoLivre, tamanhoRestante, Color.FromArgb(40, 140, 70));

            noLivre.Value = blocoOcupado;
            Blocos.AddAfter(noLivre, novoBlocoLivre);

            return blocoOcupado;
        }

        private void UnirBlocosLivres()
        {
            throw new NotImplementedException();
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

            BlocoDeMemoria blocoOcupado = BlocoDeMemoria.CriarOcupadoComBlocoInteiro(GerarNovoId(), blocoLivre.EnderecoInicio, tamanhoSolicitado, blocoLivre.TamanhoTotal, tipo, cor);

            noLivre.Value = blocoOcupado;

            return blocoOcupado;
        }
    }
}
