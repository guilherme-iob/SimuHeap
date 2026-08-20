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
    public partial class MallocForm : Form
    {
        public EventoMalloc? EventoCriado { get; private set; }
        public MallocForm()
        {
            InitializeComponent();
        }

        private void MallocForm_Load(object sender, EventArgs e)
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
    }
}
