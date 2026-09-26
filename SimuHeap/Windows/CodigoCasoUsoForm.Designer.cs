namespace SimuHeap.Windows
{
    partial class CodigoCasoUsoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoCasoUsoForm));
            LblTitulo = new Label();
            panel6 = new Panel();
            tableLayoutPanel14 = new TableLayoutPanel();
            pictureBox8 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Text_CodeViewer = new SimuHeap.Controls.CustomControls.CodeViewer();
            cardPanel1 = new SimuHeap.Controls.CustomControls.CardPanel();
            panel1 = new Panel();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            cardPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Dock = DockStyle.Fill;
            LblTitulo.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(54, 0);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(376, 40);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Titulo";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(232, 235, 239);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 40);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(484, 1);
            panel6.TabIndex = 31;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.White;
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.Controls.Add(pictureBox8, 0, 0);
            tableLayoutPanel14.Controls.Add(LblTitulo, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Top;
            tableLayoutPanel14.Location = new Point(0, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(484, 40);
            tableLayoutPanel14.TabIndex = 30;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackgroundImage = Properties.Resources.code_blocks_48dp_237DE6_FILL1_wght400_GRAD0_opsz48;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
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
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 501);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 40);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // Text_CodeViewer
            // 
            Text_CodeViewer.BackColor = Color.FromArgb(248, 250, 252);
            Text_CodeViewer.BorderStyle = BorderStyle.None;
            Text_CodeViewer.DetectUrls = false;
            Text_CodeViewer.Dock = DockStyle.Fill;
            Text_CodeViewer.Font = new Font("Consolas", 10F);
            Text_CodeViewer.ForeColor = Color.FromArgb(30, 41, 59);
            Text_CodeViewer.Location = new Point(5, 5);
            Text_CodeViewer.Name = "Text_CodeViewer";
            Text_CodeViewer.ReadOnly = true;
            Text_CodeViewer.Size = new Size(464, 440);
            Text_CodeViewer.TabIndex = 33;
            Text_CodeViewer.Text = "";
            Text_CodeViewer.WordWrap = false;
            // 
            // cardPanel1
            // 
            cardPanel1.BackColor = Color.FromArgb(247, 248, 250);
            cardPanel1.BorderColor = Color.FromArgb(222, 226, 238);
            cardPanel1.Controls.Add(Text_CodeViewer);
            cardPanel1.Dock = DockStyle.Fill;
            cardPanel1.Location = new Point(5, 5);
            cardPanel1.Margin = new Padding(5);
            cardPanel1.Name = "cardPanel1";
            cardPanel1.Padding = new Padding(5);
            cardPanel1.Size = new Size(474, 450);
            cardPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(cardPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(484, 460);
            panel1.TabIndex = 34;
            // 
            // CodigoCasoUsoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(484, 541);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            Controls.Add(tableLayoutPanel14);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(600, 580);
            MinimumSize = new Size(500, 560);
            Name = "CodigoCasoUsoForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "CodigoCasoUsoForm";
            tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            cardPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel14;
        private PictureBox pictureBox8;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.CodeViewer Text_CodeViewer;
        private Controls.CustomControls.CardPanel cardPanel1;
        private Panel panel1;
    }
}