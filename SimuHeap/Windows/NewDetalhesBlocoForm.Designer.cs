namespace SimuHeap.Windows
{
    partial class NewDetalhesBlocoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDetalhesBlocoForm));
            panel6 = new Panel();
            tableLayoutPanel14 = new TableLayoutPanel();
            lblTitulo = new Label();
            StatusPillBloco = new SimuHeap.Controls.CustomControls.StatusPill();
            ColorIndicatorBloco = new SimuHeap.Controls.CustomControls.ColorIndicator();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOK = new SimuHeap.Controls.CustomControls.RoundedButton();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            DataGridViewValores = new SimuHeap.Controls.CustomControls.StyledDataGridView();
            PanelBlocosDetalhes = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            cardPanel3 = new SimuHeap.Controls.CustomControls.CardPanel();
            lblInformacoes2 = new Label();
            panel3 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cardPanel2 = new SimuHeap.Controls.CustomControls.CardPanel();
            lblInformacoes = new Label();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewValores).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            cardPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(232, 235, 239);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 40);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(754, 1);
            panel6.TabIndex = 21;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.White;
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel14.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel14.Controls.Add(StatusPillBloco, 2, 0);
            tableLayoutPanel14.Controls.Add(ColorIndicatorBloco, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Top;
            tableLayoutPanel14.Location = new Point(0, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(754, 40);
            tableLayoutPanel14.TabIndex = 20;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Lato", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(53, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(498, 40);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Bloco";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusPillBloco
            // 
            StatusPillBloco.Dock = DockStyle.Fill;
            StatusPillBloco.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusPillBloco.ForeColor = Color.FromArgb(185, 28, 28);
            StatusPillBloco.Location = new Point(557, 3);
            StatusPillBloco.Name = "StatusPillBloco";
            StatusPillBloco.Size = new Size(194, 34);
            StatusPillBloco.TabIndex = 9;
            StatusPillBloco.Text = "Status";
            // 
            // ColorIndicatorBloco
            // 
            ColorIndicatorBloco.Anchor = AnchorStyles.None;
            ColorIndicatorBloco.Location = new Point(9, 4);
            ColorIndicatorBloco.MaximumSize = new Size(32, 32);
            ColorIndicatorBloco.Name = "ColorIndicatorBloco";
            ColorIndicatorBloco.Size = new Size(32, 32);
            ColorIndicatorBloco.TabIndex = 10;
            ColorIndicatorBloco.Text = "colorIndicator1";
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
            tableLayoutPanel1.Location = new Point(0, 621);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(754, 40);
            tableLayoutPanel1.TabIndex = 22;
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
            BtnOK.Location = new Point(567, 3);
            BtnOK.Name = "BtnOK";
            BtnOK.Padding = new Padding(10, 0, 10, 0);
            BtnOK.Size = new Size(184, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 235, 239);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 620);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 1);
            panel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(DataGridViewValores, 0, 2);
            tableLayoutPanel2.Controls.Add(PanelBlocosDetalhes, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 41);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(754, 579);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // DataGridViewValores
            // 
            DataGridViewValores.AllowUserToAddRows = false;
            DataGridViewValores.AllowUserToDeleteRows = false;
            DataGridViewValores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 253, 254);
            DataGridViewValores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewValores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewValores.BackgroundColor = Color.White;
            DataGridViewValores.BorderStyle = BorderStyle.None;
            DataGridViewValores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewValores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(75, 85, 105);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(75, 85, 105);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewValores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 239, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewValores.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewValores.Dock = DockStyle.Fill;
            DataGridViewValores.EnableHeadersVisualStyles = false;
            DataGridViewValores.GridColor = Color.FromArgb(222, 226, 232);
            DataGridViewValores.Location = new Point(10, 407);
            DataGridViewValores.Margin = new Padding(10, 3, 10, 3);
            DataGridViewValores.MultiSelect = false;
            DataGridViewValores.Name = "DataGridViewValores";
            DataGridViewValores.RowHeadersVisible = false;
            DataGridViewValores.RowTemplate.Height = 42;
            DataGridViewValores.ScrollBars = ScrollBars.Vertical;
            DataGridViewValores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewValores.Size = new Size(734, 169);
            DataGridViewValores.TabIndex = 0;
            // 
            // PanelBlocosDetalhes
            // 
            PanelBlocosDetalhes.AutoScroll = true;
            PanelBlocosDetalhes.Dock = DockStyle.Fill;
            PanelBlocosDetalhes.Location = new Point(10, 10);
            PanelBlocosDetalhes.Margin = new Padding(10);
            PanelBlocosDetalhes.Name = "PanelBlocosDetalhes";
            PanelBlocosDetalhes.Size = new Size(734, 95);
            PanelBlocosDetalhes.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cardPanel3, 1, 0);
            tableLayoutPanel3.Controls.Add(cardPanel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 118);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(748, 283);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // cardPanel3
            // 
            cardPanel3.BackColor = Color.White;
            cardPanel3.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel3.Controls.Add(lblInformacoes2);
            cardPanel3.Controls.Add(panel3);
            cardPanel3.Controls.Add(tableLayoutPanel5);
            cardPanel3.Dock = DockStyle.Fill;
            cardPanel3.Location = new Point(376, 3);
            cardPanel3.Margin = new Padding(2, 3, 10, 3);
            cardPanel3.Name = "cardPanel3";
            cardPanel3.Padding = new Padding(5);
            cardPanel3.Size = new Size(362, 277);
            cardPanel3.TabIndex = 2;
            // 
            // lblInformacoes2
            // 
            lblInformacoes2.AutoSize = true;
            lblInformacoes2.Dock = DockStyle.Fill;
            lblInformacoes2.Font = new Font("Lato", 9.749999F);
            lblInformacoes2.Location = new Point(5, 46);
            lblInformacoes2.Name = "lblInformacoes2";
            lblInformacoes2.Padding = new Padding(0, 10, 0, 10);
            lblInformacoes2.Size = new Size(143, 36);
            lblInformacoes2.TabIndex = 22;
            lblInformacoes2.Text = "informacoes da alocacao";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 235, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 45);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 1);
            panel3.TabIndex = 21;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.White;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.Controls.Add(label2, 1, 0);
            tableLayoutPanel5.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(5, 5);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(352, 40);
            tableLayoutPanel5.TabIndex = 20;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Lato", 14.25F);
            label2.Location = new Point(53, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 40);
            label2.TabIndex = 8;
            label2.Text = "Origem da Alocação";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.segment_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cardPanel2
            // 
            cardPanel2.BackColor = Color.White;
            cardPanel2.BorderColor = Color.FromArgb(222, 226, 232);
            cardPanel2.Controls.Add(lblInformacoes);
            cardPanel2.Controls.Add(panel2);
            cardPanel2.Controls.Add(tableLayoutPanel4);
            cardPanel2.Dock = DockStyle.Fill;
            cardPanel2.Location = new Point(10, 3);
            cardPanel2.Margin = new Padding(10, 3, 2, 3);
            cardPanel2.Name = "cardPanel2";
            cardPanel2.Padding = new Padding(5);
            cardPanel2.Size = new Size(362, 277);
            cardPanel2.TabIndex = 1;
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Dock = DockStyle.Fill;
            lblInformacoes.Font = new Font("Lato", 9.749999F);
            lblInformacoes.Location = new Point(5, 46);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Padding = new Padding(0, 10, 0, 10);
            lblInformacoes.Size = new Size(149, 36);
            lblInformacoes.TabIndex = 22;
            lblInformacoes.Text = "informacoes da estrutura";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 235, 239);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 45);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 1);
            panel2.TabIndex = 21;
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
            tableLayoutPanel4.Location = new Point(5, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(352, 40);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Lato", 14.25F);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 40);
            label1.TabIndex = 8;
            label1.Text = "Estrutura do Bloco";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackgroundImage = Properties.Resources.settings_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(10, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // NewDetalhesBlocoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(754, 661);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            Controls.Add(tableLayoutPanel14);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(770, 700);
            MinimumSize = new Size(770, 700);
            Name = "NewDetalhesBlocoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewDetalhesBlocoForm";
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewValores).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            cardPanel3.ResumeLayout(false);
            cardPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardPanel2.ResumeLayout(false);
            cardPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel14;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.RoundedButton BtnOK;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Controls.CustomControls.StatusPill StatusPillBloco;
        private TableLayoutPanel tableLayoutPanel3;
        private Controls.CustomControls.CardPanel cardPanel3;
        private Controls.CustomControls.CardPanel cardPanel2;
        private Controls.CustomControls.ColorIndicator ColorIndicatorBloco;
        private Panel PanelBlocosDetalhes;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private PictureBox pictureBox8;
        private Controls.CustomControls.StyledDataGridView DataGridViewValores;
        private Label lblInformacoes;
        private Label lblInformacoes2;
    }
}