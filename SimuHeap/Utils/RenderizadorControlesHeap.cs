using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Utils
{
    public static class RenderizadorControlesHeap
    {
        public static void DesenharCelula(
            Graphics graphics,
            Rectangle rectangle,
            Color corFundo,
            Brush corTexto,
            string texto,
            string? identificador,
            Brush? corIdentificador,
            int tamanhoCelula
            )
        {
            using SolidBrush fundo = new SolidBrush(corFundo);
            using Pen borda = new Pen(StyleHeap.CorGrade, 1f);
            using Font fonteByte = new Font(StyleHeap.FonteBytes, Math.Max(6f, tamanhoCelula * StyleHeap.FatorFonteBytes), FontStyle.Regular);
            using Font fonteId = new Font(StyleHeap.FonteIdentificador, Math.Max(6f, tamanhoCelula * StyleHeap.FatorFonteIdentificador), FontStyle.Bold);
            using StringFormat centralizado = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            graphics.FillRectangle(fundo, rectangle);
            graphics.DrawRectangle(borda, rectangle);

            graphics.DrawString(texto, fonteByte, corTexto, rectangle, centralizado);

            if (!string.IsNullOrEmpty(identificador))
            {
                graphics.DrawString(identificador, fonteId, corIdentificador ?? Brushes.White, rectangle.X + 2, rectangle.Y + 1);
            }

        }

        public static Brush ObterCorTexto(BlocoDeMemoria bloco, RegiaoBlocoMemoria regiao)
        {
            if (bloco.EstaLivre)
            {
                switch (regiao)
                {
                    case RegiaoBlocoMemoria.Header:
                        return Brushes.White;
                    case RegiaoBlocoMemoria.Footer:
                        return Brushes.White;
                    default:
                        return Brushes.Black;
                }
            }

            return regiao switch
            {
                RegiaoBlocoMemoria.Padding => Brushes.Black,

                _ => Brushes.White
            };
        }
    }
}
