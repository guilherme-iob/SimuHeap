using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public abstract class EventoHeap
    {
        public int Id { get; set; }
        public TipoEventoHeap Tipo { get; protected set; }
        public string Descricao { get; protected set; } = string.Empty;
    }
}
