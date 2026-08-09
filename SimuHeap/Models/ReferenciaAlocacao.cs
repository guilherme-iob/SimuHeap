using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class ReferenciaAlocacao
    {
        public int Id { get; set; }
        public string Nome => $"bloco{Id}";
        public TiposDeVariaveis TipoVariavel { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
