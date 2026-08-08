namespace SimuHeap.Windows
{
    partial class MainForm
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
            PanelPrincipal = new TableLayoutPanel();
            PanelMenuSuperior = new Panel();
            MenuOperacoes = new GroupBox();
            Panel_Operacoes = new TableLayoutPanel();
            Panel_OperacoesAlocacao = new TableLayoutPanel();
            Btn_Malloc = new Button();
            Btn_Free = new Button();
            Btn_Calloc = new Button();
            Btn_Realloc = new Button();
            Panel_OperacoesSimulacao = new TableLayoutPanel();
            Btn_ZerarSimulacao = new Button();
            Btn_PararSimulacao = new Button();
            Btn_IniciarSimulacao = new Button();
            MenuParametros = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            UseFirstFit = new RadioButton();
            UseBestFit = new RadioButton();
            UseWorstFit = new RadioButton();
            Label_AlgoritmosAlocacao = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            SelectHeapSize = new ComboBox();
            Label_TamanhoHeap = new Label();
            panel1 = new Panel();
            HabilitarCoalesing = new CheckBox();
            HabilitarSplit = new CheckBox();
            Panel_Simulacao = new TableLayoutPanel();
            Panel_Simulacao_Estruturas = new Panel();
            Panel_Simulacao_2 = new TableLayoutPanel();
            Panel_Segmentos = new Panel();
            PanelGridHeap = new Panel();
            Panel_Simulacao_Nav = new Panel();
            BtnPrimeiro = new Button();
            BtnUltimo = new Button();
            BtnAnterior = new Button();
            BtnProximo = new Button();
            Label_Segmentos = new Label();
            Panel_ListaBlocosLivres = new Panel();
            ListBoxBlocosLivres = new ListBox();
            label1 = new Label();
            Label_Heap = new Label();
            Panel_Eventos = new Panel();
            ListBoxEventos = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            PanelPrincipal.SuspendLayout();
            PanelMenuSuperior.SuspendLayout();
            MenuOperacoes.SuspendLayout();
            Panel_Operacoes.SuspendLayout();
            Panel_OperacoesAlocacao.SuspendLayout();
            Panel_OperacoesSimulacao.SuspendLayout();
            MenuParametros.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            Panel_Simulacao.SuspendLayout();
            Panel_Simulacao_Estruturas.SuspendLayout();
            Panel_Simulacao_2.SuspendLayout();
            Panel_Segmentos.SuspendLayout();
            Panel_Simulacao_Nav.SuspendLayout();
            Panel_ListaBlocosLivres.SuspendLayout();
            Panel_Eventos.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.ColumnCount = 1;
            PanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelPrincipal.Controls.Add(PanelMenuSuperior, 0, 0);
            PanelPrincipal.Controls.Add(Panel_Simulacao, 0, 1);
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.RowCount = 2;
            PanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            PanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            PanelPrincipal.Size = new Size(1264, 681);
            PanelPrincipal.TabIndex = 0;
            // 
            // PanelMenuSuperior
            // 
            PanelMenuSuperior.Controls.Add(MenuOperacoes);
            PanelMenuSuperior.Controls.Add(MenuParametros);
            PanelMenuSuperior.Dock = DockStyle.Fill;
            PanelMenuSuperior.Location = new Point(3, 3);
            PanelMenuSuperior.Name = "PanelMenuSuperior";
            PanelMenuSuperior.Size = new Size(1258, 198);
            PanelMenuSuperior.TabIndex = 0;
            // 
            // MenuOperacoes
            // 
            MenuOperacoes.Controls.Add(Panel_Operacoes);
            MenuOperacoes.Dock = DockStyle.Left;
            MenuOperacoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuOperacoes.Location = new Point(385, 0);
            MenuOperacoes.Name = "MenuOperacoes";
            MenuOperacoes.Size = new Size(357, 198);
            MenuOperacoes.TabIndex = 1;
            MenuOperacoes.TabStop = false;
            MenuOperacoes.Text = "Operações";
            // 
            // Panel_Operacoes
            // 
            Panel_Operacoes.ColumnCount = 2;
            Panel_Operacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_Operacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_Operacoes.Controls.Add(Panel_OperacoesAlocacao, 0, 0);
            Panel_Operacoes.Controls.Add(Panel_OperacoesSimulacao, 1, 0);
            Panel_Operacoes.Dock = DockStyle.Fill;
            Panel_Operacoes.Location = new Point(3, 25);
            Panel_Operacoes.Name = "Panel_Operacoes";
            Panel_Operacoes.RowCount = 1;
            Panel_Operacoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Operacoes.Size = new Size(351, 170);
            Panel_Operacoes.TabIndex = 0;
            // 
            // Panel_OperacoesAlocacao
            // 
            Panel_OperacoesAlocacao.ColumnCount = 1;
            Panel_OperacoesAlocacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_OperacoesAlocacao.Controls.Add(Btn_Malloc, 0, 0);
            Panel_OperacoesAlocacao.Controls.Add(Btn_Free, 0, 3);
            Panel_OperacoesAlocacao.Controls.Add(Btn_Calloc, 0, 1);
            Panel_OperacoesAlocacao.Controls.Add(Btn_Realloc, 0, 2);
            Panel_OperacoesAlocacao.Dock = DockStyle.Fill;
            Panel_OperacoesAlocacao.Location = new Point(3, 3);
            Panel_OperacoesAlocacao.Name = "Panel_OperacoesAlocacao";
            Panel_OperacoesAlocacao.RowCount = 4;
            Panel_OperacoesAlocacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesAlocacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesAlocacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesAlocacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesAlocacao.Size = new Size(169, 164);
            Panel_OperacoesAlocacao.TabIndex = 0;
            // 
            // Btn_Malloc
            // 
            Btn_Malloc.BackColor = SystemColors.MenuHighlight;
            Btn_Malloc.Dock = DockStyle.Fill;
            Btn_Malloc.FlatStyle = FlatStyle.Flat;
            Btn_Malloc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Malloc.ForeColor = SystemColors.ControlLightLight;
            Btn_Malloc.Location = new Point(3, 3);
            Btn_Malloc.Name = "Btn_Malloc";
            Btn_Malloc.Size = new Size(163, 35);
            Btn_Malloc.TabIndex = 0;
            Btn_Malloc.Text = "malloc";
            Btn_Malloc.UseVisualStyleBackColor = false;
            Btn_Malloc.Click += Btn_Malloc_Click;
            // 
            // Btn_Free
            // 
            Btn_Free.BackColor = Color.OliveDrab;
            Btn_Free.Dock = DockStyle.Fill;
            Btn_Free.FlatStyle = FlatStyle.Flat;
            Btn_Free.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Free.ForeColor = SystemColors.ControlLightLight;
            Btn_Free.Location = new Point(3, 126);
            Btn_Free.Name = "Btn_Free";
            Btn_Free.Size = new Size(163, 35);
            Btn_Free.TabIndex = 3;
            Btn_Free.Text = "free";
            Btn_Free.UseVisualStyleBackColor = false;
            Btn_Free.Click += Btn_Free_Click;
            // 
            // Btn_Calloc
            // 
            Btn_Calloc.BackColor = SystemColors.MenuHighlight;
            Btn_Calloc.Dock = DockStyle.Fill;
            Btn_Calloc.FlatStyle = FlatStyle.Flat;
            Btn_Calloc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Calloc.ForeColor = SystemColors.ControlLightLight;
            Btn_Calloc.Location = new Point(3, 44);
            Btn_Calloc.Name = "Btn_Calloc";
            Btn_Calloc.Size = new Size(163, 35);
            Btn_Calloc.TabIndex = 1;
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
            Btn_Realloc.Location = new Point(3, 85);
            Btn_Realloc.Name = "Btn_Realloc";
            Btn_Realloc.Size = new Size(163, 35);
            Btn_Realloc.TabIndex = 2;
            Btn_Realloc.Text = "realloc";
            Btn_Realloc.UseVisualStyleBackColor = false;
            Btn_Realloc.Click += Btn_Realloc_Click;
            // 
            // Panel_OperacoesSimulacao
            // 
            Panel_OperacoesSimulacao.ColumnCount = 1;
            Panel_OperacoesSimulacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_OperacoesSimulacao.Controls.Add(Btn_ZerarSimulacao, 0, 2);
            Panel_OperacoesSimulacao.Controls.Add(Btn_PararSimulacao, 0, 1);
            Panel_OperacoesSimulacao.Controls.Add(Btn_IniciarSimulacao, 0, 0);
            Panel_OperacoesSimulacao.Dock = DockStyle.Fill;
            Panel_OperacoesSimulacao.Location = new Point(178, 3);
            Panel_OperacoesSimulacao.Name = "Panel_OperacoesSimulacao";
            Panel_OperacoesSimulacao.RowCount = 4;
            Panel_OperacoesSimulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesSimulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesSimulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesSimulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Panel_OperacoesSimulacao.Size = new Size(170, 164);
            Panel_OperacoesSimulacao.TabIndex = 1;
            // 
            // Btn_ZerarSimulacao
            // 
            Btn_ZerarSimulacao.BackColor = Color.Gray;
            Btn_ZerarSimulacao.Dock = DockStyle.Fill;
            Btn_ZerarSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_ZerarSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_ZerarSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_ZerarSimulacao.Location = new Point(3, 85);
            Btn_ZerarSimulacao.Name = "Btn_ZerarSimulacao";
            Btn_ZerarSimulacao.Size = new Size(164, 35);
            Btn_ZerarSimulacao.TabIndex = 3;
            Btn_ZerarSimulacao.Text = "Zerar Simulação";
            Btn_ZerarSimulacao.UseVisualStyleBackColor = false;
            Btn_ZerarSimulacao.Click += Btn_ZerarSimulacao_Click;
            // 
            // Btn_PararSimulacao
            // 
            Btn_PararSimulacao.BackColor = Color.IndianRed;
            Btn_PararSimulacao.Dock = DockStyle.Fill;
            Btn_PararSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_PararSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_PararSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_PararSimulacao.Location = new Point(3, 44);
            Btn_PararSimulacao.Name = "Btn_PararSimulacao";
            Btn_PararSimulacao.Size = new Size(164, 35);
            Btn_PararSimulacao.TabIndex = 2;
            Btn_PararSimulacao.Text = "Parar Simulação";
            Btn_PararSimulacao.UseVisualStyleBackColor = false;
            Btn_PararSimulacao.Click += Btn_PararSimulacao_Click;
            // 
            // Btn_IniciarSimulacao
            // 
            Btn_IniciarSimulacao.BackColor = Color.ForestGreen;
            Btn_IniciarSimulacao.Dock = DockStyle.Fill;
            Btn_IniciarSimulacao.FlatStyle = FlatStyle.Flat;
            Btn_IniciarSimulacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_IniciarSimulacao.ForeColor = SystemColors.ControlLightLight;
            Btn_IniciarSimulacao.Location = new Point(3, 3);
            Btn_IniciarSimulacao.Name = "Btn_IniciarSimulacao";
            Btn_IniciarSimulacao.Size = new Size(164, 35);
            Btn_IniciarSimulacao.TabIndex = 1;
            Btn_IniciarSimulacao.Text = "Iniciar Simulação";
            Btn_IniciarSimulacao.UseVisualStyleBackColor = false;
            Btn_IniciarSimulacao.Click += Btn_IniciarSimulacao_Click;
            // 
            // MenuParametros
            // 
            MenuParametros.Controls.Add(tableLayoutPanel1);
            MenuParametros.Dock = DockStyle.Left;
            MenuParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuParametros.Location = new Point(0, 0);
            MenuParametros.Name = "MenuParametros";
            MenuParametros.Size = new Size(385, 198);
            MenuParametros.TabIndex = 0;
            MenuParametros.TabStop = false;
            MenuParametros.Text = "Parâmetros de Simulação";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(379, 170);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Controls.Add(Label_AlgoritmosAlocacao);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 79);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(UseFirstFit, 0, 0);
            tableLayoutPanel3.Controls.Add(UseBestFit, 1, 0);
            tableLayoutPanel3.Controls.Add(UseWorstFit, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(373, 58);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // UseFirstFit
            // 
            UseFirstFit.AutoSize = true;
            UseFirstFit.Dock = DockStyle.Fill;
            UseFirstFit.Location = new Point(3, 3);
            UseFirstFit.Name = "UseFirstFit";
            UseFirstFit.Size = new Size(118, 52);
            UseFirstFit.TabIndex = 2;
            UseFirstFit.TabStop = true;
            UseFirstFit.Text = "First-Fit";
            UseFirstFit.TextAlign = ContentAlignment.MiddleCenter;
            UseFirstFit.UseVisualStyleBackColor = true;
            // 
            // UseBestFit
            // 
            UseBestFit.AutoSize = true;
            UseBestFit.Dock = DockStyle.Fill;
            UseBestFit.Location = new Point(127, 3);
            UseBestFit.Name = "UseBestFit";
            UseBestFit.Size = new Size(118, 52);
            UseBestFit.TabIndex = 4;
            UseBestFit.TabStop = true;
            UseBestFit.Text = "Best-Fit";
            UseBestFit.TextAlign = ContentAlignment.MiddleCenter;
            UseBestFit.UseVisualStyleBackColor = true;
            // 
            // UseWorstFit
            // 
            UseWorstFit.AutoSize = true;
            UseWorstFit.Dock = DockStyle.Fill;
            UseWorstFit.Location = new Point(251, 3);
            UseWorstFit.Name = "UseWorstFit";
            UseWorstFit.Size = new Size(119, 52);
            UseWorstFit.TabIndex = 3;
            UseWorstFit.TabStop = true;
            UseWorstFit.Text = "Worst-Fit";
            UseWorstFit.TextAlign = ContentAlignment.MiddleCenter;
            UseWorstFit.UseVisualStyleBackColor = true;
            // 
            // Label_AlgoritmosAlocacao
            // 
            Label_AlgoritmosAlocacao.Dock = DockStyle.Top;
            Label_AlgoritmosAlocacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_AlgoritmosAlocacao.Location = new Point(0, 0);
            Label_AlgoritmosAlocacao.Name = "Label_AlgoritmosAlocacao";
            Label_AlgoritmosAlocacao.Size = new Size(373, 21);
            Label_AlgoritmosAlocacao.TabIndex = 7;
            Label_AlgoritmosAlocacao.Text = "Algoritmo de Alocação";
            Label_AlgoritmosAlocacao.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(373, 79);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(SelectHeapSize);
            panel2.Controls.Add(Label_TamanhoHeap);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(189, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 73);
            panel2.TabIndex = 1;
            // 
            // SelectHeapSize
            // 
            SelectHeapSize.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectHeapSize.FormattingEnabled = true;
            SelectHeapSize.Location = new Point(0, 24);
            SelectHeapSize.Name = "SelectHeapSize";
            SelectHeapSize.Size = new Size(181, 29);
            SelectHeapSize.TabIndex = 5;
            SelectHeapSize.SelectedIndexChanged += SelectHeapSize_SelectedIndexChanged;
            // 
            // Label_TamanhoHeap
            // 
            Label_TamanhoHeap.Dock = DockStyle.Top;
            Label_TamanhoHeap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_TamanhoHeap.Location = new Point(0, 0);
            Label_TamanhoHeap.Name = "Label_TamanhoHeap";
            Label_TamanhoHeap.Size = new Size(181, 21);
            Label_TamanhoHeap.TabIndex = 6;
            Label_TamanhoHeap.Text = "Tamanho da Heap";
            Label_TamanhoHeap.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(HabilitarCoalesing);
            panel1.Controls.Add(HabilitarSplit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 73);
            panel1.TabIndex = 0;
            // 
            // HabilitarCoalesing
            // 
            HabilitarCoalesing.AutoSize = true;
            HabilitarCoalesing.Location = new Point(0, 36);
            HabilitarCoalesing.Name = "HabilitarCoalesing";
            HabilitarCoalesing.Size = new Size(167, 25);
            HabilitarCoalesing.TabIndex = 1;
            HabilitarCoalesing.Text = "Habilitar Coalescing";
            HabilitarCoalesing.UseVisualStyleBackColor = true;
            // 
            // HabilitarSplit
            // 
            HabilitarSplit.AutoSize = true;
            HabilitarSplit.Location = new Point(0, 11);
            HabilitarSplit.Name = "HabilitarSplit";
            HabilitarSplit.Size = new Size(123, 25);
            HabilitarSplit.TabIndex = 0;
            HabilitarSplit.Text = "Habilitar Split";
            HabilitarSplit.UseVisualStyleBackColor = true;
            // 
            // Panel_Simulacao
            // 
            Panel_Simulacao.ColumnCount = 2;
            Panel_Simulacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            Panel_Simulacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Panel_Simulacao.Controls.Add(Panel_Simulacao_Estruturas, 0, 0);
            Panel_Simulacao.Controls.Add(Panel_Eventos, 1, 0);
            Panel_Simulacao.Dock = DockStyle.Fill;
            Panel_Simulacao.Location = new Point(3, 207);
            Panel_Simulacao.Name = "Panel_Simulacao";
            Panel_Simulacao.RowCount = 1;
            Panel_Simulacao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel_Simulacao.Size = new Size(1258, 471);
            Panel_Simulacao.TabIndex = 1;
            // 
            // Panel_Simulacao_Estruturas
            // 
            Panel_Simulacao_Estruturas.Controls.Add(Panel_Simulacao_2);
            Panel_Simulacao_Estruturas.Controls.Add(Label_Heap);
            Panel_Simulacao_Estruturas.Dock = DockStyle.Fill;
            Panel_Simulacao_Estruturas.Location = new Point(3, 3);
            Panel_Simulacao_Estruturas.Name = "Panel_Simulacao_Estruturas";
            Panel_Simulacao_Estruturas.Size = new Size(811, 465);
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
            Panel_Simulacao_2.Size = new Size(811, 430);
            Panel_Simulacao_2.TabIndex = 1;
            // 
            // Panel_Segmentos
            // 
            Panel_Segmentos.Controls.Add(PanelGridHeap);
            Panel_Segmentos.Controls.Add(Panel_Simulacao_Nav);
            Panel_Segmentos.Controls.Add(Label_Segmentos);
            Panel_Segmentos.Dock = DockStyle.Fill;
            Panel_Segmentos.Location = new Point(246, 3);
            Panel_Segmentos.Name = "Panel_Segmentos";
            Panel_Segmentos.Size = new Size(562, 424);
            Panel_Segmentos.TabIndex = 0;
            // 
            // PanelGridHeap
            // 
            PanelGridHeap.AutoScroll = true;
            PanelGridHeap.Dock = DockStyle.Fill;
            PanelGridHeap.Location = new Point(0, 23);
            PanelGridHeap.Name = "PanelGridHeap";
            PanelGridHeap.Size = new Size(562, 360);
            PanelGridHeap.TabIndex = 0;
            // 
            // Panel_Simulacao_Nav
            // 
            Panel_Simulacao_Nav.BackColor = SystemColors.ActiveBorder;
            Panel_Simulacao_Nav.Controls.Add(tableLayoutPanel4);
            Panel_Simulacao_Nav.Dock = DockStyle.Bottom;
            Panel_Simulacao_Nav.Location = new Point(0, 383);
            Panel_Simulacao_Nav.Name = "Panel_Simulacao_Nav";
            Panel_Simulacao_Nav.Size = new Size(562, 41);
            Panel_Simulacao_Nav.TabIndex = 2;
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
            BtnPrimeiro.Size = new Size(46, 35);
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
            BtnUltimo.Location = new Point(159, 3);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(46, 35);
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
            BtnAnterior.Location = new Point(55, 3);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(46, 35);
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
            BtnProximo.Location = new Point(107, 3);
            BtnProximo.Name = "BtnProximo";
            BtnProximo.Size = new Size(46, 35);
            BtnProximo.TabIndex = 0;
            BtnProximo.UseVisualStyleBackColor = true;
            BtnProximo.Click += BtnProximo_Click;
            // 
            // Label_Segmentos
            // 
            Label_Segmentos.Dock = DockStyle.Top;
            Label_Segmentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Segmentos.Location = new Point(0, 0);
            Label_Segmentos.Name = "Label_Segmentos";
            Label_Segmentos.Size = new Size(562, 23);
            Label_Segmentos.TabIndex = 1;
            Label_Segmentos.Text = "Segmentos (Blocos)";
            Label_Segmentos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_ListaBlocosLivres
            // 
            Panel_ListaBlocosLivres.Controls.Add(ListBoxBlocosLivres);
            Panel_ListaBlocosLivres.Controls.Add(label1);
            Panel_ListaBlocosLivres.Dock = DockStyle.Fill;
            Panel_ListaBlocosLivres.Location = new Point(3, 3);
            Panel_ListaBlocosLivres.Name = "Panel_ListaBlocosLivres";
            Panel_ListaBlocosLivres.Size = new Size(237, 424);
            Panel_ListaBlocosLivres.TabIndex = 1;
            // 
            // ListBoxBlocosLivres
            // 
            ListBoxBlocosLivres.Dock = DockStyle.Fill;
            ListBoxBlocosLivres.FormattingEnabled = true;
            ListBoxBlocosLivres.Location = new Point(0, 23);
            ListBoxBlocosLivres.Name = "ListBoxBlocosLivres";
            ListBoxBlocosLivres.Size = new Size(237, 401);
            ListBoxBlocosLivres.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 23);
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
            Label_Heap.Size = new Size(811, 35);
            Label_Heap.TabIndex = 0;
            Label_Heap.Text = "HEAP";
            Label_Heap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Eventos
            // 
            Panel_Eventos.Controls.Add(ListBoxEventos);
            Panel_Eventos.Dock = DockStyle.Fill;
            Panel_Eventos.Location = new Point(820, 3);
            Panel_Eventos.Name = "Panel_Eventos";
            Panel_Eventos.Size = new Size(435, 465);
            Panel_Eventos.TabIndex = 1;
            // 
            // ListBoxEventos
            // 
            ListBoxEventos.FormattingEnabled = true;
            ListBoxEventos.Location = new Point(0, 35);
            ListBoxEventos.Name = "ListBoxEventos";
            ListBoxEventos.Size = new Size(192, 424);
            ListBoxEventos.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(BtnPrimeiro, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnUltimo, 3, 0);
            tableLayoutPanel4.Controls.Add(BtnAnterior, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnProximo, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Left;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(208, 41);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelPrincipal);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            PanelPrincipal.ResumeLayout(false);
            PanelMenuSuperior.ResumeLayout(false);
            MenuOperacoes.ResumeLayout(false);
            Panel_Operacoes.ResumeLayout(false);
            Panel_OperacoesAlocacao.ResumeLayout(false);
            Panel_OperacoesSimulacao.ResumeLayout(false);
            MenuParametros.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Panel_Simulacao.ResumeLayout(false);
            Panel_Simulacao_Estruturas.ResumeLayout(false);
            Panel_Simulacao_2.ResumeLayout(false);
            Panel_Segmentos.ResumeLayout(false);
            Panel_Simulacao_Nav.ResumeLayout(false);
            Panel_ListaBlocosLivres.ResumeLayout(false);
            Panel_Eventos.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelPrincipal;
        private Panel PanelMenuSuperior;
        private GroupBox MenuParametros;
        private CheckBox HabilitarCoalesing;
        private CheckBox HabilitarSplit;
        private Label Label_AlgoritmosAlocacao;
        private Label Label_TamanhoHeap;
        private ComboBox SelectHeapSize;
        private RadioButton UseBestFit;
        private RadioButton UseWorstFit;
        private RadioButton UseFirstFit;
        private GroupBox MenuOperacoes;
        private Button Btn_Free;
        private Button Btn_Realloc;
        private Button Btn_Calloc;
        private Button Btn_Malloc;
        private TableLayoutPanel Panel_Operacoes;
        private TableLayoutPanel Panel_OperacoesAlocacao;
        private TableLayoutPanel Panel_OperacoesSimulacao;
        private Button Btn_ZerarSimulacao;
        private Button Btn_PararSimulacao;
        private Button Btn_IniciarSimulacao;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
        private Panel PanelGridHeap;
        private TableLayoutPanel Panel_Simulacao;
        private Panel Panel_Simulacao_Estruturas;
        private Label Label_Heap;
        private TableLayoutPanel Panel_Simulacao_2;
        private Panel Panel_Segmentos;
        private Panel Panel_Simulacao_Nav;
        private Label Label_Segmentos;
        private Panel Panel_Eventos;
        private ListBox ListBoxEventos;
        private Panel Panel_ListaBlocosLivres;
        private Label label1;
        private ListBox ListBoxBlocosLivres;
        private Button BtnPrimeiro;
        private Button BtnUltimo;
        private Button BtnAnterior;
        private Button BtnProximo;
        private TableLayoutPanel tableLayoutPanel4;
    }
}