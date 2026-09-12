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
        private bool mouseOver;

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
            UseVisualStyleBackColor = false;

            BackColor = CoresInterface.Superficie;
            ForeColor = CoresInterface.TextoSecundario;

            Height = 48;
            Width = 150;

            Cursor = Cursors.Hand;
            Font = new Font("Lato", 10F, FontStyle.Regular);

            TextAlign = ContentAlignment.MiddleLeft;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextImageRelation = TextImageRelation.ImageBeforeText;

            Padding = new Padding(18, 0, 10, 0);
            Margin = new Padding(0);

            FlatAppearance.MouseOverBackColor = CoresInterface.Hover;
            FlatAppearance.MouseDownBackColor = CoresInterface.Hover;

            AtualizarAparencia();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseOver = true;
            AtualizarAparencia();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseOver = false;
            AtualizarAparencia();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (Selecionado)
            {
                using Brush brush = new SolidBrush(CoresInterface.Primaria);
                pevent.Graphics.FillRectangle(brush, 0, Height - 3, Width, 3);
            }
            else if (mouseOver)
            {
                using Brush brush = new SolidBrush(CoresInterface.Primaria);
                pevent.Graphics.FillRectangle(brush, 0, Height - 2, Width, 2);
            }
        }

        private void AtualizarAparencia()
        {
            if (Selecionado)
            {
                BackColor = CoresInterface.Superficie;
                ForeColor = CoresInterface.Primaria;
                Font = new Font("Lato", 10F, FontStyle.Bold);
            }
            else if (mouseOver)
            {
                BackColor = CoresInterface.Hover;
                ForeColor = CoresInterface.Primaria;
                Font = new Font("Lato", 10F, FontStyle.Regular);
            }
            else
            {
                BackColor = CoresInterface.Superficie;
                ForeColor = CoresInterface.TextoSecundario;
                Font = new Font("Lato", 10F, FontStyle.Regular);
            }
        }
    }
}
