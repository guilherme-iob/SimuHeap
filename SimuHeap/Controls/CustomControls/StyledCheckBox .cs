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
    public partial class StyledCheckBox : CheckBox
    {
        private int boxSize = 20;
        private int borderRadius = 4;

        [Category("Aparência")]
        [DefaultValue(20)]
        public int BoxSize
        {
            get => boxSize;
            set
            {
                boxSize = Math.Max(12, value);
                Invalidate();
            }
        }

        [Category("Aparência")]
        [DefaultValue(4)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(1, value);
                Invalidate();
            }
        }

        public StyledCheckBox()
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

            Rectangle boxRect = new Rectangle(0, (Height - BoxSize) / 2, BoxSize, BoxSize);

            using GraphicsPath path = CriarCaminhoArredondado(boxRect, BorderRadius);
            using SolidBrush fillBrush = new SolidBrush(Checked ? CoresInterface.Primaria : Color.White);
            using Pen borderPen = new Pen(Checked ? CoresInterface.Primaria : CoresInterface.Borda, 1.5f);

            e.Graphics.FillPath(fillBrush, path);
            e.Graphics.DrawPath(borderPen, path);

            if (Checked)
                DesenharCheck(e.Graphics, boxRect);

            Rectangle textRect = new Rectangle(BoxSize + 10, 0, Width - BoxSize - 10, Height);
            TextRenderer.DrawText(e.Graphics, Text, Font, textRect, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        private void DesenharCheck(Graphics g, Rectangle rect)
        {
            using Pen pen = new Pen(Color.White, 2.2f);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            Point p1 = new Point(rect.X + 5, rect.Y + rect.Height / 2);
            Point p2 = new Point(rect.X + 9, rect.Y + rect.Height - 6);
            Point p3 = new Point(rect.Right - 5, rect.Y + 6);

            g.DrawLines(pen, new[] { p1, p2, p3 });
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
