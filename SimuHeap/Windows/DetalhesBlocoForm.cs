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
    public partial class DetalhesBlocoForm : Form
    {
        private readonly BlocoDeMemoria bloco;
        private readonly InformacaoAlocacaoBloco? informacaoAlocacao;
        public DetalhesBlocoForm(BlocoDeMemoria bloco, InformacaoAlocacaoBloco? informacaoAlocacao)
        {
            InitializeComponent();
            this.Text = bloco.EstaLivre ? $"Detalhes do Bloco Livre #{bloco.Id}" : $"Detalhes do Bloco Alocado #{bloco.Id}";
            this.BackColor = bloco.EstaLivre ? Color.ForestGreen : Color.Firebrick;
            this.bloco = bloco;
            this.informacaoAlocacao = informacaoAlocacao;

            Controle_BlocoDetalhes.RegiaoClicada += Controle_BlocoDetalhes_RegiaoClicada;

            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            Controle_BlocoDetalhes.Bloco = bloco;

            lblTitulo.Text = bloco.EstaLivre ? $"Bloco Livre #{bloco.Id}" : $"Bloco Alocado #{bloco.Id}";

            string info = "";

            info += $"Estado: {(bloco.EstaLivre ? "Livre" : "Alocado")}\r\n";
            info += $"ID do bloco: #{bloco.Id}\r\n";

            if (!bloco.EstaLivre)
            {
                info += $"Tipo de dado: {bloco.TipoDado}\r\n";
            }

            info += $"Endereço inicial: {bloco.EnderecoInicio} (0x{bloco.EnderecoInicio:X})\r\n";
            info += $"Endereço final: {bloco.EnderecoFim} (0x{bloco.EnderecoFim:X})\r\n";

            info += "\r\n";

            info += $"Tamanho total: {bloco.TamanhoTotal} bytes\r\n";
            info += $"Header: {bloco.TamanhoHeader} bytes\r\n";

            if (bloco.EstaLivre)
            {
                info += $"Espaço livre: {bloco.TamanhoPayload} bytes\r\n";
            }
            else
            {
                info += $"Payload: {bloco.TamanhoPayload} bytes\r\n";
                info += $"Padding: {bloco.TamanhoPadding} bytes\r\n";
            }

            info += $"Footer: {bloco.TamanhoFooter} bytes";

            string info2 = "";
            if (informacaoAlocacao is not null)
            {
                info2 += $"Referência: bloco{informacaoAlocacao.ReferenciaBloco}\r\n";
                info2 += $"Operação: {informacaoAlocacao.TipoOperacao}\r\n";
                info2 += $"Evento: #{informacaoAlocacao.IdEvento}\r\n";
                info2 += $"Origem: {informacaoAlocacao.DescricaoOperacao}";
            }

            lblInformacoes.Text = info;
            lblInformacoes2.Text = info2;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            MostrarAvisoExplicativo("Header do bloco", texto);
        }

        private void MostrarInformacaoPayload()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoPayload(bloco, informacaoAlocacao);
            MostrarAvisoExplicativo("Payload do bloco", texto);
        }

        private void MostrarInformacaoPadding()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoPadding(bloco);
            MostrarAvisoExplicativo("Padding do bloco", texto);
        }

        private void MostrarInformacaoFooter()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoFooter(bloco);
            MostrarAvisoExplicativo("Footer do bloco", texto);
        }

        private void MostrarInformacaoBlocoLivre()
        {
            string texto = ExplicacoesConceitos.ObterExplicacaoBlocoLivre(bloco);
            MostrarAvisoExplicativo("Região livre", texto);
        }
    }
}
