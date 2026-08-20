namespace SimuHeap.Windows.Avisos
{
    partial class AvisoFalhaAlocacaoForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            txtMensagem = new RichTextBox();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMensagem, 0, 1);
            tableLayoutPanel1.Controls.Add(btnClose, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(384, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(376, 61);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(79, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 61);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.warning;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(17, 10);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.MaximumSize = new Size(40, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = Color.Gray;
            txtMensagem.BorderStyle = BorderStyle.None;
            txtMensagem.Dock = DockStyle.Fill;
            txtMensagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMensagem.ForeColor = SystemColors.Window;
            txtMensagem.Location = new Point(10, 79);
            txtMensagem.Margin = new Padding(10);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ReadOnly = true;
            txtMensagem.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtMensagem.Size = new Size(364, 302);
            txtMensagem.TabIndex = 2;
            txtMensagem.Text = "";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(284, 408);
            btnClose.Margin = new Padding(4);
            btnClose.MaximumSize = new Size(96, 35);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 35);
            btnClose.TabIndex = 3;
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AvisoFalhaAlocacaoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(384, 461);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AvisoFalhaAlocacaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AvisoFalhaAlocacaoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private RichTextBox txtMensagem;
        private Button btnClose;
    }
}