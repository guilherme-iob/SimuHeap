using SimuHeap.Controls;
using SimuHeap.Data;
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

namespace SimuHeap.Windows
{
    public partial class NewDetalhesBlocoForm : Form
    {
        private readonly BlocoDeMemoria bloco;
        private readonly InformacaoAlocacaoBloco? informacaoAlocacao;
        private readonly byte[] memoria;

        private readonly BlocoDetalhesControl blocoDetalhesControl;

        public NewDetalhesBlocoForm(BlocoDeMemoria bloco, InformacaoAlocacaoBloco? informacaoAlocacao, byte[] memoria)
        {
            InitializeComponent();

            this.bloco = bloco;
            this.informacaoAlocacao = informacaoAlocacao;
            this.memoria = memoria;

            ConfigurarTituloJanela();

            blocoDetalhesControl = new BlocoDetalhesControl
            {
                Location = new Point(0, 0),
                Bloco = bloco,
                Memoria = memoria
            };

            blocoDetalhesControl.RegiaoClicada += Controle_BlocoDetalhes_RegiaoClicada;

            PanelBlocosDetalhes.Resize += PanelBlocosDetalhes_Resize;
            PanelBlocosDetalhes.AutoScroll = true;
            PanelBlocosDetalhes.Controls.Add(blocoDetalhesControl);

            blocoDetalhesControl.AjustarTamanho(PanelBlocosDetalhes.ClientSize.Width);

            ConfigurarGridValores();
            CarregarInformacoes();
            CarregarValoresPayload();
        }

        private void ConfigurarTituloJanela()
        {
            if (bloco.EstaLivre)
            {
                Text = $"Detalhes do Bloco Livre #{bloco.Id}";
                return;
            }

            string referencia = ObterNomeBloco();

            Text = $"Detalhes do Bloco Alocado — {referencia}";
        }

        private void CarregarInformacoes()
        {
            ConfigurarCabecalho();

            string infoEstrutura = MontarInformacoesEstrutura();
            string infoOrigem = MontarInformacoesOrigem();

            lblInformacoes.Text = infoEstrutura;
            lblInformacoes2.Text = infoOrigem;
        }

        private void ConfigurarCabecalho()
        {
            if (bloco.EstaLivre)
            {
                lblTitulo.Text = $"Bloco Livre #{bloco.Id}";

                StatusPillBloco.Text = "LIVRE";
                StatusPillBloco.FillColor = CoresInterface.LivreSuave;
                StatusPillBloco.BorderColor = CoresInterface.LivreBorda;
                StatusPillBloco.TextColorCustom = CoresInterface.LivreEscuro;

                ColorIndicatorBloco.FillColor = CoresInterface.Livre;
                ColorIndicatorBloco.BorderColor = CoresInterface.LivreEscuro;
            }
            else
            {
                lblTitulo.Text = bloco.EstaLivre ? $"Bloco Livre #{bloco.Id}" : $"Bloco Alocado — {ObterNomeBloco()}";

                StatusPillBloco.Text = "ALOCADO";
                StatusPillBloco.FillColor = CoresInterface.OcupadoSuave;
                StatusPillBloco.BorderColor = CoresInterface.OcupadoBorda;
                StatusPillBloco.TextColorCustom = CoresInterface.OcupadoEscuro;

                ColorIndicatorBloco.FillColor = CoresInterface.Ocupado;
                ColorIndicatorBloco.BorderColor = CoresInterface.OcupadoEscuro;
            }

            ColorIndicatorBloco.BorderSize = 1;
            ColorIndicatorBloco.BorderRadius = 6;
        }

        private string ObterNomeBloco()
        {
            if (!string.IsNullOrWhiteSpace(informacaoAlocacao?.NomeVariavel))
                return $"*{informacaoAlocacao.NomeVariavel}";

            if (informacaoAlocacao is not null)
                return $"*bloco{informacaoAlocacao.ReferenciaBloco}";

            return $"#{bloco.Id}";
        }

        private string MontarInformacoesEstrutura()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"Estado: {(bloco.EstaLivre ? "Livre" : "Alocado")}");
            info.AppendLine($"ID interno: #{bloco.Id}");

            if (!bloco.EstaLivre)
                info.AppendLine($"Tipo de dado: {bloco.TipoDado}");

            info.AppendLine($"Endereço inicial: {bloco.EnderecoInicio} (0x{bloco.EnderecoInicio:X})");
            info.AppendLine($"Endereço final: {bloco.EnderecoFim} (0x{bloco.EnderecoFim:X})");

            info.AppendLine();

            info.AppendLine($"Tamanho total: {bloco.TamanhoTotal} bytes");
            info.AppendLine($"Cabeçalho (header): {bloco.TamanhoHeader} bytes");

            if (bloco.EstaLivre)
            {
                info.AppendLine($"Espaço livre disponível: {bloco.TamanhoPayload} bytes");
            }
            else
            {
                info.AppendLine($"Área de dados (payload): {bloco.TamanhoPayload} bytes");
                info.AppendLine($"Preenchimento interno (padding): {bloco.TamanhoPadding} bytes");
            }

            info.Append($"Rodapé (footer): {bloco.TamanhoFooter} bytes");

            return info.ToString();
        }

        private string MontarInformacoesOrigem()
        {
            if (informacaoAlocacao is null)
                return string.Empty;

            StringBuilder info = new StringBuilder();

            info.AppendLine($"Referência: {ObterNomeBloco()}");
            info.AppendLine($"Operação: {informacaoAlocacao.TipoOperacao}");
            info.AppendLine($"Evento: #{informacaoAlocacao.IdEvento}");
            info.Append($"Origem: {informacaoAlocacao.DescricaoOperacao}");

            return info.ToString();
        }

        private void ConfigurarGridValores()
        {
            if (bloco.EstaLivre)
            {
                DataGridViewValores.Visible = false;
                return;
            }

            DataGridViewValores.Visible = true;
            DataGridViewValores.Columns.Clear();

            DataGridViewValores.Columns.Add("Indice", "Índice");
            DataGridViewValores.Columns.Add("Valor", "Valor");
            DataGridViewValores.Columns.Add("Bytes", "Bytes");
            DataGridViewValores.Columns.Add("Endereco", "Endereço");

            DataGridViewValores.Columns["Indice"].FillWeight = 20;
            DataGridViewValores.Columns["Valor"].FillWeight = 25;
            DataGridViewValores.Columns["Bytes"].FillWeight = 35;
            DataGridViewValores.Columns["Endereco"].FillWeight = 25;

            foreach (DataGridViewColumn coluna in DataGridViewValores.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CarregarValoresPayload()
        {
            DataGridViewValores.Rows.Clear();

            if (bloco.EstaLivre)
                return;

            if (bloco.TipoDado is not TiposDeVariaveis tipo)
                return;

            int tamanhoTipo = Configuracoes.ObterTamanhoTipo(tipo);

            if (tamanhoTipo <= 0)
                return;

            int quantidade = bloco.TamanhoPayload / tamanhoTipo;

            for (int i = 0; i < quantidade; i++)
            {
                int endereco = bloco.EnderecoPayload + (i * tamanhoTipo);

                ReadOnlySpan<byte> bytes = memoria.AsSpan(endereco, tamanhoTipo);

                object valor = ConversorValorBytes.ConverterBytesParaValor(bytes, tipo);
                string valorFormatado = ConversorValorBytes.FormatarValor(valor, tipo);
                string bytesFormatados = BitConverter.ToString(bytes.ToArray()).Replace("-", " ");

                DataGridViewValores.Rows.Add($"[{i}]", valorFormatado, bytesFormatados, $"0x{endereco:X}");
            }

            DataGridViewValores.ClearSelection();
        }

        private void Controle_BlocoDetalhes_RegiaoClicada(object? sender, RegiaoBlocoMemoria regiao)
        {
            switch (regiao)
            {
                case RegiaoBlocoMemoria.Header:
                    MostrarInformacaoHeader();
                    break;

                case RegiaoBlocoMemoria.Payload:
                    MostrarInformacaoPayload();
                    break;

                case RegiaoBlocoMemoria.Padding:
                    MostrarInformacaoPadding();
                    break;

                case RegiaoBlocoMemoria.Footer:
                    MostrarInformacaoFooter();
                    break;

                case RegiaoBlocoMemoria.Livre:
                    MostrarInformacaoBlocoLivre();
                    break;
            }
        }

        private void MostrarAvisoExplicativo(string titulo, string texto)
        {
            using AvisoExplicativoForm form = new AvisoExplicativoForm(titulo, texto);
            form.ShowDialog(this);
        }

        private void MostrarInformacaoHeader()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoHeader(bloco);
            MostrarAvisoExplicativo("Cabeçalho do bloco (header)", texto);
        }

        private void MostrarInformacaoPayload()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoPayload(bloco, informacaoAlocacao);
            MostrarAvisoExplicativo("Área de dados do bloco (payload)", texto);
        }

        private void MostrarInformacaoPadding()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoPadding(bloco);
            MostrarAvisoExplicativo("Preenchimento interno (padding)", texto);
        }

        private void MostrarInformacaoFooter()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoFooter(bloco);
            MostrarAvisoExplicativo("Rodapé do bloco (footer)", texto);
        }

        private void MostrarInformacaoBlocoLivre()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoBlocoLivre(bloco);
            MostrarAvisoExplicativo("Região livre", texto);
        }

        private void PanelBlocosDetalhes_Resize(object? sender, EventArgs e)
        {
            blocoDetalhesControl.AjustarTamanho(PanelBlocosDetalhes.ClientSize.Width);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
