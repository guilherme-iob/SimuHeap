using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Controls.CustomControls
{
    public partial class TabNavigationButton : Button
    {
        private bool selecionado;

        [Category("Aparência")]
        [DefaultValue(false)]
        public bool Selecionado
        {
            get => selecionado;
            set
            {
                selecionado = value;
                AtualizarAparencia();
                Invalidate();
            }
        }

        public TabNavigationButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            BackColor = CoresInterface.Superficie;
            ForeColor = CoresInterface.TextoSecundario;

            Height = 54;
            Width = 150;

            Cursor = Cursors.Hand;

            Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            TextAlign = ContentAlignment.MiddleCenter;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextImageRelation = TextImageRelation.ImageBeforeText;

            Padding = new Padding(14, 0, 14, 0);

            FlatAppearance.MouseOverBackColor = CoresInterface.Hover;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 240, 247);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (!Selecionado)
                return;

            int alturaLinha = 3;

            using Brush brush = new SolidBrush(CoresInterface.Primaria);

            pevent.Graphics.FillRectangle(brush, 0, Height - alturaLinha, Width, alturaLinha);
        }

        private void AtualizarAparencia()
        {
            ForeColor = Selecionado ? CoresInterface.Primaria : CoresInterface.TextoSecundario;
            Font = new Font(Font.FontFamily, Font.Size, Selecionado ? FontStyle.Bold : FontStyle.Regular);
        }
    }
}
