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
            Text_Codigo = new RichTextBox();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Dock = DockStyle.Top;
            LblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(0, 0);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(404, 35);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Titulo";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Text_Codigo
            // 
            Text_Codigo.Dock = DockStyle.Fill;
            Text_Codigo.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Codigo.Location = new Point(0, 35);
            Text_Codigo.Name = "Text_Codigo";
            Text_Codigo.ReadOnly = true;
            Text_Codigo.Size = new Size(404, 486);
            Text_Codigo.TabIndex = 1;
            Text_Codigo.Text = "";
            Text_Codigo.WordWrap = false;
            // 
            // CodigoCasoUsoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 521);
            Controls.Add(Text_Codigo);
            Controls.Add(LblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(420, 560);
            Name = "CodigoCasoUsoForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "CodigoCasoUsoForm";
            ResumeLayout(false);
        }

        #endregion

        private Label LblTitulo;
        private RichTextBox Text_Codigo;
    }
}