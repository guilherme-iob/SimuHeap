using SimuHeap.Enums;
using SimuHeap.Models;
using SimuHeap.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SimuHeap.Controls
{
    public partial class HeapGridControl : UserControl
    {
        private int cellSize = 28;
        private int columns = 32;
        private int rows;

        private HeapSimulator? simulator;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public HeapSimulator? Simulator
        {
            get => simulator;

            set
            {
                simulator = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        [Category("Configurações Visuais")]
        [DefaultValue(28)]
        public int CellSize
        {
            get => cellSize;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "O tamanho da célula deve ser maior que zero.");
                }

                cellSize = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        [Category("Configurações Visuais")]
        [DefaultValue(32)]
        public int Columns
        {
            get => columns;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "A quantidade de colunas deve ser maior que zero.");
                }

                columns = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        public HeapGridControl()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.FromArgb(30, 30, 30);
        }

        public void AtualizarVisualizacao()
        {
            RecalculateDimensions();
            Invalidate();
        }

        private void RecalculateDimensions()
        {
            if (cellSize <= 0 || columns <= 0)
            {
                return;
            }

            int tamanhoHeap = simulator?.TamanhoHeap ?? 0;

            rows = tamanhoHeap == 0
                ? 0
                : (int)Math.Ceiling(
                    (double)tamanhoHeap / columns);

            Size = new Size(
                columns * cellSize,
                rows * cellSize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (simulator == null ||
                simulator.TamanhoHeap == 0 ||
                columns <= 0 ||
                rows <= 0)
            {
                return;
            }

            Graphics graphics = e.Graphics;

            graphics.TextRenderingHint =
                TextRenderingHint.ClearTypeGridFit;

            using Pen gridPen =
                new Pen(Color.FromArgb(45, 45, 45), 1f);

            using Font hexFont =
                new Font(
                    "Consolas",
                    Math.Max(6f, cellSize * 0.32f),
                    FontStyle.Regular);

            using Font idFont =
                new Font(
                    "Segoe UI",
                    Math.Max(6f, cellSize * 0.25f),
                    FontStyle.Bold);

            using StringFormat centerFormat =
                new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

            foreach (BlocoDeMemoria bloco in simulator.Blocos)
            {
                DesenharBloco(
                    graphics,
                    bloco,
                    gridPen,
                    hexFont,
                    idFont,
                    centerFormat);
            }
        }

        private void DesenharBloco(
            Graphics graphics,
            BlocoDeMemoria bloco,
            Pen gridPen,
            Font hexFont,
            Font idFont,
            StringFormat centerFormat)
        {
            if (simulator == null)
            {
                return;
            }

            for (int endereco = bloco.EnderecoInicio;
                 endereco <= bloco.EnderecoFim;
                 endereco++)
            {
                if (endereco < 0 ||
                    endereco >= simulator.Memoria.Length)
                {
                    continue;
                }

                int coluna = endereco % columns;
                int linha = endereco / columns;

                int x = coluna * cellSize;
                int y = linha * cellSize;

                Rectangle cellRectangle =
                    new Rectangle(
                        x,
                        y,
                        cellSize,
                        cellSize);

                RegiaoBlocoMemoria regiao =
                    bloco.ObterRegiao(endereco);

                using SolidBrush backgroundBrush =
                    new SolidBrush(
                        ObterCorRegiao(bloco, regiao));

                graphics.FillRectangle(
                    backgroundBrush,
                    cellRectangle);

                graphics.DrawRectangle(
                    gridPen,
                    cellRectangle);

                string texto =
                    ObterTextoCelula(bloco, endereco);

                Brush textBrush =
                    ObterCorTexto(bloco, regiao);

                graphics.DrawString(
                    texto,
                    hexFont,
                    textBrush,
                    cellRectangle,
                    centerFormat);

                if (!bloco.EstaLivre &&
                    endereco == bloco.EnderecoInicio)
                {
                    graphics.DrawString(
                        $"#{bloco.Id}",
                        idFont,
                        Brushes.Yellow,
                        x + 2,
                        y + 1);
                }
            }
        }

        private string ObterTextoCelula(
            BlocoDeMemoria bloco,
            int endereco)
        {
            if (simulator == null)
            {
                return string.Empty;
            }

            if (bloco.EstaLivre)
            {
                return "??";
            }

            return simulator.Memoria[endereco].ToString("X2");
        }

        private static Brush ObterCorTexto(
            BlocoDeMemoria bloco,
            RegiaoBlocoMemoria regiao)
        {
            if (bloco.EstaLivre)
            {
                return Brushes.LightGreen;
            }

            return regiao switch
            {
                RegiaoBlocoMemoria.Padding =>
                    Brushes.Black,

                _ => Brushes.White
            };
        }

        private static Color ObterCorRegiao(
            BlocoDeMemoria bloco,
            RegiaoBlocoMemoria regiao)
        {
            if (bloco.EstaLivre)
            {
                return bloco.Cor;
            }

            return regiao switch
            {
                RegiaoBlocoMemoria.Header =>
                    EscurecerCor(bloco.Cor, 0.55f),

                RegiaoBlocoMemoria.Payload =>
                    bloco.Cor,

                RegiaoBlocoMemoria.Padding =>
                    ClarearCor(bloco.Cor, 0.55f),

                RegiaoBlocoMemoria.Footer =>
                    EscurecerCor(bloco.Cor, 0.55f),

                _ => bloco.Cor
            };
        }

        private static Color EscurecerCor(
            Color cor,
            float fator)
        {
            return Color.FromArgb(
                cor.A,
                Math.Clamp((int)(cor.R * fator), 0, 255),
                Math.Clamp((int)(cor.G * fator), 0, 255),
                Math.Clamp((int)(cor.B * fator), 0, 255));
        }

        private static Color ClarearCor(
            Color cor,
            float fator)
        {
            int vermelho =
                cor.R + (int)((255 - cor.R) * fator);

            int verde =
                cor.G + (int)((255 - cor.G) * fator);

            int azul =
                cor.B + (int)((255 - cor.B) * fator);

            return Color.FromArgb(
                cor.A,
                Math.Clamp(vermelho, 0, 255),
                Math.Clamp(verde, 0, 255),
                Math.Clamp(azul, 0, 255));
        }
    }
}