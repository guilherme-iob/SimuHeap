using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Enums
{
    public enum TipoDestaqueSimulacao
    {
        Nenhum,

        BlocoEmAnalise,
        MelhorBlocoEncontrado,
        MelhorBlocoSelecionado,

        LiberandoBloco,
        ReduzindoBloco,
        ExpandindoBloco,
        MovendoBloco,

        InicializandoCalloc,
        Coalescing
    }
}
