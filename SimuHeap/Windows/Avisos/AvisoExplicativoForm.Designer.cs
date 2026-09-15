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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvisoExplicativoForm));
            panel1 = new Panel();
            cardPanel1 = new SimuHeap.Controls.CustomControls.CardPanel();
            Mensagem = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOK = new SimuHeap.Controls.CustomControls.RoundedButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            Lbl_Titulo = new Label();
            panel1.SuspendLayout();
            cardPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cardPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(499, 370);
            panel1.TabIndex = 29;
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
            cardPanel1.Size = new Size(489, 360);
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
            Mensagem.Size = new Size(473, 344);
            Mensagem.TabIndex = 0;
            Mensagem.Text = "";
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
            tableLayoutPanel1.Location = new Point(0, 410);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(499, 40);
            tableLayoutPanel1.TabIndex = 28;
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
            BtnOK.Location = new Point(335, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Padding = new Padding(10, 0, 10, 0);
            BtnOK.Size = new Size(161, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += Btn_Fechar_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(Lbl_Titulo, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(499, 40);
            tableLayoutPanel4.TabIndex = 27;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.Dock = DockStyle.Fill;
            Lbl_Titulo.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Titulo.Location = new Point(3, 0);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(493, 40);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Título";
            Lbl_Titulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AvisoExplicativoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(499, 450);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AvisoExplicativoForm";
            Text = "AvisoExplicativoForm";
            panel1.ResumeLayout(false);
            cardPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Controls.CustomControls.CardPanel cardPanel1;
        private RichTextBox Mensagem;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.RoundedButton BtnOK;
        private TableLayoutPanel tableLayoutPanel4;
        private Label Lbl_Titulo;
    }
}