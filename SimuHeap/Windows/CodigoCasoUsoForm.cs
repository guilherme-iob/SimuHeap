using SimuHeap.Enums;
using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuHeap.Windows
{
    public partial class CodigoCasoUsoForm : Form
    {
        public CodigoCasoUsoForm(CasoUsoSimulacao casoUsoSimulacao)
        {
            InitializeComponent();
            Text = ObterTitulo(casoUsoSimulacao);
            LblTitulo.Text = Text;
            Text_Codigo.Text = ObterCodigo(casoUsoSimulacao);
        }

        private string ObterTitulo(CasoUsoSimulacao casoUsoSimulacao)
        {
            switch (casoUsoSimulacao)
            {
                case CasoUsoSimulacao.NotasEFaltas:
                    return "Caso 1 - Notas e Faltas";
                case CasoUsoSimulacao.DuasProvas:
                    return "Caso 2 - Duas Provas";
                case CasoUsoSimulacao.RedimensionamentoTurma:
                    return "Caso 3 - Redimensionamento de Turma";
                default:
                    return "Caso de Uso Desconhecido";
            }
        }

        private string ObterCodigo(CasoUsoSimulacao casoUsoSimulacao)
        {
            switch (casoUsoSimulacao)
            {
                case CasoUsoSimulacao.NotasEFaltas:
                    return CasosDeUso.CodigoCaso1;
                case CasoUsoSimulacao.DuasProvas:
                    return CasosDeUso.CodigoCaso2;
                case CasoUsoSimulacao.RedimensionamentoTurma:
                    return CasosDeUso.CodigoCaso3;
                default:
                    return "// Código do caso de uso desconhecido.";
            }
        }
    }
}
