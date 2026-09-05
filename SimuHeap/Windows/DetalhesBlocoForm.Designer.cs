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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesBlocoForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            groupBoxDetalhes = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblInformacoes2 = new Label();
            lblInformacoes = new Label();
            PanelBlocosDetalhes = new Panel();
            btnFechar = new Button();
            DataGridViewValores = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBoxDetalhes.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewValores).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxDetalhes, 0, 2);
            tableLayoutPanel1.Controls.Add(PanelBlocosDetalhes, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFechar, 0, 4);
            tableLayoutPanel1.Controls.Add(DataGridViewValores, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(754, 661);
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
            lblTitulo.Size = new Size(746, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bloco";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxDetalhes
            // 
            groupBoxDetalhes.Controls.Add(tableLayoutPanel2);
            groupBoxDetalhes.Dock = DockStyle.Fill;
            groupBoxDetalhes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDetalhes.Location = new Point(3, 165);
            groupBoxDetalhes.Name = "groupBoxDetalhes";
            groupBoxDetalhes.Size = new Size(748, 286);
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
            tableLayoutPanel2.Size = new Size(742, 258);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblInformacoes2
            // 
            lblInformacoes2.AutoSize = true;
            lblInformacoes2.Dock = DockStyle.Fill;
            lblInformacoes2.Location = new Point(374, 0);
            lblInformacoes2.Name = "lblInformacoes2";
            lblInformacoes2.Size = new Size(365, 258);
            lblInformacoes2.TabIndex = 1;
            lblInformacoes2.Text = "i2";
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Dock = DockStyle.Fill;
            lblInformacoes.Location = new Point(3, 0);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(365, 258);
            lblInformacoes.TabIndex = 0;
            lblInformacoes.Text = "i1";
            // 
            // PanelBlocosDetalhes
            // 
            PanelBlocosDetalhes.AutoScroll = true;
            PanelBlocosDetalhes.Dock = DockStyle.Fill;
            PanelBlocosDetalhes.Location = new Point(3, 68);
            PanelBlocosDetalhes.Name = "PanelBlocosDetalhes";
            PanelBlocosDetalhes.Size = new Size(748, 91);
            PanelBlocosDetalhes.TabIndex = 4;
            // 
            // btnFechar
            // 
            btnFechar.Dock = DockStyle.Right;
            btnFechar.ForeColor = SystemColors.ControlText;
            btnFechar.Location = new Point(645, 587);
            btnFechar.MaximumSize = new Size(106, 40);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(106, 40);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // DataGridViewValores
            // 
            DataGridViewValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewValores.Dock = DockStyle.Fill;
            DataGridViewValores.Location = new Point(3, 457);
            DataGridViewValores.Name = "DataGridViewValores";
            DataGridViewValores.Size = new Size(748, 124);
            DataGridViewValores.TabIndex = 5;
            // 
            // DetalhesBlocoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(754, 661);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)DataGridViewValores).EndInit();
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
        private DataGridView DataGridViewValores;
    }
}