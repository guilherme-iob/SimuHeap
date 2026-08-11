using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class EventoCalloc : EventoHeap
    {
        public TiposDeVariaveis TipoVariavel { get; set; }
        public int Quantidade { get; set; }
        public int ReferenciaBloco { get; set; }

        public EventoCalloc()
        {
            Tipo = TipoEventoHeap.Calloc;
        }

        public void AtualizarDescricao()
        {
            Descricao = $"{ObterArtibuicaoVariavel(TipoVariavel)} *bloco{ReferenciaBloco} = calloc({Quantidade}, sizeof({TipoVariavel.ToString().ToLower()}));";
        }
    }
}
