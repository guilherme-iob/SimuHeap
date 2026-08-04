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
            Panel_Simulacao = new Panel();
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
            Panel_Simulacao.Dock = DockStyle.Fill;
            Panel_Simulacao.Location = new Point(3, 207);
            Panel_Simulacao.Name = "Panel_Simulacao";
            Panel_Simulacao.Size = new Size(1258, 471);
            Panel_Simulacao.TabIndex = 1;
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
        private Panel Panel_Simulacao;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
    }
}