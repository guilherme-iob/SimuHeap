using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuHeap.Controls;
using SimuHeap.Services;

namespace SimuHeap.Windows
{
    public partial class MainForm : Form
    {
        private HeapSimulator heapSimulator;
        private HeapGridControl HeapGrid;
        public MainForm()
        {
            InitializeComponent();

            InicializarHeap();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectHeapSize.DataSource = Enum.GetValues(typeof(TamanhosHeap));
        }

        private void InicializarHeap()
        {
            heapSimulator = new HeapSimulator((int)TamanhosHeap.Heap64);

            this.HeapGrid = new HeapGridControl
            {
                Location = new Point(0, 0),
                CellSize = 28,
                Columns = 32,
                Simulator = heapSimulator
            };

            this.PanelGridHeap.AutoScroll = true;
            this.PanelGridHeap.Controls.Add(this.HeapGrid);
        }

        private void AlterarTamanhoHeap(TamanhosHeap novoTamanho)
        {
            heapSimulator = new HeapSimulator((int)novoTamanho);

            HeapGrid.Simulator = heapSimulator;
        }

        private void ResetarHeap()
        {
            heapSimulator.Resetar();
            HeapGrid.AtualizarVisualizacao();
        }

        private void SelectHeapSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlterarTamanhoHeap((TamanhosHeap)SelectHeapSize.SelectedItem);
        }
    }
}
