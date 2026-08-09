using SimuHeap.Models;
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
    public partial class FreeForm : Form
    {
        public EventoFree? EventoCriado { get; private set; }
        public FreeForm(IEnumerable<ReferenciaAlocacao> alocacoes)
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
    }
}
