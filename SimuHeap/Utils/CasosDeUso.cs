using SimuHeap.Enums;
using SimuHeap.Models;
using SimuHeap.Services;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Utils
{
    public static class CasosDeUso
    {
        /*
         * ============================================================
         * CASO 1
         * Notas e faltas de uma turma
         *
         * Objetivo:
         * - Demonstrar malloc
         * - Demonstrar calloc
         * - Comparar a inicialização das duas funções
         * - Demonstrar free
         * ============================================================
         */

        public const string CodigoCaso1 = """
            #include <stdio.h>
            #include <stdlib.h>

            int main()
            {
                int quantidade = 5;

                float *notas =
                    malloc(quantidade * sizeof(float));

                int *faltas =
                    calloc(quantidade, sizeof(int));

                /* leitura e processamento dos dados */

                free(notas);
                free(faltas);

                return 0;
            }
            """;


        public static List<EventoHeap> CriarCasoNotasEFaltas()
        {
            List<EventoHeap> eventos = new();

            int proximaReferenciaBloco = 1;


            // --------------------------------------------------
            // 1 - float *notas = malloc(5 * sizeof(float));
            // --------------------------------------------------
            EventoMalloc mallocNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "notas",
                TipoVariavel = TiposDeVariaveis.Float,
                Quantidade = 5
            };

            mallocNotas.AtualizarDescricao();
            eventos.Add(mallocNotas);


            // --------------------------------------------------
            // 2 - int *faltas = calloc(5, sizeof(int));
            // --------------------------------------------------
            EventoCalloc callocFaltas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "faltas",
                TipoVariavel = TiposDeVariaveis.Int,
                Quantidade = 5
            };

            callocFaltas.AtualizarDescricao();
            eventos.Add(callocFaltas);


            // --------------------------------------------------
            // 3 - free(notas);
            // --------------------------------------------------
            EventoFree freeNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocNotas.ReferenciaBloco,
                NomeVariavel = mallocNotas.NomeVariavel
            };

            freeNotas.AtualizarDescricao();
            eventos.Add(freeNotas);


            // --------------------------------------------------
            // 4 - free(faltas);
            // --------------------------------------------------
            EventoFree freeFaltas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = callocFaltas.ReferenciaBloco,
                NomeVariavel = callocFaltas.NomeVariavel
            };

            freeFaltas.AtualizarDescricao();
            eventos.Add(freeFaltas);


            return eventos;
        }


        /*
         * ============================================================
         * CASO 2
         * Notas de duas provas e cálculo das médias
         *
         * Objetivo:
         * - Demonstrar várias alocações simultâneas
         * - Demonstrar várias liberações
         * - Gerar blocos livres no decorrer da execução
         * - Permitir observar split, coalescing e reutilização
         * - Permitir observar fragmentação
         * ============================================================
         */

        public const string CodigoCaso2 = """
            #include <stdio.h>
            #include <stdlib.h>

            int main()
            {
                int quantidade = 6;

                float *prova1 =
                    malloc(quantidade * sizeof(float));

                float *prova2 =
                    malloc(quantidade * sizeof(float));

                float *medias =
                    malloc(quantidade * sizeof(float));

                /* leitura das notas */

                for (int i = 0; i < quantidade; i++)
                {
                    medias[i] =
                        (prova1[i] + prova2[i]) / 2.0f;
                }

                free(prova1);
                free(prova2);

                char *situacao =
                    malloc(quantidade * sizeof(char));

                for (int i = 0; i < quantidade; i++)
                {
                    situacao[i] =
                        medias[i] >= 6.0f ? 'A' : 'R';
                }

                free(medias);
                free(situacao);

                return 0;
            }
            """;


        public static List<EventoHeap> CriarCasoDuasProvas()
        {
            List<EventoHeap> eventos = new();

            int proximaReferenciaBloco = 1;


            // --------------------------------------------------
            // 1 - float *prova1 = malloc(6 * sizeof(float));
            // --------------------------------------------------
            EventoMalloc mallocProva1 = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "prova1",
                TipoVariavel = TiposDeVariaveis.Float,
                Quantidade = 6
            };

            mallocProva1.AtualizarDescricao();
            eventos.Add(mallocProva1);


            // --------------------------------------------------
            // 2 - float *prova2 = malloc(6 * sizeof(float));
            // --------------------------------------------------
            EventoMalloc mallocProva2 = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "prova2",
                TipoVariavel = TiposDeVariaveis.Float,
                Quantidade = 6
            };

            mallocProva2.AtualizarDescricao();
            eventos.Add(mallocProva2);


            // --------------------------------------------------
            // 3 - float *medias = malloc(6 * sizeof(float));
            // --------------------------------------------------
            EventoMalloc mallocMedias = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "medias",
                TipoVariavel = TiposDeVariaveis.Float,
                Quantidade = 6
            };

            mallocMedias.AtualizarDescricao();
            eventos.Add(mallocMedias);


            // --------------------------------------------------
            // 4 - free(prova1);
            // --------------------------------------------------
            EventoFree freeProva1 = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocProva1.ReferenciaBloco,
                NomeVariavel = mallocProva1.NomeVariavel
            };

            freeProva1.AtualizarDescricao();
            eventos.Add(freeProva1);


            // --------------------------------------------------
            // 5 - free(prova2);
            // --------------------------------------------------
            EventoFree freeProva2 = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocProva2.ReferenciaBloco,
                NomeVariavel = mallocProva2.NomeVariavel
            };

            freeProva2.AtualizarDescricao();
            eventos.Add(freeProva2);


            // --------------------------------------------------
            // 6 - char *situacao = malloc(6 * sizeof(char));
            // --------------------------------------------------
            EventoMalloc mallocSituacao = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "situacao",
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 6
            };

            mallocSituacao.AtualizarDescricao();
            eventos.Add(mallocSituacao);


            // --------------------------------------------------
            // 7 - free(medias);
            // --------------------------------------------------
            EventoFree freeMedias = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocMedias.ReferenciaBloco,
                NomeVariavel = mallocMedias.NomeVariavel
            };

            freeMedias.AtualizarDescricao();
            eventos.Add(freeMedias);


            // --------------------------------------------------
            // 8 - free(situacao);
            // --------------------------------------------------
            EventoFree freeSituacao = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocSituacao.ReferenciaBloco,
                NomeVariavel = mallocSituacao.NomeVariavel
            };

            freeSituacao.AtualizarDescricao();
            eventos.Add(freeSituacao);


            return eventos;
        }


        /*
         * ============================================================
         * CASO 3
         * Redimensionamento da quantidade de alunos
         *
         * Objetivo:
         * - Demonstrar malloc
         * - Demonstrar realloc reduzindo uma alocação
         * - Demonstrar realloc aumentando uma alocação
         * - Demonstrar free
         * ============================================================
         */

        public const string CodigoCaso3 = """
            #include <stdio.h>
            #include <stdlib.h>

            int main()
            {
                int quantidade = 8;

                float *notas =
                    malloc(quantidade * sizeof(float));

                /* três alunos deixaram a turma */

                quantidade = 5;

                notas = realloc(
                    notas,
                    quantidade * sizeof(float)
                );

                /* dois novos alunos entraram na turma */

                quantidade = 7;

                notas = realloc(
                    notas,
                    quantidade * sizeof(float)
                );

                free(notas);

                return 0;
            }
            """;


        public static List<EventoHeap> CriarCasoRedimensionamentoTurma()
        {
            List<EventoHeap> eventos = new();

            int proximaReferenciaBloco = 1;


            // --------------------------------------------------
            // 1 - float *notas = malloc(8 * sizeof(float));
            // --------------------------------------------------
            EventoMalloc mallocNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                NomeVariavel = "notas",
                TipoVariavel = TiposDeVariaveis.Float,
                Quantidade = 8
            };

            mallocNotas.AtualizarDescricao();
            eventos.Add(mallocNotas);


            // --------------------------------------------------
            // 2 - notas = realloc(notas, 5 * sizeof(float));
            // Redução do vetor.
            // --------------------------------------------------
            EventoRealloc reallocReduzirNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocNotas.ReferenciaBloco,
                NomeVariavel = mallocNotas.NomeVariavel,
                TipoVariavel = TiposDeVariaveis.Float,
                NovaQuantidade = 5
            };

            reallocReduzirNotas.AtualizarDescricao();
            eventos.Add(reallocReduzirNotas);


            // --------------------------------------------------
            // 3 - notas = realloc(notas, 7 * sizeof(float));
            // Expansão do vetor.
            // --------------------------------------------------
            EventoRealloc reallocAumentarNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocNotas.ReferenciaBloco,
                NomeVariavel = mallocNotas.NomeVariavel,
                TipoVariavel = TiposDeVariaveis.Float,
                NovaQuantidade = 7
            };

            reallocAumentarNotas.AtualizarDescricao();
            eventos.Add(reallocAumentarNotas);


            // --------------------------------------------------
            // 4 - free(notas);
            // --------------------------------------------------
            EventoFree freeNotas = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = mallocNotas.ReferenciaBloco,
                NomeVariavel = mallocNotas.NomeVariavel
            };

            freeNotas.AtualizarDescricao();
            eventos.Add(freeNotas);


            return eventos;
        }
    }
}
