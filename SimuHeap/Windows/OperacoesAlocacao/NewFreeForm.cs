using SimuHeap.Models;
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

namespace SimuHeap.Windows.OperacoesAlocacao
{
    public partial class NewFreeForm : Form
    {
        public EventoFree? EventoCriado { get; private set; }
        public NewFreeForm(IEnumerable<ReferenciaAlocacao> alocacoes)
        {
            InitializeComponent();
            this.ComboBox_Blocos.DataSource = alocacoes.ToList();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ComboBox_Blocos.SelectedItem is not ReferenciaAlocacao referencia) return;

            EventoCriado = new EventoFree
            {
                ReferenciaBloco = referencia.Id
            };

            EventoCriado.AtualizarDescricao();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Free", ExplicacoesConceitos.ExplicacaoFree);
            avisoExplicativoForm.ShowDialog();
        }

        private void ComboBox_Blocos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLabelPreview();
        }

        private void AtualizarLabelPreview()
        {
            if (ComboBox_Blocos.SelectedItem is not ReferenciaAlocacao referencia) return;

            string nomeVariavel = ComboBox_Blocos.SelectedItem?.ToString()?.ToLower() ?? "bloco";
            this.Lbl_PreVisualizacao.Text = $"free({nomeVariavel});";
        }
    }
}
