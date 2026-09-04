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
    public partial class BlocoDetalhesControl : HeapBytesControl
    {
        private BlocoDeMemoria? bloco;
        private byte[] memoria = Array.Empty<byte>();

        public event EventHandler<RegiaoBlocoMemoria>? RegiaoClicada;

        protected override int QuantidadeBytes => Bloco?.TamanhoTotal ?? 0;

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

                Rectangle rectangle = ObterRetanguloCelula(indiceLocal);
                RegiaoBlocoMemoria regiao = Bloco.ObterRegiao(endereco);
                Color corFundo = CoresSimulacao.ObterCorRegiao(Bloco, regiao);
                Brush corTexto = RenderizadorControlesHeap.ObterCorTexto(Bloco, regiao);
                string texto = ObterTextoCelula(endereco, regiao);
                ObterId(Bloco, endereco, out string? id, out Brush? corId);
                id = string.Empty; // Não exibir o ID no detalhe do bloco
                RenderizadorControlesHeap.DesenharCelula(e.Graphics, rectangle, corFundo, corTexto, texto, id, corId, CellSize);
            }
        }

        private string ObterTextoCelula(int endereco,RegiaoBlocoMemoria regiao)
        {
            if (Bloco is null) return string.Empty;

            if (Bloco.EstaLivre && regiao == RegiaoBlocoMemoria.Livre)
            {
                return "??";
            }

            return Memoria[endereco].ToString("X2");
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left || Bloco is null)
                return;

            int indiceLocal = ObterIndicePorCoordenada(e.Location);
            if (indiceLocal < 0 || indiceLocal >= Bloco.TamanhoTotal) return;
            int endereco = Bloco.EnderecoInicio + indiceLocal;
            RegiaoBlocoMemoria regiao = Bloco.ObterRegiao(endereco);
            RegiaoClicada?.Invoke(this, regiao);
        }
    }
}
