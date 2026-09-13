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
    public partial class StyledProgressBar : Control
    {
        private double percentual;
        private Color corProgresso = CoresInterface.Primaria;
        private Color corFundo = Color.FromArgb(228, 234, 241);

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
        [DefaultValue((double)100)]
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
        [DefaultValue((double)100)]
        public Color CorFundo
        {
            get => corFundo;
            set
            {
                corFundo = value;
                Invalidate();
            }
        }

        public StyledProgressBar()
        {
            Height = 14;
            MinimumSize = new Size(50, 8);

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rectFundo = new Rectangle(0, 0, Width - 1, Height - 1);

            using GraphicsPath pathFundo = CriarCaminhoArredondado(rectFundo);
            using SolidBrush brushFundo = new SolidBrush(CorFundo);

            e.Graphics.FillPath(brushFundo, pathFundo);

            int larguraProgresso = (int)((Width - 1) * Percentual / 100.0);

            if (larguraProgresso <= 0)
                return;

            Rectangle rectProgresso = new Rectangle(0, 0, larguraProgresso, Height - 1);

            using GraphicsPath pathProgresso = CriarCaminhoArredondado(rectProgresso);
            using SolidBrush brushProgresso = new SolidBrush(CorProgresso);

            e.Graphics.FillPath(brushProgresso, pathProgresso);
        }

        private GraphicsPath CriarCaminhoArredondado(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            if (rect.Width <= 0 || rect.Height <= 0)
                return path;

            int raio = Math.Min(rect.Height / 2, rect.Width / 2);
            int diametro = raio * 2;

            if (diametro <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, diametro, diametro, 90, 180);
            path.AddArc(rect.Right - diametro, rect.Top, diametro, diametro, 270, 180);
            path.CloseFigure();

            return path;
        }
    }
}
