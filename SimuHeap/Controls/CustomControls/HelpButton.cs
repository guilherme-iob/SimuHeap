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
    public partial class HelpButton : Button
    {
        private bool mouseOver;
        private bool mouseDown;

        private Color borderColor = CoresInterface.Borda;

        [Category("Aparência")]
        [DefaultValue(typeof(Color), "Borda")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public HelpButton()
        {
            Size = new Size(28, 28);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;

            BackColor = CoresInterface.Superficie;
            ForeColor = CoresInterface.TextoSecundario;

            Cursor = Cursors.Hand;
            TabStop = false;

            Text = "";

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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color corFundoPai = Parent?.BackColor ?? CoresInterface.Superficie;
            e.Graphics.Clear(corFundoPai);

            Rectangle rect = new Rectangle(1, 1, Width - 3, Height - 3);

            Color corFundo = CoresInterface.Superficie;

            if (mouseDown)
                corFundo = CoresInterface.Selecao;
            else if (mouseOver)
                corFundo = CoresInterface.Hover;

            using Brush brush = new SolidBrush(corFundo);
            using Pen pen = new Pen(BorderColor, 1);

            e.Graphics.FillEllipse(brush, rect);
            e.Graphics.DrawEllipse(pen, rect);

            Image? imagem = Image ?? BackgroundImage;

            if (imagem is not null)
            {
                int tamanhoIcone = 16;
                int x = (Width - tamanhoIcone) / 2;
                int y = (Height - tamanhoIcone) / 2;

                e.Graphics.DrawImage(imagem, x, y, tamanhoIcone, tamanhoIcone);
            }
        }
    }
}
