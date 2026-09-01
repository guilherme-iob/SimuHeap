using SimuHeap.Enums;
using SimuHeap.Models;
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

namespace SimuHeap.Controls
{
    public partial class BlocoDetalhesControl : UserControl
    {
        private BlocoDeMemoria? bloco;
        private byte[] memoria = Array.Empty<byte>();

        private const int CellSize = StyleHeap.TamanhoCelula;

        private int columns = 1;
        private int rows = 1;

        public event EventHandler<RegiaoBlocoMemoria>? RegiaoClicada;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BlocoDeMemoria? Bloco
        {
            get => bloco;
            set
            {
                bloco = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public byte[] Memoria
        {
            get => memoria;
            set
            {
                memoria = value ?? Array.Empty<byte>();
                Invalidate();
            }
        }

        public BlocoDetalhesControl()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;

            BackColor = Color.FromArgb(30, 30, 30);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Bloco is null || Memoria.Length == 0)
                return;

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            for (int endereco = Bloco.EnderecoInicio; endereco <= Bloco.EnderecoFim; endereco++)
            {
                if (endereco < 0 || endereco >= Memoria.Length)
                    continue;

                int indiceLocal = endereco - Bloco.EnderecoInicio;
                int coluna = indiceLocal % columns;
                int linha = indiceLocal / columns;

                int x = coluna * CellSize;
                int y = linha * CellSize;

                Rectangle r = new Rectangle(x, y, CellSize, CellSize);

                RegiaoBlocoMemoria regiao = Bloco.ObterRegiao(endereco);

                Color corFundo = CoresSimulacao.ObterCorRegiao(Bloco, regiao);

                Brush corTexto = RenderizadorControlesHeap.ObterCorTexto(Bloco, regiao);

                string texto;

                if(Bloco.EstaLivre && regiao == RegiaoBlocoMemoria.Livre)
                {
                    texto = "??";
                }
                else
                {
                    texto = Memoria[endereco].ToString("X2");
                }

                string? id = null;
                Brush? corId = null;

                if(endereco == Bloco.EnderecoInicio)
                {
                    id = Bloco.EstaLivre ? $"L#{Bloco.Id}" : $"#{Bloco.Id}";
                    corId = Bloco.EstaLivre ? Brushes.White : Brushes.Yellow;
                }

                RenderizadorControlesHeap.DesenharCelula(e.Graphics, r, corFundo, corTexto, texto, id, corId, CellSize);
            }
        }

        public void AjustarTamanho(int larguraDisponivel)
        {
            if (Bloco is null || larguraDisponivel <= 0) return;

            
            columns = Math.Max(1, larguraDisponivel / CellSize);
            rows = (int)Math.Ceiling((double)Bloco.TamanhoTotal / columns);
            Width = columns * CellSize;
            Height = rows * CellSize;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left || Bloco is null)
                return;

            int coluna = e.X / CellSize;
            int linha = e.Y / CellSize;

            int indiceLocal = linha * columns + coluna;

            if (indiceLocal < 0 || indiceLocal >= Bloco.TamanhoTotal) return;

            int endereco = Bloco.EnderecoInicio + indiceLocal;

            RegiaoBlocoMemoria regiao = Bloco.ObterRegiao(endereco);

            RegiaoClicada?.Invoke(this, regiao);
        }
    }
}
