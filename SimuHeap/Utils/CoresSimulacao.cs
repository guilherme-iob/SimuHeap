using SimuHeap.Enums;
using SimuHeap.Models;
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

        public static Color Escurecer(Color cor, float fator = 0.55f)
        {
            return Color.FromArgb(cor.A,Math.Clamp((int)(cor.R * fator), 0, 255), Math.Clamp((int)(cor.G * fator), 0, 255), Math.Clamp((int)(cor.B * fator), 0, 255));
        }

        public static Color Clarear(Color cor, float fator = 0.55f)
        {
            int vermelho = cor.R + (int)((255 - cor.R) * fator);
            int verde = cor.G + (int)((255 - cor.G) * fator);
            int azul = cor.B + (int)((255 - cor.B) * fator);

            return Color.FromArgb(cor.A, Math.Clamp(vermelho, 0, 255), Math.Clamp(verde, 0, 255), Math.Clamp(azul, 0, 255));
        }

        public static Color ObterCorRegiao(BlocoDeMemoria bloco, RegiaoBlocoMemoria regiao)
        {
            if (bloco.EstaLivre)
            {
                return regiao switch
                {
                    RegiaoBlocoMemoria.Header => Escurecer(bloco.Cor),
                    RegiaoBlocoMemoria.Footer => Escurecer(bloco.Cor),
                    RegiaoBlocoMemoria.Livre => bloco.Cor,
                    _ => bloco.Cor
                };
            }

            return regiao switch
            {
                RegiaoBlocoMemoria.Header => Escurecer(bloco.Cor),
                RegiaoBlocoMemoria.Payload => bloco.Cor,
                RegiaoBlocoMemoria.Padding => Clarear(bloco.Cor),
                RegiaoBlocoMemoria.Footer => Escurecer(bloco.Cor),
                _ => bloco.Cor
            };
        }
    }
}
