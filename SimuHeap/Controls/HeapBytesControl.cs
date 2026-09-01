using SimuHeap.Models;
using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuHeap.Controls
{
    public abstract partial class HeapBytesControl : UserControl
    {
        protected int cellSize = StyleHeap.TamanhoCelula;
        protected int columns = 1;
        protected int rows = 1;

        protected HeapBytesControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            BackColor = Color.FromArgb(30, 30, 30);
            Cursor = Cursors.Hand;
        }

        [Category("Configurações Visuais")]
        [DefaultValue(StyleHeap.TamanhoCelula)]
        public int CellSize
        {
            get => cellSize;
            set
            {
                if (value > 0)
                {
                    cellSize = value;
                    RecalcularDimensoes();
                    Invalidate();
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        [Browsable(false)]
        public int Columns => columns;

        [Browsable(false)]
        public int Rows => rows;

        protected abstract int QuantidadeBytes { get; }

        public void AjustarTamanho(int larguraDisponivel)
        {
            if (larguraDisponivel <= 0 || cellSize <= 0) return;

            columns = Math.Max(1, larguraDisponivel / cellSize);
            RecalcularDimensoes();
        }

        protected void RecalcularDimensoes()
        {
            if(columns <=0) return;

            rows = QuantidadeBytes == 0 ? 0 : (int)Math.Ceiling((double)QuantidadeBytes / columns);
            Width = columns * cellSize;
            Height = rows * cellSize;

            Invalidate();
        }

        protected Rectangle ObterRetanguloCelula(int indice)
        {
            int coluna = indice % columns;
            int linha = indice / columns;

            return new Rectangle(coluna * cellSize, linha * cellSize, cellSize, cellSize);
        }

        protected int ObterIndicePorCoordenada(Point ponto)
        {
            int coluna = ponto.X / cellSize;
            int linha = ponto.Y / cellSize;

            return linha * columns + coluna;
        }

        protected static void ObterId(BlocoDeMemoria bloco, int endereco, out string? id, out Brush? corId)
        {
            id = null;
            corId = null;

            if (endereco != bloco.EnderecoInicio) return;

            id = bloco.EstaLivre ? $"L#{bloco.Id}" : $"#{bloco.Id}";
            corId = bloco.EstaLivre ? Brushes.White : Brushes.Yellow;
        }
    }
}
