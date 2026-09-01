using SimuHeap.Enums;
using SimuHeap.Models;
using SimuHeap.Services;
using SimuHeap.Utils;
using SimuHeap.Windows;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SimuHeap.Controls
{
    public partial class HeapGridControl : HeapBytesControl
    {
        private HeapSimulator? simulator;
        private HeapSnapshot? snapshot = null;
        private bool visualizacaoAvancada = false;
        private IEnumerable<BlocoDeMemoria> BlocosAtuais =>
                   snapshot?.Blocos ??
                   simulator?.Blocos ??
                   Enumerable.Empty<BlocoDeMemoria>();

        private byte[] MemoriaAtual =>
                snapshot?.Memoria ??
                simulator?.Memoria ??
                Array.Empty<byte>();

        protected override int QuantidadeBytes => MemoriaAtual.Length;

       

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HeapSimulator? Simulator
        {
            get => simulator;

            set
            {
                simulator = value;

                RecalcularDimensoes();
                Invalidate();
            }
        }

        [Category("Configurações Visuais")]
        [DefaultValue(false)]
        public bool UsarVisualizacaoAvancada
        {
            get => visualizacaoAvancada;
            set
            {
                visualizacaoAvancada = value;
                Invalidate();
            }
        }

        public HeapGridControl()
        {
            InitializeComponent();
        }

        public void AtualizarVisualizacao()
        {
            RecalcularDimensoes();
            Invalidate();
        }

        //private void RecalculateDimensions()
        //{
        //    if (cellSize <= 0 || columns <= 0)
        //    {
        //        return;
        //    }

        //    int tamanhoHeap = MemoriaAtual.Length;

        //    rows = tamanhoHeap == 0 ? 0 : (int)Math.Ceiling((double)tamanhoHeap / columns);

        //    Size = new Size(columns * cellSize, rows * cellSize);
        //}

        //public void AjustarTamanho(int larguraDisponivel)
        //{
        //    if (larguraDisponivel <= 0 || cellSize <= 0) return;


        //    columns = Math.Max(1, larguraDisponivel / cellSize);

        //    int tamanhoHeap = MemoriaAtual.Length;

        //    rows = tamanhoHeap == 0 ? 0 : (int)Math.Ceiling((double)tamanhoHeap / columns);

        //    Width = columns * cellSize;
        //    Height = rows * cellSize;

        //    Invalidate();
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            byte[] memoria = MemoriaAtual;

            if (memoria.Length == 0 || columns <= 0 || rows <= 0) return;
            

            Graphics graphics = e.Graphics;

            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            //using Pen gridPen = new Pen(Color.FromArgb(45, 45, 45), 1f);

            //using Font hexFont = new Font("Consolas", Math.Max(6f, cellSize * 0.32f), FontStyle.Regular);

            //using Font idFont = new Font( "Segoe UI", Math.Max(6f, cellSize * 0.25f), FontStyle.Bold);

            //using StringFormat centerFormat =
            //    new StringFormat
            //    {
            //        Alignment = StringAlignment.Center,
            //        LineAlignment = StringAlignment.Center
            //    };

            foreach (BlocoDeMemoria bloco in BlocosAtuais)
            {
                DesenharBloco(
                    graphics,
                    bloco);
            }
        }

        private void DesenharBloco(Graphics graphics, BlocoDeMemoria bloco)
        {
            byte[] memoria = MemoriaAtual;

            for (int endereco = bloco.EnderecoInicio; endereco <= bloco.EnderecoFim; endereco++)
            {
                if (endereco < 0 || endereco >= memoria.Length)
                {
                    continue;
                }

                Rectangle rectangle = ObterRetanguloCelula(endereco);
                RegiaoBlocoMemoria regiao = bloco.ObterRegiao(endereco);
                Color corFundo = ObterCorVisual(bloco, regiao);
                string texto = ObterTextoCelula(bloco, endereco);
                Brush corTexto = RenderizadorControlesHeap.ObterCorTexto(bloco, regiao);
                ObterId(bloco, endereco, out string? id, out Brush? corId);

                RenderizadorControlesHeap.DesenharCelula(
                    graphics,
                    rectangle,
                    corFundo,
                    corTexto,
                    texto,
                    id,
                    corId,
                    cellSize);
            }
        }

        private Color ObterCorVisual(BlocoDeMemoria bloco, RegiaoBlocoMemoria regiao)
        {
            if (snapshot != null)
            {
                if (snapshot.EnderecoMelhorBloco == bloco.EnderecoInicio && snapshot.DestaqueMelhorBloco != TipoDestaqueSimulacao.Nenhum)
                {
                    return CoresSimulacao.ObterCorDestaque(snapshot.DestaqueMelhorBloco);
                }

                if(snapshot.EnderecoBlocoSecundario == bloco.EnderecoInicio && snapshot.DestaqueBlocoSecundario != TipoDestaqueSimulacao.Nenhum)
                {
                    return CoresSimulacao.ObterCorDestaque(snapshot.DestaqueBlocoSecundario);
                }

                if (snapshot.EnderecoBlocoEmAnalise == bloco.EnderecoInicio && snapshot.DestaqueBlocoEmAnalise != TipoDestaqueSimulacao.Nenhum)
                {
                    return CoresSimulacao.ObterCorDestaque(snapshot.DestaqueBlocoEmAnalise);
                }
            }

            return CoresSimulacao.ObterCorRegiao(bloco,  regiao);
        }

        private string ObterTextoCelula(BlocoDeMemoria bloco, int endereco)
        {
            if (!visualizacaoAvancada) return string.Empty;

            RegiaoBlocoMemoria regiao = bloco.ObterRegiao(endereco);

            if (bloco.EstaLivre && regiao == RegiaoBlocoMemoria.Livre)
            {
                return "??";
            }

            return MemoriaAtual[endereco].ToString("X2");
        }

        public void DefinirSnapshot(HeapSnapshot novoSnapshot)
        {
            snapshot = novoSnapshot ?? throw new ArgumentNullException(nameof(novoSnapshot));
            RecalcularDimensoes();
            Invalidate();
        }

        public void LimparSnapshot()
        {
            snapshot = null;
            RecalcularDimensoes();
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left) return;

            if (cellSize <= 0 || columns <= 0) return;

            int endereco = ObterIndicePorCoordenada(e.Location);

            if (endereco < 0 || endereco >= MemoriaAtual.Length) return;

            BlocoDeMemoria? blocoClicado = BlocosAtuais.FirstOrDefault(x => x.ContemEndereco(endereco));

            if (blocoClicado is null) return;

            InformacaoAlocacaoBloco? informacao = null;

            if (snapshot is not null)
            {
                snapshot.InformacoesAlocacao.TryGetValue(blocoClicado.Id, out informacao);
            }

            byte[] copiaMemoria = (byte[])MemoriaAtual.Clone();
            using DetalhesBlocoForm form = new DetalhesBlocoForm(blocoClicado, informacao, copiaMemoria);

            form.ShowDialog(this);
        }
    }
}