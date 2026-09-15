using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Data;
using SimuHeap.Utils;

namespace SimuHeap.Services
{
    public class ExecutorSimulacao
    {
        public List<EventoHeap> Eventos { get; } = new List<EventoHeap>();
        public List<HeapSnapshot> Snapshots { get; } = new List<HeapSnapshot>();

        private readonly Dictionary<int, int> referenciasBlocos = new();

        private readonly Dictionary<int, InformacaoAlocacaoBloco> informacoesAlocacao = new();

        public void Executar(HeapSimulator simulator, AlgoritmosDeAlocacao algoritmo, bool gerarPassosIntermediatios = true)
        {
            Snapshots.Clear();
            referenciasBlocos.Clear();
            informacoesAlocacao.Clear();

            int passo = 0;
            Snapshots.Add(CriarSnapshot(simulator, 0, "Estado Inicial"));
            passo++;

            foreach (EventoHeap evento in Eventos)
            {
                ErroSimulacao? erro = ExecutarEvento(simulator, evento, algoritmo, ref passo, gerarPassosIntermediatios);

                Snapshots.Add(CriarSnapshot(simulator, passo, evento.Descricao, null, evento.Id, erro));
                passo++;

                if(erro is null)
                {
                    ExecutarEscritaAposEvento(simulator, evento, ref passo);
                }
            }

        }

        private ErroSimulacao? ExecutarEvento(HeapSimulator simulador, EventoHeap evento, AlgoritmosDeAlocacao algoritmo, ref int passo, bool gerarPassosIntermediarios)
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

                        BlocoDeMemoria? bloco = simulador.Malloc(tamanhoSolicitado, malloc.TipoVariavel, Color.FromArgb(190, 50, 50), algoritmo, registrarPasso);
                        passo = passoLocal;

                        if (bloco is null) // falha de alocacao
                        {
                            return CriarErroFalhaAlocacao(simulador, tamanhoSolicitado);
                        }

                        // bloco alocado com sucesso
                        referenciasBlocos[malloc.ReferenciaBloco] = bloco.Id;

                        informacoesAlocacao[bloco.Id] =
                            new InformacaoAlocacaoBloco
                            {
                                IdBloco = bloco.Id,
                                IdEvento = evento.Id,
                                ReferenciaBloco = malloc.ReferenciaBloco,
                                TipoOperacao = TipoEventoHeap.Malloc,
                                DescricaoOperacao = malloc.Descricao,
                                NomeVariavel = string.IsNullOrWhiteSpace(evento.NomeVariavel) ? $"bloco{malloc.ReferenciaBloco}" : evento.NomeVariavel
                            };

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

                        BlocoDeMemoria? bloco = simulador.Calloc(tamanhoSolicitado, calloc.TipoVariavel, Color.FromArgb(190, 50, 50), algoritmo, registrarPasso);
                        passo = passoLocal;

                        if (bloco is null) // falha de alocacao
                        {
                            return CriarErroFalhaAlocacao(simulador, tamanhoSolicitado);
                        }

                        // alocacao com sucesso
                        referenciasBlocos[calloc.ReferenciaBloco] = bloco.Id;

                        informacoesAlocacao[bloco.Id] =
                            new InformacaoAlocacaoBloco
                            {
                                IdBloco = bloco.Id,
                                IdEvento = evento.Id,
                                ReferenciaBloco = calloc.ReferenciaBloco,
                                TipoOperacao = TipoEventoHeap.Calloc,
                                DescricaoOperacao = calloc.Descricao,
                                NomeVariavel = string.IsNullOrWhiteSpace(evento.NomeVariavel) ? $"bloco{calloc.ReferenciaBloco}" : evento.NomeVariavel
                            };

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

                        BlocoDeMemoria? bloco = simulador.Realloc(idBloco, tamanhoSolicitado, realloc.TipoVariavel, Color.FromArgb(190, 50, 50), algoritmo, registrarPasso);
                        passo = passoLocal;

                        if (bloco is null)
                        {
                            ErroSimulacao erro = CriarErroFalhaAlocacao(simulador, tamanhoSolicitado);

                            return new ErroSimulacao
                            {
                                Tipo = TipoErroSimulacao.FalhaRealocacao,
                                Titulo = "Falha de realocação",
                                Mensagem = "Não foi possível redimensionar o bloco solicitado.",
                                Detalhes = erro.Detalhes,
                                Explicacao =
                                    erro.Explicacao +
                                    "\r\n\r\n" +
                                    "Como a realocação falhou, o bloco original permanece alocado " +
                                    "e continua contendo seus dados anteriores."
                            };
                        }

                        informacoesAlocacao.Remove(idBloco);

                        referenciasBlocos[realloc.ReferenciaBloco] = bloco.Id;

                        informacoesAlocacao[bloco.Id] =
                            new InformacaoAlocacaoBloco
                            {
                                IdBloco = bloco.Id,
                                IdEvento = evento.Id,
                                ReferenciaBloco = realloc.ReferenciaBloco,
                                TipoOperacao = TipoEventoHeap.Realloc,
                                DescricaoOperacao = realloc.Descricao,
                                NomeVariavel = string.IsNullOrWhiteSpace(evento.NomeVariavel) ? $"bloco{realloc.ReferenciaBloco}" : evento.NomeVariavel
                            };

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

                        informacoesAlocacao.TryGetValue(idBloco, out InformacaoAlocacaoBloco? informacaoAnterior);
                        informacoesAlocacao.Remove(idBloco);

                        bool liberou = simulador.Free(idBloco, registrarPasso);
                        passo = passoLocal;


                        if (!liberou)
                        {
                            // Restaura a informação porque a liberação não ocorreu.
                            if (informacaoAnterior is not null)
                            {
                                informacoesAlocacao[idBloco] = informacaoAnterior;
                            }

                            return new ErroSimulacao
                            {
                                Tipo = TipoErroSimulacao.FalhaLiberacao,
                                Titulo = "Falha de liberação",
                                Mensagem = "Não foi possível liberar o bloco solicitado.",
                                Detalhes =
                                    $"Referência: bloco{free.ReferenciaBloco}\r\n" +
                                    $"ID do bloco: #{idBloco}",

                                Explicacao =
                                    "A referência da operação existe, porém o bloco ocupado " +
                                    "correspondente não foi encontrado na heap simulada. " +
                                    "Por segurança, nenhuma alteração foi realizada."
                            };
                        }

                        referenciasBlocos.Remove(free.ReferenciaBloco);

                        break;
                    }
                default:
                    throw new InvalidOperationException($"Tipo de evento desconhecido: {evento.GetType().Name}");
                    
            }

            return null;
        }

        private HeapSnapshot CriarSnapshot(HeapSimulator simulator, int passo, string descricaoEvento, EstadoPassoSimulacao? estado = null, int? idEvento = null, ErroSimulacao? erro = null)
        {
            return new HeapSnapshot
            {
                Passo = passo,
                DescricaoPasso = estado?.Descricao ?? descricaoEvento,

                IdEvento = idEvento,
                DescricaoEvento = descricaoEvento,

                EnderecoBlocoEmAnalise = estado?.EnderecoBlocoEmAnalise,
                DestaqueBlocoEmAnalise = estado?.DestaqueBlocoEmAnalise ?? TipoDestaqueSimulacao.Nenhum,

                EnderecoMelhorBloco = estado?.EnderecoMelhorBloco,
                DestaqueMelhorBloco = estado?.DestaqueMelhorBloco ?? TipoDestaqueSimulacao.Nenhum,

                EnderecoBlocoSecundario = estado?.EnderecoBlocoSecundario,
                DestaqueBlocoSecundario = estado?.DestaqueBlocoSecundario ?? TipoDestaqueSimulacao.Nenhum,

                Memoria = (byte[])simulator.Memoria.Clone(),
                Blocos = simulator.Blocos.Select(x => x.Clonar()).ToList(),
                BlocosLivres = simulator.Blocos.Where(x => x.EstaLivre).Select(x => x.Clonar()).ToList(),

                InformacoesAlocacao = informacoesAlocacao.ToDictionary(item => item.Key, item => item.Value.Clonar()),

                Erro = erro,

                Metricas = CalculadoraMetricasHeap.Calcular(simulator)
            };
        }

        private ErroSimulacao CriarErroFalhaAlocacao(HeapSimulator simulator, int tamanhoSolicitado)
        {
            int tamanhoTotalNecessario = Configuracoes.CalcularTamanhoTotalBloco(tamanhoSolicitado);
            List<BlocoDeMemoria> blocosLivres = simulator.Blocos.Where(x => x.EstaLivre).ToList();

            int totalLivre = blocosLivres.Sum(x => x.TamanhoTotal);

            int maiorBlocoLivre = blocosLivres.Count > 0 ? blocosLivres.Max(x => x.TamanhoTotal) : 0;

            bool falhaPorFragmentacao = totalLivre >= tamanhoTotalNecessario && maiorBlocoLivre < tamanhoTotalNecessario;

            if (falhaPorFragmentacao)
            {
                return new ErroSimulacao
                {
                    Tipo = TipoErroSimulacao.FalhaAlocacaoFragmentacao,
                    Titulo = "Falha de alocação por fragmentação externa",
                    Mensagem ="Não foi encontrado um bloco livre contíguo grande o suficiente.",

                    Detalhes =
                        $"Payload solicitado: {tamanhoSolicitado} bytes\r\n" +
                        $"Tamanho total necessário: {tamanhoTotalNecessario} bytes\r\n" +
                        $"Memória livre total: {totalLivre} bytes\r\n" +
                        $"Maior bloco livre: {maiorBlocoLivre} bytes",

                    Explicacao =
                        "Existe memória livre suficiente no total, porém ela está " +
                        "distribuída entre diferentes blocos livres. Como nenhum desses " +
                        "blocos possui tamanho suficiente para atender à solicitação, " +
                        "a alocação falha por fragmentação externa."
                };
            }

            return new ErroSimulacao
            {
                Tipo = TipoErroSimulacao.FalhaAlocacaoSemEspaco,
                Titulo = "Limite da heap simulada atingido",
                Mensagem =
                    "Não há memória livre suficiente na heap simulada para realizar esta alocação.",

                Detalhes =
                    $"Payload solicitado: {tamanhoSolicitado} bytes\r\n" +
                    $"Tamanho total necessário: {tamanhoTotalNecessario} bytes\r\n" +
                    $"Memória livre total: {totalLivre} bytes\r\n" +
                    $"Maior bloco livre: {maiorBlocoLivre} bytes",

                Explicacao =
                    "A heap simulada atingiu o limite de memória definido para esta simulação. " +
                    "A memória livre disponível não é suficiente para criar o bloco solicitado.\r\n\r\n" +

                    "Neste simulador, o tamanho da heap é fixo para facilitar a visualização " +
                    "de situações como esgotamento de espaço e fragmentação.\r\n\r\n" +

                    "Em um sistema real, a região administrada pelo alocador pode crescer. " +
                    "Quando não existe espaço suficiente nas regiões já disponíveis, o alocador " +
                    "pode solicitar mais memória ao sistema operacional.\r\n\r\n" +

                    "O crescimento não é ilimitado. Se o sistema operacional não puder fornecer " +
                    "mais memória, ou algum limite do processo for atingido, a alocação falha. "
            };
        }

        private void ExecutarEscritaAposEvento(HeapSimulator simulator, EventoHeap evento, ref int passo)
        {
            foreach (EscritaMemoria escrita in evento.EscritasAposEvento)
            {
                bool encontrou = referenciasBlocos.TryGetValue(escrita.ReferenciaBloco, out int idBloco);
                if (!encontrou) continue;

                BlocoDeMemoria? bloco = simulator.EscreverValoresNaMemoria(idBloco, escrita.TipoVariavel, escrita.Valores);
                if (bloco is null) continue;

                EstadoPassoSimulacao estado = new()
                {
                    Descricao = escrita.Descricao,
                    EnderecoBlocoEmAnalise = bloco.EnderecoInicio
                };

                Snapshots.Add(CriarSnapshot(simulator, passo, escrita.Descricao, estado, evento.Id));
                passo++;
            }
        }
    }
}
