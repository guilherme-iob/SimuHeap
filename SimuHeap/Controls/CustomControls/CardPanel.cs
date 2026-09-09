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
    public partial class CardPanel : Panel
    {
        private int borderRadius = 10;
        private int borderSize = 1;
        private Color borderColor = CoresInterface.Borda;

        [Category("Aparência")]
        [DefaultValue(10)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(1, value);
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(1)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(1)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public CardPanel()
        {
            DoubleBuffered = true;
            BackColor = CoresInterface.Superficie;
            Margin = new Padding(0);
            Padding = new Padding(0);

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color corFundoPai = Parent?.BackColor ?? SystemColors.Control;
            e.Graphics.Clear(corFundoPai);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using GraphicsPath path = CriarCaminhoArredondado(rect, BorderRadius);
            using SolidBrush brush = new SolidBrush(BackColor);

            e.Graphics.FillPath(brush, path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (borderSize <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using GraphicsPath path = CriarCaminhoArredondado(rect, BorderRadius);
            using Pen pen = new Pen(BorderColor, BorderSize);

            e.Graphics.DrawPath(pen, path);
        }

        private GraphicsPath CriarCaminhoArredondado(Rectangle rect, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            int diametro = Math.Min(raio * 2, Math.Min(rect.Width, rect.Height));

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90);
            path.AddArc(rect.Right - diametro, rect.Y, diametro, diametro, 270, 90);
            path.AddArc(rect.Right - diametro, rect.Bottom - diametro, diametro, diametro, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
