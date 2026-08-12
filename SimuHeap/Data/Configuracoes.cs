using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Data
{
    public static class Configuracoes
    {
        public static int TAM_HEADER = 4;
        public static int TAM_FOOTER = 4;
        public static int TAM_ALINHAMENTO = 8;
        public static int TAM_MIN_PAYLOAD = 4;

        public const uint FLAG_OCUPADO = 0x1;

        public static int TAM_MIN_BLOCO => CalcularTamanhoTotalBloco(TAM_MIN_PAYLOAD);

        public static int CalcularPadding(int tamanhoPayload)
        {
            int tamanhoSemPadding = TAM_HEADER + tamanhoPayload + TAM_FOOTER;

            return (TAM_ALINHAMENTO - tamanhoSemPadding % TAM_ALINHAMENTO) % TAM_ALINHAMENTO;
        }

        public static int CalcularTamanhoTotalBloco(int tamanhoPayload)
        {
            return TAM_HEADER + tamanhoPayload + TAM_FOOTER + CalcularPadding(tamanhoPayload);
        }

        public static int ObterTamanhoTipo(TiposDeVariaveis tipo)
        {
            switch (tipo)
            {
                case TiposDeVariaveis.Char:
                    return 1;
                case TiposDeVariaveis.Short:
                    return 2;
                case TiposDeVariaveis.Int:
                    return 4;
                case TiposDeVariaveis.Long:
                    return 8;
                case TiposDeVariaveis.Float:
                    return 4;
                case TiposDeVariaveis.Double:
                    return 8;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo));
            }
        }
    }
}
