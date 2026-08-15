using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Utils
{
    public static class CoresSimulacao
    {
        public static readonly Color BlocoLivre = Color.FromArgb(40, 140, 70);
        public static readonly Color BlocoOcupado = Color.FromArgb(190, 50, 50);

        public static readonly Color BlocoEmAnalise = Color.Gold;
        public static readonly Color MelhorBlocoEncontrado = Color.DeepSkyBlue;
        public static readonly Color MelhorBlocoSelecionado = Color.DodgerBlue;

        public static readonly Color BlocoSendoLiberado = Color.Orange;
        public static readonly Color BlocoSendoReduzido = Color.MediumPurple;
        public static readonly Color BlocoSendoExpandido = Color.CornflowerBlue;
        public static readonly Color BlocoSendoMovido = Color.MediumOrchid;
        public static readonly Color BlocoInicializadoCalloc = Color.LightSeaGreen;
        public static readonly Color BlocoCoalescing = Color.YellowGreen;

        public static Color ObterCorDestaque(TipoDestaqueSimulacao tipoDestaque)
        {
            switch (tipoDestaque)
            {
                case TipoDestaqueSimulacao.BlocoEmAnalise:
                    return BlocoEmAnalise;
                case TipoDestaqueSimulacao.MelhorBlocoEncontrado:
                    return MelhorBlocoEncontrado;
                case TipoDestaqueSimulacao.MelhorBlocoSelecionado:
                    return MelhorBlocoSelecionado;
                case TipoDestaqueSimulacao.LiberandoBloco:
                    return BlocoSendoLiberado;
                case TipoDestaqueSimulacao.ReduzindoBloco:
                    return BlocoSendoReduzido;
                case TipoDestaqueSimulacao.ExpandindoBloco:
                    return BlocoSendoExpandido;
                case TipoDestaqueSimulacao.MovendoBloco:
                    return BlocoSendoMovido;
                case TipoDestaqueSimulacao.InicializandoCalloc:
                    return BlocoInicializadoCalloc;
                case TipoDestaqueSimulacao.Coalescing:
                    return BlocoCoalescing;

                default:
                    return Color.Transparent;
            }
        }
    }
}
