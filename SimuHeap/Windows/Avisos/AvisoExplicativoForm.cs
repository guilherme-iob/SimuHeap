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
    public partial class AvisoExplicativoForm : Form
    {
        public AvisoExplicativoForm(string titulo, string conteudo)
        {
            InitializeComponent();
            this.Text = titulo;
            lblTitulo.Text = titulo;

            txtConteudo.Text = conteudo;
            txtConteudo.ReadOnly = true;
            txtConteudo.BorderStyle = BorderStyle.None;
            txtConteudo.BackColor = Color.CornflowerBlue;

            txtConteudo.SelectionStart = 0;
            txtConteudo.SelectionLength = 0;

            StartPosition = FormStartPosition.CenterParent;

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
