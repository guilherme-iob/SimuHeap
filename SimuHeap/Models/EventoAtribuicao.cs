using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class EventoAtribuicao: EventoHeap
    {
        public int ReferenciaBloco { get; set; }
        public TiposDeVariaveis TipoVariavel { get; set; }
        public List<ValorAtribuidoMemoria> Valores { get; set; } = new();

        public string? DescricaoPersonalizada { get; set; }

        public EventoAtribuicao()
        {
            Tipo = TipoEventoHeap.Atribuicao;
        }

        public override void AtualizarDescricao()
        {
            if (!string.IsNullOrWhiteSpace(DescricaoPersonalizada))
            {
                Descricao = DescricaoPersonalizada;
                return;
            }

            string valores = string.Join(", ", Valores.Select(x => x.Valor));

            Descricao = string.IsNullOrWhiteSpace(NomeVariavel)
                ? $"Atribuição do valor {valores} ao bloco{ReferenciaBloco};"
                : $"Atribuição do valor {valores} a {NomeVariavel};";
        }
    }
}
