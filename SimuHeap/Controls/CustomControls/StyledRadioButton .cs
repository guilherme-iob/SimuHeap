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
    public partial class StyledRadioButton : RadioButton
    {
        private int circleSize = 20;

        [Category("Aparência")]
        [DefaultValue(20)]
        public int CircleSize
        {
            get => circleSize;
            set
            {
                circleSize = Math.Max(12, value);
                Invalidate();
            }
        }

        public StyledRadioButton()
        {
            AutoSize = false;
            Height = 28;
            MinimumSize = new Size(0, 28);

            Font = new Font("Lato", 10F, FontStyle.Regular);
            ForeColor = CoresInterface.TextoPrincipal;
            BackColor = Color.Transparent;

            Cursor = Cursors.Hand;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? Color.White);

            Rectangle outerRect = new Rectangle(0, (Height - CircleSize) / 2, CircleSize, CircleSize);

            using SolidBrush fillBrush = new SolidBrush(Color.White);
            using Pen borderPen = new Pen(Checked ? CoresInterface.Primaria : CoresInterface.Borda, 1.5f);

            e.Graphics.FillEllipse(fillBrush, outerRect);
            e.Graphics.DrawEllipse(borderPen, outerRect);

            if (Checked)
            {
                Rectangle innerRect = new Rectangle(outerRect.X + 5, outerRect.Y + 5, outerRect.Width - 10, outerRect.Height - 10);
                using SolidBrush innerBrush = new SolidBrush(CoresInterface.Primaria);
                e.Graphics.FillEllipse(innerBrush, innerRect);
            }

            Rectangle textRect = new Rectangle(CircleSize + 10, 0, Width - CircleSize - 10, Height);
            TextRenderer.DrawText(e.Graphics, Text, Font, textRect, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
