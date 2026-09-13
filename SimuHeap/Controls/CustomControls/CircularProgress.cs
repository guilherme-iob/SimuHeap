using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Controls.CustomControls
{
    public partial class CircularProgress : Control
    {
        private double percentual;
        private int espessura = 18;
        private Color corProgresso = CoresInterface.Primaria;
        private Color corFundo = Color.FromArgb(228, 234, 241);
        private string textoSecundario = "Uso da heap";

        [Category("Aparência")]
        [DefaultValue(0d)]
        public double Percentual
        {
            get => percentual;
            set
            {
                percentual = Math.Clamp(value, 0, 100);
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(18)]
        public int Espessura
        {
            get => espessura;
            set
            {
                espessura = Math.Max(1, value);
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(typeof(Color), "1, 120, 215")]
        public Color CorProgresso
        {
            get => corProgresso;
            set
            {
                corProgresso = value;
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(typeof(Color), "228, 234, 241")]
        public Color CorFundo
        {
            get => corFundo;
            set
            {
                corFundo = value;
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue("Uso da heap")]
        public string TextoSecundario
        {
            get => textoSecundario;
            set
            {
                textoSecundario = value;
                Invalidate();
            }
        }

        public CircularProgress()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            Size = new Size(220, 220);
            BackColor = Color.Transparent;
            ForeColor = CoresInterface.TextoPrincipal;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            int tamanho = Math.Min(Width, Height);
            int margem = Espessura / 2 + 2;

            Rectangle rect = new Rectangle((Width - tamanho) / 2 + margem, (Height - tamanho) / 2 + margem, tamanho - margem * 2, tamanho - margem * 2);

            using Pen penFundo = new Pen(CorFundo, Espessura);
            penFundo.StartCap = LineCap.Round;
            penFundo.EndCap = LineCap.Round;

            e.Graphics.DrawArc(penFundo, rect, 0, 360);

            if (Percentual > 0)
            {
                using Pen penProgresso = new Pen(CorProgresso, Espessura);
                penProgresso.StartCap = LineCap.Round;
                penProgresso.EndCap = LineCap.Round;

                float angulo = (float)(360 * Percentual / 100.0);
                e.Graphics.DrawArc(penProgresso, rect, -90, angulo);
            }

            DesenharTexto(e.Graphics);
        }

        private void DesenharTexto(Graphics graphics)
        {
            string textoPercentual = $"{Percentual:0.00}%";

            using Font fonteValor = new Font("Lato", 20F, FontStyle.Bold);
            using Font fonteDescricao = new Font("Lato", 10F, FontStyle.Regular);

            Size tamanhoValor = TextRenderer.MeasureText(textoPercentual, fonteValor);
            Size tamanhoDescricao = TextRenderer.MeasureText(TextoSecundario, fonteDescricao);

            int alturaTotal = tamanhoValor.Height + tamanhoDescricao.Height - 4;
            int yInicial = (Height - alturaTotal) / 2;

            Rectangle areaValor = new Rectangle(0, yInicial, Width, tamanhoValor.Height);
            Rectangle areaDescricao = new Rectangle(0, yInicial + tamanhoValor.Height - 4, Width, tamanhoDescricao.Height);

            TextRenderer.DrawText(graphics, textoPercentual, fonteValor, areaValor, CoresInterface.TextoPrincipal, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            TextRenderer.DrawText(graphics, TextoSecundario, fonteDescricao, areaDescricao, CoresInterface.TextoSecundario, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
