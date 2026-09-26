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

        #region Caso 1 - Notas e faltas

        public const string CodigoCaso1 = """
            #include <stdio.h>
            #include <stdlib.h>

            int main()
            {
                int quantidade = 5;

                float *notas = malloc(quantidade * sizeof(float));

                notas[0] = 7.5f;
                notas[1] = 8.0f;
                notas[2] = 6.5f;
                notas[3] = 9.0f;
                notas[4] = 8.5f;

                int *faltas = calloc(quantidade, sizeof(int));

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

            VariavelCaso notas = Malloc(eventos, ref proximaReferencia, "notas", TiposDeVariaveis.Float, 5);

            Atribuir(eventos, notas, 0, 7.5f);
            Atribuir(eventos, notas, 1, 8.0f);
            Atribuir(eventos, notas, 2, 6.5f);
            Atribuir(eventos, notas, 3, 9.0f);
            Atribuir(eventos, notas, 4, 8.5f);

            VariavelCaso faltas = Calloc(eventos, ref proximaReferencia, "faltas", TiposDeVariaveis.Int, 5);

            Atribuir(eventos, faltas, 1, 2);
            Atribuir(eventos, faltas, 2, 1);
            Atribuir(eventos, faltas, 4, 3);

            Free(eventos, notas);
            Free(eventos, faltas);

            return eventos;
        }

        #endregion

        #region Caso 2 - Duas provas

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

            VariavelCaso prova1 = Malloc(eventos, ref proximaReferencia, "prova1", TiposDeVariaveis.Float, 6);

            Atribuir(eventos, prova1, 0, 7.0f);
            Atribuir(eventos, prova1, 1, 8.5f);
            Atribuir(eventos, prova1, 2, 5.0f);
            Atribuir(eventos, prova1, 3, 9.0f);
            Atribuir(eventos, prova1, 4, 6.0f);
            Atribuir(eventos, prova1, 5, 4.5f);

            VariavelCaso prova2 = Malloc(eventos, ref proximaReferencia, "prova2", TiposDeVariaveis.Float, 6);

            Atribuir(eventos, prova2, 0, 8.0f);
            Atribuir(eventos, prova2, 1, 7.5f);
            Atribuir(eventos, prova2, 2, 6.0f);
            Atribuir(eventos, prova2, 3, 8.0f);
            Atribuir(eventos, prova2, 4, 7.0f);
            Atribuir(eventos, prova2, 5, 5.5f);

            VariavelCaso medias = Malloc(eventos, ref proximaReferencia, "medias", TiposDeVariaveis.Float, 6);

            Atribuir(eventos, medias, 0, 7.5f);
            Atribuir(eventos, medias, 1, 8.0f);
            Atribuir(eventos, medias, 2, 5.5f);
            Atribuir(eventos, medias, 3, 8.5f);
            Atribuir(eventos, medias, 4, 6.5f);
            Atribuir(eventos, medias, 5, 5.0f);

            Free(eventos, prova1);
            Free(eventos, prova2);

            VariavelCaso situacao = Malloc(eventos, ref proximaReferencia, "situacao", TiposDeVariaveis.Char, 6);

            Atribuir(eventos, situacao, 0, 'A');
            Atribuir(eventos, situacao, 1, 'A');
            Atribuir(eventos, situacao, 2, 'R');
            Atribuir(eventos, situacao, 3, 'A');
            Atribuir(eventos, situacao, 4, 'A');
            Atribuir(eventos, situacao, 5, 'R');

            Free(eventos, medias);
            Free(eventos, situacao);

            return eventos;
        }

        #endregion

        #region Caso 3 - Redimensionamento da turma

        public const string CodigoCaso3 = """
            #include <stdio.h>
            #include <stdlib.h>

            int main()
            {
                int quantidade = 8;

                float *notas = malloc(quantidade * sizeof(float));

                notas[0] = 7.5f;
                notas[1] = 8.0f;
                notas[2] = 6.5f;
                notas[3] = 9.0f;
                notas[4] = 8.5f;
                notas[5] = 5.0f;
                notas[6] = 7.0f;
                notas[7] = 6.0f;

                /* quatro alunos deixaram a turma */

                quantidade = 4;

                notas = realloc(notas,quantidade * sizeof(float));

                /* três novos alunos entraram na turma */

                quantidade = 7;

                notas = realloc(notas,quantidade * sizeof(float));

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

            VariavelCaso notas = Malloc(eventos, ref proximaReferencia, "notas", TiposDeVariaveis.Float, 8);

            Atribuir(eventos, notas, 0, 7.5f);
            Atribuir(eventos, notas, 1, 8.0f);
            Atribuir(eventos, notas, 2, 6.5f);
            Atribuir(eventos, notas, 3, 9.0f);
            Atribuir(eventos, notas, 4, 8.5f);
            Atribuir(eventos, notas, 5, 5.0f);
            Atribuir(eventos, notas, 6, 7.0f);
            Atribuir(eventos, notas, 7, 6.0f);

            Realloc(eventos, notas, 4);

            Realloc(eventos, notas, 7);

            Atribuir(eventos, notas, 4, 2.3f);
            Atribuir(eventos, notas, 5, 7.0f);
            Atribuir(eventos, notas, 6, 9.5f);

            Free(eventos, notas);

            return eventos;
        }

        #endregion

        #region Fragmentação interna

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

        #endregion

        #region Fragmentação externa

        public const string CodigoAltaFragExterna = """
            #include <stdlib.h>

            int main()
            {
                int *a = malloc(8 * sizeof(int));
                int *b = malloc(2 * sizeof(int));
                int *c = malloc(4 * sizeof(int));
                int *d = malloc(2 * sizeof(int));
                int *e = malloc(12 * sizeof(int));
                int *f = malloc(2 * sizeof(int));

                free(a);
                free(c);
                free(e);

                int *g = malloc(3 * sizeof(int));

                free(g);
                free(b);
                free(d);
                free(f);

                return 0;
            }
        """;

        public static List<EventoHeap> CriarCasoAltaFragmentacaoExterna()
        {
            List<EventoHeap> eventos = new();
            int proximaReferencia = 1;

            VariavelCaso a = Malloc(eventos, ref proximaReferencia, "a", TiposDeVariaveis.Int, 8);
            VariavelCaso b = Malloc(eventos, ref proximaReferencia, "b", TiposDeVariaveis.Int, 2);
            VariavelCaso c = Malloc(eventos, ref proximaReferencia, "c", TiposDeVariaveis.Int, 4);
            VariavelCaso d = Malloc(eventos, ref proximaReferencia, "d", TiposDeVariaveis.Int, 2);
            VariavelCaso e = Malloc(eventos, ref proximaReferencia, "e", TiposDeVariaveis.Int, 12);
            VariavelCaso f = Malloc(eventos, ref proximaReferencia, "f", TiposDeVariaveis.Int, 2);

            Free(eventos, a);
            Free(eventos, c);
            Free(eventos, e);

            VariavelCaso g = Malloc(eventos, ref proximaReferencia, "g", TiposDeVariaveis.Int, 3);

            Free(eventos, g);
            Free(eventos, b);
            Free(eventos, d);
            Free(eventos, f);

            return eventos;
        }

        #endregion

        #region Caso real 1 - Alocações diferentes

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

            Atribuir(eventos, s, 0, 'T', "s[0] = 'T';");
            Atribuir(eventos, s, 1, 'E', "s[1] = 'E';");
            Atribuir(eventos, s, 2, 'S', "s[2] = 'S';");
            Atribuir(eventos, s, 3, 'T', "s[3] = 'T';");
            Atribuir(eventos, s, 4, 'E', "s[4] = 'E';");
            Atribuir(eventos, s, 5, '\0', @"s[5] = '\0';");

            Atribuir(eventos, c, 0, 'X', "*c = 'X';");

            Free(eventos, s);
            Free(eventos, c);
            Free(eventos, vet);
            Free(eventos, i);

            return eventos;
        }

        #endregion

        #region Caso real 4 - Letras

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
            //int proximaReferencia = 1;

            //VariavelCaso primeiraString = Malloc(eventos, ref proximaReferencia, "s", TiposDeVariaveis.Char, 36,
            //    (0, 'A'), (1, 'B'), (2, 'C'), (3, 'D'), (4, 'E'), (5, 'F'), (6, 'G'), (7, 'H'), (8, 'I'),
            //    (9, 'J'), (10, 'K'), (11, 'L'), (12, 'M'), (13, 'N'), (14, 'O'), (15, 'P'), (16, 'Q'),
            //    (17, 'R'), (18, 'S'), (19, 'T'), (20, 'U'), (21, 'V'), (22, 'W'), (23, 'X'), (24, 'Y'),
            //    (25, 'Z'), (26, 'A'), (27, 'B'), (28, 'C'), (29, 'D'), (30, 'E'), (31, 'F'), (32, 'G'),
            //    (33, 'H'), (34, 'I'), (35, '\0'));

            //Free(eventos, primeiraString);

            //VariavelCaso segundaString = Malloc(eventos, ref proximaReferencia, "s", TiposDeVariaveis.Char, 36,
            //    (0, 'A'), (1, 'B'), (2, 'C'), (3, 'D'), (4, 'E'), (5, 'F'), (6, 'G'), (7, 'H'), (8, 'I'),
            //    (9, 'J'), (10, 'K'), (11, 'L'), (12, 'M'), (13, 'N'), (14, 'O'), (15, 'P'), (16, 'Q'),
            //    (17, 'R'), (18, 'S'), (19, 'T'), (20, 'U'), (21, 'V'), (22, 'W'), (23, 'X'), (24, 'Y'),
            //    (25, 'Z'), (26, 'A'), (27, 'B'), (28, 'C'), (29, 'D'), (30, 'E'), (31, 'F'), (32, 'G'),
            //    (33, 'H'), (34, 'I'), (35, '\0'));

            //Free(eventos, segundaString);

            return eventos;
        }

        #endregion

        #region Caso real 5 - Dígitos

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
            //int proximaReferencia = 1;

            //VariavelCaso d = Malloc(eventos, ref proximaReferencia, "d", TiposDeVariaveis.Char, 13,
            //    (0, '1'), (1, '2'), (2, '7'), (3, '6'), (4, '5'), (5, '8'), (6, '8'),
            //    (7, '8'), (8, '2'), (9, '2'), (10, '4'), (11, '1'), (12, '\0'));

            //Free(eventos, d);

            return eventos;
        }

        #endregion

        #region Caso real 8 - Mediana

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

            Atribuir(eventos, vPrimeiraChamada, 0, 30);
            Atribuir(eventos, vPrimeiraChamada, 1, 2);
            Atribuir(eventos, vPrimeiraChamada, 2, 23);
            Atribuir(eventos, vPrimeiraChamada, 3, 173);
            Atribuir(eventos, vPrimeiraChamada, 4, 1247);
            Atribuir(eventos, vPrimeiraChamada, 5, 1);
            Atribuir(eventos, vPrimeiraChamada, 6, 99);

            Atribuir(eventos, vPrimeiraChamada, 0, 1, "Ordenação: v[0] = 1;");
            Atribuir(eventos, vPrimeiraChamada, 1, 2, "Ordenação: v[1] = 2;");
            Atribuir(eventos, vPrimeiraChamada, 2, 23, "Ordenação: v[2] = 23;");
            Atribuir(eventos, vPrimeiraChamada, 3, 30, "Ordenação: v[3] = 30;");
            Atribuir(eventos, vPrimeiraChamada, 4, 99, "Ordenação: v[4] = 99;");
            Atribuir(eventos, vPrimeiraChamada, 5, 173, "Ordenação: v[5] = 173;");
            Atribuir(eventos, vPrimeiraChamada, 6, 1247, "Ordenação: v[6] = 1247;");

            Free(eventos, vPrimeiraChamada);

            VariavelCaso vSegundaChamada = Malloc(eventos, ref proximaReferencia, "v", TiposDeVariaveis.Int, 4);

            Atribuir(eventos, vSegundaChamada, 0, 30);
            Atribuir(eventos, vSegundaChamada, 1, 2);
            Atribuir(eventos, vSegundaChamada, 2, 23);
            Atribuir(eventos, vSegundaChamada, 3, 173);

            Atribuir(eventos, vSegundaChamada, 0, 2, "Ordenação: v[0] = 2;");
            Atribuir(eventos, vSegundaChamada, 1, 23, "Ordenação: v[1] = 23;");
            Atribuir(eventos, vSegundaChamada, 2, 30, "Ordenação: v[2] = 30;");
            Atribuir(eventos, vSegundaChamada, 3, 173, "Ordenação: v[3] = 173;");

            Free(eventos, vSegundaChamada);

            return eventos;
        }

        #endregion

        #region Caso real 10 - Subtração de vetores

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

            Atribuir(eventos, vTemp, 0, 13);
            Atribuir(eventos, vTemp, 1, 63);

            VariavelCaso vR = Malloc(eventos, ref proximaReferencia, "vR", TiposDeVariaveis.Int, 2);

            Atribuir(eventos, vR, 0, 13);
            Atribuir(eventos, vR, 1, 63);

            Free(eventos, vTemp);
            Free(eventos, vR);

            return eventos;
        }

        #endregion

        #region Funções auxiliares

        private static VariavelCaso Malloc(List<EventoHeap> eventos, ref int proximaReferencia, string nome, TiposDeVariaveis tipo, int quantidade)
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
            eventos.Add(evento);

            return new VariavelCaso
            {
                ReferenciaBloco = evento.ReferenciaBloco,
                Nome = nome,
                Tipo = tipo
            };
        }

        private static VariavelCaso Calloc(List<EventoHeap> eventos, ref int proximaReferencia, string nome, TiposDeVariaveis tipo, int quantidade)
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
            eventos.Add(evento);

            return new VariavelCaso
            {
                ReferenciaBloco = evento.ReferenciaBloco,
                Nome = nome,
                Tipo = tipo
            };
        }

        private static void Realloc(List<EventoHeap> eventos, VariavelCaso variavel, int novaQuantidade)
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

        private static void Atribuir(List<EventoHeap> eventos, VariavelCaso variavel, int indice, object valor, string? descricao = null)
        {
            EventoAtribuicao evento = new()
            {
                Id = eventos.Count + 1,
                ReferenciaBloco = variavel.ReferenciaBloco,
                NomeVariavel = variavel.Nome,
                TipoVariavel = variavel.Tipo,
                DescricaoPersonalizada = descricao ?? $"{variavel.Nome}[{indice}] = {FormatarValor(valor)};",
                Valores = new List<ValorAtribuidoMemoria>
                {
                    new ValorAtribuidoMemoria { Indice = indice, Valor = valor }
                }
            };

            evento.AtualizarDescricao();
            eventos.Add(evento);
        }

        private static string FormatarValor(object valor)
        {
            return valor switch
            {
                '\0' => @"'\0'",
                char c => $"'{c}'",
                float f => $"{f:0.0}f",
                double d => $"{d:0.0}",
                _ => valor.ToString() ?? string.Empty
            };
        }

        #endregion
    }
}