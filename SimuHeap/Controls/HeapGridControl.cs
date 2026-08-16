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
    public partial class HeapGridControl : UserControl
    {
        private int cellSize = 28;
        private int columns = 32;
        private int rows;

        private HeapSimulator? simulator;
        private HeapSnapshot? snapshot = null;

        private IEnumerable<BlocoDeMemoria> BlocosAtuais =>
                   snapshot?.Blocos ??
                   simulator?.Blocos ??
                   Enumerable.Empty<BlocoDeMemoria>();

        private byte[] MemoriaAtual =>
                snapshot?.Memoria ??
                simulator?.Memoria ??
                Array.Empty<byte>();

        private static readonly Color CorBlocoEmAnalise = Color.Gold;

        private static readonly Color CorMelhorBloco = Color.DeepSkyBlue;

        // Propriedades do controle

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HeapSimulator? Simulator
        {
            get => simulator;

            set
            {
                simulator = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        [Category("Configurações Visuais")]
        [DefaultValue(28)]
        public int CellSize
        {
            get => cellSize;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "O tamanho da célula deve ser maior que zero.");
                }

                cellSize = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        [Category("Configurações Visuais")]
        [DefaultValue(32)]
        public int Columns
        {
            get => columns;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "A quantidade de colunas deve ser maior que zero.");
                }

                columns = value;

                RecalculateDimensions();
                Invalidate();
            }
        }

        public HeapGridControl()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.FromArgb(30, 30, 30);
            Cursor = Cursors.Hand;
        }

        public void AtualizarVisualizacao()
        {
            RecalculateDimensions();
            Invalidate();
        }

        private void RecalculateDimensions()
        {
            if (cellSize <= 0 || columns <= 0)
            {
                return;
            }

            int tamanhoHeap = MemoriaAtual.Length;

            rows = tamanhoHeap == 0 ? 0 : (int)Math.Ceiling((double)tamanhoHeap / columns);

            Size = new Size(columns * cellSize, rows * cellSize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            byte[] memoria = MemoriaAtual;
            if (memoria.Length == 0 || columns <= 0 || rows <= 0)
            {
                return;
            }

            Graphics graphics = e.Graphics;

            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            using Pen gridPen = new Pen(Color.FromArgb(45, 45, 45), 1f);

            using Font hexFont = new Font("Consolas", Math.Max(6f, cellSize * 0.32f), FontStyle.Regular);

            using Font idFont = new Font( "Segoe UI", Math.Max(6f, cellSize * 0.25f), FontStyle.Bold);

            using StringFormat centerFormat =
                new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

            foreach (BlocoDeMemoria bloco in BlocosAtuais)
            {
                DesenharBloco(
                    graphics,
                    bloco,
                    gridPen,
                    hexFont,
                    idFont,
                    centerFormat);
            }
        }

        private void DesenharBloco(
            Graphics graphics,
            BlocoDeMemoria bloco,
            Pen gridPen,
            Font hexFont,
            Font idFont,
            StringFormat centerFormat)
        {
            byte[] memoria = MemoriaAtual;

            for (int endereco = bloco.EnderecoInicio; endereco <= bloco.EnderecoFim; endereco++)
            {
                if (endereco < 0 ||
                    endereco >= memoria.Length)
                {
                    continue;
                }

                int coluna = endereco % columns;
                int linha = endereco / columns;

                int x = coluna * cellSize;
                int y = linha * cellSize;

                Rectangle cellRectangle =
                    new Rectangle(
                        x,
                        y,
                        cellSize,
                        cellSize);

                RegiaoBlocoMemoria regiao = bloco.ObterRegiao(endereco);

                Color corFundo = ObterCorVisual(bloco, regiao);

                using SolidBrush backgroundBrush = new SolidBrush(corFundo);

                graphics.FillRectangle(backgroundBrush, cellRectangle);

                graphics.DrawRectangle(gridPen, cellRectangle);

                string texto = ObterTextoCelula(bloco, endereco);

                Brush textBrush = ObterCorTexto(bloco, regiao);

                graphics.DrawString(
                    texto,
                    hexFont,
                    textBrush,
                    cellRectangle,
                    centerFormat);

                if (endereco == bloco.EnderecoInicio)
                {
                    string identificador = bloco.EstaLivre ? $"L#{bloco.Id}" : $"#{bloco.Id}";

                    Brush corId = bloco.EstaLivre ? Brushes.White : Brushes.Yellow;

                    graphics.DrawString(
                        identificador,
                        idFont,
                        corId,
                        x + 2,
                        y + 1);
                }
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
            RegiaoBlocoMemoria regiao = bloco.ObterRegiao(endereco);

            if (bloco.EstaLivre && regiao == RegiaoBlocoMemoria.Livre)
            {
                return "??";
            }

            return MemoriaAtual[endereco].ToString("X2");
        }

        private static Brush ObterCorTexto(BlocoDeMemoria bloco, RegiaoBlocoMemoria regiao)
        {
            if (bloco.EstaLivre)
            {
                switch (regiao)
                {
                    case RegiaoBlocoMemoria.Header:
                        return Brushes.White;
                    case RegiaoBlocoMemoria.Footer:
                        return Brushes.White;
                    default:
                        return Brushes.Black;
                }
            }

            return regiao switch
            {
                RegiaoBlocoMemoria.Padding => Brushes.Black,

                _ => Brushes.White
            };
        }

        public void DefinirSnapshot(HeapSnapshot novoSnapshot)
        {
            snapshot = novoSnapshot ?? throw new ArgumentNullException(nameof(novoSnapshot));
            RecalculateDimensions();
            Invalidate();
        }

        public void LimparSnapshot()
        {
            snapshot = null;
            RecalculateDimensions();
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left) return;

            if (cellSize <= 0 || columns <= 0) return;

            // linha e coluna clicada
            int coluna = e.X / cellSize;
            int linha = e.Y / cellSize;

            int endereco = linha * columns + coluna;

            if (endereco < 0 || endereco >= MemoriaAtual.Length) return;

            BlocoDeMemoria? blocoClicado = BlocosAtuais.FirstOrDefault(x => x.ContemEndereco(endereco));

            if (blocoClicado is null) return;

            InformacaoAlocacaoBloco? informacao = null;

            if (snapshot is not null)
            {
                snapshot.InformacoesAlocacao.TryGetValue(blocoClicado.Id, out informacao);
            }

            using DetalhesBlocoForm form = new DetalhesBlocoForm(blocoClicado, informacao);

            form.ShowDialog(this);
        }
    }
}