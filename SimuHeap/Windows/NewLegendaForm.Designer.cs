namespace SimuHeap.Windows
{
    partial class NewLegendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLegendaForm));
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOK = new SimuHeap.Controls.CustomControls.RoundedButton();
            panel1 = new Panel();
            panel3 = new Panel();
            cardPanel1 = new SimuHeap.Controls.CustomControls.CardPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            Lbl_BlocoSendoReduzido = new Label();
            Lbl_BlocoCalloc = new Label();
            Lbl_MelhorBlocoSelecionado = new Label();
            Lbl_BlocoSendoMovido = new Label();
            Lbl_MelhorBlocoEncontrado = new Label();
            Lbl_BlocoSendoExpandido = new Label();
            Lbl_BlocoEmAnalise = new Label();
            ColorIndicator_BlocoEmAnalise = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_MelhorBlocoEncontrado = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_MelhorBlocoSelecionado = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_Coalescing = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoSendoReduzido = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoSendoExpandido = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoSendoMovido = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoCalloc = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoSendoLiberado = new SimuHeap.Controls.CustomControls.ColorIndicator();
            Lbl_BlocoSendoLiberado = new Label();
            Lbl_Coalescing = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            Lbl_BlocoOcupado = new Label();
            Lbl_BlocoLivre = new Label();
            ColorIndicator_BlocoLivre = new SimuHeap.Controls.CustomControls.ColorIndicator();
            ColorIndicator_BlocoOcupado = new SimuHeap.Controls.CustomControls.ColorIndicator();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            cardPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 235, 239);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 1);
            panel2.TabIndex = 23;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Controls.Add(pictureBox8, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(514, 40);
            tableLayoutPanel4.TabIndex = 22;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Lato", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 40);
            label1.TabIndex = 8;
            label1.Text = "Legenda de Cores";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackgroundImage = Properties.Resources.palette_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(BtnOK, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 421);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(514, 40);
            tableLayoutPanel1.TabIndex = 24;
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
            BtnOK.Location = new Point(387, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Padding = new Padding(10, 0, 10, 0);
            BtnOK.Size = new Size(124, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "Fechar";
            BtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 235, 239);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 41);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 1);
            panel1.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 235, 239);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 420);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 1);
            panel3.TabIndex = 26;
            // 
            // cardPanel1
            // 
            cardPanel1.BackColor = Color.White;
            cardPanel1.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel1.Controls.Add(tableLayoutPanel2);
            cardPanel1.Dock = DockStyle.Fill;
            cardPanel1.Location = new Point(5, 5);
            cardPanel1.Margin = new Padding(0);
            cardPanel1.Name = "cardPanel1";
            cardPanel1.Padding = new Padding(5);
            cardPanel1.Size = new Size(504, 368);
            cardPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 2);
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(494, 358);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(232, 235, 239);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(5, 110);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new Size(484, 1);
            panel7.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel7);
            panel6.Controls.Add(tableLayoutPanel5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 113);
            panel6.Name = "panel6";
            panel6.Size = new Size(488, 242);
            panel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(Lbl_BlocoSendoReduzido, 1, 4);
            tableLayoutPanel7.Controls.Add(Lbl_BlocoCalloc, 3, 2);
            tableLayoutPanel7.Controls.Add(Lbl_MelhorBlocoSelecionado, 1, 2);
            tableLayoutPanel7.Controls.Add(Lbl_BlocoSendoMovido, 3, 1);
            tableLayoutPanel7.Controls.Add(Lbl_MelhorBlocoEncontrado, 1, 1);
            tableLayoutPanel7.Controls.Add(Lbl_BlocoSendoExpandido, 3, 0);
            tableLayoutPanel7.Controls.Add(Lbl_BlocoEmAnalise, 1, 0);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoEmAnalise, 0, 0);
            tableLayoutPanel7.Controls.Add(ColorIndicator_MelhorBlocoEncontrado, 0, 1);
            tableLayoutPanel7.Controls.Add(ColorIndicator_MelhorBlocoSelecionado, 0, 2);
            tableLayoutPanel7.Controls.Add(ColorIndicator_Coalescing, 0, 3);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoSendoReduzido, 0, 4);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoSendoExpandido, 2, 0);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoSendoMovido, 2, 1);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoCalloc, 2, 2);
            tableLayoutPanel7.Controls.Add(ColorIndicator_BlocoSendoLiberado, 2, 3);
            tableLayoutPanel7.Controls.Add(Lbl_BlocoSendoLiberado, 3, 3);
            tableLayoutPanel7.Controls.Add(Lbl_Coalescing, 1, 3);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 40);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Size = new Size(488, 202);
            tableLayoutPanel7.TabIndex = 25;
            // 
            // Lbl_BlocoSendoReduzido
            // 
            Lbl_BlocoSendoReduzido.Dock = DockStyle.Fill;
            Lbl_BlocoSendoReduzido.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoSendoReduzido.Location = new Point(53, 160);
            Lbl_BlocoSendoReduzido.Name = "Lbl_BlocoSendoReduzido";
            Lbl_BlocoSendoReduzido.Size = new Size(188, 42);
            Lbl_BlocoSendoReduzido.TabIndex = 18;
            Lbl_BlocoSendoReduzido.Text = "Bloco sendo Reduzido";
            Lbl_BlocoSendoReduzido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_BlocoCalloc
            // 
            Lbl_BlocoCalloc.Dock = DockStyle.Fill;
            Lbl_BlocoCalloc.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoCalloc.Location = new Point(297, 80);
            Lbl_BlocoCalloc.Name = "Lbl_BlocoCalloc";
            Lbl_BlocoCalloc.Size = new Size(188, 40);
            Lbl_BlocoCalloc.TabIndex = 15;
            Lbl_BlocoCalloc.Text = "Bloco Inicializado pelo calloc";
            Lbl_BlocoCalloc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_MelhorBlocoSelecionado
            // 
            Lbl_MelhorBlocoSelecionado.Dock = DockStyle.Fill;
            Lbl_MelhorBlocoSelecionado.Font = new Font("Lato", 9.749999F);
            Lbl_MelhorBlocoSelecionado.Location = new Point(53, 80);
            Lbl_MelhorBlocoSelecionado.Name = "Lbl_MelhorBlocoSelecionado";
            Lbl_MelhorBlocoSelecionado.Size = new Size(188, 40);
            Lbl_MelhorBlocoSelecionado.TabIndex = 14;
            Lbl_MelhorBlocoSelecionado.Text = "Melhor Bloco Selecionado";
            Lbl_MelhorBlocoSelecionado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_BlocoSendoMovido
            // 
            Lbl_BlocoSendoMovido.Dock = DockStyle.Fill;
            Lbl_BlocoSendoMovido.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoSendoMovido.Location = new Point(297, 40);
            Lbl_BlocoSendoMovido.Name = "Lbl_BlocoSendoMovido";
            Lbl_BlocoSendoMovido.Size = new Size(188, 40);
            Lbl_BlocoSendoMovido.TabIndex = 13;
            Lbl_BlocoSendoMovido.Text = "Bloco sendo Movido";
            Lbl_BlocoSendoMovido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_MelhorBlocoEncontrado
            // 
            Lbl_MelhorBlocoEncontrado.Dock = DockStyle.Fill;
            Lbl_MelhorBlocoEncontrado.Font = new Font("Lato", 9.749999F);
            Lbl_MelhorBlocoEncontrado.Location = new Point(53, 40);
            Lbl_MelhorBlocoEncontrado.Name = "Lbl_MelhorBlocoEncontrado";
            Lbl_MelhorBlocoEncontrado.Size = new Size(188, 40);
            Lbl_MelhorBlocoEncontrado.TabIndex = 12;
            Lbl_MelhorBlocoEncontrado.Text = "Melhor Bloco Encontrado";
            Lbl_MelhorBlocoEncontrado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_BlocoSendoExpandido
            // 
            Lbl_BlocoSendoExpandido.Dock = DockStyle.Fill;
            Lbl_BlocoSendoExpandido.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoSendoExpandido.Location = new Point(297, 0);
            Lbl_BlocoSendoExpandido.Name = "Lbl_BlocoSendoExpandido";
            Lbl_BlocoSendoExpandido.Size = new Size(188, 40);
            Lbl_BlocoSendoExpandido.TabIndex = 11;
            Lbl_BlocoSendoExpandido.Text = "Bloco sendo Expandido";
            Lbl_BlocoSendoExpandido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_BlocoEmAnalise
            // 
            Lbl_BlocoEmAnalise.Dock = DockStyle.Fill;
            Lbl_BlocoEmAnalise.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoEmAnalise.Location = new Point(53, 0);
            Lbl_BlocoEmAnalise.Name = "Lbl_BlocoEmAnalise";
            Lbl_BlocoEmAnalise.Size = new Size(188, 40);
            Lbl_BlocoEmAnalise.TabIndex = 10;
            Lbl_BlocoEmAnalise.Text = "Bloco em Análise";
            Lbl_BlocoEmAnalise.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ColorIndicator_BlocoEmAnalise
            // 
            ColorIndicator_BlocoEmAnalise.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoEmAnalise.Location = new Point(9, 4);
            ColorIndicator_BlocoEmAnalise.Name = "ColorIndicator_BlocoEmAnalise";
            ColorIndicator_BlocoEmAnalise.Size = new Size(32, 32);
            ColorIndicator_BlocoEmAnalise.TabIndex = 1;
            ColorIndicator_BlocoEmAnalise.Text = "colorIndicator2";
            // 
            // ColorIndicator_MelhorBlocoEncontrado
            // 
            ColorIndicator_MelhorBlocoEncontrado.Anchor = AnchorStyles.None;
            ColorIndicator_MelhorBlocoEncontrado.Location = new Point(9, 44);
            ColorIndicator_MelhorBlocoEncontrado.Name = "ColorIndicator_MelhorBlocoEncontrado";
            ColorIndicator_MelhorBlocoEncontrado.Size = new Size(32, 32);
            ColorIndicator_MelhorBlocoEncontrado.TabIndex = 2;
            ColorIndicator_MelhorBlocoEncontrado.Text = "colorIndicator3";
            // 
            // ColorIndicator_MelhorBlocoSelecionado
            // 
            ColorIndicator_MelhorBlocoSelecionado.Anchor = AnchorStyles.None;
            ColorIndicator_MelhorBlocoSelecionado.Location = new Point(9, 84);
            ColorIndicator_MelhorBlocoSelecionado.Name = "ColorIndicator_MelhorBlocoSelecionado";
            ColorIndicator_MelhorBlocoSelecionado.Size = new Size(32, 32);
            ColorIndicator_MelhorBlocoSelecionado.TabIndex = 3;
            ColorIndicator_MelhorBlocoSelecionado.Text = "colorIndicator4";
            // 
            // ColorIndicator_Coalescing
            // 
            ColorIndicator_Coalescing.Anchor = AnchorStyles.None;
            ColorIndicator_Coalescing.Location = new Point(9, 124);
            ColorIndicator_Coalescing.Name = "ColorIndicator_Coalescing";
            ColorIndicator_Coalescing.Size = new Size(32, 32);
            ColorIndicator_Coalescing.TabIndex = 4;
            ColorIndicator_Coalescing.Text = "colorIndicator5";
            // 
            // ColorIndicator_BlocoSendoReduzido
            // 
            ColorIndicator_BlocoSendoReduzido.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoSendoReduzido.Location = new Point(9, 165);
            ColorIndicator_BlocoSendoReduzido.Name = "ColorIndicator_BlocoSendoReduzido";
            ColorIndicator_BlocoSendoReduzido.Size = new Size(32, 32);
            ColorIndicator_BlocoSendoReduzido.TabIndex = 5;
            ColorIndicator_BlocoSendoReduzido.Text = "colorIndicator6";
            // 
            // ColorIndicator_BlocoSendoExpandido
            // 
            ColorIndicator_BlocoSendoExpandido.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoSendoExpandido.Location = new Point(253, 4);
            ColorIndicator_BlocoSendoExpandido.Name = "ColorIndicator_BlocoSendoExpandido";
            ColorIndicator_BlocoSendoExpandido.Size = new Size(32, 32);
            ColorIndicator_BlocoSendoExpandido.TabIndex = 6;
            ColorIndicator_BlocoSendoExpandido.Text = "colorIndicator8";
            // 
            // ColorIndicator_BlocoSendoMovido
            // 
            ColorIndicator_BlocoSendoMovido.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoSendoMovido.Location = new Point(253, 44);
            ColorIndicator_BlocoSendoMovido.Name = "ColorIndicator_BlocoSendoMovido";
            ColorIndicator_BlocoSendoMovido.Size = new Size(32, 32);
            ColorIndicator_BlocoSendoMovido.TabIndex = 7;
            ColorIndicator_BlocoSendoMovido.Text = "colorIndicator9";
            // 
            // ColorIndicator_BlocoCalloc
            // 
            ColorIndicator_BlocoCalloc.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoCalloc.Location = new Point(253, 84);
            ColorIndicator_BlocoCalloc.Name = "ColorIndicator_BlocoCalloc";
            ColorIndicator_BlocoCalloc.Size = new Size(32, 32);
            ColorIndicator_BlocoCalloc.TabIndex = 8;
            ColorIndicator_BlocoCalloc.Text = "colorIndicator10";
            // 
            // ColorIndicator_BlocoSendoLiberado
            // 
            ColorIndicator_BlocoSendoLiberado.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoSendoLiberado.Location = new Point(253, 124);
            ColorIndicator_BlocoSendoLiberado.Name = "ColorIndicator_BlocoSendoLiberado";
            ColorIndicator_BlocoSendoLiberado.Size = new Size(32, 32);
            ColorIndicator_BlocoSendoLiberado.TabIndex = 9;
            ColorIndicator_BlocoSendoLiberado.Text = "colorIndicator11";
            // 
            // Lbl_BlocoSendoLiberado
            // 
            Lbl_BlocoSendoLiberado.Dock = DockStyle.Fill;
            Lbl_BlocoSendoLiberado.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoSendoLiberado.Location = new Point(297, 120);
            Lbl_BlocoSendoLiberado.Name = "Lbl_BlocoSendoLiberado";
            Lbl_BlocoSendoLiberado.Size = new Size(188, 40);
            Lbl_BlocoSendoLiberado.TabIndex = 16;
            Lbl_BlocoSendoLiberado.Text = "Bloco sendo Liberado";
            Lbl_BlocoSendoLiberado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Coalescing
            // 
            Lbl_Coalescing.Dock = DockStyle.Fill;
            Lbl_Coalescing.Font = new Font("Lato", 9.749999F);
            Lbl_Coalescing.Location = new Point(53, 120);
            Lbl_Coalescing.Name = "Lbl_Coalescing";
            Lbl_Coalescing.Size = new Size(188, 40);
            Lbl_Coalescing.TabIndex = 19;
            Lbl_Coalescing.Text = "Bloco Envolvido no Coalescing";
            Lbl_Coalescing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.White;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.Controls.Add(label3, 1, 0);
            tableLayoutPanel5.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(488, 40);
            tableLayoutPanel5.TabIndex = 23;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(53, 0);
            label3.Name = "label3";
            label3.Size = new Size(382, 40);
            label3.TabIndex = 8;
            label3.Text = "Estados durante a Simulação";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.modeling_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(10, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel6);
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 99);
            panel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(Lbl_BlocoOcupado, 3, 0);
            tableLayoutPanel6.Controls.Add(Lbl_BlocoLivre, 1, 0);
            tableLayoutPanel6.Controls.Add(ColorIndicator_BlocoLivre, 0, 0);
            tableLayoutPanel6.Controls.Add(ColorIndicator_BlocoOcupado, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 40);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(488, 59);
            tableLayoutPanel6.TabIndex = 24;
            // 
            // Lbl_BlocoOcupado
            // 
            Lbl_BlocoOcupado.Dock = DockStyle.Fill;
            Lbl_BlocoOcupado.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoOcupado.Location = new Point(297, 0);
            Lbl_BlocoOcupado.Name = "Lbl_BlocoOcupado";
            Lbl_BlocoOcupado.Size = new Size(188, 59);
            Lbl_BlocoOcupado.TabIndex = 10;
            Lbl_BlocoOcupado.Text = "Bloco Ocupado";
            Lbl_BlocoOcupado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_BlocoLivre
            // 
            Lbl_BlocoLivre.Dock = DockStyle.Fill;
            Lbl_BlocoLivre.Font = new Font("Lato", 9.749999F);
            Lbl_BlocoLivre.Location = new Point(53, 0);
            Lbl_BlocoLivre.Name = "Lbl_BlocoLivre";
            Lbl_BlocoLivre.Size = new Size(188, 59);
            Lbl_BlocoLivre.TabIndex = 9;
            Lbl_BlocoLivre.Text = "Bloco Livre";
            Lbl_BlocoLivre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ColorIndicator_BlocoLivre
            // 
            ColorIndicator_BlocoLivre.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoLivre.Location = new Point(9, 13);
            ColorIndicator_BlocoLivre.Name = "ColorIndicator_BlocoLivre";
            ColorIndicator_BlocoLivre.Size = new Size(32, 32);
            ColorIndicator_BlocoLivre.TabIndex = 0;
            ColorIndicator_BlocoLivre.Text = "colorIndicator1";
            // 
            // ColorIndicator_BlocoOcupado
            // 
            ColorIndicator_BlocoOcupado.Anchor = AnchorStyles.None;
            ColorIndicator_BlocoOcupado.Location = new Point(253, 13);
            ColorIndicator_BlocoOcupado.Name = "ColorIndicator_BlocoOcupado";
            ColorIndicator_BlocoOcupado.Size = new Size(32, 32);
            ColorIndicator_BlocoOcupado.TabIndex = 1;
            ColorIndicator_BlocoOcupado.Text = "colorIndicator7";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(488, 40);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Lato Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(53, 0);
            label2.Name = "label2";
            label2.Size = new Size(382, 40);
            label2.TabIndex = 8;
            label2.Text = "Estados da Memória";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.memory_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(cardPanel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 42);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(514, 378);
            panel4.TabIndex = 28;
            // 
            // NewLegendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(514, 461);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(530, 500);
            MinimumSize = new Size(530, 500);
            Name = "NewLegendaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Legenda de Cores";
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            cardPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private PictureBox pictureBox8;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.RoundedButton BtnOK;
        private Panel panel1;
        private Panel panel3;
        private Controls.CustomControls.CardPanel cardPanel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoEmAnalise;
        private Controls.CustomControls.ColorIndicator ColorIndicator_MelhorBlocoEncontrado;
        private Controls.CustomControls.ColorIndicator ColorIndicator_MelhorBlocoSelecionado;
        private Controls.CustomControls.ColorIndicator ColorIndicator_Coalescing;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoSendoReduzido;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoSendoExpandido;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoSendoMovido;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoCalloc;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoSendoLiberado;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoLivre;
        private Controls.CustomControls.ColorIndicator ColorIndicator_BlocoOcupado;
        private Label Lbl_BlocoSendoReduzido;
        private Label Lbl_BlocoSendoLiberado;
        private Label Lbl_BlocoCalloc;
        private Label Lbl_MelhorBlocoSelecionado;
        private Label Lbl_BlocoSendoMovido;
        private Label Lbl_MelhorBlocoEncontrado;
        private Label Lbl_BlocoSendoExpandido;
        private Label Lbl_BlocoEmAnalise;
        private Label Lbl_BlocoOcupado;
        private Label Lbl_BlocoLivre;
        private Label Lbl_Coalescing;
        private Panel panel7;
    }
}