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



        /*
 * ============================================================
 * CASO REAL 1
 * Alocações de diferentes tipos e tamanhos
 * ============================================================
 */

        public const string CodigoCasoAlocacoesDiferentes = """
    #include <stdio.h>
    #include <string.h>
    #include <stdlib.h>

    int main()
    {
        char *s;
        char *c;
        int *vet;
        int *i;

        s = malloc(10 * sizeof(char));
        if (s == NULL) { printf("Problema na alocacao.\n"); exit(2); }

        c = malloc(sizeof(char));
        if (c == NULL) { printf("Problema na alocacao.\n"); exit(2); }

        vet = malloc(20 * sizeof(int));
        if (vet == NULL) { printf("Problema na alocacao.\n"); exit(2); }

        i = malloc(sizeof(int));
        if (i == NULL) { printf("Problema na alocacao.\n"); exit(2); }

        s[0] = 'T';
        s[1] = 'E';
        s[2] = 'S';
        s[3] = 'T';
        s[4] = 'E';
        s[5] = '\0';

        *c = 'X';

        printf("s=%s\n", s);
        printf("c=%c\n", *c);

        free(s);
        free(c);
        free(vet);
        free(i);

        return 0;
    }
    """;

        public static List<EventoHeap> CriarCasoAlocacoesDiferentes()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso s = Malloc(eventos, ref proximaReferencia, "s", TiposDeVariaveis.Char, 10);
            VariavelCaso c = Malloc(eventos, ref proximaReferencia, "c", TiposDeVariaveis.Char, 1);
            VariavelCaso vet = Malloc(eventos, ref proximaReferencia, "vet", TiposDeVariaveis.Int, 20);
            VariavelCaso i = Malloc(eventos, ref proximaReferencia, "i", TiposDeVariaveis.Int, 1);

            eventos[^1].EscritasAposEvento.Add(CriarEscrita(s.ReferenciaBloco, s.Tipo, "Atribuindo a string \"TESTE\" ao vetor s.", (0, 'T'), (1, 'E'), (2, 'S'), (3, 'T'), (4, 'E'), (5, '\0')));
            eventos[^1].EscritasAposEvento.Add(CriarEscrita(c.ReferenciaBloco, c.Tipo, "Atribuindo o caractere 'X' à variável apontada por c.", (0, 'X')));

            Free(eventos, s);
            Free(eventos, c);
            Free(eventos, vet);
            Free(eventos, i);

            return eventos;
        }


        /*
         * ============================================================
         * CASO REAL 8
         * Cálculo da mediana
         * ============================================================
         */

        public const string CodigoCasoMediana = """
    #include <stdio.h>
    #include <stdlib.h>

    float Mediana(const char* strg)
    {
        int qtdnum = 0, i, trocou;
        float mediana;
        const char *aux = strg;
        int *v;

        while (*strg)
        {
            if (*strg >= '0' && *strg <= '9')
            {
                while (*strg >= '0' && *strg <= '9')
                    strg++;

                qtdnum++;
            }
            else
            {
                strg++;
            }
        }

        v = (int *)malloc(sizeof(int) * qtdnum);

        i = 0;

        while (*aux)
        {
            if (*aux >= '0' && *aux <= '9')
            {
                int num = 0;

                while (*aux >= '0' && *aux <= '9')
                {
                    num = num * 10 + (*aux - '0');
                    aux++;
                }

                v[i] = num;
                i++;
            }
            else
            {
                aux++;
            }
        }

        do
        {
            trocou = 0;

            for (i = 0; i < qtdnum - 1; i++)
            {
                if (v[i] > v[i + 1])
                {
                    int auxiliar = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = auxiliar;
                    trocou = 1;
                }
            }
        }
        while (trocou);

        if (qtdnum % 2 == 1)
            mediana = v[qtdnum / 2];
        else
            mediana = (v[qtdnum / 2 - 1] + v[qtdnum / 2]) / 2.0;

        free(v);

        return mediana;
    }

    int main()
    {
        float r;

        r = Mediana("30 2 23 173 1247 1 99");
        printf("Mediana=%f\n", r);

        r = Mediana("30 2 23 173");
        printf("Mediana=%f\n", r);

        return 0;
    }
    """;

        public static List<EventoHeap> CriarCasoMediana()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso vPrimeiraChamada = Malloc(eventos, ref proximaReferencia, "v", TiposDeVariaveis.Int, 7);

            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vPrimeiraChamada.ReferenciaBloco, vPrimeiraChamada.Tipo, "Armazenando em v os números encontrados na primeira string.", (0, 30), (1, 2), (2, 23), (3, 173), (4, 1247), (5, 1), (6, 99)));
            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vPrimeiraChamada.ReferenciaBloco, vPrimeiraChamada.Tipo, "Ordenando os valores de v para calcular a mediana.", (0, 1), (1, 2), (2, 23), (3, 30), (4, 99), (5, 173), (6, 1247)));

            Free(eventos, vPrimeiraChamada);

            VariavelCaso vSegundaChamada = Malloc(eventos, ref proximaReferencia, "v", TiposDeVariaveis.Int, 4);

            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vSegundaChamada.ReferenciaBloco, vSegundaChamada.Tipo, "Armazenando em v os números encontrados na segunda string.", (0, 30), (1, 2), (2, 23), (3, 173)));
            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vSegundaChamada.ReferenciaBloco, vSegundaChamada.Tipo, "Ordenando os valores de v para calcular a mediana.", (0, 2), (1, 23), (2, 30), (3, 173)));

            Free(eventos, vSegundaChamada);

            return eventos;
        }


        /*
         * ============================================================
         * CASO REAL 10
         * Subtração de vetores
         * ============================================================
         */

        public const string CodigoCasoSubtracaoVetores = """
    #include <stdio.h>
    #include <stdlib.h>

    int *sub(int v1[], int qtd1, int v2[], int qtd2, int *qtdR)
    {
        int *vR, *vTemp;
        int achou, i, j, k = 0;

        vTemp = (int *)malloc(qtd1 * sizeof(int));

        for (i = 0; i < qtd1; i++)
        {
            achou = 0;

            for (j = 0; j < qtd2; j++)
                if (v1[i] == v2[j])
                    achou = 1;

            if (achou == 0)
                vTemp[k++] = v1[i];
        }

        *qtdR = k;

        vR = (int *)malloc(k * sizeof(int));

        for (i = 0; i < k; i++)
            vR[i] = vTemp[i];

        free(vTemp);

        return vR;
    }

    int main()
    {
        int v1[] = {3, 6, 13, 17, 63};
        int v2[] = {2, 3, 4, 6, 8, 17, 31, 89};

        int qtd1 = sizeof(v1) / sizeof(int);
        int qtd2 = sizeof(v2) / sizeof(int);

        int *resultado;
        int qtdresultado, i;

        resultado = sub(v1, qtd1, v2, qtd2, &qtdresultado);

        for (i = 0; i < qtdresultado; i++)
            printf("%d ", resultado[i]);

        free(resultado);

        return 0;
    }
    """;

        public static List<EventoHeap> CriarCasoSubtracaoVetores()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso vTemp = Malloc(eventos, ref proximaReferencia, "vTemp", TiposDeVariaveis.Int, 5);

            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vTemp.ReferenciaBloco, vTemp.Tipo, "Armazenando em vTemp os elementos de v1 que não pertencem a v2.", (0, 13), (1, 63)));

            VariavelCaso vR = Malloc(eventos, ref proximaReferencia, "vR", TiposDeVariaveis.Int, 2);

            eventos[^1].EscritasAposEvento.Add(CriarEscrita(vR.ReferenciaBloco, vR.Tipo, "Copiando para vR os valores encontrados em vTemp.", (0, 13), (1, 63)));

            Free(eventos, vTemp);
            Free(eventos, vR);

            return eventos;
        }

        /*
 * ============================================================
 * CASO REAL 4
 * Alocação de strings dentro de funções
 * ============================================================
 */

        public const string CodigoCasoLetras = """
    #include <stdio.h>
    #include <stdlib.h>

    char *letras(int n)
    {
        char *let;
        char ch = 'A';
        int i;

        let = (char *)malloc((n + 1) * sizeof(char));

        if (let == NULL)
            return NULL;

        for (i = 0; i < n; i++)
        {
            let[i] = ch;
            ch++;

            if (ch > 'Z')
                ch = 'A';
        }

        let[i] = '\0';

        return let;
    }

    void letras2(int n, char **let)
    {
        char ch = 'A';
        int i;

        (*let) = (char *)malloc((n + 1) * sizeof(char));

        if ((*let) == NULL)
            return;

        for (i = 0; i < n; i++)
        {
            (*let)[i] = ch;
            ch++;

            if (ch > 'Z')
                ch = 'A';
        }

        (*let)[i] = '\0';
    }

    int main()
    {
        char *s;

        s = letras(35);

        if (s == NULL)
        {
            printf("Problema na alocacao.\n");
            exit(2);
        }

        printf("opcao1: %s\n", s);
        free(s);

        letras2(35, &s);

        if (s == NULL)
        {
            printf("Problema na alocacao.\n");
            exit(2);
        }

        printf("opcao2: %s\n", s);
        free(s);

        return 0;
    }
    """;

        public static List<EventoHeap> CriarCasoLetras()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso primeiraString = Malloc(eventos, ref proximaReferencia, "s", TiposDeVariaveis.Char, 36,
                (0, 'A'), (1, 'B'), (2, 'C'), (3, 'D'), (4, 'E'), (5, 'F'), (6, 'G'), (7, 'H'), (8, 'I'),
                (9, 'J'), (10, 'K'), (11, 'L'), (12, 'M'), (13, 'N'), (14, 'O'), (15, 'P'), (16, 'Q'),
                (17, 'R'), (18, 'S'), (19, 'T'), (20, 'U'), (21, 'V'), (22, 'W'), (23, 'X'), (24, 'Y'),
                (25, 'Z'), (26, 'A'), (27, 'B'), (28, 'C'), (29, 'D'), (30, 'E'), (31, 'F'), (32, 'G'),
                (33, 'H'), (34, 'I'), (35, '\0'));

            Free(eventos, primeiraString);

            VariavelCaso segundaString = Malloc(eventos, ref proximaReferencia, "s", TiposDeVariaveis.Char, 36,
                (0, 'A'), (1, 'B'), (2, 'C'), (3, 'D'), (4, 'E'), (5, 'F'), (6, 'G'), (7, 'H'), (8, 'I'),
                (9, 'J'), (10, 'K'), (11, 'L'), (12, 'M'), (13, 'N'), (14, 'O'), (15, 'P'), (16, 'Q'),
                (17, 'R'), (18, 'S'), (19, 'T'), (20, 'U'), (21, 'V'), (22, 'W'), (23, 'X'), (24, 'Y'),
                (25, 'Z'), (26, 'A'), (27, 'B'), (28, 'C'), (29, 'D'), (30, 'E'), (31, 'F'), (32, 'G'),
                (33, 'H'), (34, 'I'), (35, '\0'));

            Free(eventos, segundaString);

            return eventos;
        }

        /*
 * ============================================================
 * CASO REAL 5
 * Extração de dígitos de uma string
 * ============================================================
 */

        public const string CodigoCasoDigitos = """
    #include <stdio.h>
    #include <stdlib.h>
    #include <ctype.h>

    char *digitos(char *s)
    {
        char *dig;
        int i, j, qtddig = 0;

        for (i = 0; s[i]; i++)
            if (isdigit(s[i]))
                qtddig++;

        dig = (char *)malloc((qtddig + 1) * sizeof(char));

        if (dig == NULL)
            return NULL;

        j = 0;

        for (i = 0; s[i]; i++)
            if (isdigit(s[i]))
                dig[j++] = s[i];

        dig[j] = '\0';

        return dig;
    }

    int main()
    {
        char *d;

        d = digitos("A1B2C765W888UYGf2241qs");

        if (d == NULL)
        {
            printf("Problema na alocacao.\n");
            exit(2);
        }

        printf("%s", d);

        free(d);

        return 0;
    }
    """;

        public static List<EventoHeap> CriarCasoDigitos()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso d = Malloc(eventos, ref proximaReferencia, "d", TiposDeVariaveis.Char, 13,
                (0, '1'), (1, '2'), (2, '7'), (3, '6'), (4, '5'), (5, '8'), (6, '8'),
                (7, '8'), (8, '2'), (9, '2'), (10, '4'), (11, '1'), (12, '\0'));

            Free(eventos, d);

            return eventos;
        }
    }
}