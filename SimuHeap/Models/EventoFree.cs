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
        public int ReferenciaBloco { get; set; }
        public EventoFree()
        {
            Tipo = TipoEventoHeap.Free;
        }

        public override void AtualizarDescricao()
        {
            string nome = ObterNomeVariavel(ReferenciaBloco);
            Descricao = $"free({nome});";
        }
    }
}
