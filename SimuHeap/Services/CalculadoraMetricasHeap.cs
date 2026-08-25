using SimuHeap.Data;
using SimuHeap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Services
{
    public static class CalculadoraMetricasHeap
    {
        public static MetricasHeap Calcular(HeapSimulator simulator)
        {
            List<BlocoDeMemoria> blocos = simulator.Blocos.ToList();

            List<BlocoDeMemoria> blocosOcupados = blocos.Where(x=>!x.EstaLivre).ToList();
            List<BlocoDeMemoria> blocosLivres = blocos.Where(x=>x.EstaLivre).ToList();

            int tamanhoHeap = simulator.TamanhoHeap;

            // uso da memoria
            int bytesOcupados = blocosOcupados.Sum(x => x.TamanhoTotal);
            int bytesLivres = blocosLivres.Sum(x=>x.TamanhoTotal);
            double percentualUsoMemoria = tamanhoHeap > 0 ? (double)bytesOcupados / tamanhoHeap * 100.0 : 0;

            // total de metadados (header + footer)
            int bytesMetadados = blocos.Count * (Configuracoes.TAM_HEADER + Configuracoes.TAM_FOOTER);

            // padding
            int bytesPadding = blocosOcupados.Sum(x => x.TamanhoPadding);

            // fragmentacao interna
            int bytesFragmentacaoInterna = blocosOcupados.Sum(x => x.TamanhoTotal - Configuracoes.TAM_HEADER - Configuracoes.TAM_FOOTER - x.TamanhoPayload);
            double percentualFramentacaoInterna = tamanhoHeap > 0 ? (double)bytesFragmentacaoInterna / tamanhoHeap * 100.0 : 0;


            // fragmentacao externa
            int maiorBlocoLivre = blocosLivres.Count > 0 ? blocosLivres.Max(x => x.TamanhoTotal) : 0;
            double percentualFragmentacaoExterna = 0;
            if(bytesLivres > 0)
            {
                percentualFragmentacaoExterna = (1.0 - ((double)maiorBlocoLivre / bytesLivres)) * 100.0;
            }

            // memoria livre inutilizavel
            List<BlocoDeMemoria> blocosInutilizaveis = blocosLivres.Where(x => x.TamanhoTotal < Configuracoes.TAM_MIN_BLOCO).ToList();
            int quantidadeBlocosInutilizaveis = blocosInutilizaveis.Count;
            int bytesInutilizaveis = blocosInutilizaveis.Sum(x => x.TamanhoTotal);
            double percentualMemoriaInutilizavel = tamanhoHeap > 0 ? (double)bytesInutilizaveis / tamanhoHeap * 100.0 : 0;
            

            return new MetricasHeap
            {
                BytesOcupados = bytesOcupados,
                BytesLivres = bytesLivres,
                PercentualUsoMemoria = percentualUsoMemoria,
                BytesFragmentacaoInterna = bytesFragmentacaoInterna,
                PercentualFragmentacaoInterna = percentualFramentacaoInterna,
                PercentualFragmentacaoExterna = percentualFragmentacaoExterna,
                BytesInutilizaveis = bytesInutilizaveis,
                PercentualMemoriaInutilizavel = percentualMemoriaInutilizavel,
                QuantidadeBlocosInutilizaveis = quantidadeBlocosInutilizaveis,
                BytesMetadados = bytesMetadados,
                BytesPadding = bytesPadding,
                TamanhoMaiorBlocoLivre = maiorBlocoLivre
            };
        }
    }
}
