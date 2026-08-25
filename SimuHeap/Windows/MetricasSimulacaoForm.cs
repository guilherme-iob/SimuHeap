using SimuHeap.Models;
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
    public partial class MetricasSimulacaoForm : Form
    {
        public MetricasSimulacaoForm()
        {
            InitializeComponent();

            InicializarLabels();
        }

        private void InicializarLabels()
        {
            // Uso da memória
            Lbl_BytesOcupados.Text = "Bytes ocupados: 0 bytes";
            Lbl_BytesLivres.Text = "Bytes livres: 0 bytes";
            Lbl_UsoHeap.Text = "Uso da heap: 0,00%";

            // Fragmentação interna
            Lbl_BytesFragInterna.Text = "Bytes de fragmentação interna: 0 bytes";
            Lbl_FragInterna.Text = "Fragmentação interna: 0,00%";
            Lbl_Padding.Text = "Bytes de padding: 0 bytes";

            // Fragmentação externa
            Lbl_FragExterna.Text = "Fragmentação externa: 0,00%";
            Lbl_MaiorBlocoLivre.Text = "Maior bloco livre: 0 bytes";

            // Memória inutilizável
            Lbl_MemInutilizavel.Text = "Bytes inutilizáveis: 0 bytes";
            Lbl_PercentualInutilizavel.Text = "Memória inutilizável: 0,00%";
            LblBlocosInutilizaveis.Text = "Blocos inutilizáveis: 0";

            // Metadados
            Lbl_Metadados.Text = "Bytes de metadados: 0 bytes";
        }
        public void AtualizarMetricas(MetricasHeap metricas)
        {
            if (metricas is null)
                return;

            // ============================================
            // Uso da memória
            // ============================================

            Lbl_BytesOcupados.Text =
                $"Bytes ocupados: {metricas.BytesOcupados} bytes";

            Lbl_BytesLivres.Text =
                $"Bytes livres: {metricas.BytesLivres} bytes";

            Lbl_UsoHeap.Text =
                $"Uso da heap: {metricas.PercentualUsoMemoria:F2}%";


            // ============================================
            // Fragmentação interna
            // ============================================

            Lbl_BytesFragInterna.Text =
                $"Bytes de fragmentação interna: {metricas.BytesFragmentacaoInterna} bytes";

            Lbl_FragInterna.Text =
                $"Fragmentação interna: {metricas.PercentualFragmentacaoInterna:F2}%";

            Lbl_Padding.Text =
                $"Bytes de padding: {metricas.BytesPadding} bytes";


            // ============================================
            // Fragmentação externa
            // ============================================

            Lbl_FragExterna.Text =
                $"Fragmentação externa: {metricas.PercentualFragmentacaoExterna:F2}%";

            Lbl_MaiorBlocoLivre.Text =
                $"Maior bloco livre: {metricas.TamanhoMaiorBlocoLivre} bytes";


            // ============================================
            // Memória inutilizável
            // ============================================

            Lbl_MemInutilizavel.Text =
                $"Bytes inutilizáveis: {metricas.BytesInutilizaveis} bytes";

            Lbl_PercentualInutilizavel.Text =
                $"Memória inutilizável: {metricas.PercentualMemoriaInutilizavel:F2}%";

            LblBlocosInutilizaveis.Text =
                $"Blocos inutilizáveis: {metricas.QuantidadeBlocosInutilizaveis}";


            // ============================================
            // Metadados
            // ============================================

            Lbl_Metadados.Text =
                $"Bytes de metadados: {metricas.BytesMetadados} bytes";
        }
    }
}
