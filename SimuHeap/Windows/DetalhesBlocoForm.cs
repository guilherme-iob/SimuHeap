using SimuHeap.Data;
using SimuHeap.Enums;
using SimuHeap.Models;
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

        private void MostrarInformacaoHeader()
        {
            uint tamanho = (uint)bloco.TamanhoTotal;

            uint valorHeader = bloco.EstaLivre
                ? tamanho
                : tamanho | Configuracoes.FLAG_OCUPADO;

            string estado = bloco.EstaLivre
                ? "Livre"
                : "Ocupado";

            string calculoEstado = bloco.EstaLivre
                ? $"0x{tamanho:X8}"
                : $"0x{tamanho:X8} | 0x{Configuracoes.FLAG_OCUPADO:X8}";

            string texto =
                "HEADER\n\n" +

                "O header é uma região de metadados localizada no início do bloco. " +
                "Esses dados são utilizados internamente pelo gerenciador da heap e não fazem parte " +
                "da área de memória solicitada pelo programa.\n\n" +

                "Em implementações reais, o conteúdo e o tamanho do header podem variar. " +
                "Dependendo do alocador, ele pode armazenar tamanho do bloco, flags de estado, " +
                "informações sobre blocos vizinhos, classes de tamanho, ponteiros para estruturas auxiliares " +
                "e outros metadados de gerenciamento.\n\n" +

                $"NO SIMULADOR\n" +
                $"O header possui {Configuracoes.TAM_HEADER} bytes e armazena o tamanho total do bloco " +
                $"juntamente com uma flag que indica se ele está ocupado.\n\n" +

                $"Tamanho total: {bloco.TamanhoTotal} bytes (0x{tamanho:X8})\n" +
                $"Estado: {estado}\n" +
                $"FLAG_OCUPADO: 0x{Configuracoes.FLAG_OCUPADO:X8}\n\n" +

                $"Cálculo do header:\n" +
                $"{calculoEstado}\n" +
                $"Resultado: 0x{valorHeader:X8}\n\n" +

                $"Como os blocos do simulador são alinhados em {Configuracoes.TAM_ALINHAMENTO} bytes, " +
                "o bit menos significativo do tamanho normalmente está disponível para representar uma flag. " +
                "Neste modelo, o bit 0 é utilizado como FLAG_OCUPADO.";

            MessageBox.Show(
                texto,
                "Header do bloco",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MostrarInformacaoPayload()
        {
            string texto =
                "PAYLOAD\n\n" +

                "O payload é a região do bloco disponibilizada ao programa para armazenar os dados " +
                "solicitados pela operação de alocação. Diferentemente do header e do footer, " +
                "essa região pertence efetivamente à alocação solicitada pelo usuário.\n\n" +

                $"NO SIMULADOR\n" +
                $"Este bloco possui {bloco.TamanhoPayload} bytes de payload.\n";

            if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Malloc)
            {
                texto +=
                    "\nO bloco foi alocado por malloc.\n\n" +

                    "A função malloc reserva a região solicitada, mas não inicializa seu conteúdo. " +
                    "Portanto, os bytes do payload possuem valores indeterminados, podendo corresponder " +
                    "ao conteúdo anteriormente existente naquela região da memória.\n\n" +

                    "Para tornar esse comportamento visível, o simulador inicializa a heap com valores " +
                    "indeterminados simulados, em vez de zerar automaticamente a memória.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Calloc)
            {
                texto +=
                    "\nO bloco foi alocado por calloc.\n\n" +

                    "Diferentemente do malloc, o calloc inicializa com zero a região disponibilizada " +
                    "para os elementos solicitados.\n\n" +

                    $"Assim, os {bloco.TamanhoPayload} bytes do payload são inicialmente representados " +
                    "pelo simulador com valor 0x00.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Realloc)
            {
                texto +=
                    "\nO estado atual do bloco foi produzido por realloc.\n\n" +

                    "O realloc altera o tamanho de uma alocação existente. Quando necessário, " +
                    "o bloco pode ser expandido no próprio local ou movido para outra região da heap.\n\n" +

                    "O conteúdo existente é preservado até o menor valor entre o tamanho antigo " +
                    "e o novo tamanho solicitado. Se a alocação aumentar, a região adicional não é " +
                    "automaticamente inicializada com zero.";
            }
            else
            {
                texto +=
                    "\nO conteúdo inicial do payload depende da operação que originou a alocação.";
            }

            MessageBox.Show(
                texto,
                "Payload do bloco",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MostrarInformacaoPadding()
        {
            int tamanhoSemPadding =
                Configuracoes.TAM_HEADER +
                bloco.TamanhoPayload +
                Configuracoes.TAM_FOOTER;

            int paddingAlinhamento =
                Configuracoes.CalcularPadding(bloco.TamanhoPayload);

            int paddingAdicional =
                Math.Max(
                    0,
                    bloco.TamanhoPadding - paddingAlinhamento);

            string texto =
                "PADDING\n\n" +

                "Padding é uma região não utilizada pelo payload que pode ser adicionada ao bloco " +
                "para satisfazer requisitos de alinhamento de memória.\n\n" +

                "O alinhamento utilizado por um alocador real depende da arquitetura, da ABI " +
                "e da implementação do gerenciador de memória. Portanto, esse valor não é universal.\n\n" +

                $"NO SIMULADOR\n" +
                $"O alinhamento configurado é de {Configuracoes.TAM_ALINHAMENTO} bytes.\n\n" +

                "O padding necessário para alinhamento é calculado por:\n\n" +

                "padding = (alinhamento - (tamanhoSemPadding % alinhamento)) % alinhamento\n\n" +

                $"tamanhoSemPadding = Header + Payload + Footer\n" +
                $"tamanhoSemPadding = {Configuracoes.TAM_HEADER} + {bloco.TamanhoPayload} + {Configuracoes.TAM_FOOTER}\n" +
                $"tamanhoSemPadding = {tamanhoSemPadding} bytes\n\n" +

                $"padding = ({Configuracoes.TAM_ALINHAMENTO} - " +
                $"({tamanhoSemPadding} % {Configuracoes.TAM_ALINHAMENTO})) " +
                $"% {Configuracoes.TAM_ALINHAMENTO}\n" +

                $"padding de alinhamento = {paddingAlinhamento} bytes\n\n" +

                $"Padding representado atualmente no bloco: {bloco.TamanhoPadding} bytes.";

            if (paddingAdicional > 0)
            {
                texto +=
                    "\n\nNeste bloco existe ainda uma particularidade:\n\n" +

                    $"{paddingAdicional} bytes não são necessários para o alinhamento, mas permaneceram " +
                    "dentro do bloco porque a sobra era pequena demais para formar um novo bloco livre válido.\n\n" +

                    "Neste simulador, essa sobra interna também é contabilizada na propriedade TamanhoPadding. " +
                    "Ela representa espaço interno não aproveitado e contribui para a fragmentação interna.";
            }

            MessageBox.Show(
                texto,
                "Padding do bloco",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MostrarInformacaoFooter()
        {
            uint valorFooter =
                (uint)bloco.TamanhoTotal;

            string texto =
                "FOOTER\n\n" +

                "O footer é uma região de metadados localizada no final do bloco. " +
                "Uma técnica comum em gerenciamento de memória é utilizar informações nos limites " +
                "dos blocos para facilitar a localização de blocos adjacentes.\n\n" +

                "Nem todos os alocadores reais utilizam footer em todos os blocos. " +
                "A organização dos metadados depende da implementação; algumas estruturas conseguem " +
                "realizar o gerenciamento utilizando outras informações ou armazenando determinados " +
                "metadados apenas em blocos livres.\n\n" +

                $"NO SIMULADOR\n" +
                $"O footer possui {Configuracoes.TAM_FOOTER} bytes e armazena o tamanho total do bloco.\n\n" +

                $"Tamanho total do bloco: {bloco.TamanhoTotal} bytes\n" +
                $"Valor armazenado no footer: 0x{valorFooter:X8}\n\n" +

                "Diferentemente do header, o footer do simulador não armazena a FLAG_OCUPADO.\n\n" +

                "Ter o tamanho disponível no limite final do bloco auxilia na representação da " +
                "coalescência, pois permite identificar os limites dos blocos vizinhos e combinar " +
                "blocos livres adjacentes.";

            MessageBox.Show(
                texto,
                "Footer do bloco",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MostrarInformacaoBlocoLivre()
        {
            int tamanhoUtil =
                bloco.TamanhoPayload;

            string texto =
                "ESPAÇO LIVRE\n\n" +

                "Um bloco livre representa uma região da heap que não está atualmente associada " +
                "a uma alocação ativa e, portanto, pode ser reutilizada para atender futuras solicitações.\n\n" +

                $"NO SIMULADOR\n" +
                $"Este bloco possui {bloco.TamanhoTotal} bytes no total.\n\n" +

                $"Header: {bloco.TamanhoHeader} bytes\n" +
                $"Região livre: {tamanhoUtil} bytes\n" +
                $"Footer: {bloco.TamanhoFooter} bytes\n\n" +

                "Quando uma operação malloc, calloc ou realloc necessita de espaço, o gerenciador " +
                "procura entre os blocos livres aqueles que possuem tamanho suficiente para atender " +
                "à solicitação, incluindo os metadados e o alinhamento necessários.\n\n" +

                "A escolha entre blocos adequados depende do algoritmo selecionado:\n\n" +

                "First-Fit: seleciona o primeiro bloco livre com tamanho suficiente.\n" +
                "Best-Fit: percorre os candidatos e seleciona o menor bloco suficiente.\n" +
                "Worst-Fit: percorre os candidatos e seleciona o maior bloco suficiente.\n\n" +

                "Se o bloco escolhido for maior que o necessário e a sobra puder formar um bloco " +
                "livre válido, o simulador pode aplicar split. Caso blocos livres adjacentes sejam " +
                "encontrados, o coalescing pode uni-los em um bloco maior.";

            MessageBox.Show(
                texto,
                "Bloco livre",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
