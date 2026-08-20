using SimuHeap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Models
{
    public class ErroSimulacao
    {
        public TipoErroSimulacao Tipo { get; init; } // init = só pode atribuir esse valor na inicializacao do objeto
        public string Titulo { get; init; } = string.Empty;
        public string Mensagem { get; init; } = string.Empty;
        public string Detalhes { get; init; } = string.Empty;
        public string Explicacao { get; init; } = string.Empty;
    }
}
