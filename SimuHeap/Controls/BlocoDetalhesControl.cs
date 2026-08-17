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

        public event EventHandler<RegiaoBlocoMemoria>? RegiaoClicada;
        private readonly Dictionary<RegiaoBlocoMemoria, Rectangle> areasRegioes = new();

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

        public BlocoDetalhesControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            BackColor = Color.FromArgb(30, 30, 30);

            Height = 100;

            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            areasRegioes.Clear();

            if (Bloco is null)
                return;

            Graphics graphics = e.Graphics;

            int margem = 0;

            int xInicial = margem;
            int yInicial = margem;

            int larguraDisponivel = Width - (margem * 2);
            int alturaBloco = Height - (margem * 2);

            if (larguraDisponivel <= 0 || alturaBloco <= 0)
                return;

            using Pen borda = new Pen(
                Color.FromArgb(45, 45, 45),
                1f);

            using Font fonte = new Font(
                "Consolas",
                9f,
                FontStyle.Regular);

            using StringFormat formatoCentralizado =
                new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

            if (Bloco.EstaLivre)
            {
                DesenharBlocoLivre(
                    graphics,
                    borda,
                    fonte,
                    formatoCentralizado,
                    xInicial,
                    yInicial,
                    larguraDisponivel,
                    alturaBloco);
            }
            else
            {
                DesenharBlocoOcupado(
                    graphics,
                    borda,
                    fonte,
                    formatoCentralizado,
                    xInicial,
                    yInicial,
                    larguraDisponivel,
                    alturaBloco);
            }
        }

        private void DesenharBlocoOcupado(
    Graphics graphics,
    Pen borda,
    Font fonte,
    StringFormat formato,
    int xInicial,
    int yInicial,
    int larguraDisponivel,
    int altura)
        {
            if (Bloco is null)
                return;

            int x = xInicial;

            int larguraHeader = 70;
            int larguraFooter = 70;

            int larguraDisponivelDados =
                larguraDisponivel -
                larguraHeader -
                larguraFooter;

            if (larguraDisponivelDados <= 0)
                return;

            int larguraMinima = 70;

            int tamanhoDados =
                Bloco.TamanhoPayload +
                Bloco.TamanhoPadding;

            int larguraPayload;
            int larguraPadding;

            if (Bloco.TamanhoPadding > 0)
            {
                larguraPayload = (int)Math.Round(
                    larguraDisponivelDados *
                    ((double)Bloco.TamanhoPayload / tamanhoDados));

                larguraPadding =
                    larguraDisponivelDados -
                    larguraPayload;

                if (larguraDisponivelDados >= larguraMinima * 2)
                {
                    larguraPayload = Math.Max(larguraPayload, larguraMinima);
                    larguraPadding = Math.Max(larguraPadding, larguraMinima);

                    // Corrige caso os mínimos tenham feito a soma ultrapassar
                    // a largura total disponível.
                    int excesso =
                        larguraPayload +
                        larguraPadding -
                        larguraDisponivelDados;

                    if (excesso > 0)
                    {
                        if (larguraPayload > larguraPadding)
                            larguraPayload -= excesso;
                        else
                            larguraPadding -= excesso;
                    }
                }
            }
            else
            {
                larguraPayload = larguraDisponivelDados;
                larguraPadding = 0;
            }

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraHeader,
                altura,
                "Header",
                Bloco.TamanhoHeader,
                CoresSimulacao.Escurecer(Bloco.Cor, 0.55f),
                Brushes.White,
                RegiaoBlocoMemoria.Header);

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraPayload,
                altura,
                "Payload",
                Bloco.TamanhoPayload,
                Bloco.Cor,
                Brushes.White,
                RegiaoBlocoMemoria.Payload);

            if (Bloco.TamanhoPadding > 0)
            {
                DesenharRegiaoComLargura(
                    graphics,
                    borda,
                    fonte,
                    formato,
                    ref x,
                    yInicial,
                    larguraPadding,
                    altura,
                    "Padding",
                    Bloco.TamanhoPadding,
                    CoresSimulacao.Clarear(Bloco.Cor, 0.55f),
                    Brushes.Black,
                    RegiaoBlocoMemoria.Padding);
            }

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraFooter,
                altura,
                "Footer",
                Bloco.TamanhoFooter,
                CoresSimulacao.Escurecer(Bloco.Cor, 0.55f),
                Brushes.White,
                RegiaoBlocoMemoria.Footer);
        }

        private void DesenharBlocoLivre(
            Graphics graphics,
            Pen borda,
            Font fonte,
            StringFormat formato,
            int xInicial,
            int yInicial,
            int larguraDisponivel,
            int altura)
        {
            if (Bloco is null)
                return;

            int x = xInicial;

            int larguraHeader = 70;
            int larguraFooter = 70;

            int larguraLivre =
                larguraDisponivel -
                larguraHeader -
                larguraFooter;

            if (larguraLivre <= 0)
                return;

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraHeader,
                altura,
                "Header",
                Bloco.TamanhoHeader,
                CoresSimulacao.Escurecer(Bloco.Cor, 0.55f),
                Brushes.White,
                RegiaoBlocoMemoria.Header);

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraLivre,
                altura,
                "Livre",
                Bloco.TamanhoPayload,
                Bloco.Cor,
                Brushes.Black,
                RegiaoBlocoMemoria.Livre);

            DesenharRegiaoComLargura(
                graphics,
                borda,
                fonte,
                formato,
                ref x,
                yInicial,
                larguraFooter,
                altura,
                "Footer",
                Bloco.TamanhoFooter,
                CoresSimulacao.Escurecer(Bloco.Cor, 0.55f),
                Brushes.White,
                RegiaoBlocoMemoria.Footer);
        }

        private void DesenharRegiaoComLargura(
            Graphics graphics,
            Pen borda,
            Font fonte,
            StringFormat formato,
            ref int x,
            int y,
            int largura,
            int altura,
            string descricao,
            int tamanhoRegiao,
            Color corFundo,
            Brush corTexto,
            RegiaoBlocoMemoria regiao)
        {
            Rectangle retangulo =
                new Rectangle(
                    x,
                    y,
                    largura,
                    altura);

            areasRegioes[regiao] = retangulo;

            using SolidBrush fundo =
                new SolidBrush(corFundo);

            graphics.FillRectangle(
                fundo,
                retangulo);

            graphics.DrawRectangle(
                borda,
                retangulo);

            string texto =
                $"{descricao}\n{tamanhoRegiao} B";

            graphics.DrawString(
                texto,
                fonte,
                corTexto,
                retangulo,
                formato);

            x += largura;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left)
                return;

            foreach (KeyValuePair<RegiaoBlocoMemoria, Rectangle> item in areasRegioes)
            {
                if (item.Value.Contains(e.Location))
                {
                    RegiaoClicada?.Invoke(this, item.Key);
                    return;
                }
            }
        }
    }
}
