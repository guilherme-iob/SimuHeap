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
    public partial class LegendaCoresForm : Form
    {
        public LegendaCoresForm(bool usarLegendasDetalhadas)
        {
            InitializeComponent();

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlowLayoutPanel_Legenda.AutoSize = true;
            FlowLayoutPanel_Legenda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanel_Legenda.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel_Legenda.WrapContents = false;

            AdicionarItemLegenda(CoresSimulacao.BlocoLivre, "Bloco livre");
            AdicionarItemLegenda(CoresSimulacao.BlocoOcupado, "Bloco ocupado");

            AdicionarItemLegenda(CoresSimulacao.BlocoEmAnalise, "Bloco em análise");
            AdicionarItemLegenda(CoresSimulacao.MelhorBlocoEncontrado, "Melhor bloco encontrado");
            AdicionarItemLegenda(CoresSimulacao.MelhorBlocoSelecionado, "Melhor bloco selecionado");

            if (usarLegendasDetalhadas)
            {
                AdicionarItemLegenda(CoresSimulacao.BlocoSendoLiberado, "Bloco sendo liberado");
                AdicionarItemLegenda(CoresSimulacao.BlocoSendoReduzido, "Bloco sendo reduzido");
                AdicionarItemLegenda(CoresSimulacao.BlocoSendoExpandido, "Bloco sendo expandido");
                AdicionarItemLegenda(CoresSimulacao.BlocoSendoMovido, "Bloco sendo movido");
                AdicionarItemLegenda(CoresSimulacao.BlocoInicializadoCalloc, "Bloco inicializado pelo calloc");
            }

            
            AdicionarItemLegenda(CoresSimulacao.BlocoCoalescing, "Bloco envolvido no coalescing");
        }

        private void AdicionarItemLegenda(Color cor, string descricao)
        {
            Panel painelCor = new()
            {
                BackColor = cor,
                Width = 24,
                Height = 24,
                Margin = new Padding(3, 3, 10, 3),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label label = new()
            {
                Text = descricao,
                AutoSize = true,
                Anchor = AnchorStyles.Left
            };

            FlowLayoutPanel item = new()
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5)
            };

            item.Controls.Add(painelCor);
            item.Controls.Add(label);

            FlowLayoutPanel_Legenda.Controls.Add(item);
        }
    }
}
