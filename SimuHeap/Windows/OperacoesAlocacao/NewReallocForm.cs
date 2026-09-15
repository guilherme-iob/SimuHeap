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
    public partial class NewReallocForm : Form
    {
        public EventoRealloc? EventoCriado { get; private set; }

        public NewReallocForm(IEnumerable<ReferenciaAlocacao> alocacoes)
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

            EventoCriado = new EventoRealloc
            {
                TipoVariavel = referencia.TipoVariavel,
                ReferenciaBloco = referencia.Id,
                NovaQuantidade = (int)Input_Quantidade.Value
            };

            EventoCriado.AtualizarDescricao();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Realloc", ExplicacoesConceitos.ExplicacaoRealloc);
            avisoExplicativoForm.ShowDialog();
        }

        private void ComboBox_Blocos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLabelPreview();
        }

        private void Input_Quantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLabelPreview();
        }

        private void AtualizarLabelPreview()
        {
            if (ComboBox_Blocos.SelectedItem is not ReferenciaAlocacao referencia) return;

            string nomeVariavel = ComboBox_Blocos.SelectedItem?.ToString()?.ToLower() ?? "bloco";
            this.Lbl_PreVisualizacao.Text = $"{referencia.TipoVariavel.ToString().ToLower()} *{nomeVariavel} = realloc({nomeVariavel}, {Input_Quantidade.Value} * sizeof({referencia.TipoVariavel.ToString().ToLower()}));";
        }
    }
}
