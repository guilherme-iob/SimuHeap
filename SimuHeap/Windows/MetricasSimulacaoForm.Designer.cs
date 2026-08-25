namespace SimuHeap.Windows
{
    partial class MetricasSimulacaoForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            Lbl_UsoHeap = new Label();
            Lbl_BytesLivres = new Label();
            Lbl_BytesOcupados = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 4);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.Size = new Size(384, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Lbl_Metadados);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(4, 524);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(376, 153);
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
            groupBox3.Location = new Point(4, 364);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(376, 152);
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
            groupBox2.Location = new Point(4, 204);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(376, 152);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 40);
            label1.TabIndex = 0;
            label1.Text = "Métricas de Simulação";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Lbl_UsoHeap);
            groupBox1.Controls.Add(Lbl_BytesLivres);
            groupBox1.Controls.Add(Lbl_BytesOcupados);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 44);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(376, 152);
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
            // MetricasSimulacaoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 681);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MetricasSimulacaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Métricas de Simulação";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label Lbl_BytesOcupados;
        private Label Lbl_BytesLivres;
        private Label Lbl_UsoHeap;
        private Label Lbl_BytesFragInterna;
        private Label Lbl_MaiorBlocoLivre;
        private Label Lbl_FragExterna;
        private Label Lbl_FragInterna;
        private Label LblBlocosInutilizaveis;
        private Label Lbl_PercentualInutilizavel;
        private Label Lbl_MemInutilizavel;
        private Label Lbl_Padding;
        private Label Lbl_Metadados;
    }
}