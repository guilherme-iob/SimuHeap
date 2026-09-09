using SimuHeap.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Controls.CustomControls
{
    public partial class StyledDataGridView : DataGridView
    {
        public StyledDataGridView()
        {
            ConfigurarEstilo();
        }

        private void ConfigurarEstilo()
        {
            BorderStyle = BorderStyle.None;
            BackgroundColor = CoresInterface.Superficie;
            GridColor = CoresInterface.Borda;

            EnableHeadersVisualStyles = false;

            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;

            RowHeadersVisible = false;

            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;

            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ColumnHeadersHeight = 38;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            RowTemplate.Height = 42;

            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            DefaultCellStyle.ForeColor = CoresInterface.TextoPrincipal;
            DefaultCellStyle.BackColor = CoresInterface.Superficie;
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 239, 255);
            DefaultCellStyle.SelectionForeColor = CoresInterface.TextoPrincipal;
            DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);

            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.ForeColor = CoresInterface.TextoSecundario;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.SelectionForeColor = CoresInterface.TextoSecundario;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);

            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 253, 254);

            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            ScrollBars = ScrollBars.Vertical;

            DoubleBuffered = true;
        }
    }
}
