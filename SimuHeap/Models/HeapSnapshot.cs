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

        public string OperacaoAtual { get; set; } = string.Empty;
        public string InformacoesBusca { get; set; } = string.Empty;

        //public int BytesLivres { get; set; }
        //public int BytesOcupados { get; set; }
        //public double UsoHeapPercentual { get; set; }
        //public double FragmentacaoExterna { get; set; }
        //public double FragmentacaoInterna { get; set; }

        public override string ToString()
        {
            return $"Passo: {Passo}\r\n" +
                $"Descrição Evento: {DescricaoEvento}\r\n" +
                $"Descrição Passo: {DescricaoPasso}\r\n" +
                $"Endereco Bloco em Análise: {EnderecoBlocoEmAnalise}\r\n" +
                $"Endereço Melhor Bloco: {EnderecoMelhorBloco}\r\n" +
                $"Operação Atual: {OperacaoAtual}\r\n" +
                $"Informações Busca: {InformacoesBusca}";
        }
    }
}
