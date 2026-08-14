using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Data;

namespace SimuHeap.Services
{
    public class ExecutorSimulacao
    {
        public List<EventoHeap> Eventos { get; } = new List<EventoHeap>();
        public List<HeapSnapshot> Snapshots { get; } = new List<HeapSnapshot>();

        private readonly Dictionary<int, int> referenciasBlocos = new();

        public void Executar(HeapSimulator simulator, bool gerarPassosIntermediatios = true)
        {
            Snapshots.Clear();
            referenciasBlocos.Clear();

            int passo = 0;
            Snapshots.Add(CriarSnapshot(simulator, 0, "Estado Inicial"));
            passo++;

            foreach (EventoHeap evento in Eventos)
            {
                ExecutarEvento(simulator, evento, ref passo, gerarPassosIntermediatios);

                Snapshots.Add(CriarSnapshot(simulator, passo, evento.Descricao, null, evento.Id));
                passo++;
            }

        }

        private void ExecutarEvento(HeapSimulator simulador, EventoHeap evento, ref int passo, bool gerarPassosIntermediarios)
        {
            switch (evento)
            {
                case EventoMalloc malloc:
                    {
                        int tamanhoTipo = Configuracoes.ObterTamanhoTipo(malloc.TipoVariavel);
                        int tamanhoSolicitado = malloc.Quantidade * tamanhoTipo;

                        int passoLocal = passo;
                        Action<EstadoPassoSimulacao>? registrarPasso = null;
                        if (gerarPassosIntermediarios)
                        {
                            registrarPasso = estado =>
                            {
                                Snapshots.Add(CriarSnapshot(simulador, passoLocal, malloc.Descricao, estado, evento.Id));
                                passoLocal++;
                            };
                        }

                        BlocoDeMemoria? bloco = simulador.Malloc(tamanhoSolicitado, malloc.TipoVariavel, Color.FromArgb(190, 50, 50), AlgoritmosDeAlocacao.FirstFit, registrarPasso);
                        passo = passoLocal;

                        if (bloco is not null) referenciasBlocos[malloc.ReferenciaBloco] = bloco.Id;

                        break;
                    }
                    
                case EventoCalloc calloc:
                    {
                        int tamanhoTipo = Configuracoes.ObterTamanhoTipo(calloc.TipoVariavel);
                        int tamanhoSolicitado = calloc.Quantidade * tamanhoTipo;

                        int passoLocal = passo;
                        Action<EstadoPassoSimulacao>? registrarPasso = null;
                        if (gerarPassosIntermediarios)
                        {
                            registrarPasso = estado =>
                            {
                                Snapshots.Add(CriarSnapshot(simulador, passoLocal, calloc.Descricao, estado, evento.Id));
                                passoLocal++;
                            };
                        }

                        BlocoDeMemoria? bloco = simulador.Calloc(tamanhoSolicitado, calloc.TipoVariavel, Color.FromArgb(190, 50, 50), AlgoritmosDeAlocacao.FirstFit, registrarPasso);
                        passo = passoLocal;

                        if (bloco is not null) referenciasBlocos[calloc.ReferenciaBloco] = bloco.Id;

                        break;
                    }
                    
                    
                case EventoRealloc realloc:
                    {
                        int tamanhoTipo = Configuracoes.ObterTamanhoTipo(realloc.TipoVariavel);
                        int tamanhoSolicitado = realloc.NovaQuantidade * tamanhoTipo;
                        bool encontrou = referenciasBlocos.TryGetValue(realloc.ReferenciaBloco, out int idBloco);

                        if (!encontrou)
                        {
                            break;
                        }

                        int passoLocal = passo;
                        Action<EstadoPassoSimulacao>? registrarPasso = null;
                        if (gerarPassosIntermediarios)
                        {
                            registrarPasso = estado =>
                            {
                                Snapshots.Add(CriarSnapshot(simulador, passoLocal, realloc.Descricao, estado, evento.Id));
                                passoLocal++;
                            };
                        }

                        BlocoDeMemoria? bloco = simulador.Realloc(idBloco, tamanhoSolicitado, realloc.TipoVariavel, Color.FromArgb(190, 50, 50), AlgoritmosDeAlocacao.FirstFit, registrarPasso);
                        passo = passoLocal;

                        if (bloco is not null) referenciasBlocos[realloc.ReferenciaBloco] = bloco.Id;

                        break;
                    }
                case EventoFree free:
                    {
                        // simulator free
                        int idBloco;
                        bool encontrou = referenciasBlocos.TryGetValue(free.ReferenciaBloco, out idBloco);
                        if (!encontrou) break;

                        int passoLocal = passo;
                        Action<EstadoPassoSimulacao>? registrarPasso = null;
                        if (gerarPassosIntermediarios)
                        {
                            registrarPasso = estado =>
                            {
                                Snapshots.Add(CriarSnapshot(simulador, passoLocal, free.Descricao, estado, evento.Id));
                                passoLocal++;
                            };
                        }

                        simulador.Free(idBloco, registrarPasso);
                        passo = passoLocal;
                        break;
                    }
                default:
                    MessageBox.Show("Evento desconhecido");
                    break;
            }
        }

        private HeapSnapshot CriarSnapshot(HeapSimulator simulator, int passo, string descricaoEvento, EstadoPassoSimulacao? estado = null, int? idEvento = null)
        {
            return new HeapSnapshot
            {
                Passo = passo,
                IdEvento = idEvento,
                DescricaoEvento = descricaoEvento,
                DescricaoPasso = estado?.Descricao ?? descricaoEvento,
                EnderecoBlocoEmAnalise = estado?.EnderecoBlocoEmAnalise,
                EnderecoMelhorBloco = estado?.EnderecoMelhorBloco,
                Memoria = (byte[])simulator.Memoria.Clone(),
                Blocos = simulator.Blocos.Select(x => x.Clonar()).ToList(),
                BlocosLivres = simulator.Blocos.Where(x => x.EstaLivre).Select(x => x.Clonar()).ToList(),
            };
        }
    }
}
