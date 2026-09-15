namespace SimuHeap.Windows.OperacoesAlocacao
{
    partial class NewCallocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCallocForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            cardPanel2 = new SimuHeap.Controls.CustomControls.CardPanel();
            panel4 = new Panel();
            cardPanel3 = new SimuHeap.Controls.CustomControls.CardPanel();
            Lbl_PreVisualizacao = new Label();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            cardPanel1 = new SimuHeap.Controls.CustomControls.CardPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            Input_Quantidade = new NumericUpDown();
            label4 = new Label();
            ComboBox_TipoVariavel = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOK = new SimuHeap.Controls.CustomControls.RoundedButton();
            BtnCancel = new SimuHeap.Controls.CustomControls.RoundedButton();
            panel6 = new Panel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label5 = new Label();
            pictureBox8 = new PictureBox();
            Btn_Help = new SimuHeap.Controls.CustomControls.HelpButton();
            tableLayoutPanel2.SuspendLayout();
            cardPanel2.SuspendLayout();
            panel4.SuspendLayout();
            cardPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cardPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Input_Quantidade).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(cardPanel2, 0, 1);
            tableLayoutPanel2.Controls.Add(cardPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 41);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(434, 379);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // cardPanel2
            // 
            cardPanel2.BackColor = Color.White;
            cardPanel2.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel2.Controls.Add(panel4);
            cardPanel2.Controls.Add(panel3);
            cardPanel2.Controls.Add(tableLayoutPanel4);
            cardPanel2.Dock = DockStyle.Fill;
            cardPanel2.Location = new Point(5, 251);
            cardPanel2.Margin = new Padding(5);
            cardPanel2.Name = "cardPanel2";
            cardPanel2.Padding = new Padding(5);
            cardPanel2.Size = new Size(424, 123);
            cardPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(cardPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 46);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 15, 10, 15);
            panel4.Size = new Size(414, 72);
            panel4.TabIndex = 19;
            // 
            // cardPanel3
            // 
            cardPanel3.BackColor = Color.WhiteSmoke;
            cardPanel3.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel3.Controls.Add(Lbl_PreVisualizacao);
            cardPanel3.Dock = DockStyle.Fill;
            cardPanel3.Location = new Point(10, 15);
            cardPanel3.Margin = new Padding(0);
            cardPanel3.Name = "cardPanel3";
            cardPanel3.Padding = new Padding(4);
            cardPanel3.Size = new Size(394, 42);
            cardPanel3.TabIndex = 19;
            // 
            // Lbl_PreVisualizacao
            // 
            Lbl_PreVisualizacao.Dock = DockStyle.Fill;
            Lbl_PreVisualizacao.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_PreVisualizacao.Location = new Point(4, 4);
            Lbl_PreVisualizacao.Name = "Lbl_PreVisualizacao";
            Lbl_PreVisualizacao.Size = new Size(386, 34);
            Lbl_PreVisualizacao.TabIndex = 12;
            Lbl_PreVisualizacao.Text = "char *bloco = calloc(1, sizeof(char));";
            Lbl_PreVisualizacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 235, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 45);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 1);
            panel3.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(5, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(414, 40);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(53, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 40);
            label2.TabIndex = 8;
            label2.Text = "Pré-Visualização";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.code_blocks_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(10, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // cardPanel1
            // 
            cardPanel1.BackColor = Color.White;
            cardPanel1.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel1.Controls.Add(tableLayoutPanel5);
            cardPanel1.Controls.Add(panel2);
            cardPanel1.Controls.Add(tableLayoutPanel3);
            cardPanel1.Dock = DockStyle.Fill;
            cardPanel1.Location = new Point(5, 5);
            cardPanel1.Margin = new Padding(5);
            cardPanel1.Name = "cardPanel1";
            cardPanel1.Padding = new Padding(5);
            cardPanel1.Size = new Size(424, 236);
            cardPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Input_Quantidade, 1, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 1);
            tableLayoutPanel5.Controls.Add(ComboBox_TipoVariavel, 1, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(5, 46);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(414, 185);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // Input_Quantidade
            // 
            Input_Quantidade.Anchor = AnchorStyles.None;
            Input_Quantidade.Font = new Font("Segoe UI", 14.25F);
            Input_Quantidade.Location = new Point(222, 52);
            Input_Quantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Input_Quantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Input_Quantidade.Name = "Input_Quantidade";
            Input_Quantidade.Size = new Size(176, 33);
            Input_Quantidade.TabIndex = 12;
            Input_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Input_Quantidade.ValueChanged += Input_Quantidade_ValueChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Lato", 11.9999981F);
            label4.Location = new Point(3, 46);
            label4.Name = "label4";
            label4.Size = new Size(201, 46);
            label4.TabIndex = 11;
            label4.Text = "Quantidade";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboBox_TipoVariavel
            // 
            ComboBox_TipoVariavel.Anchor = AnchorStyles.None;
            ComboBox_TipoVariavel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_TipoVariavel.Font = new Font("Segoe UI", 14.25F);
            ComboBox_TipoVariavel.FormattingEnabled = true;
            ComboBox_TipoVariavel.Location = new Point(222, 6);
            ComboBox_TipoVariavel.Name = "ComboBox_TipoVariavel";
            ComboBox_TipoVariavel.Size = new Size(176, 33);
            ComboBox_TipoVariavel.TabIndex = 10;
            ComboBox_TipoVariavel.SelectedIndexChanged += ComboBox_TipoVariavel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Lato", 11.9999981F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 46);
            label3.TabIndex = 9;
            label3.Text = "Tipo de Variável";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 235, 239);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 45);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 1);
            panel2.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(5, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(414, 40);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 40);
            label1.TabIndex = 8;
            label1.Text = "Parâmetros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.settings_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 235, 239);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 420);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 1);
            panel1.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(BtnOK, 1, 0);
            tableLayoutPanel1.Controls.Add(BtnCancel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 421);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(434, 40);
            tableLayoutPanel1.TabIndex = 20;
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
            BtnOK.Location = new Point(220, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Padding = new Padding(10, 0, 10, 0);
            BtnOK.Size = new Size(211, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(247, 248, 250);
            BtnCancel.BorderColor = Color.FromArgb(222, 226, 232);
            BtnCancel.BorderSize = 1;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(3, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Padding = new Padding(10, 0, 10, 0);
            BtnCancel.Size = new Size(211, 34);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "Cancelar";
            BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancelar_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(232, 235, 239);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 40);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(434, 1);
            panel6.TabIndex = 19;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.White;
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.Controls.Add(label5, 1, 0);
            tableLayoutPanel14.Controls.Add(pictureBox8, 0, 0);
            tableLayoutPanel14.Controls.Add(Btn_Help, 2, 0);
            tableLayoutPanel14.Dock = DockStyle.Top;
            tableLayoutPanel14.Location = new Point(0, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(434, 40);
            tableLayoutPanel14.TabIndex = 18;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Lato", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 0);
            label5.Name = "label5";
            label5.Size = new Size(328, 40);
            label5.TabIndex = 8;
            label5.Text = "Calloc";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackgroundImage = Properties.Resources.assignment_add_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(10, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // Btn_Help
            // 
            Btn_Help.Anchor = AnchorStyles.None;
            Btn_Help.BackColor = Color.White;
            Btn_Help.BackgroundImage = Properties.Resources.question;
            Btn_Help.BorderColor = Color.FromArgb(222, 226, 232);
            Btn_Help.FlatAppearance.BorderSize = 0;
            Btn_Help.FlatStyle = FlatStyle.Flat;
            Btn_Help.ForeColor = Color.FromArgb(75, 85, 105);
            Btn_Help.Location = new Point(395, 6);
            Btn_Help.Name = "Btn_Help";
            Btn_Help.Size = new Size(28, 28);
            Btn_Help.TabIndex = 9;
            Btn_Help.TabStop = false;
            Btn_Help.Text = "helpButton1";
            Btn_Help.UseVisualStyleBackColor = false;
            Btn_Help.Click += Btn_Help_Click;
            // 
            // NewCallocForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            Controls.Add(tableLayoutPanel14);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 500);
            MinimumSize = new Size(450, 500);
            Name = "NewCallocForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calloc";
            Load += CallocForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            cardPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            cardPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cardPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Input_Quantidade).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Controls.CustomControls.CardPanel cardPanel2;
        private Panel panel4;
        private Controls.CustomControls.CardPanel cardPanel3;
        private Label Lbl_PreVisualizacao;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private PictureBox pictureBox2;
        private Controls.CustomControls.CardPanel cardPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private NumericUpDown Input_Quantidade;
        private Label label4;
        private ComboBox ComboBox_TipoVariavel;
        private Label label3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.RoundedButton BtnOK;
        private Controls.CustomControls.RoundedButton BtnCancel;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label5;
        private PictureBox pictureBox8;
        private Controls.CustomControls.HelpButton Btn_Help;
    }
}