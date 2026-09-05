using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class EscritaMemoria
    {
        public int ReferenciaBloco { get; set; }
        public TiposDeVariaveis TipoVariavel { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public List<ValorAtribuidoMemoria> Valores { get; set; } = new();
    }

    public class ValorAtribuidoMemoria
    {
        public int Indice { get; set; }
        public object Valor { get; set; } = default!;
    }
}
