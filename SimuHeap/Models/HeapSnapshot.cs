using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class HeapSnapshot
    {
        public int Passo { get; set; }
        public string DescricaoEvento { get; set; } = string.Empty;
        public int? IdEvento { get; set; }
        public string DescricaoPasso { get; set; } = string.Empty;
        public byte[] Memoria { get; set; } = Array.Empty<byte>();
        public List<BlocoDeMemoria> Blocos { get; set; } = new List<BlocoDeMemoria>();
        public List<BlocoDeMemoria> BlocosLivres { get; set; } = new List<BlocoDeMemoria>();

        public int? EnderecoBlocoEmAnalise { get; set; }
        public int? EnderecoMelhorBloco { get; set; }

        public TipoDestaqueSimulacao DestaqueBlocoEmAnalise { get; set; } = TipoDestaqueSimulacao.Nenhum;
        public TipoDestaqueSimulacao DestaqueMelhorBloco { get; set; }= TipoDestaqueSimulacao.Nenhum;

        // para visualização melhor do coalescing
        public int? EnderecoBlocoSecundario { get; set; }
        public TipoDestaqueSimulacao DestaqueBlocoSecundario { get; set; } = TipoDestaqueSimulacao.Nenhum;


        public string OperacaoAtual { get; set; } = string.Empty;
        public string InformacoesBusca { get; set; } = string.Empty;

        public Dictionary<int, InformacaoAlocacaoBloco> InformacoesAlocacao { get; set; } = new();

        //public int BytesLivres { get; set; }
        //public int BytesOcupados { get; set; }
        //public double UsoHeapPercentual { get; set; }
        //public double FragmentacaoExterna { get; set; }
        //public double FragmentacaoInterna { get; set; }

        public override string ToString()
        {
            return $"Evento: {DescricaoEvento}\r\n" +
                   $"Passo: {Passo}\r\n" +
                   $"Descrição: {DescricaoPasso}\r\n" +
                   $"Endereco Bloco em Análise: {EnderecoBlocoEmAnalise}\r\n" +
                   $"Endereço Melhor Bloco: {EnderecoMelhorBloco}\r\n" +
                   $"Destaque Bloco em Análise: {DestaqueBlocoEmAnalise}\r\n" +
                   $"Destaque Melhor Bloco: {DestaqueMelhorBloco}\r\n";
        }
    }
}
