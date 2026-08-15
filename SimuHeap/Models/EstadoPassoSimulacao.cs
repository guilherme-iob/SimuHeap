using SimuHeap.Enums;
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
        public TipoDestaqueSimulacao DestaqueBlocoEmAnalise { get; set; } = TipoDestaqueSimulacao.Nenhum;
        public TipoDestaqueSimulacao DestaqueMelhorBloco { get; set; } = TipoDestaqueSimulacao.Nenhum;

        // para visualização melhor do coalescing
        public int? EnderecoBlocoSecundario { get; set; }
        public TipoDestaqueSimulacao DestaqueBlocoSecundario { get; set; } = TipoDestaqueSimulacao.Nenhum;

        // Acresecentar depois

        /*
         public int BuscasRealizadas { get; set; }
         public int DivisoesRealizadas { get; set; }
         public int UnioesRealizadas { get; set; }
         */
    }
}
