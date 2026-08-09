using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Enums;

namespace SimuHeap.Models
{
    public class EventoMalloc : EventoHeap
    {
        public TiposDeVariaveis TipoVariavel { get; set; }
        public int Quantidade { get; set; }
        public int ReferenciaBloco { get; set; }
        public EventoMalloc()
        {
            Tipo = TipoEventoHeap.Malloc;
        }

        public void AtualizarDescricao()
        {
            string tamanho = Quantidade == 1 ? $"sizeof({TipoVariavel.ToString().ToLower()})" : $"sizeof({TipoVariavel.ToString().ToLower()}) * {Quantidade}";
            Descricao = $"bloco{ReferenciaBloco} = malloc({tamanho});";
        }
    }
}
