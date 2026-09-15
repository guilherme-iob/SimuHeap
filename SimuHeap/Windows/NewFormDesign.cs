using SimuHeap.Controls;
using SimuHeap.Controls.CustomControls;
using SimuHeap.Enums;
using SimuHeap.Models;
using SimuHeap.Services;
using SimuHeap.Utils;
using SimuHeap.Windows.Avisos;
using SimuHeap.Windows.OperacoesAlocacao;
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
        private int snapshotAtual = 0;

        private int proximaReferenciaBloco = 1;

        private NewLegendaForm? legendaCoresForm;
        private CodigoCasoUsoForm? codigoCasoUsoForm;

        private bool emSimulacao = false;

        private CasoUsoSimulacao casoSelecionado = CasoUsoSimulacao.Nenhum;

        public NewFormDesign()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        /*  ====================================
         *  INICIALIZAÇÃO
         *  ====================================
         */
        #region Funções e Eventos de Inicialização
        private void ConfigurarFormulario()
        {
            Text = "SimuHeap";
            BackColor = CoresInterface.Fundo;
        }
        private void NewFormDesign_Load(object sender, EventArgs e)
        {
            TrocarAba(0);
            this.PanelNavegacaoSnapshot.Enabled = false;
            this.PanelGridHeap.Enabled = false;

            InicializarHeap();
            ConfigurarDataGrids();
            AtualizarLabelPassoAtual();
            SelectHeapSize.DataSource = Enum.GetValues(typeof(TamanhosHeap));
            ResetarLabelEventoAtual();
            AtualizarMetricas(CalculadoraMetricasHeap.Calcular(heapSimulator));

            HabilitarSplit.Checked = true;
            HabilitarCoalesing.Checked = false;
            UseFirstFit.Checked = true;
            SelectHeapSize.SelectedIndex = 1;
            UsarNenhumCaso.Checked = true;

            AtualizarLabelConfiguracaoAtual();
        }

        private void PanelGridHeap_Resize(object? sender, EventArgs e)
        {
            this.HeapGrid.AjustarTamanho(this.PanelGridHeap.ClientSize.Width);
        }

        private void InicializarHeap()
        {
            heapSimulator = new HeapSimulator((int)TamanhosHeap.Heap8K);
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

            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.DefaultCellStyle.Font = new Font(grid.Font.FontFamily, 9f);

            grid.Columns.Add("Descricao", string.Empty);
        }

        #endregion

        /*  ====================================
         *  Eventos de Botões e Controles
         *  ====================================
         */
        private void Btn_TabSimulacao_Click(object sender, EventArgs e)
        {
            AtualizarLabelConfiguracaoAtual();
            TrocarAba(0);
        }

        private void Btn_TabMetricas_Click(object sender, EventArgs e)
        {
            TrocarAba(1);
        }

        private void Btn_TabConfiguracoes_Click(object sender, EventArgs e)
        {
            TrocarAba(2);
        }

        private void SelectHeapSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectHeapSize.SelectedItem is not null)
            {
                AlterarTamanhoHeap((TamanhosHeap)SelectHeapSize.SelectedItem);
            }
        }
        private void HabilitarVisualizacaoAvancada_CheckedChanged(object sender, EventArgs e)
        {
            HeapGrid.UsarVisualizacaoAvancada = HabilitarVisualizacaoAvancada.Checked;
        }

        #region Eventos das Operações de Alocação
        private void Btn_Malloc_Click(object sender, EventArgs e)
        {
            NewMallocForm mf = new NewMallocForm();

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
            NewCallocForm cf = new NewCallocForm();

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
                MessageBox.Show("Não há blocos alocados", "Realloc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NewReallocForm rf = new NewReallocForm(alocacoesAtivas);

            if (rf.ShowDialog() != DialogResult.OK || rf.EventoCriado == null) return;

            rf.EventoCriado.Id = executor.Eventos.Count + 1;
            executor.Eventos.Add(rf.EventoCriado);
            AtualizarListaEventos();
        }

        private void Btn_Free_Click(object sender, EventArgs e)
        {
            List<ReferenciaAlocacao> alocacoesAtivas = ObterAlocacoesAtivas();
            if (alocacoesAtivas.Count == 0)
            {
                MessageBox.Show("Não há blocos alocados", "Free", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NewFreeForm ff = new NewFreeForm(alocacoesAtivas);

            if (ff.ShowDialog() != DialogResult.OK || ff.EventoCriado == null) return;

            ff.EventoCriado.Id = executor.Eventos.Count + 1;
            executor.Eventos.Add(ff.EventoCriado);
            AtualizarListaEventos();
        }
        #endregion

        #region Eventos de Menu de Simulação
        private void Btn_IniciarSimulacao_Click(object sender, EventArgs e)
        {
            if (emSimulacao)
            {
                MessageBox.Show(
                    "Simulação em Andamento. Pare a simulação atual para iniciar uma nova.",
                    "Simulação em Andamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (executor.Eventos.Count == 0)
            {
                MessageBox.Show(
                    "Adicione pelo menos um evento antes de iniciar a simulação.",
                    "Nenhum evento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarSequenciaEventos(out string mensagemErro))
            {
                MessageBox.Show(
                    mensagemErro,
                    "Sequência de eventos inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (casoSelecionado != CasoUsoSimulacao.Nenhum)
            {
                codigoCasoUsoForm = new CodigoCasoUsoForm(casoSelecionado);
                codigoCasoUsoForm.Show();
            }



            heapSimulator.UsarSplit = HabilitarSplit.Checked;
            heapSimulator.UsarCoalescing = HabilitarCoalesing.Checked;
            heapSimulator.UsarLegendasDetalhadas = UsarLegendaDetalhada.Checked;

            AlgoritmosDeAlocacao algoritmo = AlgoritmosDeAlocacao.FirstFit;

            if (UseFirstFit.Checked) algoritmo = AlgoritmosDeAlocacao.FirstFit;
            else if (UseBestFit.Checked) algoritmo = AlgoritmosDeAlocacao.BestFit;
            else if (UseWorstFit.Checked) algoritmo = AlgoritmosDeAlocacao.WorstFit;

            executor.Executar(heapSimulator, algoritmo);
            snapshotAtual = 0;
            MostrarSnapshotAtual();

            emSimulacao = true;

            this.Panel_Simulacao_2.Enabled = true;
            this.PanelNavegacaoSnapshot.Enabled = true;
            this.PanelGridHeap.Enabled = true;

            this.Panel_OpcoesEventos.Enabled = false;
            //this.MenuParametros.Enabled = false;
            this.CardPanelConfigMemoria.Enabled = false;
            this.CardPanelConfigGerenciamento.Enabled = false;
            this.UsarLegendaDetalhada.Enabled = false;
            this.CardPanelConfigAlgoritmos.Enabled = false;
            this.CardPanelConfigCasosUso.Enabled = false;
            this.CardPanelConfigCenariosTeste.Enabled = false;

            this.FlowPanelOperacoes.Enabled = false;

        }

        private void Btn_PararSimulacao_Click(object sender, EventArgs e)
        {

            codigoCasoUsoForm?.Close();

            snapshotAtual = 0;
            executor.Snapshots.Clear();

            heapSimulator.Resetar();
            HeapGrid.LimparSnapshot();

            DataGridViewBlocosLivres.Rows.Clear();

            AtualizarMetricas(CalculadoraMetricasHeap.Calcular(heapSimulator));

            AtualizarLabelPassoAtual();
            ResetarLabelEventoAtual();

            emSimulacao = false;
            //this.Panel_Simulacao_2.Enabled = false;

            this.PanelNavegacaoSnapshot.Enabled = false;
            this.PanelGridHeap.Enabled = false;
            this.Panel_OpcoesEventos.Enabled = true;
            //this.MenuParametros.Enabled = true;
            this.CardPanelConfigMemoria.Enabled = true;
            this.CardPanelConfigGerenciamento.Enabled = true;
            this.UsarLegendaDetalhada.Enabled = true;
            this.CardPanelConfigAlgoritmos.Enabled = true;
            this.CardPanelConfigCasosUso.Enabled = true;
            this.CardPanelConfigCenariosTeste.Enabled = true;

            this.FlowPanelOperacoes.Enabled = true;
        }

        private void Btn_ZerarSimulacao_Click(object sender, EventArgs e)
        {
            UsarNenhumCaso.Checked = true;
            snapshotAtual = 0;
            executor.Snapshots.Clear();
            executor.Eventos.Clear();
            heapSimulator.Resetar();
            HeapGrid.LimparSnapshot();

            DataGridViewEventos.Rows.Clear();
            DataGridViewBlocosLivres.Rows.Clear();

            AtualizarMetricas(CalculadoraMetricasHeap.Calcular(heapSimulator));

            AtualizarLabelPassoAtual();
            ResetarLabelEventoAtual();

            proximaReferenciaBloco = 1;

            //this.Panel_Simulacao_2.Enabled = false;
            this.PanelNavegacaoSnapshot.Enabled = false;
            this.PanelGridHeap.Enabled = false;
            this.Panel_OpcoesEventos.Enabled = true;
            //this.MenuParametros.Enabled = true;
            this.CardPanelConfigMemoria.Enabled = true;
            this.CardPanelConfigGerenciamento.Enabled = true;
            this.UsarLegendaDetalhada.Enabled = true;
            this.CardPanelConfigAlgoritmos.Enabled = true;
            this.CardPanelConfigCasosUso.Enabled = true;
            this.CardPanelConfigCenariosTeste.Enabled = true;

            this.FlowPanelOperacoes.Enabled = true;
        }

        private void Btn_LegendaCores_Click(object sender, EventArgs e)
        {
            if (legendaCoresForm is null || legendaCoresForm.IsDisposed)
            {
                legendaCoresForm = new NewLegendaForm(UsarLegendaDetalhada.Checked);
                legendaCoresForm.Show(this);
            }
            else
            {
                legendaCoresForm.BringToFront();
                legendaCoresForm.Activate();
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            NavegarParaSnapshot(0);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (snapshotAtual > 0)
            {
                NavegarParaSnapshot(snapshotAtual - 1);
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (snapshotAtual < executor.Snapshots.Count - 1)
            {
                NavegarParaSnapshot(snapshotAtual + 1);
            }

        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            NavegarParaSnapshot(executor.Snapshots.Count - 1);
        }

        private void Btn_SubirEvento_Click(object sender, EventArgs e)
        {
            if (DataGridViewEventos.CurrentRow is null) return;


            int indice = DataGridViewEventos.CurrentRow.Index;

            // Já está no topo.
            if (indice <= 0) return;

            EventoHeap eventoSelecionado = executor.Eventos[indice];

            executor.Eventos[indice] = executor.Eventos[indice - 1];

            executor.Eventos[indice - 1] = eventoSelecionado;

            ReorganizarIdsEventos();

            AtualizarListaEventos();

            // Mantém selecionado o evento que acabou de subir.
            DataGridViewEventos.Rows[indice - 1].Selected = true;
            DataGridViewEventos.CurrentCell = DataGridViewEventos.Rows[indice - 1].Cells[0];
        }

        private void Btn_DescerEvento_Click(object sender, EventArgs e)
        {
            if (DataGridViewEventos.CurrentRow is null) return;

            int indice = DataGridViewEventos.CurrentRow.Index;

            // Já está no último evento.
            if (indice < 0 || indice >= executor.Eventos.Count - 1) return;

            EventoHeap eventoSelecionado = executor.Eventos[indice];

            executor.Eventos[indice] = executor.Eventos[indice + 1];

            executor.Eventos[indice + 1] = eventoSelecionado;

            ReorganizarIdsEventos();

            AtualizarListaEventos();

            // Mantém selecionado o evento depois da movimentação.
            DataGridViewEventos.Rows[indice + 1].Selected = true;
            DataGridViewEventos.CurrentCell = DataGridViewEventos.Rows[indice + 1].Cells[0];
        }

        private void Btn_ExcluirEvento_Click(object sender, EventArgs e)
        {
            if (DataGridViewEventos.CurrentRow is null)
                return;

            int indice = DataGridViewEventos.CurrentRow.Index;

            if (indice < 0 || indice >= executor.Eventos.Count)
                return;

            executor.Eventos.RemoveAt(indice);

            ReorganizarIdsEventos();

            AtualizarListaEventos();
        }
        #endregion

        #region Eventos de Ajuda
        private void Btn_HelpSplit_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Divisão de Bloco (Split)", ExplicacoesConceitos.ExplicacaoSplit);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HepCoalescing_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("União de Blocos Livres (Coalescing)", ExplicacoesConceitos.ExplicacaoCoalescing);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpTamHeap_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Tamanho da Heap", ExplicacoesConceitos.ExplicacaoTamanhoHeap);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpAlgoritmosAlocacao_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Algoritmos de Alocação", ExplicacoesConceitos.ExplicacaoAlgoritmosAlocacao);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpHeap_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Memória Heap", ExplicacoesConceitos.ExplicacaoHeap);
            avisoExplicativoForm.ShowDialog();
        }
        private void Btn_HelpUsoHeap_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Uso da Heap", ExplicacoesConceitos.ExplicacaoUsoTotalHeap);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpFragInterna_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Fragmentação Interna", ExplicacoesConceitos.ExplicacaoFragmentacaoInterna);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpFragExterna_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Fragmentação Externa", ExplicacoesConceitos.ExplicacaoFragmentacaoExterna);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpFragmentacao_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Fragmentação", ExplicacoesConceitos.ExplicacaoFragmentacaoInterna + "\n\n\n" + ExplicacoesConceitos.ExplicacaoFragmentacaoExterna);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpMemoriaInutilizavel_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Memória Inutilizável", ExplicacoesConceitos.ExplicacaoMemoriaInutilizavel);
            avisoExplicativoForm.ShowDialog();
        }

        private void Btn_HelpTotalMetadados_Click(object sender, EventArgs e)
        {
            AvisoExplicativoForm avisoExplicativoForm = new AvisoExplicativoForm("Total de Metadados", ExplicacoesConceitos.ExplicacaoMetadados);
            avisoExplicativoForm.ShowDialog();
        }

        #endregion

        #region Casos de Uso Predefinidos
        private void UsarNenhumCaso_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarNenhumCaso.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.Nenhum;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCaso1_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCaso1.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.AlocacoesDiferentes;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCaso2_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCaso2.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.Mediana;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCaso3_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCaso3.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.SubtracaoVetores;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCaso4_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCaso4.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.NotasEFaltas;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCaso5_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCaso5.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.RedimensionamentoTurma;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarCasoAltaFragInterna_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCasoAltaFragInterna.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.AltaFragInterna;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }

        private void UsarAltaFragExterna_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarCasoAltaFragExterna.Checked)
            {
                casoSelecionado = CasoUsoSimulacao.AltaFragExterna;
                CarregarCasoPredefinido();
                BloquearOperacoesParaCasosDeUso();
            }
        }


        private void InicializarEventosTeste()
        {
            executor.Eventos.Clear();

            proximaReferenciaBloco = 1;

            /*
             * Recomendo executar este cenário com uma heap
             * de pelo menos 256 bytes.
             */

            // --------------------------------------------------
            // 1 - malloc: int[4]
            // --------------------------------------------------
            EventoMalloc malloc1 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Int,
                Quantidade = 4
            };

            malloc1.AtualizarDescricao();
            executor.Eventos.Add(malloc1);


            // --------------------------------------------------
            // 2 - malloc: int[8]
            // Bloco maior, que depois será liberado.
            // --------------------------------------------------
            EventoMalloc malloc2 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Int,
                Quantidade = 8
            };

            malloc2.AtualizarDescricao();
            executor.Eventos.Add(malloc2);


            // --------------------------------------------------
            // 3 - calloc: short[8]
            // Permite verificar se o payload ficou zerado.
            // --------------------------------------------------
            EventoCalloc calloc1 = new EventoCalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Short,
                Quantidade = 8
            };

            calloc1.AtualizarDescricao();
            executor.Eventos.Add(calloc1);


            // --------------------------------------------------
            // 4 - malloc: char[8]
            // Bloco pequeno que também será liberado depois.
            // --------------------------------------------------
            EventoMalloc malloc3 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 8
            };

            malloc3.AtualizarDescricao();
            executor.Eventos.Add(malloc3);


            // --------------------------------------------------
            // 5 - malloc: int[8]
            // Útil para testar realloc diminuindo o bloco.
            // --------------------------------------------------
            EventoMalloc malloc4 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Int,
                Quantidade = 8
            };

            malloc4.AtualizarDescricao();
            executor.Eventos.Add(malloc4);


            // --------------------------------------------------
            // 6 - free(bloco2)
            // Cria um bloco livre relativamente grande.
            // --------------------------------------------------
            EventoFree free1 = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc2.ReferenciaBloco
            };

            free1.AtualizarDescricao();
            executor.Eventos.Add(free1);


            // --------------------------------------------------
            // 7 - free(bloco4)
            // Cria outro bloco livre, menor que o anterior.
            //
            // Agora teremos blocos livres de tamanhos diferentes,
            // o que é útil para comparar os algoritmos.
            // --------------------------------------------------
            EventoFree free2 = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc3.ReferenciaBloco
            };

            free2.AtualizarDescricao();
            executor.Eventos.Add(free2);


            // --------------------------------------------------
            // 8 - malloc: int[2]
            //
            // Aqui First-Fit, Best-Fit e Worst-Fit podem
            // selecionar blocos diferentes.
            // --------------------------------------------------
            EventoMalloc malloc5 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Int,
                Quantidade = 2
            };

            malloc5.AtualizarDescricao();
            executor.Eventos.Add(malloc5);


            // --------------------------------------------------
            // 9 - realloc do bloco5 para int[2]
            //
            // O bloco foi criado como int[8], então aqui temos
            // uma redução considerável e possibilidade de split.
            // --------------------------------------------------
            EventoRealloc realloc1 = new EventoRealloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc4.ReferenciaBloco,
                TipoVariavel = malloc4.TipoVariavel,
                NovaQuantidade = 2
            };

            realloc1.AtualizarDescricao();
            executor.Eventos.Add(realloc1);


            // --------------------------------------------------
            // 10 - realloc do bloco1 aumentando.
            //
            // Dependendo da disposição atual dos blocos,
            // poderá expandir para a direita ou precisar mover.
            // --------------------------------------------------
            EventoRealloc realloc2 = new EventoRealloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc1.ReferenciaBloco,
                TipoVariavel = malloc1.TipoVariavel,
                NovaQuantidade = 12
            };

            realloc2.AtualizarDescricao();
            executor.Eventos.Add(realloc2);


            // --------------------------------------------------
            // 11 - free do calloc
            // Ajuda a testar liberação e coalescing.
            // --------------------------------------------------
            EventoFree free3 = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = calloc1.ReferenciaBloco
            };

            free3.AtualizarDescricao();
            executor.Eventos.Add(free3);


            // --------------------------------------------------
            // 12 - calloc: char[12]
            // Nova alocação após vários frees/reallocs.
            // --------------------------------------------------
            EventoCalloc calloc2 = new EventoCalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 12
            };

            calloc2.AtualizarDescricao();
            executor.Eventos.Add(calloc2);


            AtualizarListaEventos();
        }

        private void InicializarEventosTesteErros()
        {
            executor.Eventos.Clear();

            proximaReferenciaBloco = 1;

            /*
             * Executar com heap de 64 bytes.
             *
             * Recomendado:
             * Split = habilitado
             * Coalescing = desabilitado
             *
             * Objetivo:
             * testar falhas de malloc, calloc, realloc
             * e comportamento do free após falha de alocação.
             */

            // --------------------------------------------------
            // 1 - malloc: char[8]
            // Total aproximado do bloco: 16 bytes.
            // --------------------------------------------------
            EventoMalloc malloc1 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 8
            };

            malloc1.AtualizarDescricao();
            executor.Eventos.Add(malloc1);


            // --------------------------------------------------
            // 2 - malloc: char[8]
            // Outro bloco de aproximadamente 16 bytes.
            // --------------------------------------------------
            EventoMalloc malloc2 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 8
            };

            malloc2.AtualizarDescricao();
            executor.Eventos.Add(malloc2);


            // --------------------------------------------------
            // 3 - malloc: char[8]
            // Outro bloco de aproximadamente 16 bytes.
            // --------------------------------------------------
            EventoMalloc malloc3 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 8
            };

            malloc3.AtualizarDescricao();
            executor.Eventos.Add(malloc3);


            // --------------------------------------------------
            // 4 - malloc: char[8]
            // Preenche praticamente toda a heap.
            //
            // Estado esperado:
            //
            // [bloco1][bloco2][bloco3][bloco4]
            //
            // --------------------------------------------------
            EventoMalloc malloc4 = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 8
            };

            malloc4.AtualizarDescricao();
            executor.Eventos.Add(malloc4);


            // --------------------------------------------------
            // 5 - malloc: char[1]
            //
            // ERRO ESPERADO:
            // falha de alocação por falta de espaço.
            //
            // Guarda a referência para testar um free depois.
            // --------------------------------------------------
            EventoMalloc mallocFalhaEspaco = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 1
            };

            mallocFalhaEspaco.AtualizarDescricao();
            executor.Eventos.Add(mallocFalhaEspaco);


            // --------------------------------------------------
            // 6 - free(bloco2)
            //
            // Libera 16 bytes no meio da heap.
            // --------------------------------------------------
            EventoFree free1 = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc2.ReferenciaBloco
            };

            free1.AtualizarDescricao();
            executor.Eventos.Add(free1);


            // --------------------------------------------------
            // 7 - free(bloco4)
            //
            // Libera outros 16 bytes.
            //
            // Com coalescing desabilitado:
            //
            // [ocupado][LIVRE][ocupado][LIVRE]
            //
            // Total livre = 32 bytes
            // Maior bloco livre = 16 bytes
            // --------------------------------------------------
            EventoFree free2 = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc4.ReferenciaBloco
            };

            free2.AtualizarDescricao();
            executor.Eventos.Add(free2);


            // --------------------------------------------------
            // 8 - malloc: char[16]
            //
            // Payload = 16 bytes.
            // Total necessário será maior que 16 bytes.
            //
            // ERRO ESPERADO:
            // fragmentação externa.
            //
            // Existem 32 bytes livres no total,
            // mas o maior bloco livre possui apenas 16 bytes.
            // --------------------------------------------------
            EventoMalloc mallocFalhaFragmentacao = new EventoMalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 16
            };

            mallocFalhaFragmentacao.AtualizarDescricao();
            executor.Eventos.Add(mallocFalhaFragmentacao);


            // --------------------------------------------------
            // 9 - calloc: char[40]
            //
            // ERRO ESPERADO:
            // falha de calloc por falta de espaço.
            // --------------------------------------------------
            EventoCalloc callocFalha = new EventoCalloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = proximaReferenciaBloco++,
                TipoVariavel = TiposDeVariaveis.Char,
                Quantidade = 40
            };

            callocFalha.AtualizarDescricao();
            executor.Eventos.Add(callocFalha);


            // --------------------------------------------------
            // 10 - realloc(bloco1, char[40])
            //
            // bloco1 continua ocupado.
            //
            // Não existe espaço contíguo suficiente
            // para expandir e também não existe outro
            // bloco livre suficientemente grande.
            //
            // ERRO ESPERADO:
            // falha de realloc.
            //
            // IMPORTANTE:
            // bloco1 deve continuar alocado após a falha.
            // --------------------------------------------------
            EventoRealloc reallocFalha = new EventoRealloc
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc1.ReferenciaBloco,
                TipoVariavel = malloc1.TipoVariavel,
                NovaQuantidade = 40
            };

            reallocFalha.AtualizarDescricao();
            executor.Eventos.Add(reallocFalha);


            // --------------------------------------------------
            // 11 - free da referência cuja alocação falhou
            //
            // mallocFalhaEspaco nunca gerou um bloco real.
            //
            // Atualmente seu Executor deve simplesmente
            // ignorar esse free.
            //
            // Conceitualmente equivale a free(NULL).
            // --------------------------------------------------
            EventoFree freeAposMallocFalho = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = mallocFalhaEspaco.ReferenciaBloco
            };

            freeAposMallocFalho.AtualizarDescricao();
            executor.Eventos.Add(freeAposMallocFalho);


            // --------------------------------------------------
            // 12 - free(bloco1)
            //
            // Caso normal após o realloc ter falhado.
            //
            // Este evento é importante para confirmar que
            // bloco1 permaneceu válido após a falha do realloc.
            // --------------------------------------------------
            EventoFree freeBlocoOriginalRealloc = new EventoFree
            {
                Id = executor.Eventos.Count + 1,
                ReferenciaBloco = malloc1.ReferenciaBloco
            };

            freeBlocoOriginalRealloc.AtualizarDescricao();
            executor.Eventos.Add(freeBlocoOriginalRealloc);


            AtualizarListaEventos();
        }

        #endregion

        /*  ====================================
         *  FUNÇÕES AUXILIARES
         *  ====================================
         */

        #region Funções Auxiliares de Eventos e Lógica de Verificação
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

        private void NavegarParaSnapshot(int indiceDestino)
        {
            if (executor.Snapshots.Count == 0) return;

            indiceDestino = Math.Clamp(indiceDestino, 0, executor.Snapshots.Count - 1);

            bool avancar = indiceDestino > snapshotAtual;

            if (avancar)
            {
                for (int i = snapshotAtual + 1; i <= indiceDestino; i++)
                {
                    if (executor.Snapshots[i].Erro is not null)
                    {
                        indiceDestino = i;
                        break;
                    }
                }
            }

            snapshotAtual = indiceDestino;
            MostrarSnapshotAtual(avancar);
        }

        private void MostrarSnapshotAtual(bool exibirErro = false)
        {
            if (executor.Snapshots.Count == 0)
            {
                AtualizarLabelPassoAtual();
                return;
            }

            HeapSnapshot snapshot = executor.Snapshots[snapshotAtual];

            HeapGrid.DefinirSnapshot(snapshot);

            AtualizarListaBlocosLivres(snapshot);

            DestacarEventoAtual(snapshot);
            DestacarBlocoLivreAtual(snapshot);

            string strBlocoEmAnalise = snapshot.EnderecoBlocoEmAnalise is null ? "" : $"Endereço Bloco em Análise: {snapshot.EnderecoBlocoEmAnalise}\n";
            string strMelhorBloco = snapshot.EnderecoMelhorBloco is null ? "" : $"Endereço Melhor Bloco: {snapshot.EnderecoMelhorBloco}\n";
            string strDescricaoPasso = snapshot.DescricaoPasso == snapshot.DescricaoEvento ? "" : $"    -    Descrição Passo: {snapshot.DescricaoPasso}";
            //string text = $"Evento: {snapshot.DescricaoEvento}\n{strDescricaoPasso}{strBlocoEmAnalise}{strMelhorBloco}";
            string text = $"Evento: {snapshot.DescricaoEvento}{strDescricaoPasso}";
            Lbl_SnapshotAtual.Text = text;

            AtualizarLabelPassoAtual();

            AtualizarMetricas(snapshot.Metricas);

            if (exibirErro && snapshot.Erro is not null)
            {
                AvisoFalhaAlocacaoForm aviso = new AvisoFalhaAlocacaoForm(snapshot.Erro);
                aviso.ShowDialog(this);
            }
        }

        private void AtualizarLabelPassoAtual()
        {
            int totalSnapshots = executor.Snapshots.Count == 0 ? 0 : executor.Snapshots.Count - 1;
            Lbl_PassoAtual.Text = $"Passo Atual: {snapshotAtual}/{totalSnapshots}";
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

            foreach (EventoHeap evento in executor.Eventos)
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

            return ativas.Values.OrderBy(x => x.Id).ToList();
        }

        private void ReorganizarIdsEventos()
        {
            for (int i = 0; i < executor.Eventos.Count; i++)
            {
                executor.Eventos[i].Id = i + 1;
            }
        }

        private bool ValidarSequenciaEventos(out string mensagemErro)
        {
            HashSet<int> referenciasAtivas = new();

            for (int i = 0; i < executor.Eventos.Count; i++)
            {
                EventoHeap evento = executor.Eventos[i];

                switch (evento)
                {
                    case EventoMalloc malloc:
                        {
                            referenciasAtivas.Add(malloc.ReferenciaBloco);
                            break;
                        }

                    case EventoCalloc calloc:
                        {
                            referenciasAtivas.Add(calloc.ReferenciaBloco);
                            break;
                        }

                    case EventoFree free:
                        {
                            if (!referenciasAtivas.Contains(free.ReferenciaBloco))
                            {
                                mensagemErro =
                                    $"Evento {i + 1} inválido:\r\n\r\n" +
                                    $"{free.Descricao}\r\n\r\n" +
                                    $"O bloco{free.ReferenciaBloco} ainda não foi alocado " +
                                    $"ou já foi liberado.";

                                return false;
                            }

                            referenciasAtivas.Remove(free.ReferenciaBloco);

                            break;
                        }

                    case EventoRealloc realloc:
                        {
                            if (!referenciasAtivas.Contains(realloc.ReferenciaBloco))
                            {
                                mensagemErro =
                                    $"Evento {i + 1} inválido:\r\n\r\n" +
                                    $"{realloc.Descricao}\r\n\r\n" +
                                    $"O bloco{realloc.ReferenciaBloco} ainda não foi alocado " +
                                    $"ou já foi liberado.";

                                return false;
                            }

                            // Realloc mantém a referência ativa.
                            break;
                        }
                }
            }

            mensagemErro = string.Empty;

            return true;
        }

        public void AtualizarMetricas(MetricasHeap metricas)
        {
            //this.LblBlocosInutilizaveis.Visible = false;
            //this.Lbl_MemInutilizavel.Visible = false;
            //this.Lbl_PercentualInutilizavel.Visible = false;
            //this.Btn_HelpMemoriaInutilizavel.Visible = false;

            if (metricas is null)
                return;

            // ============================================
            // Uso da memória
            // ============================================

            Lbl_BytesOcupados.Text = $"Bytes ocupados: {metricas.BytesOcupados} bytes";

            Lbl_BytesLivres.Text = $"Bytes livres: {metricas.BytesLivres} bytes";

            //Lbl_UsoHeap.Text =
            //    $"Uso da heap: {metricas.PercentualUsoMemoria:F2}%";

            CircularProgressUsoHeap.Percentual = metricas.PercentualUsoMemoria;

            // ============================================
            // Fragmentação interna
            // ============================================

            Lbl_BytesFragInterna.Text = $"Bytes de fragmentação interna: {metricas.BytesFragmentacaoInterna} bytes";

            //Lbl_FragInterna.Text =
            //    $"Fragmentação interna: {metricas.PercentualFragmentacaoInterna:F2}%";

            Lbl_Padding.Text = $"Bytes de preenchimento (padding): {metricas.BytesPadding} bytes";

            CircularProgressFragExterna.Percentual = metricas.PercentualFragmentacaoExterna;
            CircularProgressFragInterna.Percentual = metricas.PercentualFragmentacaoInterna;

            // ============================================
            // Fragmentação externa
            // ============================================

            //Lbl_FragExterna.Text =
            //    $"Fragmentação externa: {metricas.PercentualFragmentacaoExterna:F2}%";

            Lbl_MaiorBlocoLivre.Text = $"Maior bloco livre: {metricas.TamanhoMaiorBlocoLivre} bytes";


            // ============================================
            // Memória inutilizável
            // ============================================

            //Lbl_MemInutilizavel.Text =
            //    $"Bytes inutilizáveis: {metricas.BytesInutilizaveis} bytes";

            //Lbl_PercentualInutilizavel.Text =
            //    $"Memória inutilizável: {metricas.PercentualMemoriaInutilizavel:F2}%";

            //LblBlocosInutilizaveis.Text =
            //    $"Blocos inutilizáveis: {metricas.QuantidadeBlocosInutilizaveis}";


            // ============================================
            // Metadados
            // ============================================

            Lbl_Metadados.Text =$"Bytes de metadados: {metricas.BytesMetadados} bytes";
        }

        private void CarregarCasoPredefinido()
        {
            executor.Eventos.Clear();
            switch (casoSelecionado)
            {
                case CasoUsoSimulacao.Nenhum:
                    break;
                case CasoUsoSimulacao.NotasEFaltas:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoNotasEFaltas());
                    break;
                case CasoUsoSimulacao.DuasProvas:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoDuasProvas());
                    break;
                case CasoUsoSimulacao.RedimensionamentoTurma:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoRedimensionamentoTurma());
                    break;
                case CasoUsoSimulacao.AltaFragInterna:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoAltaFragmentacaoInterna());
                    break;
                case CasoUsoSimulacao.AltaFragExterna:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoAltaFragmentacaoExterna());
                    break;
                case CasoUsoSimulacao.AlocacoesDiferentes:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoAlocacoesDiferentes());
                    break;
                case CasoUsoSimulacao.Mediana:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoMediana());
                    break;
                case CasoUsoSimulacao.SubtracaoVetores:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoSubtracaoVetores());
                    break;
                case CasoUsoSimulacao.Letras:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoLetras());
                    break;
                case CasoUsoSimulacao.Digitos:
                    executor.Eventos.AddRange(CasosDeUso.CriarCasoDigitos());
                    break;
                default:
                    break;
            }

            AtualizarListaEventos();

        }

        private void BloquearOperacoesParaCasosDeUso()
        {
            if (casoSelecionado == CasoUsoSimulacao.Nenhum)
            {
                this.FlowPanelOperacoes.Enabled = true;
                this.Panel_OpcoesEventos.Enabled = true;
            }
            else
            {
                this.FlowPanelOperacoes.Enabled = false;
                this.Panel_OpcoesEventos.Enabled = false;
            }

            if (casoSelecionado == CasoUsoSimulacao.AltaFragInterna || casoSelecionado == CasoUsoSimulacao.AltaFragExterna)
            {
                if (casoSelecionado == CasoUsoSimulacao.AltaFragInterna) SelectHeapSize.SelectedItem = SelectHeapSize.Items[0];
                else if (casoSelecionado == CasoUsoSimulacao.AltaFragExterna) SelectHeapSize.SelectedItem = SelectHeapSize.Items[1];
                this.SelectHeapSize.Enabled = false;
            }
            else
            {
                this.SelectHeapSize.Enabled = true;
            }
        }

        private void TrocarAba(int index)
        {
            this.MenuTabControl.SelectedIndex = index;

            Btn_TabSimulacao.Selecionado = MenuTabControl.SelectedIndex == 0;
            Btn_TabMetricas.Selecionado = MenuTabControl.SelectedIndex == 1;
            Btn_TabConfiguracoes.Selecionado = MenuTabControl.SelectedIndex == 2;
        }

        private void ResetarLabelEventoAtual()
        {
            this.Lbl_SnapshotAtual.Text = "Nenhum Evento em Andamento";
        }

        private void AtualizarLabelConfiguracaoAtual()
        {
            string heapSize = SelectHeapSize.SelectedItem switch
            {
                TamanhosHeap.Heap64 => "64 bytes",
                TamanhosHeap.Heap256 => "256 bytes",
                TamanhosHeap.Heap1K => "1 KB",
                TamanhosHeap.Heap4K => "4 KB",
                TamanhosHeap.Heap8K => "8 KB",
                _ => "N/A"
            };

            string algoritmo = "N/A";

            if (UseFirstFit.Checked) algoritmo = "First-Fit";
            else if (UseBestFit.Checked) algoritmo = "Best-Fit";
            else if (UseWorstFit.Checked) algoritmo = "Worst-Fit";

            string texto = $"Heap: {heapSize}  |  " +
                $"Algoritmo: {algoritmo}  |  " +
                $"Split: {(HabilitarSplit.Checked ? "Ativo" : "Inativo")}  |  " +
                $"Coalescing: {(HabilitarCoalesing.Checked ? "Ativo" : "Inativo")}  |  " +
                $"Visualização: {(HabilitarVisualizacaoAvancada.Checked ? "Avançada" : "Padrão")}";

            Lbl_ConfiguracoesAtuais.Text = texto;
        }
        #endregion
    }
}
