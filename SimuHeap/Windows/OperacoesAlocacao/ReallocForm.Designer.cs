namespace SimuHeap.Windows
{
    partial class ReallocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReallocForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnOK = new Button();
            BtnCancelar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            Input_Quantidade = new NumericUpDown();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            ComboBox_Blocos = new ComboBox();
            Lbl_Blocos = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            Btn_Help = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Input_Quantidade).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(274, 331);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BtnOK, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnCancelar, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 282);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(268, 46);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnOK
            // 
            BtnOK.Anchor = AnchorStyles.None;
            BtnOK.Font = new Font("Segoe UI", 12F);
            BtnOK.Location = new Point(153, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(96, 39);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.None;
            BtnCancelar.Font = new Font("Segoe UI", 12F);
            BtnCancelar.Location = new Point(19, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(96, 39);
            BtnCancelar.TabIndex = 0;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Input_Quantidade, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 167);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Size = new Size(268, 109);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // Input_Quantidade
            // 
            Input_Quantidade.Anchor = AnchorStyles.None;
            Input_Quantidade.Font = new Font("Segoe UI", 14.25F);
            Input_Quantidade.Location = new Point(35, 51);
            Input_Quantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Input_Quantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Input_Quantidade.Name = "Input_Quantidade";
            Input_Quantidade.Size = new Size(197, 33);
            Input_Quantidade.TabIndex = 3;
            Input_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 27);
            label1.TabIndex = 2;
            label1.Text = "Nova Quantidade";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(ComboBox_Blocos, 0, 1);
            tableLayoutPanel4.Controls.Add(Lbl_Blocos, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 52);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.Size = new Size(268, 109);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // ComboBox_Blocos
            // 
            ComboBox_Blocos.Anchor = AnchorStyles.None;
            ComboBox_Blocos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Blocos.Font = new Font("Segoe UI", 14.25F);
            ComboBox_Blocos.FormattingEnabled = true;
            ComboBox_Blocos.Location = new Point(35, 51);
            ComboBox_Blocos.Name = "ComboBox_Blocos";
            ComboBox_Blocos.Size = new Size(197, 33);
            ComboBox_Blocos.TabIndex = 1;
            // 
            // Lbl_Blocos
            // 
            Lbl_Blocos.AutoSize = true;
            Lbl_Blocos.Dock = DockStyle.Fill;
            Lbl_Blocos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Blocos.Location = new Point(3, 0);
            Lbl_Blocos.Name = "Lbl_Blocos";
            Lbl_Blocos.Size = new Size(262, 27);
            Lbl_Blocos.TabIndex = 0;
            Lbl_Blocos.Text = "Referência do Bloco";
            Lbl_Blocos.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.Controls.Add(label2, 1, 0);
            tableLayoutPanel5.Controls.Add(Btn_Help, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(268, 43);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 43);
            label2.TabIndex = 3;
            label2.Text = "Realloc";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Help
            // 
            Btn_Help.Anchor = AnchorStyles.None;
            Btn_Help.BackgroundImage = Properties.Resources.question;
            Btn_Help.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Help.Location = new Point(235, 9);
            Btn_Help.Name = "Btn_Help";
            Btn_Help.Size = new Size(25, 25);
            Btn_Help.TabIndex = 7;
            Btn_Help.UseVisualStyleBackColor = true;
            Btn_Help.Click += Btn_Help_Click;
            // 
            // ReallocForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 331);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReallocForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Realloc";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Input_Quantidade).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnOK;
        private Button BtnCancelar;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox ComboBox_Blocos;
        private Label Lbl_Blocos;
        private Label label1;
        private NumericUpDown Input_Quantidade;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private Button Btn_Help;
    }
}