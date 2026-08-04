using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class Heap
    {
        private uint Tamanho;
        private List<BlocoDeMemoria> ListaBlocosLivres;
        private List<BlocoDeMemoria> Segmentos;
    }
}
