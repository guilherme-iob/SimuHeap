using SimuHeap.Controls.CustomControls;
using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuHeap.Windows
{
    public partial class NewLegendaForm : Form
    {
        public NewLegendaForm(bool usarLegendasDetalhadas)
        {
            InitializeComponent();

            AplicarCores(ColorIndicator_BlocoLivre, CoresSimulacao.BlocoLivre);
            AplicarCores(ColorIndicator_BlocoOcupado, CoresSimulacao.BlocoOcupado);

            AplicarCores(ColorIndicator_BlocoEmAnalise, CoresSimulacao.BlocoEmAnalise);
            AplicarCores(ColorIndicator_MelhorBlocoEncontrado, CoresSimulacao.MelhorBlocoEncontrado);
            AplicarCores(ColorIndicator_MelhorBlocoSelecionado, CoresSimulacao.MelhorBlocoSelecionado);
            AplicarCores(ColorIndicator_Coalescing, CoresSimulacao.BlocoCoalescing);

            if (usarLegendasDetalhadas)
            {
                AplicarCores(ColorIndicator_BlocoSendoLiberado, CoresSimulacao.BlocoSendoLiberado);
                AplicarCores(ColorIndicator_BlocoSendoReduzido, CoresSimulacao.BlocoSendoReduzido);
                AplicarCores(ColorIndicator_BlocoSendoExpandido, CoresSimulacao.BlocoSendoExpandido);
                AplicarCores(ColorIndicator_BlocoSendoMovido, CoresSimulacao.BlocoSendoMovido);
                AplicarCores(ColorIndicator_BlocoCalloc, CoresSimulacao.BlocoInicializadoCalloc);
            }
            else
            {
                ColorIndicator_BlocoSendoLiberado.Visible = false;
                ColorIndicator_BlocoSendoReduzido.Visible = false;
                ColorIndicator_BlocoSendoExpandido.Visible = false;
                ColorIndicator_BlocoSendoMovido.Visible = false;
                ColorIndicator_BlocoCalloc.Visible = false;
                Lbl_BlocoSendoLiberado.Visible = false;
                Lbl_BlocoSendoReduzido.Visible = false;
                Lbl_BlocoSendoExpandido.Visible = false;
                Lbl_BlocoSendoMovido.Visible = false;
                Lbl_BlocoCalloc.Visible = false;
            }
        }

        private void AplicarCores(ColorIndicator colorIndicator, Color cor)
        {
            colorIndicator.FillColor = cor;
            colorIndicator.BorderColor = CoresSimulacao.Escurecer(cor);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
