namespace SimuHeap.Windows
{
    partial class DetalhesBlocoForm
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
            lblTitulo = new Label();
            groupBoxDetalhes = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblInformacoes2 = new Label();
            lblInformacoes = new Label();
            btnFechar = new Button();
            PanelBlocosDetalhes = new Panel();
            tableLayoutPanel1.SuspendLayout();
            groupBoxDetalhes.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxDetalhes, 0, 2);
            tableLayoutPanel1.Controls.Add(btnFechar, 0, 3);
            tableLayoutPanel1.Controls.Add(PanelBlocosDetalhes, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(751, 458);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(4, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(743, 43);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bloco";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxDetalhes
            // 
            groupBoxDetalhes.Controls.Add(tableLayoutPanel2);
            groupBoxDetalhes.Dock = DockStyle.Fill;
            groupBoxDetalhes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDetalhes.Location = new Point(3, 177);
            groupBoxDetalhes.Name = "groupBoxDetalhes";
            groupBoxDetalhes.Size = new Size(745, 191);
            groupBoxDetalhes.TabIndex = 2;
            groupBoxDetalhes.TabStop = false;
            groupBoxDetalhes.Text = "Informações";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblInformacoes2, 1, 0);
            tableLayoutPanel2.Controls.Add(lblInformacoes, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(739, 163);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblInformacoes2
            // 
            lblInformacoes2.AutoSize = true;
            lblInformacoes2.Dock = DockStyle.Fill;
            lblInformacoes2.Location = new Point(372, 0);
            lblInformacoes2.Name = "lblInformacoes2";
            lblInformacoes2.Size = new Size(364, 163);
            lblInformacoes2.TabIndex = 1;
            lblInformacoes2.Text = "i2";
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Dock = DockStyle.Fill;
            lblInformacoes.Location = new Point(3, 0);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(363, 163);
            lblInformacoes.TabIndex = 0;
            lblInformacoes.Text = "i1";
            // 
            // btnFechar
            // 
            btnFechar.Dock = DockStyle.Right;
            btnFechar.ForeColor = SystemColors.ControlText;
            btnFechar.Location = new Point(642, 374);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(106, 59);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // PanelBlocosDetalhes
            // 
            PanelBlocosDetalhes.AutoScroll = true;
            PanelBlocosDetalhes.Dock = DockStyle.Fill;
            PanelBlocosDetalhes.Location = new Point(3, 46);
            PanelBlocosDetalhes.Name = "PanelBlocosDetalhes";
            PanelBlocosDetalhes.Size = new Size(745, 125);
            PanelBlocosDetalhes.TabIndex = 4;
            // 
            // DetalhesBlocoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(751, 458);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetalhesBlocoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetalhesBlocoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBoxDetalhes.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private GroupBox groupBoxDetalhes;
        private Label lblInformacoes;
        private Button btnFechar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblInformacoes2;
        private Panel PanelBlocosDetalhes;
    }
}