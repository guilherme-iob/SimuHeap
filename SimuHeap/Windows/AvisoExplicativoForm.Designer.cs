namespace SimuHeap.Windows
{
    partial class AvisoExplicativoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Btn_Fechar = new Button();
            lblTitulo = new Label();
            txtConteudo = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Btn_Fechar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(txtConteudo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(499, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Fechar
            // 
            Btn_Fechar.Dock = DockStyle.Right;
            Btn_Fechar.Location = new Point(373, 408);
            Btn_Fechar.Name = "Btn_Fechar";
            Btn_Fechar.Size = new Size(123, 39);
            Btn_Fechar.TabIndex = 0;
            Btn_Fechar.Text = "Fechar";
            Btn_Fechar.UseVisualStyleBackColor = true;
            Btn_Fechar.Click += Btn_Fechar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(493, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConteudo
            // 
            txtConteudo.BackColor = Color.CornflowerBlue;
            txtConteudo.BorderStyle = BorderStyle.None;
            txtConteudo.Dock = DockStyle.Fill;
            txtConteudo.ForeColor = SystemColors.ControlLightLight;
            txtConteudo.Location = new Point(10, 55);
            txtConteudo.Margin = new Padding(10);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtConteudo.Size = new Size(479, 340);
            txtConteudo.TabIndex = 2;
            txtConteudo.Text = "";
            // 
            // AvisoExplicativoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(499, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AvisoExplicativoForm";
            Text = "AvisoExplicativoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_Fechar;
        private Label lblTitulo;
        private RichTextBox txtConteudo;
    }
}