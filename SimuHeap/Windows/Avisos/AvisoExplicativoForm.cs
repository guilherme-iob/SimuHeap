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
            Lbl_Titulo.Text = titulo;

            Mensagem.Text = conteudo;
            Mensagem.ReadOnly = true;
            Mensagem.BorderStyle = BorderStyle.None;
            Mensagem.BackColor = Color.White;

            Mensagem.SelectionStart = 0;
            Mensagem.SelectionLength = 0;

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
