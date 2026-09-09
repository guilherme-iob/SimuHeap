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
    public partial class RoundedButton : Button
    {
        private int borderRadius = 8;
        private int borderSize = 0;
        private Color borderColor = Color.Transparent;

        private bool mouseOver;
        private bool mouseDown;

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
        [DefaultValue(0)]
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
        [DefaultValue(0)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;

            BackColor = CoresInterface.Primaria;
            ForeColor = Color.White;

            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Cursor = Cursors.Hand;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.MiddleCenter;
            TextAlign = ContentAlignment.MiddleCenter;

            Padding = new Padding(10, 0, 10, 0);

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseOver = false;
            mouseDown = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            mouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color corFundoPai = Parent?.BackColor ?? Color.White;
            e.Graphics.Clear(corFundoPai);

            Rectangle rect = new Rectangle(1, 1, Width - 3, Height - 3);

            using GraphicsPath path = CriarCaminhoArredondado(rect, BorderRadius);

            Color corFundo = BackColor;

            if (mouseDown)
                corFundo = Escurecer(BackColor, 0.15f);
            else if (mouseOver)
                corFundo = Escurecer(BackColor, 0.08f);

            using Brush brush = new SolidBrush(corFundo);
            e.Graphics.FillPath(brush, path);

            if (BorderSize > 0)
            {
                using Pen pen = new Pen(BorderColor, BorderSize);
                e.Graphics.DrawPath(pen, path);
            }

            DesenharConteudo(e.Graphics);
        }

        private void DesenharConteudo(Graphics graphics)
        {
            Rectangle area = ClientRectangle;
            Size tamanhoTexto = TextRenderer.MeasureText(Text, Font);

            int larguraImagem = Image?.Width ?? 0;
            int espacamento = Image is null || string.IsNullOrEmpty(Text) ? 0 : 8;

            int larguraTotal = larguraImagem + espacamento + tamanhoTexto.Width;
            int x = (Width - larguraTotal) / 2;

            if (Image is not null)
            {
                int yImagem = (Height - Image.Height) / 2;
                graphics.DrawImage(Image, x, yImagem, Image.Width, Image.Height);
                x += Image.Width + espacamento;
            }

            Rectangle areaTexto = new Rectangle(x, 0, tamanhoTexto.Width + 4, Height);

            TextRenderer.DrawText(graphics, Text, Font, areaTexto, ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
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

        private Color Escurecer(Color cor, float quantidade)
        {
            int r = (int)(cor.R * (1 - quantidade));
            int g = (int)(cor.G * (1 - quantidade));
            int b = (int)(cor.B * (1 - quantidade));

            return Color.FromArgb(cor.A, r, g, b);
        }
    }
}
