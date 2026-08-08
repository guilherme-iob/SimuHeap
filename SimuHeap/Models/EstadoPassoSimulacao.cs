using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class EstadoPassoSimulacao
    {
        public string Descricao { get; set; } = string.Empty;
        public int? EnderecoBlocoEmAnalise { get; set; }
        public int? EnderecoMelhorBloco { get; set; }

        // Acresecentar depois

        /*
         public int BuscasRealizadas { get; set; }
         public int DivisoesRealizadas { get; set; }
         public int UnioesRealizadas { get; set; }
         */
    }
}
