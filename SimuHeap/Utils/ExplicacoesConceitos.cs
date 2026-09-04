using SimuHeap.Data;
using SimuHeap.Enums;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Utils
{
    public class ExplicacoesConceitos
    {
        public static string ObterExplicacaoHeader(BlocoDeMemoria bloco)
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
                "• Conceito:\n" +

                "\tO header é uma região de metadados localizada no início de um bloco de memória. " +
                "Esses dados são utilizados internamente pelo gerenciador da heap e não fazem parte " +
                "da área solicitada pelo programa para armazenar seus dados.\n" +

                "\tEm gerenciadores de memória reais, o formato do header varia conforme a implementação. " +
                "Ele pode armazenar, por exemplo, o tamanho do bloco, flags de estado, informações sobre " +
                "blocos vizinhos, classes de tamanho ou referências utilizadas por estruturas de gerenciamento. " +
                "Portanto, não existe um único formato de header utilizado por todos os alocadores.\n\n" +

                "• Representação neste simulador:\n" +

                $"\tO header possui {Configuracoes.TAM_HEADER} bytes. Neste modelo, um único valor de 32 bits " +
                "representa o tamanho total do bloco e também uma flag que indica se o bloco está ocupado.\n\n" +

                $"\tTamanho do bloco: {bloco.TamanhoTotal} bytes\n" +
                $"\tTamanho em hexadecimal: 0x{tamanho:X8}\n" +
                $"\tEstado do bloco: {estado}\n" +
                $"\tFLAG_OCUPADO: 0x{Configuracoes.FLAG_OCUPADO:X8}\n\n" +

                "• Cálculo neste bloco:\n" +

                $"\tHeader = {calculo}\n" +
                $"\tHeader armazenado = 0x{valorHeader:X8}\n\n" +

                $"\tComo o simulador utiliza alinhamento de {Configuracoes.TAM_ALINHAMENTO} bytes, " +
                "os tamanhos válidos dos blocos são múltiplos desse valor. Dessa forma, alguns bits " +
                "menos significativos do tamanho permanecem disponíveis para representar flags.\n" +

                "\tNeste modelo, o bit 0 é aproveitado para armazenar a FLAG_OCUPADO. " +
                "Quando o bloco está ocupado, esse bit é alterado de 0 para 1, enquanto os demais bits " +
                "continuam representando o tamanho do bloco.";

            return texto;
        }

        public static string ObterExplicacaoPayload(BlocoDeMemoria bloco, InformacaoAlocacaoBloco? informacaoAlocacao)
        {
            string texto =
                "• Conceito:\n" +

                "\tO payload é a região do bloco disponibilizada ao programa para armazenar os dados " +
                "solicitados pela operação de alocação.\n" +

                "\tDiferentemente do header e do footer, que pertencem ao gerenciamento interno da heap, " +
                "o payload corresponde à memória efetivamente solicitada pelo programa.\n\n" +

                "• Representação neste simulador:\n" +

                $"\tEste bloco possui {bloco.TamanhoPayload} bytes de payload.\n";

            if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Malloc)
            {
                texto +=
                    "\n\tOPERAÇÃO MALLOC\n\n" +

                    "\tEste bloco foi criado por malloc.\n\n" +

                    "\tO malloc reserva uma região de memória com o tamanho solicitado, mas não inicializa " +
                    "o conteúdo dessa região. Portanto, os bytes inicialmente presentes no payload são " +
                    "indeterminados e podem corresponder a dados anteriormente existentes naquela área da memória.\n\n" +

                    "\tPara representar esse comportamento de forma visual, o simulador preenche inicialmente " +
                    "a heap com valores variados em vez de inicializá-la automaticamente com zeros.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Calloc)
            {
                texto +=
                    "\n\tOPERAÇÃO CALLOC\n\n" +

                    "\tEste bloco foi criado por calloc.\n\n" +

                    "\tO calloc reserva memória para uma quantidade de elementos e inicializa todos os bits " +
                    "da região alocada com zero.\n\n" +

                    $"\tPor isso, imediatamente após a operação, os {bloco.TamanhoPayload} bytes do payload " +
                    "são representados no simulador pelo valor hexadecimal 0x00.";
            }
            else if (informacaoAlocacao?.TipoOperacao == TipoEventoHeap.Realloc)
            {
                texto +=
                    "\n\tOPERAÇÃO REALLOC\n\n" +

                    "\tO estado atual deste bloco foi produzido por realloc.\n\n" +

                    "\tO realloc altera o tamanho de uma alocação existente. O gerenciador pode conseguir " +
                    "redimensionar o bloco no próprio local ou pode precisar criar uma nova alocação em " +
                    "outra região da heap.\n\n" +

                    "\tOs dados existentes são preservados até o menor valor entre o tamanho antigo e o novo " +
                    "tamanho solicitado.\n\n" +

                    "\tCaso o bloco seja aumentado, a nova região acrescentada ao payload não é automaticamente " +
                    "inicializada com zero.";
            }
            else
            {
                texto +=
                    "\n\tA forma como o conteúdo foi inicializado depende da operação responsável pela alocação.";
            }
            texto += "\n";
            return texto;
        }

        public static string ObterExplicacaoPadding(BlocoDeMemoria bloco)
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
                "• Conceito:\n" +

                "\tPadding corresponde a bytes adicionais que não pertencem ao payload, mas podem ser " +
                "necessários para que a organização do bloco respeite os requisitos de alinhamento de memória.\n" +
                "\tO alinhamento utilizado por um gerenciador real pode variar conforme a arquitetura do sistema, " +
                "as convenções da plataforma e a implementação do próprio alocador. Portanto, não existe um " +
                "valor universal de alinhamento para todas as heaps.\n\n" +

                "• Representação neste simulador:\n" +

                $"\tO alinhamento configurado é de {Configuracoes.TAM_ALINHAMENTO} bytes. " +
                "Isso significa que o tamanho total calculado para um bloco deve ser múltiplo desse valor.\n" +

                "\tO padding de alinhamento é calculado pela expressão:\n" +

                "\t\tpadding = (alinhamento - (tamanhoSemPadding % alinhamento)) % alinhamento\n\n" +

                "• Cálculo do padding para este bloco:\n\n" +

                "\ttamanhoSemPadding = Header + Payload + Footer\n" +

                $"\ttamanhoSemPadding = " +
                $"{Configuracoes.TAM_HEADER} + " +
                $"{bloco.TamanhoPayload} + " +
                $"{Configuracoes.TAM_FOOTER}\n" +

                $"\ttamanhoSemPadding = {tamanhoSemPadding} bytes\n" +

                $"\tpadding = " +
                $"({Configuracoes.TAM_ALINHAMENTO} - " +
                $"({tamanhoSemPadding} % {Configuracoes.TAM_ALINHAMENTO})) " +
                $"% {Configuracoes.TAM_ALINHAMENTO}\n\n" +

                $"\tpadding de alinhamento = {paddingAlinhamento} bytes\n" +

                $"\tPadding armazenado atualmente no bloco: {bloco.TamanhoPadding} bytes.\n";

            if (paddingAdicional > 0)
            {
                texto +=
                    "\n\n• Espaço interno adicional:\n" +

                    $"\tDestes {bloco.TamanhoPadding} bytes, apenas {paddingAlinhamento} são necessários " +
                    $"pelo cálculo de alinhamento.\n" +

                    $"\tOs {paddingAdicional} bytes restantes foram incorporados ao bloco porque a sobra " +
                    "era pequena demais para formar um novo bloco livre válido.\n" +

                    "\tNeste modelo didático, esse espaço também é representado por TamanhoPadding. " +
                    "Ele corresponde a espaço interno não utilizado e contribui para a fragmentação interna.\n";
            }

            return texto;
        }

        public static string ObterExplicacaoFooter(BlocoDeMemoria bloco)
        {
            uint tamanho =
                (uint)bloco.TamanhoTotal;

            string texto =
                "• Conceito:\n" +

                "\tO footer é uma região de metadados localizada no final do bloco. " +
                "Uma possível estratégia de gerenciamento de memória consiste em armazenar informações " +
                "nos limites dos blocos para facilitar a identificação de blocos vizinhos.\n" +

                "\tNem todos os gerenciadores de memória reais utilizam footer em todos os blocos. " +
                "A organização desses metadados depende da implementação adotada pelo alocador.\n" +

                "• Representação neste simulador:\n" +

                $"\tO footer possui {Configuracoes.TAM_FOOTER} bytes e armazena o tamanho total do bloco.\n\n" +

                "• Cálculo do footer para este bloco:\n" +

                $"\tTamanho total: {bloco.TamanhoTotal} bytes\n" +
                $"\tValor decimal armazenado: {tamanho}\n" +
                $"\tValor hexadecimal armazenado: 0x{tamanho:X8}\n\n" +

                "\tAo contrário do header, o footer deste simulador não utiliza a FLAG_OCUPADO. " +
                "Ele armazena somente o tamanho do bloco.\n\n" +

                "• Coalescing (união de blocos livres)\n" +

                "\tConhecer os limites dos blocos auxilia na identificação de regiões adjacentes. " +
                "Quando dois blocos livres são vizinhos, eles podem ser combinados por uma operação de " +
                "coalescing, formando uma única região livre maior.\n";

            return texto;
        }

        public static string ObterExplicacaoBlocoLivre(BlocoDeMemoria bloco)
        {
            string texto =
                "• Conceito:\n" +

                "\tUm bloco livre representa uma região da heap que não está atualmente associada a uma " +
                "alocação ativa. Essa região pode ser reutilizada para atender futuras solicitações de memória.\n" +

                "Mesmo estando livre, o bloco ainda possui metadados utilizados pelo gerenciador para " +
                "representar seu tamanho e seus limites.\n\n" +

                "• Representação neste simulador:\n" +

                $"\tTamanho total do bloco: {bloco.TamanhoTotal} bytes\n" +
                $"\tHeader: {bloco.TamanhoHeader} bytes\n" +
                $"\tRegião disponível: {bloco.TamanhoPayload} bytes\n" +
                $"\tFooter: {bloco.TamanhoFooter} bytes\n\n" +

                "• A busca por espaço:\n" +

                "\tAntes de realizar uma alocação, o simulador calcula o tamanho total necessário, considerando " +
                "o payload solicitado, os metadados e o alinhamento.\n" +

                "\tEm seguida, os blocos livres são analisados conforme o algoritmo selecionado:\n" +

                "\t• First-Fit: seleciona o primeiro bloco livre que possui tamanho suficiente.\n" +

                "\t• Best-Fit: analisa os candidatos e seleciona o menor bloco capaz de atender à solicitação.\n" +

                "\t• Worst-Fit: analisa os candidatos e seleciona o maior bloco capaz de atender à solicitação.\n\n" +

                "• Split e Coalescing:\n" +

                "\tSe o bloco selecionado for maior que o necessário e a região restante for suficiente para " +
                "formar outro bloco válido, o simulador pode aplicar split, dividindo a região em um bloco " +
                "ocupado e outro livre.\n" +

                "\tQuando dois blocos livres tornam-se adjacentes, o coalescing pode uni-los novamente, " +
                "criando uma região livre maior e reduzindo a fragmentação externa.\n";

            return texto;
        }

        public static readonly string ExplicacaoSplit =
            """
            O Split permite dividir um bloco livre quando ele é maior do que o espaço necessário para uma alocação.

            Uma parte é utilizada pela nova alocação e o espaço restante forma um novo bloco livre, desde que tenha tamanho suficiente para representar um bloco válido.

            Essa técnica evita desperdiçar todo o bloco em uma alocação menor.
            """;

        public static readonly string ExplicacaoCoalescing =
            """
            O Coalescing permite unir blocos livres que estão adjacentes na memória.

            Quando um bloco é liberado, seus blocos vizinhos são verificados e, caso também estejam livres, podem ser unidos formando um único bloco maior.

            Essa técnica ajuda a reduzir a fragmentação externa.
            """;

        public static readonly string ExplicacaoAlgoritmosAlocacao =
            """
            Define a estratégia utilizada para escolher um bloco livre durante uma alocação.

            • First-Fit: utiliza o primeiro bloco livre que possui espaço suficiente.
            • Best-Fit: utiliza o menor bloco livre capaz de atender à solicitação.
            • Worst-Fit: utiliza o maior bloco livre disponível.
            """;

        public static readonly string ExplicacaoTamanhoHeap =
            """
            Define a quantidade total de memória disponível na Heap simulada.

            As alocações consomem esse espaço considerando a estrutura dos blocos, incluindo Header, Payload, Padding e Footer.

            Quando não existe um bloco livre com espaço suficiente, a alocação não pode ser realizada.
            """;

        public static readonly string ExplicacaoListaBlocosLivres = string.Empty;
        public static readonly string ExplicacaoSegmentos = string.Empty;

        // operacoes
        public static readonly string ExplicacaoMalloc = string.Empty;
        public static readonly string ExplicacaoCalloc = string.Empty;
        public static readonly string ExplicacaoRealloc = string.Empty;
        public static readonly string ExplicacaoFree = string.Empty;

        // metricas
        public static readonly string ExplicacaoFragmentacaoInterna = string.Empty;
        public static readonly string ExplicacaoFragmentacaoExterna = string.Empty;
    }
}
