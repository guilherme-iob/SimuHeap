using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Services
{
    public class ExecutorSimulacao
    {
        public List<EventoHeap> Eventos { get; } = new List<EventoHeap>();
        public List<HeapSnapshot> Snapshots { get; } = new List<HeapSnapshot>();

        public void Executar(HeapSimulator simulator, bool gerarPassosIntermediatios = true)
        {
            Snapshots.Clear();
            int passo = 0;
            Snapshots.Add(CriarSnapshot(simulator, 0, "Estado Inicial"));
            passo++;

            // teste temporario
            //BlocoDeMemoria? primeiroLivre = simulator.Blocos.FirstOrDefault(x => x.EstaLivre);
            //if(primeiroLivre is not null)
            //{
            //    Snapshots.Add(CriarSnapshot(simulator, passo, "Teste Analise", new EstadoPassoSimulacao
            //    {
            //        Descricao = "bloco livre sendo analisado",
            //        EnderecoBlocoEmAnalise = primeiroLivre.EnderecoInicio
            //    }));

            //    passo++;

            //    Snapshots.Add(
            //        CriarSnapshot(
            //            simulator,
            //            passo,
            //            "Teste de melhor bloco",
            //            new EstadoPassoSimulacao
            //            {
            //                Descricao =
            //                    "Bloco definido como melhor candidato.",

            //                EnderecoMelhorBloco =
            //                    primeiroLivre.EnderecoInicio
            //            }
            //        )
            //    );
            //    passo++;
            //}



            // ==============

            foreach (EventoHeap evento in Eventos)
            {
                ExecutarEvento(simulator, evento);

                Snapshots.Add(CriarSnapshot(simulator, passo, evento.Descricao));
                passo++;
            }

        }

        private void ExecutarEvento(HeapSimulator simulador, EventoHeap evento)
        {
            switch (evento)
            {
                case EventoMalloc malloc:
                    MessageBox.Show("Evento Malloc executado");
                    int tamanhoTipo = ObterTamanhoTipo(malloc.TipoVariavel);
                    int tamanhoSolicitado = malloc.Quantidade * tamanhoTipo;

                    BlocoDeMemoria? bloco = simulador.Malloc(tamanhoSolicitado, malloc.TipoVariavel, Color.FromArgb(190, 50, 50), AlgoritmosDeAlocacao.FirstFit);

                    break;
                case EventoCalloc:
                    MessageBox.Show("Evento Calloc executado");
                    // simulator calloc
                    break;
                case EventoRealloc:
                    MessageBox.Show("Evento Realloc executado");
                    // simulator realloc
                    break;
                case EventoFree:
                    MessageBox.Show("Evento Free executado");
                    // simulator free
                    break;
                default:
                    MessageBox.Show("Evento desconhecido");
                    break;
            }
        }

        private HeapSnapshot CriarSnapshot(HeapSimulator simulator, int passo, string descricaoEvento, EstadoPassoSimulacao? estado = null)
        {
            return new HeapSnapshot
            {
                Passo = passo,
                DescricaoEvento = descricaoEvento,
                DescricaoPasso = estado?.Descricao ?? descricaoEvento,
                EnderecoBlocoEmAnalise = estado?.EnderecoBlocoEmAnalise,
                EnderecoMelhorBloco = estado?.EnderecoMelhorBloco,
                Memoria = (byte[])simulator.Memoria.Clone(),
                Blocos = simulator.Blocos.Select(x => x.Clonar()).ToList(),
                BlocosLivres = simulator.Blocos.Where(x => x.EstaLivre).Select(x => x.Clonar()).ToList(),
            };
        }

        private int ObterTamanhoTipo(TiposDeVariaveis tipo)
        {
            return tipo switch
            {
                TiposDeVariaveis.Char => 1,
                TiposDeVariaveis.Short => 2,
                TiposDeVariaveis.Int => 4,
                TiposDeVariaveis.Long => 8,
                TiposDeVariaveis.Float => 4,
                TiposDeVariaveis.Double => 8,

                _ => throw new ArgumentOutOfRangeException(
                    nameof(tipo))
            };
        }
    }
}
