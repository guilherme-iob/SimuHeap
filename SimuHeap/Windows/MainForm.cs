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

        private int proximaReferenciaBloco = 1;

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
            ConfigurarDataGrids();
            SelectHeapSize.DataSource = Enum.GetValues(typeof(TamanhosHeap));

        }
        private void SelectHeapSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectHeapSize.SelectedItem is not null)
            {
                AlterarTamanhoHeap((TamanhosHeap)SelectHeapSize.SelectedItem);
            }
        }

        private void ConfigurarDataGrids()
        {
            ConfigurarDataGridSimples(DataGridViewEventos);
            ConfigurarDataGridSimples(DataGridViewBlocosLivres);
        }

        private void ConfigurarDataGridSimples(DataGridView grid)
        {
            grid.Columns.Clear();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;

            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.Enabled = false;

            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns.Add("Descricao", string.Empty);
        }

        private void Btn_Malloc_Click(object sender, EventArgs e)
        {
            MallocForm mf = new MallocForm();

            if (mf.ShowDialog() != DialogResult.OK || mf.EventoCriado == null) return;

            mf.EventoCriado.Id = executor.Eventos.Count + 1;
            mf.EventoCriado.ReferenciaBloco = proximaReferenciaBloco;
            proximaReferenciaBloco++;

            mf.EventoCriado.AtualizarDescricao();

            executor.Eventos.Add(mf.EventoCriado);
            AtualizarListaEventos();
        }

        private void Btn_Calloc_Click(object sender, EventArgs e)
        {
            CallocForm cf = new CallocForm();

            if (cf.ShowDialog() != DialogResult.OK || cf.EventoCriado == null) return;

            cf.EventoCriado.Id = executor.Eventos.Count + 1;
            cf.EventoCriado.ReferenciaBloco = proximaReferenciaBloco;
            proximaReferenciaBloco++;

            cf.EventoCriado.AtualizarDescricao();

            executor.Eventos.Add(cf.EventoCriado);
            AtualizarListaEventos();
        }

        private void Btn_Realloc_Click(object sender, EventArgs e)
        {
            List<ReferenciaAlocacao> alocacoesAtivas = ObterAlocacoesAtivas();
            if (alocacoesAtivas.Count == 0)
            {
                MessageBox.Show("Não há blocos alocados", "Free", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ReallocForm rf = new ReallocForm(alocacoesAtivas);

            if (rf.ShowDialog() != DialogResult.OK || rf.EventoCriado == null) return;

            rf.EventoCriado.Id = executor.Eventos.Count + 1;
            executor.Eventos.Add(rf.EventoCriado);
            AtualizarListaEventos();
        }

        private void Btn_Free_Click(object sender, EventArgs e)
        {
            List<ReferenciaAlocacao> alocacoesAtivas = ObterAlocacoesAtivas();
            if(alocacoesAtivas.Count == 0)
            {
                MessageBox.Show("Não há blocos alocados", "Free", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FreeForm ff = new FreeForm(alocacoesAtivas);

            if (ff.ShowDialog() != DialogResult.OK || ff.EventoCriado == null) return;

            ff.EventoCriado.Id = executor.Eventos.Count + 1;
            executor.Eventos.Add(ff.EventoCriado);
            AtualizarListaEventos();
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
            executor.Eventos.Clear();
            heapSimulator.Resetar();
            HeapGrid.LimparSnapshot();

            DataGridViewEventos.Rows.Clear();
            DataGridViewBlocosLivres.Rows.Clear();
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
            DataGridViewEventos.Rows.Clear();

            foreach (EventoHeap evento in executor.Eventos)
            {
                DataGridViewEventos.Rows.Add(evento.Descricao);
            }
        }

        private void MostrarSnapshotAtual()
        {
            if (executor.Snapshots.Count == 0) return;

            HeapSnapshot snapshot = executor.Snapshots[snapshotAtual];

            HeapGrid.DefinirSnapshot(snapshot);

            AtualizarListaBlocosLivres(snapshot);

            DestacarEventoAtual(snapshot);
            DestacarBlocoLivreAtual(snapshot);

            Lbl_SnapshotAtual.Text = snapshot.ToString();

            // atualizar labels e métricas
            //lblOperacaoAtual.Text = snapshot.DescricaoEvento;
            //lblUsoHeap.Text = $"{snapshot.UsoHeapPercentual:F1}%";
            //lblFragExterna.Text = $"{snapshot.FragmentacaoExterna:F1}%";
            //lblFragInterna.Text = $"{snapshot.FragmentacaoInterna:F1}%";
        }
        private void AtualizarListaBlocosLivres(HeapSnapshot snapshot)
        {
            DataGridViewBlocosLivres.Rows.Clear();

            foreach (BlocoDeMemoria bloco in snapshot.BlocosLivres)
            {
                int index = DataGridViewBlocosLivres.Rows.Add($"Bloco #{bloco.Id} | " + $"{bloco.TamanhoTotal} bytes | " + $"0x{bloco.EnderecoInicio:X}-0x{bloco.EnderecoFim:X}");
                DataGridViewBlocosLivres.Rows[index].Tag = bloco;
            }
        }

        private void DestacarEventoAtual(HeapSnapshot snapshot)
        {
            DataGridViewEventos.ClearSelection();

            if (snapshot.IdEvento == null)
                return;

            int indice = executor.Eventos.FindIndex(x => x.Id == snapshot.IdEvento.Value);

            if (indice < 0 || indice >= DataGridViewEventos.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = DataGridViewEventos.Rows[indice];

            row.Selected = true;

            DataGridViewEventos.FirstDisplayedScrollingRowIndex = indice;
        }

        private void DestacarBlocoLivreAtual(HeapSnapshot snapshot)
        {
            DataGridViewBlocosLivres.ClearSelection();

            if (snapshot.EnderecoBlocoEmAnalise == null)
                return;

            foreach (DataGridViewRow row in DataGridViewBlocosLivres.Rows)
            {
                if (row.Tag is not BlocoDeMemoria bloco)
                    continue;

                if (bloco.EnderecoInicio == snapshot.EnderecoBlocoEmAnalise)
                {
                    row.Selected = true;

                    DataGridViewBlocosLivres.FirstDisplayedScrollingRowIndex = row.Index;

                    break;
                }
            }
        }

        private List<ReferenciaAlocacao> ObterAlocacoesAtivas()
        {
            Dictionary<int, ReferenciaAlocacao> ativas = new();

            foreach(EventoHeap evento in executor.Eventos)
            {
                switch (evento)
                {
                    case EventoMalloc malloc:
                        ativas[malloc.ReferenciaBloco] = new ReferenciaAlocacao
                        {
                            Id = malloc.ReferenciaBloco,
                            TipoVariavel = malloc.TipoVariavel,
                        };
                        break;
                    case EventoCalloc calloc:
                        ativas[calloc.ReferenciaBloco] = new ReferenciaAlocacao
                        {
                            Id = calloc.ReferenciaBloco,
                            TipoVariavel = calloc.TipoVariavel
                        };
                        break;
                    case EventoFree free:
                        ativas.Remove(free.ReferenciaBloco);
                        break;
                    case EventoRealloc realloc:
                        /*
                         * Realloc não cria nem remove a
                         * referência.
                         *
                         * bloco1 continua sendo bloco1.
                         */
                        break;
                }
            }

            return ativas.Values.OrderBy(x=>x.Id).ToList();
        }
    }
}
