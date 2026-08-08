using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuHeap.Enums;

namespace SimuHeap.Models
{
    public class EventoFree :EventoHeap
    {
        public int BlocoId { get; set; }
        public EventoFree()
        {
            Tipo = TipoEventoHeap.Free;
        }
        public void AtualizarDescricao()
        {
            Descricao = $"free(bloco_{BlocoId});";
        }
    }
}
