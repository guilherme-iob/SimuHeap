using SimuHeap.Controls;
using SimuHeap.Enums;
using SimuHeap.Services;
using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuHeap.Windows
{
    public partial class NewFormDesign : Form
    {
        private HeapSimulator heapSimulator;
        private HeapGridControl HeapGrid;

        private ExecutorSimulacao executor;

        public NewFormDesign()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            Text = "SimuHeap";
            BackColor = CoresInterface.Fundo;
        }
        private void NewFormDesign_Load(object sender, EventArgs e)
        {
            InicializarHeap();
        }

        private void PanelGridHeap_Resize(object? sender, EventArgs e)
        {
            this.HeapGrid.AjustarTamanho(this.PanelGridHeap.ClientSize.Width);
        }

        private void InicializarHeap()
        {
            heapSimulator = new HeapSimulator((int)TamanhosHeap.Heap8KB);
            executor = new ExecutorSimulacao();

            this.HeapGrid = new HeapGridControl
            {
                Location = new Point(0, 0),
                CellSize = 28,
                //Columns = 32,
                Simulator = heapSimulator
            };

            this.PanelGridHeap.BackColor = Color.Transparent;//Color.FromArgb(30, 30, 30);
            this.PanelGridHeap.Resize += PanelGridHeap_Resize;
            this.PanelGridHeap.AutoScroll = true;
            this.PanelGridHeap.Controls.Add(this.HeapGrid);
        }

        
    }
}
