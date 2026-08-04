using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class BlocoPayload
    {
        private byte[] Dados;

        public BlocoPayload(uint tamanho, bool initializeWithZeros)
        {
            Dados = new byte[tamanho];
            if (initializeWithZeros)
            {
                Array.Clear(Dados, 0, Dados.Length);
            }
        }
    }
}
