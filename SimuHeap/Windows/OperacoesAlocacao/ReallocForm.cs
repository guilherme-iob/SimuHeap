using SimuHeap.Enums;
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
    public partial class ReallocForm : Form
    {
        public EventoRealloc? EventoCriado { get; private set; }

        public ReallocForm(IEnumerable<ReferenciaAlocacao> alocacoes)
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
    }
}
