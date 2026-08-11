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

        protected string ObterArtibuicaoVariavel(TiposDeVariaveis tipo)
        {
            return tipo switch
            {
                TiposDeVariaveis.Char => "char",
                TiposDeVariaveis.Short => "short",
                TiposDeVariaveis.Int => "int",
                TiposDeVariaveis.Long => "long",
                TiposDeVariaveis.Float => "float",
                TiposDeVariaveis.Double => "double",

                _ => throw new ArgumentOutOfRangeException(nameof(tipo))
            };
        }
    }
}
