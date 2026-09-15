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
    public partial class StatusPill : Control
    {
        private Color fillColor = Color.FromArgb(254, 242, 242);
        private Color borderColor = Color.FromArgb(254, 202, 202);
        private Color textColor = Color.FromArgb(185, 28, 28);
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TextColorCustom
        {
            get => textColor;
            set
            {
                textColor = value;
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

        public StatusPill()
        {
            Size = new Size(130, 32);
            Font = new Font("Lato SemiBold", 9.5F, FontStyle.Regular);

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

            using GraphicsPath path = CriarCaminhoArredondado(rect);
            using SolidBrush brush = new SolidBrush(FillColor);

            e.Graphics.FillPath(brush, path);

            if (BorderSize > 0)
            {
                using Pen pen = new Pen(BorderColor, BorderSize);
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, path);
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                TextColorCustom,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine |
                TextFormatFlags.NoPadding);
        }

        private GraphicsPath CriarCaminhoArredondado(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            int diametro = Math.Min(rect.Height, rect.Width);

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, diametro, diametro, 90, 180);
            path.AddArc(rect.Right - diametro, rect.Top, diametro, diametro, 270, 180);
            path.CloseFigure();

            return path;
        }
    }
}
