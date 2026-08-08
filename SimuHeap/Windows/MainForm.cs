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
using SimuHeap.Models;

namespace SimuHeap.Windows
{
    public partial class MainForm : Form
    {
        private HeapSimulator heapSimulator;
        private HeapGridControl HeapGrid;

        private ExecutorSimulacao executor;
        private int snapshotAtual = 0;


        public MainForm()
        {
            InitializeComponent();
            this.Panel_Simulacao.Enabled = false;
        }

        /*  ====================================
         *  Eventos de Botões e Controles
         *  ====================================
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            InicializarHeap();
            SelectHeapSize.DataSource = Enum.GetValues(typeof(TamanhosHeap));

        }
        private void SelectHeapSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectHeapSize.SelectedItem is not null)
            {
                AlterarTamanhoHeap((TamanhosHeap)SelectHeapSize.SelectedItem);
            }
        }

        private void Btn_Malloc_Click(object sender, EventArgs e)
        {
            TiposDeVariaveis tipo = TiposDeVariaveis.Int;
            int quantidade = 5;
            EventoMalloc evento = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                TipoVariavel = tipo,
                Quantidade = quantidade
            };
            evento.AtualizarDescricao();
            executor.Eventos.Add(evento);

            AtualizarListaEventos();
        }

        private void Btn_Calloc_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Realloc_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Free_Click(object sender, EventArgs e)
        {

        }

        private void Btn_IniciarSimulacao_Click(object sender, EventArgs e)
        {
            heapSimulator.UsarSplit = HabilitarSplit.Checked;
            heapSimulator.UsarCoalescing = HabilitarCoalesing.Checked;

            executor.Executar(heapSimulator);
            snapshotAtual = 0;
            MostrarSnapshotAtual();

            this.Panel_Simulacao.Enabled = true;

        }
        private void Btn_PararSimulacao_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ZerarSimulacao_Click(object sender, EventArgs e)
        {
            this.Panel_Simulacao.Enabled = false;
            snapshotAtual = 0;
            executor.Snapshots.Clear();
            heapSimulator.Resetar();
            HeapGrid.LimparSnapshot();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            snapshotAtual = 0;
            MostrarSnapshotAtual();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (snapshotAtual > 0)
            {
                snapshotAtual--;
                MostrarSnapshotAtual();
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (snapshotAtual < executor.Snapshots.Count - 1)
            {
                snapshotAtual++;
                MostrarSnapshotAtual();
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            snapshotAtual = executor.Snapshots.Count - 1;
            MostrarSnapshotAtual();
        }


        /*  ====================================
         *  FUNÇÕES AUXILIARES
         *  ====================================
         */
        private void InicializarHeap()
        {
            heapSimulator = new HeapSimulator((int)TamanhosHeap.Heap64);
            executor = new ExecutorSimulacao();

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
        private void AtualizarListaEventos()
        {
            ListBoxEventos.Items.Clear();
            foreach (var evento in executor.Eventos)
            {
                ListBoxEventos.Items.Add(evento.Descricao);
            }
        }

        private void MostrarSnapshotAtual()
        {
            if (executor.Snapshots.Count == 0) return;

            HeapSnapshot snapshot = executor.Snapshots[snapshotAtual];

            HeapGrid.DefinirSnapshot(snapshot);

            AtualizarListaBlocosLivres(snapshot);

            MessageBox.Show($"{snapshot.ToString()}");

            // atualizar labels e métricas
            //lblOperacaoAtual.Text = snapshot.DescricaoEvento;
            //lblUsoHeap.Text = $"{snapshot.UsoHeapPercentual:F1}%";
            //lblFragExterna.Text = $"{snapshot.FragmentacaoExterna:F1}%";
            //lblFragInterna.Text = $"{snapshot.FragmentacaoInterna:F1}%";
        }
        private void AtualizarListaBlocosLivres(HeapSnapshot snapshot)
        {
            ListBoxBlocosLivres.Items.Clear();
            foreach (BlocoDeMemoria bloco in snapshot.BlocosLivres)
            {
                ListBoxBlocosLivres.Items.Add($"ref bloco {bloco.Id} - {bloco.TamanhoTotal} bytes");
            }
        }
    }
}
