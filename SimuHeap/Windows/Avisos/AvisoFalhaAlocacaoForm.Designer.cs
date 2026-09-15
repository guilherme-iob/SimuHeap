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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvisoFalhaAlocacaoForm));
            tableLayoutPanel4 = new TableLayoutPanel();
            Lbl_Titulo = new Label();
            pictureBox8 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOK = new SimuHeap.Controls.CustomControls.RoundedButton();
            panel1 = new Panel();
            cardPanel1 = new SimuHeap.Controls.CustomControls.CardPanel();
            Mensagem = new RichTextBox();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            cardPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Controls.Add(Lbl_Titulo, 1, 0);
            tableLayoutPanel4.Controls.Add(pictureBox8, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(484, 40);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.Dock = DockStyle.Fill;
            Lbl_Titulo.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Titulo.Location = new Point(53, 0);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(378, 40);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Falha";
            Lbl_Titulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.warning_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(10, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(BtnOK, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 421);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 40);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.FromArgb(35, 125, 230);
            BtnOK.BorderColor = Color.Transparent;
            BtnOK.Dock = DockStyle.Fill;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            BtnOK.ForeColor = Color.White;
            BtnOK.Location = new Point(325, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Padding = new Padding(10, 0, 10, 0);
            BtnOK.Size = new Size(156, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cardPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(484, 381);
            panel1.TabIndex = 26;
            // 
            // cardPanel1
            // 
            cardPanel1.BackColor = Color.White;
            cardPanel1.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel1.Controls.Add(Mensagem);
            cardPanel1.Dock = DockStyle.Fill;
            cardPanel1.Location = new Point(5, 5);
            cardPanel1.Margin = new Padding(5);
            cardPanel1.Name = "cardPanel1";
            cardPanel1.Padding = new Padding(8);
            cardPanel1.Size = new Size(474, 371);
            cardPanel1.TabIndex = 0;
            // 
            // Mensagem
            // 
            Mensagem.BackColor = Color.White;
            Mensagem.BorderStyle = BorderStyle.None;
            Mensagem.Dock = DockStyle.Fill;
            Mensagem.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mensagem.Location = new Point(8, 8);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(458, 355);
            Mensagem.TabIndex = 0;
            Mensagem.Text = "";
            // 
            // AvisoFalhaAlocacaoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AvisoFalhaAlocacaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Falha de Alocação";
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            cardPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label Lbl_Titulo;
        private PictureBox pictureBox8;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.RoundedButton BtnOK;
        private Panel panel1;
        private Controls.CustomControls.CardPanel cardPanel1;
        private RichTextBox Mensagem;
    }
}