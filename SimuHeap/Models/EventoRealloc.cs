using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Enums;

namespace SimuHeap.Models
{
    public class EventoRealloc : EventoHeap
    {
        public int BlocoId { get; set; }
        public TiposDeVariaveis TipoVariavel { get; set; }
        public int NovaQuantidade { get; set; }
        public int ReferenciaBloco { get; set; }
        public EventoRealloc()
        {
            Tipo = TipoEventoHeap.Realloc;
        }

        public void AtualizarDescricao()
        {
            Descricao = $"bloco{ReferenciaBloco} = realloc(bloco{ReferenciaBloco}, sizeof({TipoVariavel.ToString().ToLower()}) * {NovaQuantidade});";
        }
    }
}
