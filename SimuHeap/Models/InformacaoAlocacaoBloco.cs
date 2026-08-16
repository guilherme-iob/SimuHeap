using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class InformacaoAlocacaoBloco
    {
        public int IdBloco { get; set; }
        public int IdEvento { get; set; }
        public int ReferenciaBloco { get; set; }
        public TipoEventoHeap TipoOperacao { get; set; }
        public string DescricaoOperacao { get; set; } = string.Empty;

        public InformacaoAlocacaoBloco Clonar()
        {
            return new InformacaoAlocacaoBloco
            {
                IdBloco = IdBloco,
                IdEvento = IdEvento,
                ReferenciaBloco = ReferenciaBloco,
                TipoOperacao = TipoOperacao,
                DescricaoOperacao = DescricaoOperacao
            };
        }
    }
}
