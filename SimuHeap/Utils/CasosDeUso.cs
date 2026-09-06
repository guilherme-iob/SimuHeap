using SimuHeap.Enums;
using SimuHeap.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimuHeap.Utils
{
    public static class CasosDeUso
    {
        private class VariavelCaso
        {
            public int ReferenciaBloco { get; set; }

            public string Nome { get; set; } = string.Empty;

            public TiposDeVariaveis Tipo { get; set; }
        }

        /*
         * ============================================================
         * CASO 1
         * Notas e faltas de uma turma
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

                notas[0] = 7.5f;
                notas[1] = 8.0f;
                notas[2] = 6.5f;
                notas[3] = 9.0f;
                notas[4] = 8.5f;

                int *faltas =
                    calloc(quantidade, sizeof(int));

                faltas[1] = 2;
                faltas[2] = 1;
                faltas[4] = 3;

                free(notas);
                free(faltas);

                return 0;
            }
            """;


        public static List<EventoHeap> CriarCasoNotasEFaltas()
        {
            List<EventoHeap> eventos = new();

            int proximaReferencia = 1;

            VariavelCaso notas = Malloc(
                eventos,
                ref proximaReferencia,
                "notas",
                TiposDeVariaveis.Float,
                5,
                (0, 7.5f),
                (1, 8.0f),
                (2, 6.5f),
                (3, 9.0f),
                (4, 8.5f));

            VariavelCaso faltas = Calloc(
                eventos,
                ref proximaReferencia,
                "faltas",
                TiposDeVariaveis.Int,
                5,
                (1, 2),
                (2, 1),
                (4, 3));

            Free(eventos, notas);
            Free(eventos, faltas);

            return eventos;
        }


        /*
         * ============================================================
         * CASO 2
         * Notas de duas provas e cálculo das médias
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

                prova1[0] = 7.0f;
                prova1[1] = 8.5f;
                prova1[2] = 5.0f;
                prova1[3] = 9.0f;
                prova1[4] = 6.0f;
                prova1[5] = 4.5f;


                float *prova2 =
                    malloc(quantidade * sizeof(float));

                prova2[0] = 8.0f;
                prova2[1] = 7.5f;
                prova2[2] = 6.0f;
                prova2[3] = 8.0f;
                prova2[4] = 7.0f;
                prova2[5] = 5.5f;


                float *medias =
                    malloc(quantidade * sizeof(float));

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

            int proximaReferencia = 1;

            VariavelCaso prova1 = Malloc(
                eventos,
                ref proximaReferencia,
                "prova1",
                TiposDeVariaveis.Float,
                6,
                (0, 7.0f),
                (1, 8.5f),
                (2, 5.0f),
                (3, 9.0f),
                (4, 6.0f),
                (5, 4.5f));

            VariavelCaso prova2 = Malloc(
                eventos,
                ref proximaReferencia,
                "prova2",
                TiposDeVariaveis.Float,
                6,
                (0, 8.0f),
                (1, 7.5f),
                (2, 6.0f),
                (3, 8.0f),
                (4, 7.0f),
                (5, 5.5f));

            VariavelCaso medias = Malloc(
                eventos,
                ref proximaReferencia,
                "medias",
                TiposDeVariaveis.Float,
                6,
                (0, 7.5f),
                (1, 8.0f),
                (2, 5.5f),
                (3, 8.5f),
                (4, 6.5f),
                (5, 5.0f));

            Free(eventos, prova1);
            Free(eventos, prova2);

            VariavelCaso situacao = Malloc(
                eventos,
                ref proximaReferencia,
                "situacao",
                TiposDeVariaveis.Char,
                6,
                (0, 'A'),
                (1, 'A'),
                (2, 'R'),
                (3, 'A'),
                (4, 'A'),
                (5, 'R'));

            Free(eventos, medias);
            Free(eventos, situacao);

            return eventos;
        }


        /*
         * ============================================================
         * CASO 3
         * Redimensionamento da quantidade de alunos
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

                notas[0] = 7.5f;
                notas[1] = 8.0f;
                notas[2] = 6.5f;
                notas[3] = 9.0f;
                notas[4] = 8.5f;
                notas[5] = 5.0f;
                notas[6] = 7.0f;
                notas[7] = 6.0f;


                /* dois alunos deixaram a turma */

                quantidade = 4;

                notas = realloc(
                    notas,
                    quantidade * sizeof(float)
                );


                /* três novos alunos entraram na turma */

                quantidade = 7;

                notas = realloc(
                    notas,
                    quantidade * sizeof(float)
                );

                notas[4] = 2.3f;
                notas[5] = 7.0f;
                notas[6] = 9.5f;


                free(notas);

                return 0;
            }
            """;


        public static List<EventoHeap> CriarCasoRedimensionamentoTurma()
        {
            List<EventoHeap> eventos = new();

            int proximaReferencia = 1;

            VariavelCaso notas = Malloc(
                eventos,
                ref proximaReferencia,
                "notas",
                TiposDeVariaveis.Float,
                8,
                (0, 7.5f),
                (1, 8.0f),
                (2, 6.5f),
                (3, 9.0f),
                (4, 8.5f),
                (5, 5.0f),
                (6, 7.0f),
                (7, 6.0f));

            Realloc(
                eventos,
                notas,
                4);

            Realloc(
                eventos,
                notas,
                7,
                (5, 7.0f),
                (6, 9.5f));

            Free(eventos, notas);

            return eventos;
        }


        public const string CodigoAltaFragInterna = """
            #include <stdlib.h>

            int main()
            {
                char *a = malloc(sizeof(char));
                char *b = malloc(sizeof(char));
                char *c = malloc(sizeof(char));
                char *d = malloc(sizeof(char));

                return 0;
            }
            """;

        public static List<EventoHeap> CriarCasoAltaFragmentacaoInterna()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            Malloc(eventos, ref proximaReferencia, "a", TiposDeVariaveis.Char, 1);
            Malloc(eventos, ref proximaReferencia, "b", TiposDeVariaveis.Char, 1);
            Malloc(eventos, ref proximaReferencia, "c", TiposDeVariaveis.Char, 1);
            Malloc(eventos, ref proximaReferencia, "d", TiposDeVariaveis.Char, 1);

            return eventos;
        }

        public const string CodigoAltaFragExterna = """
            #include <stdlib.h>

            int main()
            {
                int *a = malloc(4 * sizeof(int));
                int *b = malloc(4 * sizeof(int));
                int *c = malloc(4 * sizeof(int));
                int *d = malloc(4 * sizeof(int));
                int *e = malloc(4 * sizeof(int));
                int *f = malloc(4 * sizeof(int));
                int *g = malloc(4 * sizeof(int));
                int *h = malloc(4 * sizeof(int));

                free(a);
                free(c);
                free(e);
                free(g);

                free(b);
                free(d);

                return 0;
            }
            """;

        public static List<EventoHeap> CriarCasoAltaFragmentacaoExterna()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso a =
                Malloc(eventos, ref proximaReferencia, "a", TiposDeVariaveis.Int, 4);

            VariavelCaso b =
                Malloc(eventos, ref proximaReferencia, "b", TiposDeVariaveis.Int, 4);

            VariavelCaso c =
                Malloc(eventos, ref proximaReferencia, "c", TiposDeVariaveis.Int, 4);

            VariavelCaso d =
                Malloc(eventos, ref proximaReferencia, "d", TiposDeVariaveis.Int, 4);

            VariavelCaso e =
                Malloc(eventos, ref proximaReferencia, "e", TiposDeVariaveis.Int, 4);

            VariavelCaso f =
                Malloc(eventos, ref proximaReferencia, "f", TiposDeVariaveis.Int, 4);

            VariavelCaso g =
                Malloc(eventos, ref proximaReferencia, "g", TiposDeVariaveis.Int, 4);

            VariavelCaso h =
                Malloc(eventos, ref proximaReferencia, "h", TiposDeVariaveis.Int, 4);

            // Cria regiões livres intercaladas.
            Free(eventos, a);
            Free(eventos, c);
            Free(eventos, e);
            Free(eventos, g);

            // Evidencia a diferença com e sem coalescing.
            Free(eventos, b);
            Free(eventos, d);

            return eventos;
        }

        /*
         * ============================================================
         * FUNÇÕES AUXILIARES
         * ============================================================
         */

        private static VariavelCaso Malloc(
            List<EventoHeap> eventos,
            ref int proximaReferencia,
            string nome,
            TiposDeVariaveis tipo,
            int quantidade,
            params (int indice, object valor)[] valores)
        {
            EventoMalloc evento = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferencia++,
                NomeVariavel = nome,
                TipoVariavel = tipo,
                Quantidade = quantidade
            };

            evento.AtualizarDescricao();

            AdicionarEscritaSeNecessario(
                evento,
                evento.ReferenciaBloco,
                tipo,
                $"Atribuindo valores ao vetor {nome}.",
                valores);

            eventos.Add(evento);

            return new VariavelCaso
            {
                ReferenciaBloco = evento.ReferenciaBloco,
                Nome = nome,
                Tipo = tipo
            };
        }


        private static VariavelCaso Calloc(
            List<EventoHeap> eventos,
            ref int proximaReferencia,
            string nome,
            TiposDeVariaveis tipo,
            int quantidade,
            params (int indice, object valor)[] valores)
        {
            EventoCalloc evento = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = proximaReferencia++,
                NomeVariavel = nome,
                TipoVariavel = tipo,
                Quantidade = quantidade
            };

            evento.AtualizarDescricao();

            AdicionarEscritaSeNecessario(
                evento,
                evento.ReferenciaBloco,
                tipo,
                $"Atribuindo valores ao vetor {nome}.",
                valores);

            eventos.Add(evento);

            return new VariavelCaso
            {
                ReferenciaBloco = evento.ReferenciaBloco,
                Nome = nome,
                Tipo = tipo
            };
        }


        private static void Realloc(List<EventoHeap> eventos, VariavelCaso variavel, int novaQuantidade, params (int indice, object valor)[] valores)
        {
            EventoRealloc evento = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = variavel.ReferenciaBloco,
                NomeVariavel = variavel.Nome,
                TipoVariavel = variavel.Tipo,
                NovaQuantidade = novaQuantidade
            };

            evento.AtualizarDescricao();

            AdicionarEscritaSeNecessario(
                evento,
                variavel.ReferenciaBloco,
                variavel.Tipo,
                $"Atribuindo novos valores ao vetor {variavel.Nome}.",
                valores);

            eventos.Add(evento);
        }


        private static void Free(List<EventoHeap> eventos, VariavelCaso variavel)
        {
            EventoFree evento = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = variavel.ReferenciaBloco,
                NomeVariavel = variavel.Nome
            };

            evento.AtualizarDescricao();

            eventos.Add(evento);
        }


        private static void AdicionarEscritaSeNecessario(EventoHeap evento, int referenciaBloco, TiposDeVariaveis tipo, string descricao, params (int indice, object valor)[] valores)
        {
            if (valores.Length == 0)
                return;

            evento.EscritasAposEvento.Add(
                CriarEscrita(
                    referenciaBloco,
                    tipo,
                    descricao,
                    valores));
        }


        private static EscritaMemoria CriarEscrita(
            int referenciaBloco,
            TiposDeVariaveis tipo,
            string descricao,
            params (int indice, object valor)[] valores)
        {
            return new EscritaMemoria
            {
                ReferenciaBloco = referenciaBloco,
                TipoVariavel = tipo,
                Descricao = descricao,

                Valores = valores
                    .Select(x => new ValorAtribuidoMemoria
                    {
                        Indice = x.indice,
                        Valor = x.valor
                    })
                    .ToList()
            };
        }
    }
}