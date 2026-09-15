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
            Text_CodeViewer.Codigo = ObterCodigo(casoUsoSimulacao);
        }

        private string ObterTitulo(CasoUsoSimulacao casoUsoSimulacao)
        {
            switch (casoUsoSimulacao)
            {
                case CasoUsoSimulacao.NotasEFaltas:
                    return "Notas e Faltas";
                case CasoUsoSimulacao.DuasProvas:
                    return "Duas Provas";
                case CasoUsoSimulacao.RedimensionamentoTurma:
                    return "Redimensionamento de Turma";
                case CasoUsoSimulacao.AltaFragInterna:
                    return "Alta Fragmentação Interna";
                case CasoUsoSimulacao.AltaFragExterna:
                    return "Alta Fragmentação Externa";
                case CasoUsoSimulacao.AlocacoesDiferentes:
                    return "Alocações Diferentes";
                case CasoUsoSimulacao.Mediana:
                    return "Mediana";
                case CasoUsoSimulacao.SubtracaoVetores:
                    return "Subtração de Vetores";
                case CasoUsoSimulacao.Letras:
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
                case CasoUsoSimulacao.AltaFragInterna:
                    return CasosDeUso.CodigoAltaFragInterna;
                case CasoUsoSimulacao.AltaFragExterna:
                    return CasosDeUso.CodigoAltaFragExterna;
                case CasoUsoSimulacao.AlocacoesDiferentes:
                    return CasosDeUso.CodigoCasoAlocacoesDiferentes;
                case CasoUsoSimulacao.Mediana:
                    return CasosDeUso.CodigoCasoMediana;
                case CasoUsoSimulacao.SubtracaoVetores:
                    return CasosDeUso.CodigoCasoSubtracaoVetores;
                case CasoUsoSimulacao.Letras:
                    return CasosDeUso.CodigoCasoLetras;
                case CasoUsoSimulacao.Digitos:
                    return CasosDeUso.CodigoCasoDigitos;
                default:
                    return "// Código do caso de uso desconhecido.";
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
