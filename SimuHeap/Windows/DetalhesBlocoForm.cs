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
            this.Text = bloco.EstaLivre ? $"Detalhes do Bloco Livre #{bloco.Id}" : $"Detalhes do Bloco Alocado #{bloco.Id}";
            this.BackColor = bloco.EstaLivre ? Color.ForestGreen : Color.Crimson;
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
            uint tamanho = (uint)bloco.TamanhoTotal;

            uint valorHeader = bloco.EstaLivre
                ? tamanho
                : tamanho | Configuracoes.FLAG_OCUPADO;

            string estado = bloco.EstaLivre
                ? "Livre"
                : "Ocupado";

            string calculo = bloco.EstaLivre
                ? $"0x{tamanho:X8}"
                : $"0x{tamanho:X8} | 0x{Configuracoes.FLAG_OCUPADO:X8}";

            string texto =
                "CONCEITO\n\n" +

                "O header é uma região de metadados localizada no início de um bloco de memória. " +
                "Esses dados são utilizados internamente pelo gerenciador da heap e não fazem parte " +
                "da área solicitada pelo programa para armazenar seus dados.\n\n" +

                "Em gerenciadores de memória reais, o formato do header varia conforme a implementação. " +
                "Ele pode armazenar, por exemplo, o tamanho do bloco, flags de estado, informações sobre " +
                "blocos vizinhos, classes de tamanho ou referências utilizadas por estruturas de gerenciamento. " +
                "Portanto, não existe um único formato de header utilizado por todos os alocadores.\n\n" +

                "NO SIMULADOR\n\n" +

                $"O header possui {Configuracoes.TAM_HEADER} bytes. Neste modelo, um único valor de 32 bits " +
                "representa o tamanho total do bloco e também uma flag que indica se o bloco está ocupado.\n\n" +

                $"Tamanho do bloco: {bloco.TamanhoTotal} bytes\n" +
                $"Tamanho em hexadecimal: 0x{tamanho:X8}\n" +
                $"Estado do bloco: {estado}\n" +
                $"FLAG_OCUPADO: 0x{Configuracoes.FLAG_OCUPADO:X8}\n\n" +

                "CÁLCULO NESTE BLOCO\n\n" +

                $"Header = {calculo}\n" +
                $"Header armazenado = 0x{valorHeader:X8}\n\n" +

                $"Como o simulador utiliza alinhamento de {Configuracoes.TAM_ALINHAMENTO} bytes, " +
                "os tamanhos válidos dos blocos são múltiplos desse valor. Dessa forma, alguns bits " +
                "menos significativos do tamanho permanecem disponíveis para representar flags.\n\n" +

                "Neste modelo, o bit 0 é utilizado como FLAG_OCUPADO. Assim, quando o bloco está ocupado, " +
                "esse bit é ativado por uma operação OR sem perder a informação do tamanho.";

            MostrarAvisoExplicativo("Header do bloco", texto);
        }

        private void MostrarInformacaoPayload()
        {
            string texto =
                "CONCEITO\n\n" +

                "O payload é a região do bloco disponibilizada ao programa para armazenar os dados " +
                "solicitados pela operação de alocação.\n\n" +

                "Diferentemente do header e do footer, que pertencem ao gerenciamento interno da heap, " +
                "o payload corresponde à memória efetivamente solicitada pelo programa.\n\n" +

                "NO SIMULADOR\n\n" +

                $"Este bloco possui {bloco.TamanhoPayload} bytes de payload.\n";

            if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Malloc)
            {
                texto +=
                    "\nOPERAÇÃO MALLOC\n\n" +

                    "Este bloco foi criado por malloc.\n\n" +

                    "O malloc reserva uma região de memória com o tamanho solicitado, mas não inicializa " +
                    "o conteúdo dessa região. Portanto, os bytes inicialmente presentes no payload são " +
                    "indeterminados e podem corresponder a dados anteriormente existentes naquela área da memória.\n\n" +

                    "Para representar esse comportamento de forma visual, o simulador preenche inicialmente " +
                    "a heap com valores variados em vez de inicializá-la automaticamente com zeros.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Calloc)
            {
                texto +=
                    "\nOPERAÇÃO CALLOC\n\n" +

                    "Este bloco foi criado por calloc.\n\n" +

                    "O calloc reserva memória para uma quantidade de elementos e inicializa todos os bits " +
                    "da região alocada com zero.\n\n" +

                    $"Por isso, imediatamente após a operação, os {bloco.TamanhoPayload} bytes do payload " +
                    "são representados no simulador pelo valor hexadecimal 0x00.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Realloc)
            {
                texto +=
                    "\nOPERAÇÃO REALLOC\n\n" +

                    "O estado atual deste bloco foi produzido por realloc.\n\n" +

                    "O realloc altera o tamanho de uma alocação existente. O gerenciador pode conseguir " +
                    "redimensionar o bloco no próprio local ou pode precisar criar uma nova alocação em " +
                    "outra região da heap.\n\n" +

                    "Os dados existentes são preservados até o menor valor entre o tamanho antigo e o novo " +
                    "tamanho solicitado.\n\n" +

                    "Caso o bloco seja aumentado, a nova região acrescentada ao payload não é automaticamente " +
                    "inicializada com zero.";
            }
            else
            {
                texto +=
                    "\nA forma como o conteúdo foi inicializado depende da operação responsável pela alocação.";
            }

            MostrarAvisoExplicativo("Payload do bloco", texto);
        }

        private void MostrarInformacaoPadding()
        {
            int tamanhoSemPadding =
                Configuracoes.TAM_HEADER +
                bloco.TamanhoPayload +
                Configuracoes.TAM_FOOTER;

            int paddingAlinhamento =
                Configuracoes.CalcularPadding(
                    bloco.TamanhoPayload);

            int paddingAdicional =
                Math.Max(
                    0,
                    bloco.TamanhoPadding - paddingAlinhamento);

            string texto =
                "CONCEITO\n\n" +

                "Padding corresponde a bytes adicionais que não pertencem ao payload, mas podem ser " +
                "necessários para que a organização do bloco respeite os requisitos de alinhamento de memória.\n\n" +

                "O alinhamento utilizado por um gerenciador real pode variar conforme a arquitetura do sistema, " +
                "as convenções da plataforma e a implementação do próprio alocador. Portanto, não existe um " +
                "valor universal de alinhamento para todas as heaps.\n\n" +

                "NO SIMULADOR\n\n" +

                $"O alinhamento configurado é de {Configuracoes.TAM_ALINHAMENTO} bytes. " +
                "Isso significa que o tamanho total calculado para um bloco deve ser múltiplo desse valor.\n\n" +

                "O padding de alinhamento é calculado pela expressão:\n\n" +

                "padding = (alinhamento - (tamanhoSemPadding % alinhamento)) % alinhamento\n\n" +

                "CÁLCULO NESTE BLOCO\n\n" +

                "tamanhoSemPadding = Header + Payload + Footer\n\n" +

                $"tamanhoSemPadding = " +
                $"{Configuracoes.TAM_HEADER} + " +
                $"{bloco.TamanhoPayload} + " +
                $"{Configuracoes.TAM_FOOTER}\n\n" +

                $"tamanhoSemPadding = {tamanhoSemPadding} bytes\n\n" +

                $"padding = " +
                $"({Configuracoes.TAM_ALINHAMENTO} - " +
                $"({tamanhoSemPadding} % {Configuracoes.TAM_ALINHAMENTO})) " +
                $"% {Configuracoes.TAM_ALINHAMENTO}\n\n" +

                $"padding de alinhamento = {paddingAlinhamento} bytes\n\n" +

                $"Padding armazenado atualmente no bloco: {bloco.TamanhoPadding} bytes.";

            if (paddingAdicional > 0)
            {
                texto +=
                    "\n\nESPAÇO INTERNO ADICIONAL\n\n" +

                    $"Destes {bloco.TamanhoPadding} bytes, apenas {paddingAlinhamento} são necessários " +
                    $"pelo cálculo de alinhamento.\n\n" +

                    $"Os {paddingAdicional} bytes restantes foram incorporados ao bloco porque a sobra " +
                    "era pequena demais para formar um novo bloco livre válido.\n\n" +

                    "Neste modelo didático, esse espaço também é representado por TamanhoPadding. " +
                    "Ele corresponde a espaço interno não utilizado e contribui para a fragmentação interna.";
            }

            MostrarAvisoExplicativo("Padding do bloco", texto);
        }

        private void MostrarInformacaoFooter()
        {
            uint tamanho =
                (uint)bloco.TamanhoTotal;

            string texto =
                "CONCEITO\n\n" +

                "O footer é uma região de metadados localizada no final do bloco. " +
                "Uma possível estratégia de gerenciamento de memória consiste em armazenar informações " +
                "nos limites dos blocos para facilitar a identificação de blocos vizinhos.\n\n" +

                "Nem todos os gerenciadores de memória reais utilizam footer em todos os blocos. " +
                "A organização desses metadados depende da implementação adotada pelo alocador.\n\n" +

                "NO SIMULADOR\n\n" +

                $"O footer possui {Configuracoes.TAM_FOOTER} bytes e armazena o tamanho total do bloco.\n\n" +

                "CÁLCULO NESTE BLOCO\n\n" +

                $"Tamanho total: {bloco.TamanhoTotal} bytes\n" +
                $"Valor decimal armazenado: {tamanho}\n" +
                $"Valor hexadecimal armazenado: 0x{tamanho:X8}\n\n" +

                "Ao contrário do header, o footer deste simulador não utiliza a FLAG_OCUPADO. " +
                "Ele armazena somente o tamanho do bloco.\n\n" +

                "COALESCING\n\n" +

                "Conhecer os limites dos blocos auxilia na identificação de regiões adjacentes. " +
                "Quando dois blocos livres são vizinhos, eles podem ser combinados por uma operação de " +
                "coalescing, formando uma única região livre maior.";

            MostrarAvisoExplicativo("Footer do bloco", texto);
        }

        private void MostrarInformacaoBlocoLivre()
        {
            string texto =
                "CONCEITO\n\n" +

                "Um bloco livre representa uma região da heap que não está atualmente associada a uma " +
                "alocação ativa. Essa região pode ser reutilizada para atender futuras solicitações de memória.\n\n" +

                "Mesmo estando livre, o bloco ainda possui metadados utilizados pelo gerenciador para " +
                "representar seu tamanho e seus limites.\n\n" +

                "NO SIMULADOR\n\n" +

                $"Tamanho total do bloco: {bloco.TamanhoTotal} bytes\n" +
                $"Header: {bloco.TamanhoHeader} bytes\n" +
                $"Região disponível: {bloco.TamanhoPayload} bytes\n" +
                $"Footer: {bloco.TamanhoFooter} bytes\n\n" +

                "BUSCA POR ESPAÇO\n\n" +

                "Antes de realizar uma alocação, o simulador calcula o tamanho total necessário, considerando " +
                "o payload solicitado, os metadados e o alinhamento.\n\n" +

                "Em seguida, os blocos livres são analisados conforme o algoritmo selecionado:\n\n" +

                "• First-Fit: seleciona o primeiro bloco livre que possui tamanho suficiente.\n\n" +

                "• Best-Fit: analisa os candidatos e seleciona o menor bloco capaz de atender à solicitação.\n\n" +

                "• Worst-Fit: analisa os candidatos e seleciona o maior bloco capaz de atender à solicitação.\n\n" +

                "SPLIT E COALESCING\n\n" +

                "Se o bloco selecionado for maior que o necessário e a região restante for suficiente para " +
                "formar outro bloco válido, o simulador pode aplicar split, dividindo a região em um bloco " +
                "ocupado e outro livre.\n\n" +

                "Quando dois blocos livres tornam-se adjacentes, o coalescing pode uni-los novamente, " +
                "criando uma região livre maior e reduzindo a fragmentação externa.";

            MostrarAvisoExplicativo("Região livre", texto);
        }
    }
}
