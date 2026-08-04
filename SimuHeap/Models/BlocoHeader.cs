using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class BlocoHeader
    {
        private uint TamanhoBloco;
        private EstadoBlocoMemoria EstadoBlocoMemoria;

        public BlocoHeader(uint tamanhoBloco, EstadoBlocoMemoria estadoBlocoMemoria)
        {
            TamanhoBloco = tamanhoBloco;
            EstadoBlocoMemoria = estadoBlocoMemoria;
        }
    }
}
