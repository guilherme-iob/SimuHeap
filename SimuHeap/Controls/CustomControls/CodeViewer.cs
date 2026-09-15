using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimuHeap.Controls.CustomControls
{
    public partial class CodeViewer : RichTextBox
    {
        private string codigo = string.Empty;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Codigo
        {
            get => codigo;
            set
            {
                codigo = value ?? string.Empty;
                ExibirCodigo();
            }
        }

        public CodeViewer()
        {
            ReadOnly = true;
            WordWrap = false;
            DetectUrls = false;

            BorderStyle = BorderStyle.None;
            ScrollBars = RichTextBoxScrollBars.Both;

            BackColor = Color.FromArgb(248, 250, 252);
            ForeColor = CoresInterface.TextoPrincipal;

            Font = new Font("Consolas", 10F, FontStyle.Regular);

            Padding = new Padding(8);
        }

        private void ExibirCodigo()
        {
            SuspendLayout();

            string[] linhas = codigo.Replace("\r\n", "\n").Split('\n');
            int digitos = Math.Max(2, linhas.Length.ToString().Length);

            for (int i = 0; i < linhas.Length; i++)
            {
                string numero = (i + 1).ToString().PadLeft(digitos);
                linhas[i] = $"{numero}    {linhas[i]}";
            }

            Text = string.Join(Environment.NewLine, linhas);

            AplicarRealceSintaxe();
            ColorirNumerosDasLinhas(digitos);

            SelectionStart = 0;
            SelectionLength = 0;

            ResumeLayout();
        }

        private void AplicarRealceSintaxe()
        {
            SelectAll();
            SelectionColor = CoresInterface.TextoPrincipal;

            AplicarCor(@"^\s*\d+\s+#.*$", Color.FromArgb(190, 60, 45), RegexOptions.Multiline);

            AplicarCor(@"\b(char|short|int|long|float|double|void|const|return|if|else|for|while|do|switch|case|break|continue|struct|typedef)\b",
                Color.FromArgb(35, 125, 230));

            AplicarCor(@"\b(malloc|calloc|realloc|free|sizeof)\b",
                Color.FromArgb(35, 85, 210));

            AplicarCor(@"\b\d+([.,]\d+)?[fF]?\b",
                Color.FromArgb(0, 135, 150));

            AplicarCor("\"(?:\\\\.|[^\"\\\\])*\"",
                Color.FromArgb(180, 90, 30));

            AplicarCor(@"//.*?$|/\*[\s\S]*?\*/",
                Color.FromArgb(40, 135, 55), RegexOptions.Multiline);
        }

        private void AplicarCor(string padrao, Color cor, RegexOptions options = RegexOptions.None)
        {
            foreach (Match match in Regex.Matches(Text, padrao, options))
            {
                Select(match.Index, match.Length);
                SelectionColor = cor;
            }
        }

        private void ColorirNumerosDasLinhas(int digitos)
        {
            for (int i = 0; i < Lines.Length; i++)
            {
                int inicio = GetFirstCharIndexFromLine(i);

                if (inicio < 0)
                    continue;

                Select(inicio, digitos);
                SelectionColor = CoresInterface.TextoSuave;
            }
        }
    }
}
