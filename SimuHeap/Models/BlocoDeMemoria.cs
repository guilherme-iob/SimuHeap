using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class BlocoDeMemoria
    {
        private EstadoBlocoMemoria EstadoBlocoMemoria;
        private byte[] Header;
        private byte[] Payload;
        private byte[] Padding;
        private byte[] Footer;
        private int TamanhoTotalBloco;
        private int EnderecoInicioBloco;
    }
}
