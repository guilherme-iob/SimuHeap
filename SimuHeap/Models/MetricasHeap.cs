using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class MetricasHeap
    {
        public int BytesOcupados { get; set; }
        public int BytesLivres { get; set; }

        public double PercentualUsoMemoria { get; set; }

        public int BytesFragmentacaoInterna { get; set; }
        public double PercentualFragmentacaoInterna { get; set; }

        public double PercentualFragmentacaoExterna { get; set; }

        public int BytesInutilizaveis { get; set; }
        public double PercentualMemoriaInutilizavel { get; set; }
        public int QuantidadeBlocosInutilizaveis { get; set; }

        public int BytesMetadados { get; set; }
        public int BytesPadding { get; set; }

        public int TamanhoMaiorBlocoLivre { get; set; }

        public override string ToString()
        {
            return
                $"Uso da memória:\r\n" +
                $"  Bytes ocupados: {BytesOcupados}\r\n" +
                $"  Bytes livres: {BytesLivres}\r\n" +
                $"  Uso da heap: {PercentualUsoMemoria:F2}%\r\n" +
                $"\r\n" +

                $"Fragmentação interna:\r\n" +
                $"  Bytes de fragmentação interna: {BytesFragmentacaoInterna}\r\n" +
                $"  Percentual: {PercentualFragmentacaoInterna:F2}%\r\n" +
                $"  Bytes de padding: {BytesPadding}\r\n" +
                $"\r\n" +

                $"Fragmentação externa:\r\n" +
                $"  Percentual: {PercentualFragmentacaoExterna:F2}%\r\n" +
                $"  Maior bloco livre: {TamanhoMaiorBlocoLivre} bytes\r\n" +
                $"\r\n" +

                $"Memória livre inutilizável:\r\n" +
                $"  Bytes inutilizáveis: {BytesInutilizaveis}\r\n" +
                $"  Percentual: {PercentualMemoriaInutilizavel:F2}%\r\n" +
                $"  Blocos inutilizáveis: {QuantidadeBlocosInutilizaveis}\r\n" +
                $"\r\n" +

                $"Metadados:\r\n" +
                $"  Bytes de metadados: {BytesMetadados}";
        }
    }
}
