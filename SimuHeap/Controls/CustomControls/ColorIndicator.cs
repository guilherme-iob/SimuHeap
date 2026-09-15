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
    public partial class ColorIndicator : Control
    {
        private Color fillColor = Color.White;
        private Color borderColor = CoresInterface.Borda;
        private int borderRadius = 8;
        private int borderSize = 1;

        [Category("Aparência")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color FillColor
        {
            get => fillColor;
            set
            {
                fillColor = value;
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(8)]
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

        public ColorIndicator()
        {
            Size = new Size(32, 32);
            DoubleBuffered = true;

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color corFundoPai = Parent?.BackColor ?? Color.White;
            e.Graphics.Clear(corFundoPai);

            Rectangle rect = new Rectangle(1, 1, Width - 3, Height - 3);

            using GraphicsPath path = CriarCaminhoArredondado(rect, BorderRadius);
            using SolidBrush brush = new SolidBrush(FillColor);
            using Pen pen = new Pen(BorderColor, BorderSize);

            pen.Alignment = PenAlignment.Inset;

            e.Graphics.FillPath(brush, path);

            if (BorderSize > 0)
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
