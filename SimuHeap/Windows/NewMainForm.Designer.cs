namespace SimuHeap.Windows
{
    partial class NewMainForm
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
            Tabs_Principal = new TabControl();
            tab_simulacao = new TabPage();
            Panel_Simulacao = new TableLayoutPanel();
            Panel_Simulacao_Estruturas = new Panel();
            Panel_Simulacao_2 = new TableLayoutPanel();
            Panel_Segmentos = new Panel();
            PanelGridHeap = new Panel();
            Panel_Simulacao_Nav = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnPrimeiro = new Button();
            BtnUltimo = new Button();
            BtnAnterior = new Button();
            BtnProximo = new Button();
            Lbl_PassoAtual = new Label();
            Label_Segmentos = new Label();
            Panel_ListaBlocosLivres = new Panel();
            panel4 = new Panel();
            DataGridViewBlocosLivres = new DataGridView();
            label1 = new Label();
            Label_Heap = new Label();
            Panel_Eventos = new Panel();
            panel6 = new Panel();
            DataGridViewEventos = new DataGridView();
            Panel_OpcoesEventos = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            Btn_ExcluirEvento = new Button();
            Btn_DescerEvento = new Button();
            Btn_SubirEvento = new Button();
            tableLayoutPanel15 = new TableLayoutPanel();
            Lbl_SnapshotAtual = new Label();
            tableLayoutPanel16 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_Malloc = new Button();
            Btn_Calloc = new Button();
            Btn_Realloc = new Button();
            Btn_Free = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Btn_IniciarSimulacao = new Button();
            Btn_PararSimulacao = new Button();
            Btn_ZerarSimulacao = new Button();
            Btn_LegendaCores = new Button();
            tab_metricas = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            Lbl_Metadados = new Label();
            groupBox3 = new GroupBox();
            LblBlocosInutilizaveis = new Label();
            Lbl_PercentualInutilizavel = new Label();
            Lbl_MemInutilizavel = new Label();
            Lbl_Padding = new Label();
            groupBox2 = new GroupBox();
            Lbl_MaiorBlocoLivre = new Label();
            Lbl_FragExterna = new Label();
            Lbl_FragInterna = new Label();
            Lbl_BytesFragInterna = new Label();
            groupBox1 = new GroupBox();
            Lbl_UsoHeap = new Label();
            Lbl_BytesLivres = new Label();
            Lbl_BytesOcupados = new Label();
            tab_config = new TabPage();
            MenuParametros = new GroupBox();
            Label_AlgoritmosAlocacao = new Label();
            Btn_HelpAlgoritmosAlocacao = new Button();
            Btn_HelpSplit = new Button();
            HabilitarSplit = new CheckBox();
            UseFirstFit = new RadioButton();
            HabilitarCoalesing = new CheckBox();
            SelectHeapSize = new ComboBox();
            Btn_HepCoalescing = new Button();
            UseBestFit = new RadioButton();
            Label_TamanhoHeap = new Label();
            UseWorstFit = new RadioButton();
            Btn_HelpTamHeap = new Button();
            Tabs_Principal.SuspendLayout();
            tab_simulacao.SuspendLayout();
            Panel_Simulacao.SuspendLayout();
            Panel_Simulacao_Estruturas.SuspendLayout();
            Panel_Simulacao_2.SuspendLayout();
            Panel_Segmentos.SuspendLayout();
            Panel_Simulacao_Nav.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            Panel_ListaBlocosLivres.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBlocosLivres).BeginInit();
            Panel_Eventos.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEventos).BeginInit();
            Panel_OpcoesEventos.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tab_metricas.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tab_config.SuspendLayout();
            MenuParametros.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs_Principal
            // 
            Tabs_Principal.Controls.Add(tab_simulacao);
            Tabs_Principal.Controls.Add(tab_metricas);
            Tabs_Principal.Controls.Add(tab_config);
            Tabs_Principal.Dock = DockStyle.Fill;
            Tabs_Principal.Location = new Point(0, 0);
            Tabs_Principal.Margin = new Padding(4);
            Tabs_Principal.Name = "Tabs_Principal";
            Tabs_Principal.SelectedIndex = 0;
            Tabs_Principal.Size = new Size(1264, 681);
            Tabs_Principal.TabIndex = 0;
            // 
            // tab_simulacao
            // 
            tab_simulacao.Controls.Add(Panel_Simulacao);
            tab_simulacao.Controls.Add(tableLayoutPanel15);
            tab_simulacao.Location = new Point(4, 30);
            tab_simulacao.Margin = new Padding(4);
            tab_simulacao.Name = "tab_simulacao";
            tab_simulacao.Padding = new Padding(4);
            tab_simulacao.Size = new Size(1256, 647);
            tab_simulacao.TabIndex = 0;
            tab_simulacao.Text = "Simulação";
            tab_simulacao.UseVisualStyleBackColor = true;
            // 
            // Panel_Simulacao
            // 
            Panel_Simulacao.ColumnCount = 2;
            Panel_Simulacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            Panel_Simulacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Panel_Simulacao.Controls.Add(Panel_Simulacao_Estruturas, 0, 0);
            Panel_Simulacao.Controls.Add(Panel_Eventos, 1, 0);
            Panel_Simulacao.Dock = DockStyle.Fill;
            Panel_Simulacao.Location = new Point(4, 104);
            Panel_Simulacao.Name = "Panel_Simulacao";
            Panel_Simulacao.RowCount = 1;
            Panel_Simulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel_Simulacao.Size = new Size(1248, 539);
            Panel_Simulacao.TabIndex = 3;
            // 
            // Panel_Simulacao_Estruturas
            // 
            Panel_Simulacao_Estruturas.Controls.Add(Panel_Simulacao_2);
            Panel_Simulacao_Estruturas.Controls.Add(Label_Heap);
            Panel_Simulacao_Estruturas.Dock = DockStyle.Fill;
            Panel_Simulacao_Estruturas.Location = new Point(3, 3);
            Panel_Simulacao_Estruturas.Name = "Panel_Simulacao_Estruturas";
            Panel_Simulacao_Estruturas.Size = new Size(805, 533);
            Panel_Simulacao_Estruturas.TabIndex = 0;
            // 
            // Panel_Simulacao_2
            // 
            Panel_Simulacao_2.ColumnCount = 2;
            Panel_Simulacao_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            Panel_Simulacao_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            Panel_Simulacao_2.Controls.Add(Panel_Segmentos, 1, 0);
            Panel_Simulacao_2.Controls.Add(Panel_ListaBlocosLivres, 0, 0);
            Panel_Simulacao_2.Dock = DockStyle.Fill;
            Panel_Simulacao_2.Location = new Point(0, 35);
            Panel_Simulacao_2.Name = "Panel_Simulacao_2";
            Panel_Simulacao_2.RowCount = 1;
            Panel_Simulacao_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel_Simulacao_2.Size = new Size(805, 498);
            Panel_Simulacao_2.TabIndex = 1;
            // 
            // Panel_Segmentos
            // 
            Panel_Segmentos.Controls.Add(PanelGridHeap);
            Panel_Segmentos.Controls.Add(Panel_Simulacao_Nav);
            Panel_Segmentos.Controls.Add(Label_Segmentos);
            Panel_Segmentos.Dock = DockStyle.Fill;
            Panel_Segmentos.Location = new Point(244, 3);
            Panel_Segmentos.Name = "Panel_Segmentos";
            Panel_Segmentos.Size = new Size(558, 492);
            Panel_Segmentos.TabIndex = 0;
            // 
            // PanelGridHeap
            // 
            PanelGridHeap.AutoScroll = true;
            PanelGridHeap.Dock = DockStyle.Fill;
            PanelGridHeap.Location = new Point(0, 23);
            PanelGridHeap.Name = "PanelGridHeap";
            PanelGridHeap.Size = new Size(558, 428);
            PanelGridHeap.TabIndex = 0;
            // 
            // Panel_Simulacao_Nav
            // 
            Panel_Simulacao_Nav.BackColor = SystemColors.ActiveBorder;
            Panel_Simulacao_Nav.Controls.Add(tableLayoutPanel4);
            Panel_Simulacao_Nav.Dock = DockStyle.Bottom;
            Panel_Simulacao_Nav.Location = new Point(0, 451);
            Panel_Simulacao_Nav.Name = "Panel_Simulacao_Nav";
            Panel_Simulacao_Nav.Size = new Size(558, 41);
            Panel_Simulacao_Nav.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Controls.Add(BtnPrimeiro, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnUltimo, 4, 0);
            tableLayoutPanel4.Controls.Add(BtnAnterior, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnProximo, 3, 0);
            tableLayoutPanel4.Controls.Add(Lbl_PassoAtual, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(558, 41);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // BtnPrimeiro
            // 
            BtnPrimeiro.BackgroundImage = Properties.Resources.primeiro;
            BtnPrimeiro.BackgroundImageLayout = ImageLayout.Center;
            BtnPrimeiro.Dock = DockStyle.Fill;
            BtnPrimeiro.FlatAppearance.BorderSize = 0;
            BtnPrimeiro.FlatStyle = FlatStyle.Flat;
            BtnPrimeiro.Location = new Point(3, 3);
            BtnPrimeiro.Name = "BtnPrimeiro";
            BtnPrimeiro.Size = new Size(87, 35);
            BtnPrimeiro.TabIndex = 3;
            BtnPrimeiro.UseVisualStyleBackColor = true;
            BtnPrimeiro.Click += BtnPrimeiro_Click;
            // 
            // BtnUltimo
            // 
            BtnUltimo.BackgroundImage = Properties.Resources.ultimo;
            BtnUltimo.BackgroundImageLayout = ImageLayout.Center;
            BtnUltimo.Dock = DockStyle.Fill;
            BtnUltimo.FlatAppearance.BorderSize = 0;
            BtnUltimo.FlatStyle = FlatStyle.Flat;
            BtnUltimo.Location = new Point(468, 3);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(87, 35);
            BtnUltimo.TabIndex = 2;
            BtnUltimo.UseVisualStyleBackColor = true;
            BtnUltimo.Click += BtnUltimo_Click;
            // 
            // BtnAnterior
            // 
            BtnAnterior.BackgroundImage = Properties.Resources.anterior;
            BtnAnterior.BackgroundImageLayout = ImageLayout.Center;
            BtnAnterior.Dock = DockStyle.Fill;
            BtnAnterior.FlatAppearance.BorderSize = 0;
            BtnAnterior.FlatStyle = FlatStyle.Flat;
            BtnAnterior.Location = new Point(96, 3);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(87, 35);
            BtnAnterior.TabIndex = 1;
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnProximo
            // 
            BtnProximo.BackgroundImage = Properties.Resources.proximo;
            BtnProximo.BackgroundImageLayout = ImageLayout.Center;
            BtnProximo.Dock = DockStyle.Fill;
            BtnProximo.FlatAppearance.BorderSize = 0;
            BtnProximo.FlatStyle = FlatStyle.Flat;
            BtnProximo.Location = new Point(375, 3);
            BtnProximo.Name = "BtnProximo";
            BtnProximo.Size = new Size(87, 35);
            BtnProximo.TabIndex = 0;
            BtnProximo.UseVisualStyleBackColor = true;
            BtnProximo.Click += BtnProximo_Click;
            // 
            // Lbl_PassoAtual
            // 
            Lbl_PassoAtual.AutoSize = true;
            Lbl_PassoAtual.Dock = DockStyle.Fill;
            Lbl_PassoAtual.Location = new Point(189, 0);
            Lbl_PassoAtual.Name = "Lbl_PassoAtual";
            Lbl_PassoAtual.Size = new Size(180, 41);
            Lbl_PassoAtual.TabIndex = 4;
            Lbl_PassoAtual.Text = "Passo Atual:";
            Lbl_PassoAtual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Segmentos
            // 
            Label_Segmentos.Dock = DockStyle.Top;
            Label_Segmentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Segmentos.Location = new Point(0, 0);
            Label_Segmentos.Name = "Label_Segmentos";
            Label_Segmentos.Size = new Size(558, 23);
            Label_Segmentos.TabIndex = 1;
            Label_Segmentos.Text = "Segmentos (Blocos)";
            Label_Segmentos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_ListaBlocosLivres
            // 
            Panel_ListaBlocosLivres.Controls.Add(panel4);
            Panel_ListaBlocosLivres.Controls.Add(label1);
            Panel_ListaBlocosLivres.Dock = DockStyle.Fill;
            Panel_ListaBlocosLivres.Location = new Point(3, 3);
            Panel_ListaBlocosLivres.Name = "Panel_ListaBlocosLivres";
            Panel_ListaBlocosLivres.Size = new Size(235, 492);
            Panel_ListaBlocosLivres.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(DataGridViewBlocosLivres);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 469);
            panel4.TabIndex = 4;
            // 
            // DataGridViewBlocosLivres
            // 
            DataGridViewBlocosLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBlocosLivres.Dock = DockStyle.Fill;
            DataGridViewBlocosLivres.Location = new Point(0, 0);
            DataGridViewBlocosLivres.Name = "DataGridViewBlocosLivres";
            DataGridViewBlocosLivres.RowHeadersWidth = 51;
            DataGridViewBlocosLivres.Size = new Size(235, 469);
            DataGridViewBlocosLivres.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 23);
            label1.TabIndex = 2;
            label1.Text = "Lista de Blocos Livres";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Heap
            // 
            Label_Heap.Dock = DockStyle.Top;
            Label_Heap.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Heap.Location = new Point(0, 0);
            Label_Heap.Name = "Label_Heap";
            Label_Heap.Size = new Size(805, 35);
            Label_Heap.TabIndex = 0;
            Label_Heap.Text = "HEAP";
            Label_Heap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Eventos
            // 
            Panel_Eventos.Controls.Add(panel6);
            Panel_Eventos.Controls.Add(Panel_OpcoesEventos);
            Panel_Eventos.Dock = DockStyle.Fill;
            Panel_Eventos.Location = new Point(814, 3);
            Panel_Eventos.Name = "Panel_Eventos";
            Panel_Eventos.Size = new Size(431, 533);
            Panel_Eventos.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(DataGridViewEventos);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 489);
            panel6.TabIndex = 5;
            // 
            // DataGridViewEventos
            // 
            DataGridViewEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEventos.Dock = DockStyle.Fill;
            DataGridViewEventos.Location = new Point(0, 0);
            DataGridViewEventos.Name = "DataGridViewEventos";
            DataGridViewEventos.RowHeadersWidth = 51;
            DataGridViewEventos.Size = new Size(431, 489);
            DataGridViewEventos.TabIndex = 2;
            // 
            // Panel_OpcoesEventos
            // 
            Panel_OpcoesEventos.Controls.Add(tableLayoutPanel5);
            Panel_OpcoesEventos.Dock = DockStyle.Bottom;
            Panel_OpcoesEventos.Location = new Point(0, 489);
            Panel_OpcoesEventos.Name = "Panel_OpcoesEventos";
            Panel_OpcoesEventos.Size = new Size(431, 44);
            Panel_OpcoesEventos.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(Btn_ExcluirEvento, 2, 0);
            tableLayoutPanel5.Controls.Add(Btn_DescerEvento, 1, 0);
            tableLayoutPanel5.Controls.Add(Btn_SubirEvento, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Left;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(200, 44);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // Btn_ExcluirEvento
            // 
            Btn_ExcluirEvento.BackgroundImage = Properties.Resources.trash;
            Btn_ExcluirEvento.BackgroundImageLayout = ImageLayout.Center;
            Btn_ExcluirEvento.Dock = DockStyle.Fill;
            Btn_ExcluirEvento.FlatAppearance.BorderSize = 0;
            Btn_ExcluirEvento.FlatStyle = FlatStyle.Flat;
            Btn_ExcluirEvento.Location = new Point(135, 3);
            Btn_ExcluirEvento.Name = "Btn_ExcluirEvento";
            Btn_ExcluirEvento.Size = new Size(62, 38);
            Btn_ExcluirEvento.TabIndex = 5;
            Btn_ExcluirEvento.UseVisualStyleBackColor = true;
            Btn_ExcluirEvento.Click += Btn_ExcluirEvento_Click;
            // 
            // Btn_DescerEvento
            // 
            Btn_DescerEvento.BackgroundImage = Properties.Resources.arrow_down;
            Btn_DescerEvento.BackgroundImageLayout = ImageLayout.Center;
            Btn_DescerEvento.Dock = DockStyle.Fill;
            Btn_DescerEvento.FlatAppearance.BorderSize = 0;
            Btn_DescerEvento.FlatStyle = FlatStyle.Flat;
            Btn_DescerEvento.Location = new Point(69, 3);
            Btn_DescerEvento.Name = "Btn_DescerEvento";
            Btn_DescerEvento.Size = new Size(60, 38);
            Btn_DescerEvento.TabIndex = 4;
            Btn_DescerEvento.UseVisualStyleBackColor = true;
            Btn_DescerEvento.Click += Btn_DescerEvento_Click;
            // 
            // Btn_SubirEvento
            // 
            Btn_SubirEvento.BackgroundImage = Properties.Resources.arrow_up;
            Btn_SubirEvento.BackgroundImageLayout = ImageLayout.Center;
            Btn_SubirEvento.Dock = DockStyle.Fill;
            Btn_SubirEvento.FlatAppearance.BorderSize = 0;
            Btn_SubirEvento.FlatStyle = FlatStyle.Flat;
            Btn_SubirEvento.Location = new Point(3, 3);
            Btn_SubirEvento.Name = "Btn_SubirEvento";
            Btn_SubirEvento.Size = new Size(60, 38);
            Btn_SubirEvento.TabIndex = 3;
            Btn_SubirEvento.UseVisualStyleBackColor = true;
            Btn_SubirEvento.Click += Btn_SubirEvento_Click;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel15.Controls.Add(Lbl_SnapshotAtual, 1, 0);
            tableLayoutPanel15.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Top;
            tableLayoutPanel15.Location = new Point(4, 4);
            tableLayoutPanel15.MinimumSize = new Size(0, 100);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(1248, 100);
            tableLayoutPanel15.TabIndex = 1;
            // 
            // Lbl_SnapshotAtual
            // 
            Lbl_SnapshotAtual.Dock = DockStyle.Fill;
            Lbl_SnapshotAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_SnapshotAtual.Location = new Point(751, 0);
            Lbl_SnapshotAtual.Name = "Lbl_SnapshotAtual";
            Lbl_SnapshotAtual.Size = new Size(494, 100);
            Lbl_SnapshotAtual.TabIndex = 7;
            Lbl_SnapshotAtual.Text = "Estado Atual";
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel16.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Size = new Size(742, 94);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_Malloc);
            flowLayoutPanel1.Controls.Add(Btn_Calloc);
            flowLayoutPanel1.Controls.Add(Btn_Realloc);
            flowLayoutPanel1.Controls.Add(Btn_Free);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(736, 41);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Malloc
            // 
            Btn_Malloc.BackColor = SystemColors.MenuHighlight;
            Btn_Malloc.FlatStyle = FlatStyle.Flat;
            Btn_Malloc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Malloc.ForeColor = SystemColors.ControlLightLight;
            Btn_Malloc.Location = new Point(3, 3);
            Btn_Malloc.Name = "Btn_Malloc";
            Btn_Malloc.Size = new Size(170, 35);
            Btn_Malloc.TabIndex = 1;
            Btn_Malloc.Text = "malloc";
            Btn_Malloc.UseVisualStyleBackColor = false;
            Btn_Malloc.Click += Btn_Malloc_Click;
            // 
            // Btn_Calloc
            // 
            Btn_Calloc.BackColor = SystemColors.MenuHighlight;
            Btn_Calloc.Dock = DockStyle.Fill;
            Btn_Calloc.FlatStyle = FlatStyle.Flat;
            Btn_Calloc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Calloc.ForeColor = SystemColors.ControlLightLight;
            Btn_Calloc.Location = new Point(179, 3);
            Btn_Calloc.Name = "Btn_Calloc";
            Btn_Calloc.Size = new Size(170, 35);
            Btn_Calloc.TabIndex = 2;
            Btn_Calloc.Text = "calloc";
            Btn_Calloc.UseVisualStyleBackColor = false;
            Btn_Calloc.Click += Btn_Calloc_Click;
            // 
            // Btn_Realloc
            // 
            Btn_Realloc.BackColor = SystemColors.MenuHighlight;
            Btn_Realloc.Dock = DockStyle.Fill;
            Btn_Realloc.FlatStyle = FlatStyle.Flat;
            Btn_Realloc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Realloc.ForeColor = SystemColors.ControlLightLight;
            Btn_Realloc.Location = new Point(355, 3);
            Btn_Realloc.Name = "Btn_Realloc";
            Btn_Realloc.Size = new Size(170, 35);
            Btn_Realloc.TabIndex = 3;
            Btn_Realloc.Text = "realloc";
            Btn_Realloc.UseVisualStyleBackColor = false;
            Btn_Realloc.Click += Btn_Realloc_Click;
            // 
            // Btn_Free
            // 
            Btn_Free.BackColor = Color.OliveDrab;
            Btn_Free.Dock = DockStyle.Fill;
            Btn_Free.FlatStyle = FlatStyle.Flat;
            Btn_Free.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Free.ForeColor = SystemColors.ControlLightLight;
            Btn_Free.Location = new Point(531, 3);
            Btn_Free.Name = "Btn_Free";
            Btn_Free.Size = new Size(170, 35);
            Btn_Free.TabIndex = 4;
            Btn_Free.Text = "free";
            Btn_Free.UseVisualStyleBackColor = false;
            Btn_Free.Click += Btn_Free_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(Btn_IniciarSimulacao);
            flowLayoutPanel2.Controls.Add(Btn_PararSimulacao);
            flowLayoutPanel2.Controls.Add(Btn_ZerarSimulacao);
            flowLayoutPanel2.Controls.Add(Btn_LegendaCores);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(736, 41);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // Btn_IniciarSimulacao
            // 
            Btn_IniciarSimulacao.BackColor = Color.ForestGreen;
            Btn_IniciarSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_IniciarSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_IniciarSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_IniciarSimulacao.Location = new Point(3, 3);
            Btn_IniciarSimulacao.Name = "Btn_IniciarSimulacao";
            Btn_IniciarSimulacao.Size = new Size(170, 35);
            Btn_IniciarSimulacao.TabIndex = 2;
            Btn_IniciarSimulacao.Text = "Iniciar Simulação";
            Btn_IniciarSimulacao.UseVisualStyleBackColor = false;
            Btn_IniciarSimulacao.Click += Btn_IniciarSimulacao_Click;
            // 
            // Btn_PararSimulacao
            // 
            Btn_PararSimulacao.BackColor = Color.IndianRed;
            Btn_PararSimulacao.Dock = DockStyle.Fill;
            Btn_PararSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_PararSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_PararSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_PararSimulacao.Location = new Point(179, 3);
            Btn_PararSimulacao.Name = "Btn_PararSimulacao";
            Btn_PararSimulacao.Size = new Size(170, 35);
            Btn_PararSimulacao.TabIndex = 3;
            Btn_PararSimulacao.Text = "Parar Simulação";
            Btn_PararSimulacao.UseVisualStyleBackColor = false;
            Btn_PararSimulacao.Click += Btn_PararSimulacao_Click;
            // 
            // Btn_ZerarSimulacao
            // 
            Btn_ZerarSimulacao.BackColor = Color.Gray;
            Btn_ZerarSimulacao.Dock = DockStyle.Fill;
            Btn_ZerarSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_ZerarSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_ZerarSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_ZerarSimulacao.Location = new Point(355, 3);
            Btn_ZerarSimulacao.Name = "Btn_ZerarSimulacao";
            Btn_ZerarSimulacao.Size = new Size(170, 35);
            Btn_ZerarSimulacao.TabIndex = 4;
            Btn_ZerarSimulacao.Text = "Zerar Simulação";
            Btn_ZerarSimulacao.UseVisualStyleBackColor = false;
            Btn_ZerarSimulacao.Click += Btn_ZerarSimulacao_Click;
            // 
            // Btn_LegendaCores
            // 
            Btn_LegendaCores.BackColor = Color.DimGray;
            Btn_LegendaCores.Dock = DockStyle.Fill;
            Btn_LegendaCores.FlatStyle = FlatStyle.Flat;
            Btn_LegendaCores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_LegendaCores.ForeColor = SystemColors.ControlLightLight;
            Btn_LegendaCores.Location = new Point(531, 3);
            Btn_LegendaCores.Name = "Btn_LegendaCores";
            Btn_LegendaCores.Size = new Size(170, 35);
            Btn_LegendaCores.TabIndex = 5;
            Btn_LegendaCores.Text = "Legenda de Cores";
            Btn_LegendaCores.UseVisualStyleBackColor = false;
            Btn_LegendaCores.Click += Btn_LegendaCores_Click;
            // 
            // tab_metricas
            // 
            tab_metricas.Controls.Add(tableLayoutPanel1);
            tab_metricas.Location = new Point(4, 24);
            tab_metricas.Margin = new Padding(4);
            tab_metricas.Name = "tab_metricas";
            tab_metricas.Padding = new Padding(4);
            tab_metricas.Size = new Size(1256, 653);
            tab_metricas.TabIndex = 1;
            tab_metricas.Text = "Métricas";
            tab_metricas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 645);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Lbl_Metadados);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(4, 487);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(376, 154);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Metadados";
            // 
            // Lbl_Metadados
            // 
            Lbl_Metadados.AutoSize = true;
            Lbl_Metadados.Dock = DockStyle.Top;
            Lbl_Metadados.Location = new Point(4, 26);
            Lbl_Metadados.Margin = new Padding(4, 0, 4, 0);
            Lbl_Metadados.Name = "Lbl_Metadados";
            Lbl_Metadados.Size = new Size(123, 21);
            Lbl_Metadados.TabIndex = 8;
            Lbl_Metadados.Text = "Total Metadados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LblBlocosInutilizaveis);
            groupBox3.Controls.Add(Lbl_PercentualInutilizavel);
            groupBox3.Controls.Add(Lbl_MemInutilizavel);
            groupBox3.Controls.Add(Lbl_Padding);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(4, 326);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(376, 153);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Desperdício de memória";
            // 
            // LblBlocosInutilizaveis
            // 
            LblBlocosInutilizaveis.AutoSize = true;
            LblBlocosInutilizaveis.Dock = DockStyle.Top;
            LblBlocosInutilizaveis.Location = new Point(4, 89);
            LblBlocosInutilizaveis.Margin = new Padding(4, 0, 4, 0);
            LblBlocosInutilizaveis.Name = "LblBlocosInutilizaveis";
            LblBlocosInutilizaveis.Size = new Size(133, 21);
            LblBlocosInutilizaveis.TabIndex = 7;
            LblBlocosInutilizaveis.Text = "Bloco Inutilizaveis";
            // 
            // Lbl_PercentualInutilizavel
            // 
            Lbl_PercentualInutilizavel.AutoSize = true;
            Lbl_PercentualInutilizavel.Dock = DockStyle.Top;
            Lbl_PercentualInutilizavel.Location = new Point(4, 68);
            Lbl_PercentualInutilizavel.Margin = new Padding(4, 0, 4, 0);
            Lbl_PercentualInutilizavel.Name = "Lbl_PercentualInutilizavel";
            Lbl_PercentualInutilizavel.Size = new Size(160, 21);
            Lbl_PercentualInutilizavel.TabIndex = 6;
            Lbl_PercentualInutilizavel.Text = "Percentual Inutilizavel";
            // 
            // Lbl_MemInutilizavel
            // 
            Lbl_MemInutilizavel.AutoSize = true;
            Lbl_MemInutilizavel.Dock = DockStyle.Top;
            Lbl_MemInutilizavel.Location = new Point(4, 47);
            Lbl_MemInutilizavel.Margin = new Padding(4, 0, 4, 0);
            Lbl_MemInutilizavel.Name = "Lbl_MemInutilizavel";
            Lbl_MemInutilizavel.Size = new Size(189, 21);
            Lbl_MemInutilizavel.TabIndex = 5;
            Lbl_MemInutilizavel.Text = "Memoria Livre Inutilizavel";
            // 
            // Lbl_Padding
            // 
            Lbl_Padding.AutoSize = true;
            Lbl_Padding.Dock = DockStyle.Top;
            Lbl_Padding.Location = new Point(4, 26);
            Lbl_Padding.Margin = new Padding(4, 0, 4, 0);
            Lbl_Padding.Name = "Lbl_Padding";
            Lbl_Padding.Size = new Size(66, 21);
            Lbl_Padding.TabIndex = 4;
            Lbl_Padding.Text = "Padding";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Lbl_MaiorBlocoLivre);
            groupBox2.Controls.Add(Lbl_FragExterna);
            groupBox2.Controls.Add(Lbl_FragInterna);
            groupBox2.Controls.Add(Lbl_BytesFragInterna);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(4, 165);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(376, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fragmentação";
            // 
            // Lbl_MaiorBlocoLivre
            // 
            Lbl_MaiorBlocoLivre.AutoSize = true;
            Lbl_MaiorBlocoLivre.Dock = DockStyle.Top;
            Lbl_MaiorBlocoLivre.Location = new Point(4, 89);
            Lbl_MaiorBlocoLivre.Margin = new Padding(4, 0, 4, 0);
            Lbl_MaiorBlocoLivre.Name = "Lbl_MaiorBlocoLivre";
            Lbl_MaiorBlocoLivre.Size = new Size(198, 21);
            Lbl_MaiorBlocoLivre.TabIndex = 6;
            Lbl_MaiorBlocoLivre.Text = "Tamanho Maior Bloco Livre";
            // 
            // Lbl_FragExterna
            // 
            Lbl_FragExterna.AutoSize = true;
            Lbl_FragExterna.Dock = DockStyle.Top;
            Lbl_FragExterna.Location = new Point(4, 68);
            Lbl_FragExterna.Margin = new Padding(4, 0, 4, 0);
            Lbl_FragExterna.Name = "Lbl_FragExterna";
            Lbl_FragExterna.Size = new Size(137, 21);
            Lbl_FragExterna.TabIndex = 5;
            Lbl_FragExterna.Text = "Bytes Frag Externa";
            // 
            // Lbl_FragInterna
            // 
            Lbl_FragInterna.AutoSize = true;
            Lbl_FragInterna.Dock = DockStyle.Top;
            Lbl_FragInterna.Location = new Point(4, 47);
            Lbl_FragInterna.Margin = new Padding(4, 0, 4, 0);
            Lbl_FragInterna.Name = "Lbl_FragInterna";
            Lbl_FragInterna.Size = new Size(94, 21);
            Lbl_FragInterna.TabIndex = 4;
            Lbl_FragInterna.Text = "Frag Interna";
            // 
            // Lbl_BytesFragInterna
            // 
            Lbl_BytesFragInterna.AutoSize = true;
            Lbl_BytesFragInterna.Dock = DockStyle.Top;
            Lbl_BytesFragInterna.Location = new Point(4, 26);
            Lbl_BytesFragInterna.Margin = new Padding(4, 0, 4, 0);
            Lbl_BytesFragInterna.Name = "Lbl_BytesFragInterna";
            Lbl_BytesFragInterna.Size = new Size(135, 21);
            Lbl_BytesFragInterna.TabIndex = 3;
            Lbl_BytesFragInterna.Text = "Bytes Frag Interna";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Lbl_UsoHeap);
            groupBox1.Controls.Add(Lbl_BytesLivres);
            groupBox1.Controls.Add(Lbl_BytesOcupados);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(376, 153);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uso da memória heap";
            // 
            // Lbl_UsoHeap
            // 
            Lbl_UsoHeap.AutoSize = true;
            Lbl_UsoHeap.Dock = DockStyle.Top;
            Lbl_UsoHeap.Location = new Point(4, 68);
            Lbl_UsoHeap.Margin = new Padding(4, 0, 4, 0);
            Lbl_UsoHeap.Name = "Lbl_UsoHeap";
            Lbl_UsoHeap.Size = new Size(98, 21);
            Lbl_UsoHeap.TabIndex = 2;
            Lbl_UsoHeap.Text = "Uso da Heap";
            // 
            // Lbl_BytesLivres
            // 
            Lbl_BytesLivres.AutoSize = true;
            Lbl_BytesLivres.Dock = DockStyle.Top;
            Lbl_BytesLivres.Location = new Point(4, 47);
            Lbl_BytesLivres.Margin = new Padding(4, 0, 4, 0);
            Lbl_BytesLivres.Name = "Lbl_BytesLivres";
            Lbl_BytesLivres.Size = new Size(92, 21);
            Lbl_BytesLivres.TabIndex = 1;
            Lbl_BytesLivres.Text = "Bytes Livres";
            // 
            // Lbl_BytesOcupados
            // 
            Lbl_BytesOcupados.AutoSize = true;
            Lbl_BytesOcupados.Dock = DockStyle.Top;
            Lbl_BytesOcupados.Location = new Point(4, 26);
            Lbl_BytesOcupados.Margin = new Padding(4, 0, 4, 0);
            Lbl_BytesOcupados.Name = "Lbl_BytesOcupados";
            Lbl_BytesOcupados.Size = new Size(121, 21);
            Lbl_BytesOcupados.TabIndex = 0;
            Lbl_BytesOcupados.Text = "Bytes Ocupados";
            // 
            // tab_config
            // 
            tab_config.Controls.Add(MenuParametros);
            tab_config.Location = new Point(4, 30);
            tab_config.Margin = new Padding(4);
            tab_config.Name = "tab_config";
            tab_config.Padding = new Padding(4);
            tab_config.Size = new Size(1256, 647);
            tab_config.TabIndex = 2;
            tab_config.Text = "Configurações";
            tab_config.UseVisualStyleBackColor = true;
            // 
            // MenuParametros
            // 
            MenuParametros.Controls.Add(Label_AlgoritmosAlocacao);
            MenuParametros.Controls.Add(Btn_HelpAlgoritmosAlocacao);
            MenuParametros.Controls.Add(Btn_HelpSplit);
            MenuParametros.Controls.Add(HabilitarSplit);
            MenuParametros.Controls.Add(UseFirstFit);
            MenuParametros.Controls.Add(HabilitarCoalesing);
            MenuParametros.Controls.Add(SelectHeapSize);
            MenuParametros.Controls.Add(Btn_HepCoalescing);
            MenuParametros.Controls.Add(UseBestFit);
            MenuParametros.Controls.Add(Label_TamanhoHeap);
            MenuParametros.Controls.Add(UseWorstFit);
            MenuParametros.Controls.Add(Btn_HelpTamHeap);
            MenuParametros.Dock = DockStyle.Left;
            MenuParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuParametros.Location = new Point(4, 4);
            MenuParametros.Name = "MenuParametros";
            MenuParametros.Size = new Size(294, 639);
            MenuParametros.TabIndex = 1;
            MenuParametros.TabStop = false;
            MenuParametros.Text = "Parâmetros de Simulação";
            // 
            // Label_AlgoritmosAlocacao
            // 
            Label_AlgoritmosAlocacao.AutoSize = true;
            Label_AlgoritmosAlocacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_AlgoritmosAlocacao.Location = new Point(9, 197);
            Label_AlgoritmosAlocacao.Name = "Label_AlgoritmosAlocacao";
            Label_AlgoritmosAlocacao.Size = new Size(167, 21);
            Label_AlgoritmosAlocacao.TabIndex = 7;
            Label_AlgoritmosAlocacao.Text = "Algoritmo de Alocação";
            Label_AlgoritmosAlocacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_HelpAlgoritmosAlocacao
            // 
            Btn_HelpAlgoritmosAlocacao.BackgroundImage = Properties.Resources.question;
            Btn_HelpAlgoritmosAlocacao.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_HelpAlgoritmosAlocacao.Location = new Point(204, 197);
            Btn_HelpAlgoritmosAlocacao.Name = "Btn_HelpAlgoritmosAlocacao";
            Btn_HelpAlgoritmosAlocacao.Size = new Size(25, 25);
            Btn_HelpAlgoritmosAlocacao.TabIndex = 6;
            Btn_HelpAlgoritmosAlocacao.UseVisualStyleBackColor = true;
            Btn_HelpAlgoritmosAlocacao.Click += Btn_HelpAlgoritmosAlocacao_Click;
            // 
            // Btn_HelpSplit
            // 
            Btn_HelpSplit.BackgroundImage = Properties.Resources.question;
            Btn_HelpSplit.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_HelpSplit.Location = new Point(204, 28);
            Btn_HelpSplit.Name = "Btn_HelpSplit";
            Btn_HelpSplit.Size = new Size(25, 25);
            Btn_HelpSplit.TabIndex = 4;
            Btn_HelpSplit.UseVisualStyleBackColor = true;
            Btn_HelpSplit.Click += Btn_HelpSplit_Click;
            // 
            // HabilitarSplit
            // 
            HabilitarSplit.AutoSize = true;
            HabilitarSplit.Location = new Point(9, 28);
            HabilitarSplit.Name = "HabilitarSplit";
            HabilitarSplit.Size = new Size(123, 25);
            HabilitarSplit.TabIndex = 0;
            HabilitarSplit.Text = "Habilitar Split";
            HabilitarSplit.UseVisualStyleBackColor = true;
            // 
            // UseFirstFit
            // 
            UseFirstFit.AutoSize = true;
            UseFirstFit.Location = new Point(9, 230);
            UseFirstFit.Name = "UseFirstFit";
            UseFirstFit.Size = new Size(81, 25);
            UseFirstFit.TabIndex = 2;
            UseFirstFit.TabStop = true;
            UseFirstFit.Text = "First-Fit";
            UseFirstFit.TextAlign = ContentAlignment.MiddleCenter;
            UseFirstFit.UseVisualStyleBackColor = true;
            // 
            // HabilitarCoalesing
            // 
            HabilitarCoalesing.AutoSize = true;
            HabilitarCoalesing.Location = new Point(9, 59);
            HabilitarCoalesing.Name = "HabilitarCoalesing";
            HabilitarCoalesing.Size = new Size(167, 25);
            HabilitarCoalesing.TabIndex = 1;
            HabilitarCoalesing.Text = "Habilitar Coalescing";
            HabilitarCoalesing.UseVisualStyleBackColor = true;
            // 
            // SelectHeapSize
            // 
            SelectHeapSize.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectHeapSize.FormattingEnabled = true;
            SelectHeapSize.Location = new Point(9, 133);
            SelectHeapSize.Name = "SelectHeapSize";
            SelectHeapSize.Size = new Size(167, 29);
            SelectHeapSize.TabIndex = 5;
            SelectHeapSize.SelectedIndexChanged += SelectHeapSize_SelectedIndexChanged;
            // 
            // Btn_HepCoalescing
            // 
            Btn_HepCoalescing.BackgroundImage = Properties.Resources.question;
            Btn_HepCoalescing.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_HepCoalescing.Location = new Point(204, 59);
            Btn_HepCoalescing.Name = "Btn_HepCoalescing";
            Btn_HepCoalescing.Size = new Size(25, 25);
            Btn_HepCoalescing.TabIndex = 5;
            Btn_HepCoalescing.UseVisualStyleBackColor = true;
            Btn_HepCoalescing.Click += Btn_HepCoalescing_Click;
            // 
            // UseBestFit
            // 
            UseBestFit.AutoSize = true;
            UseBestFit.Location = new Point(9, 261);
            UseBestFit.Name = "UseBestFit";
            UseBestFit.Size = new Size(80, 25);
            UseBestFit.TabIndex = 4;
            UseBestFit.TabStop = true;
            UseBestFit.Text = "Best-Fit";
            UseBestFit.TextAlign = ContentAlignment.MiddleCenter;
            UseBestFit.UseVisualStyleBackColor = true;
            // 
            // Label_TamanhoHeap
            // 
            Label_TamanhoHeap.AutoSize = true;
            Label_TamanhoHeap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_TamanhoHeap.Location = new Point(9, 109);
            Label_TamanhoHeap.Name = "Label_TamanhoHeap";
            Label_TamanhoHeap.Size = new Size(134, 21);
            Label_TamanhoHeap.TabIndex = 6;
            Label_TamanhoHeap.Text = "Tamanho da Heap";
            Label_TamanhoHeap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UseWorstFit
            // 
            UseWorstFit.AutoSize = true;
            UseWorstFit.Location = new Point(9, 292);
            UseWorstFit.Name = "UseWorstFit";
            UseWorstFit.Size = new Size(92, 25);
            UseWorstFit.TabIndex = 3;
            UseWorstFit.TabStop = true;
            UseWorstFit.Text = "Worst-Fit";
            UseWorstFit.TextAlign = ContentAlignment.MiddleCenter;
            UseWorstFit.UseVisualStyleBackColor = true;
            // 
            // Btn_HelpTamHeap
            // 
            Btn_HelpTamHeap.BackgroundImage = Properties.Resources.question;
            Btn_HelpTamHeap.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_HelpTamHeap.Location = new Point(204, 134);
            Btn_HelpTamHeap.Margin = new Padding(0);
            Btn_HelpTamHeap.Name = "Btn_HelpTamHeap";
            Btn_HelpTamHeap.Size = new Size(25, 25);
            Btn_HelpTamHeap.TabIndex = 5;
            Btn_HelpTamHeap.UseVisualStyleBackColor = true;
            Btn_HelpTamHeap.Click += Btn_HelpTamHeap_Click;
            // 
            // NewMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(Tabs_Principal);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "NewMainForm";
            Text = "NewMainForm";
            Load += NewMainForm_Load;
            Tabs_Principal.ResumeLayout(false);
            tab_simulacao.ResumeLayout(false);
            Panel_Simulacao.ResumeLayout(false);
            Panel_Simulacao_Estruturas.ResumeLayout(false);
            Panel_Simulacao_2.ResumeLayout(false);
            Panel_Segmentos.ResumeLayout(false);
            Panel_Simulacao_Nav.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            Panel_ListaBlocosLivres.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewBlocosLivres).EndInit();
            Panel_Eventos.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewEventos).EndInit();
            Panel_OpcoesEventos.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tab_metricas.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tab_config.ResumeLayout(false);
            MenuParametros.ResumeLayout(false);
            MenuParametros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs_Principal;
        private TabPage tab_simulacao;
        private TabPage tab_metricas;
        private TabPage tab_config;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_Malloc;
        private Button Btn_Calloc;
        private Button Btn_Realloc;
        private Button Btn_Free;
        private Button Btn_IniciarSimulacao;
        private Button Btn_PararSimulacao;
        private Button Btn_ZerarSimulacao;
        private Button Btn_LegendaCores;
        private GroupBox MenuParametros;
        private Button Btn_HelpAlgoritmosAlocacao;
        private RadioButton UseFirstFit;
        private RadioButton UseBestFit;
        private RadioButton UseWorstFit;
        private Label Label_AlgoritmosAlocacao;
        private ComboBox SelectHeapSize;
        private Label Label_TamanhoHeap;
        private Button Btn_HelpTamHeap;
        private Button Btn_HepCoalescing;
        private CheckBox HabilitarCoalesing;
        private CheckBox HabilitarSplit;
        private Button Btn_HelpSplit;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel Panel_Simulacao;
        private Panel Panel_Simulacao_Estruturas;
        private TableLayoutPanel Panel_Simulacao_2;
        private Panel Panel_Segmentos;
        private Panel PanelGridHeap;
        private Panel Panel_Simulacao_Nav;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnPrimeiro;
        private Button BtnUltimo;
        private Button BtnAnterior;
        private Button BtnProximo;
        private Label Lbl_PassoAtual;
        private Label Label_Segmentos;
        private Panel Panel_ListaBlocosLivres;
        private Panel panel4;
        private DataGridView DataGridViewBlocosLivres;
        private Label label1;
        private Label Label_Heap;
        private Panel Panel_Eventos;
        private Panel panel6;
        private DataGridView DataGridViewEventos;
        private Panel Panel_OpcoesEventos;
        private TableLayoutPanel tableLayoutPanel5;
        private Button Btn_ExcluirEvento;
        private Button Btn_DescerEvento;
        private Button Btn_SubirEvento;
        private Label Lbl_SnapshotAtual;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox4;
        private Label Lbl_Metadados;
        private GroupBox groupBox3;
        private Label LblBlocosInutilizaveis;
        private Label Lbl_PercentualInutilizavel;
        private Label Lbl_MemInutilizavel;
        private Label Lbl_Padding;
        private GroupBox groupBox2;
        private Label Lbl_MaiorBlocoLivre;
        private Label Lbl_FragExterna;
        private Label Lbl_FragInterna;
        private Label Lbl_BytesFragInterna;
        private GroupBox groupBox1;
        private Label Lbl_UsoHeap;
        private Label Lbl_BytesLivres;
        private Label Lbl_BytesOcupados;
    }
}