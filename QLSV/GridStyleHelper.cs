using System.Drawing;
using System.Windows.Forms;

namespace QLSV
{
    internal static class GridStyleHelper
    {
        public static void ApplyPrimary(DataGridView grid)
        {
            Apply(grid,
                Color.FromArgb(30, 64, 175),
                Color.FromArgb(219, 234, 254),
                Color.FromArgb(248, 250, 252));
        }

        public static void ApplyAccent(DataGridView grid)
        {
            Apply(grid,
                Color.FromArgb(14, 116, 144),
                Color.FromArgb(204, 251, 241),
                Color.FromArgb(240, 253, 250));
        }

        private static void Apply(
            DataGridView grid,
            Color headerColor,
            Color selectionColor,
            Color alternateRowColor)
        {
            if (grid == null)
            {
                return;
            }

            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.FromArgb(226, 232, 240);
            grid.RowHeadersVisible = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowTemplate.Height = 32;
            grid.ColumnHeadersHeight = 40;

            grid.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = headerColor;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            grid.DefaultCellStyle.SelectionBackColor = selectionColor;
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            grid.RowsDefaultCellStyle.SelectionBackColor = selectionColor;
            grid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            grid.AlternatingRowsDefaultCellStyle.BackColor = alternateRowColor;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionColor;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
        }
    }
}
