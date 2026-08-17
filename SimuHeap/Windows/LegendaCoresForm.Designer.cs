namespace SimuHeap.Windows
{
    partial class LegendaCoresForm
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
            FlowLayoutPanel_Legenda = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowLayoutPanel_Legenda
            // 
            FlowLayoutPanel_Legenda.AutoScroll = true;
            FlowLayoutPanel_Legenda.Dock = DockStyle.Fill;
            FlowLayoutPanel_Legenda.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel_Legenda.Location = new Point(0, 0);
            FlowLayoutPanel_Legenda.Name = "FlowLayoutPanel_Legenda";
            FlowLayoutPanel_Legenda.Size = new Size(254, 461);
            FlowLayoutPanel_Legenda.TabIndex = 0;
            FlowLayoutPanel_Legenda.WrapContents = false;
            // 
            // LegendaCoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 461);
            Controls.Add(FlowLayoutPanel_Legenda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LegendaCoresForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Legenda";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowLayoutPanel_Legenda;
    }
}