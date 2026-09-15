using SimuHeap.Enums;
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
    public partial class NewMallocForm : Form
    {
        public EventoMalloc? EventoCriado { get; private set; }
        public NewMallocForm()
        {
            InitializeComponent();
        }

        private void NewMallocForm_Load(object sender, EventArgs e)
        {
            this.ComboBox_TipoVariavel.DataSource = Enum.GetValues(typeof(TiposDeVariaveis));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            EventoCriado = new EventoMalloc
            {
                TipoVariavel = (TiposDeVariaveis)this.ComboBox_TipoVariavel.SelectedItem!,
                Quantidade = (int)Input_Quantidade.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Malloc", ExplicacoesConceitos.ExplicacaoMalloc);
            avisoExplicativoForm.ShowDialog();
        }

        private void ComboBox_TipoVariavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLabelPreview();
        }

        private void Input_Quantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLabelPreview();
        }

        private void AtualizarLabelPreview()
        {
            string tipoVariavel = ComboBox_TipoVariavel.SelectedItem?.ToString()?.ToLower() ?? "tipo";
            this.Lbl_PreVisualizacao.Text = $"{tipoVariavel} *bloco = malloc({Input_Quantidade.Value} * sizeof({tipoVariavel}));";
        }
    }
}
