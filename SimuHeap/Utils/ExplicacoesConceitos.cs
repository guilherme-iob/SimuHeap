using SimuHeap.Data;
using SimuHeap.Enums;
using SimuHeap.Models;
using System;

namespace SimuHeap.Utils
{
    public static class ExplicacoesConceitos
    {
        /*
         * ============================================================
         * ESTRUTURA DOS BLOCOS
         * ============================================================
         */

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

            return $"""
                O cabeçalho (header) é uma região de metadados utilizada pelo gerenciador da heap para armazenar informações sobre o bloco. Em alocadores reais, sua estrutura varia conforme a implementação.

                Neste simulador, o cabeçalho possui {Configuracoes.TAM_HEADER} bytes e armazena o tamanho total do bloco junto de uma flag que indica se ele está ocupado.

                • Tamanho total: {bloco.TamanhoTotal} bytes
                • Estado: {estado}
                • Flag de ocupado (FLAG_OCUPADO): 0x{Configuracoes.FLAG_OCUPADO:X8}
                • Cálculo: {calculo}
                • Valor armazenado: 0x{valorHeader:X8}

                Como os blocos são alinhados em {Configuracoes.TAM_ALINHAMENTO} bytes, o bit menos significativo do tamanho pode ser utilizado como flag sem perder a informação referente ao tamanho do bloco.
                """;
        }

        public static string ObterExplicacaoPayload(BlocoDeMemoria bloco, InformacaoAlocacaoBloco? informacaoAlocacao)
        {
            string explicacaoOperacao = informacaoAlocacao?.TipoOperacao switch
            {
                TipoEventoHeap.Malloc =>
                    $"""
                    Este bloco foi obtido por malloc. O espaço é reservado, mas seu conteúdo não é inicializado, podendo conter bytes residuais existentes anteriormente naquela região.
                    """,

                TipoEventoHeap.Calloc =>
                    $"""
                    Este bloco foi obtido por calloc. Os {bloco.TamanhoPayload} bytes solicitados são inicializados com zero antes de serem disponibilizados ao programa.
                    """,

                TipoEventoHeap.Realloc =>
                    $"""
                    O estado atual do bloco foi produzido por realloc. Os dados anteriores são preservados até o menor tamanho entre a alocação antiga e a nova; caso o bloco aumente, a nova região não é inicializada automaticamente.
                    """,

                _ =>
                    $"""
                    A inicialização do conteúdo depende da operação utilizada para obter esta região de memória.
                    """
            };

            return $"""
                A área de dados (payload) é a região do bloco disponibilizada ao programa para armazenar seus dados. Diferentemente do cabeçalho (header), do rodapé (footer) e do preenchimento interno (padding), ela corresponde ao espaço efetivamente solicitado pela aplicação.

                • Tamanho da área de dados: {bloco.TamanhoPayload} bytes

                {explicacaoOperacao}
                """;
        }

        public static string ObterExplicacaoPadding(BlocoDeMemoria bloco)
        {
            int tamanhoSemPadding = Configuracoes.TAM_HEADER + bloco.TamanhoPayload + Configuracoes.TAM_FOOTER;
            int paddingAlinhamento = Configuracoes.CalcularPadding(bloco.TamanhoPayload);
            int paddingAdicional = Math.Max(0, bloco.TamanhoPadding - paddingAlinhamento);

            if (paddingAdicional > 0)
            {
                return $"""
                    O preenchimento interno (padding) corresponde a bytes que pertencem ao bloco alocado, mas não fazem parte da área de dados solicitada pelo programa. Parte desse espaço pode ser necessária para manter o tamanho do bloco alinhado em {Configuracoes.TAM_ALINHAMENTO} bytes.

                    • Tamanho sem preenchimento: {Configuracoes.TAM_HEADER} + {bloco.TamanhoPayload} + {Configuracoes.TAM_FOOTER} = {tamanhoSemPadding} bytes
                    • Preenchimento necessário para alinhamento: {paddingAlinhamento} bytes
                    • Preenchimento total do bloco: {bloco.TamanhoPadding} bytes

                    Neste bloco existem ainda {paddingAdicional} bytes adicionais de preenchimento interno. Eles foram incorporados ao bloco porque a sobra resultante era pequena demais para formar um novo bloco livre válido. Esses bytes também contribuem para a fragmentação interna.
                    """;
            }

            return $"""
                O preenchimento interno (padding) corresponde a bytes que pertencem ao bloco alocado, mas não fazem parte da área de dados solicitada pelo programa. Neste caso, ele é utilizado para manter o tamanho do bloco alinhado em {Configuracoes.TAM_ALINHAMENTO} bytes.

                • Tamanho sem preenchimento: {Configuracoes.TAM_HEADER} + {bloco.TamanhoPayload} + {Configuracoes.TAM_FOOTER} = {tamanhoSemPadding} bytes
                • Preenchimento para alinhamento: {paddingAlinhamento} bytes
                • Preenchimento total armazenado no bloco: {bloco.TamanhoPadding} bytes

                O cálculo do alinhamento segue a expressão: padding = (alinhamento - (tamanhoSemPadding % alinhamento)) % alinhamento.
                """;
        }

        public static string ObterExplicacaoFooter(BlocoDeMemoria bloco)
        {
            uint tamanho = (uint)bloco.TamanhoTotal;

            return $"""
                O rodapé (footer) é uma região de metadados localizada no final do bloco. Algumas estratégias de alocação utilizam informações armazenadas nos limites dos blocos para facilitar a identificação de regiões vizinhas.

                Neste simulador, o rodapé possui {Configuracoes.TAM_FOOTER} bytes e armazena somente o tamanho total do bloco.

                • Valor decimal: {tamanho}
                • Valor hexadecimal: 0x{tamanho:X8}

                Diferentemente do cabeçalho (header), o rodapé não utiliza a flag de ocupado (FLAG_OCUPADO). A presença dessas informações nos limites dos blocos também auxilia didaticamente na compreensão da união de blocos livres adjacentes (coalescing).
                """;
        }

        public static string ObterExplicacaoBlocoLivre(BlocoDeMemoria bloco)
        {
            return $"""
                Um bloco livre representa uma região da heap que não pertence atualmente a uma alocação ativa e pode ser reutilizada para atender uma solicitação futura.

                • Tamanho total: {bloco.TamanhoTotal} bytes
                • Região disponível: {bloco.TamanhoPayload} bytes
                • Cabeçalho (header): {bloco.TamanhoHeader} bytes
                • Rodapé (footer): {bloco.TamanhoFooter} bytes

                A escolha de qual bloco utilizar depende do algoritmo de alocação selecionado. A divisão de bloco (split) pode separar uma região livre maior que o necessário, enquanto a união de blocos livres (coalescing) pode combinar regiões livres adjacentes.
                """;
        }

        /*
         * ============================================================
         * HEAP E GERENCIAMENTO
         * ============================================================
         */

        public static readonly string ExplicacaoHeap =
            $"""
            A heap é uma região de memória utilizada para alocações dinâmicas realizadas durante a execução do programa. Operações como malloc, calloc, realloc e free são utilizadas pelo programa para solicitar, redimensionar e liberar essas regiões.

            O gerenciador organiza a heap em blocos ocupados e livres, utilizando metadados para identificar seus tamanhos e limites. Em implementações reais, a memória administrada pelo alocador pode estar organizada em uma ou mais regiões ou segmentos, e o alocador pode solicitar novas regiões de memória ao sistema operacional quando necessário.

            Neste simulador, a heap possui um tamanho fixo definido antes da execução para facilitar a visualização da alocação, da fragmentação e do esgotamento do espaço disponível. Os blocos são apresentados sequencialmente na memória, enquanto a lista de blocos livres mostra quais regiões estão disponíveis para atender novas solicitações.

            Quando uma alocação é solicitada, os blocos livres são analisados pelo algoritmo selecionado e o estado da heap pode ser alterado conforme as configurações utilizadas na simulação.
            """;

        public static readonly string ExplicacaoTamanhoHeap =
            $"""
            Define a quantidade total de memória disponível na heap simulada. Esse espaço é dividido entre blocos ocupados e livres, incluindo seus metadados e eventuais bytes de preenchimento interno (padding).

            Quando nenhum bloco livre possui tamanho suficiente para atender uma solicitação, a alocação falha na simulação. Em sistemas reais, o alocador pode tentar solicitar mais memória ao sistema operacional, embora esse crescimento também possua limites.
            """;

        public static readonly string ExplicacaoSplit =
            $"""
            A divisão de bloco (split) ocorre quando um bloco livre é maior que o necessário para atender uma alocação. Uma parte do bloco é utilizada pela nova alocação e a sobra permanece como um novo bloco livre, desde que possua tamanho suficiente para formar um bloco válido.

            Essa técnica evita que um bloco livre inteiro seja ocupado por uma solicitação significativamente menor, reduzindo o desperdício interno de memória.
            """;

        public static readonly string ExplicacaoCoalescing =
            $"""
            A união de blocos livres (coalescing) combina blocos livres que estão adjacentes na memória. Quando uma região é liberada, seus blocos vizinhos podem ser verificados e unidos para formar um único bloco livre maior.

            Essa técnica ajuda a concentrar o espaço livre disponível e, consequentemente, a reduzir a fragmentação externa.
            """;

        public static readonly string ExplicacaoAlgoritmosAlocacao =
            $"""
            Os algoritmos de alocação definem como um bloco livre é escolhido para atender uma solicitação de memória.

            • Primeiro encaixe (First-Fit): seleciona o primeiro bloco encontrado que possui espaço suficiente.
            • Melhor encaixe (Best-Fit): seleciona o menor bloco capaz de atender a solicitação.
            • Pior encaixe (Worst-Fit): seleciona o maior bloco capaz de atender a solicitação.

            Estratégias diferentes podem produzir organizações e níveis de fragmentação diferentes para uma mesma sequência de operações.
            """;

        /*
         * ============================================================
         * OPERAÇÕES
         * ============================================================
         */

        public static readonly string ExplicacaoMalloc =
            $"""
            malloc reserva uma quantidade de bytes na heap e retorna uma referência para a área de dados (payload) disponibilizada ao programa.

            O conteúdo dessa área não é inicializado pela operação. Por isso, os bytes encontrados inicialmente podem conter valores residuais e devem ser considerados indeterminados até que o programa realize uma escrita.
            """;

        public static readonly string ExplicacaoCalloc =
            $"""
            calloc reserva memória para uma quantidade de elementos e inicializa a área de dados (payload) solicitada com zero.

            Diferentemente de malloc, a região disponibilizada por calloc possui inicialmente todos os seus bytes zerados.
            """;

        public static readonly string ExplicacaoRealloc =
            $"""
            realloc altera o tamanho de uma alocação existente. O bloco pode ser reduzido, expandido no próprio local ou movido para outra região caso não exista espaço suficiente ao seu redor.

            Os dados existentes são preservados até o menor tamanho entre a região antiga e a nova. Quando a alocação cresce, os bytes adicionados não são inicializados automaticamente.
            """;

        public static readonly string ExplicacaoFree =
            $"""
            free libera uma alocação, permitindo que aquela região seja reutilizada pelo gerenciador da heap.

            A liberação não significa que os bytes anteriores sejam apagados. O conteúdo pode permanecer fisicamente naquela região até ser sobrescrito por uma utilização futura.
            """;

        /*
         * ============================================================
         * MÉTRICAS
         * ============================================================
         */

        public static readonly string ExplicacaoUsoTotalHeap =
            $"""
            Indica quanto da heap simulada está atualmente ocupado por blocos alocados. O cálculo considera o tamanho total dos blocos, incluindo a área de dados (payload), os metadados e o preenchimento interno (padding).

            Bytes ocupados = soma dos tamanhos totais dos blocos ocupados.

            Uso da heap (%) = (bytes ocupados / tamanho total da heap) × 100.
            """;

        public static readonly string ExplicacaoFragmentacaoInterna =
            $"""
            Fragmentação interna é o espaço que pertence a blocos ocupados, mas não faz parte da área de dados (payload) solicitada pelo programa.

            No simulador: bytes de fragmentação interna = Σ(tamanho total − cabeçalho − rodapé − área de dados).

            Fragmentação interna (%) = (bytes de fragmentação interna / tamanho da heap) × 100. Neste modelo, esse valor corresponde ao preenchimento interno (padding), incluindo tanto os bytes necessários para alinhamento quanto eventuais pequenas sobras incorporadas ao bloco.
            """;

        public static readonly string ExplicacaoFragmentacaoExterna =
            $"""
            Fragmentação externa ocorre quando a memória livre está distribuída entre vários blocos separados, dificultando solicitações que precisam de uma região contígua maior.

            O simulador utiliza: fragmentação externa (%) = [1 − (maior bloco livre / total de bytes livres)] × 100.

            Quanto mais próximo de 0%, mais concentrado está o espaço livre. Valores maiores indicam que esse espaço está mais distribuído entre diferentes blocos.
            """;

        /*
         * ============================================================
         * OUTRAS MÉTRICAS
         * ============================================================
         */

        public static readonly string ExplicacaoMemoriaInutilizavel =
            $"""
            Representa blocos livres pequenos demais para formar uma alocação válida no modelo do simulador.

            São considerados inutilizáveis os blocos com tamanho total menor que {Configuracoes.TAM_MIN_BLOCO} bytes.

            Memória inutilizável (%) = (bytes inutilizáveis / tamanho da heap) × 100.
            """;

        public static readonly string ExplicacaoMetadados =
            $"""
            Metadados são bytes utilizados pelo gerenciador para armazenar informações sobre os blocos e não fazem parte dos dados solicitados pelo programa.

            Neste simulador, cada bloco possui {Configuracoes.TAM_HEADER} bytes de cabeçalho (header) e {Configuracoes.TAM_FOOTER} bytes de rodapé (footer).

            Total de metadados = quantidade de blocos × (cabeçalho + rodapé).
            """;

        public static readonly string ExplicacaoPaddingMetrica =
            $"""
            Indica a quantidade total de bytes de preenchimento interno (padding) existente nos blocos ocupados.

            Total de preenchimento interno = soma do TamanhoPadding de todos os blocos ocupados.

            Esse preenchimento pode surgir pela necessidade de alinhamento ou pela incorporação de pequenas sobras que não possuem tamanho suficiente para formar um novo bloco livre.
            """;

        public static readonly string ExplicacaoMaiorBlocoLivre =
            $"""
            Indica o tamanho do maior bloco livre contíguo disponível na heap.

            Maior bloco livre = maior TamanhoTotal entre todos os blocos livres.

            Essa medida ajuda a identificar o tamanho máximo de uma região atualmente disponível para uma nova alocação.
            """;

        public static readonly string ExplicacaoBytesLivres =
            $"""
            Representa a quantidade total de memória pertencente a blocos livres.

            Bytes livres = soma dos tamanhos totais de todos os blocos livres.

            Ter memória livre suficiente no total não garante que uma alocação será possível, pois esse espaço pode estar dividido entre vários blocos menores.
            """;
    }
}