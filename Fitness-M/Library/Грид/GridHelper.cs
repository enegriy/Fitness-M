using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Хэлпер для грида
    /// </summary>
    public static class GridHelper
    {
        public static void SetGridStyle(DataGridView grid)
        {
            var alternativeRow = new DataGridViewCellStyle();
            alternativeRow.BackColor = System.Drawing.Color.WhiteSmoke;
            alternativeRow.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            alternativeRow.SelectionForeColor = System.Drawing.Color.White;
            
            grid.AlternatingRowsDefaultCellStyle = alternativeRow;
            grid.MultiSelect = false;
            grid.AutoGenerateColumns = false;

            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = BorderStyle.Fixed3D;
            grid.GridColor = System.Drawing.Color.WhiteSmoke;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = System.Drawing.Color.White;
            defaultCellStyle.ForeColor = System.Drawing.Color.Black;
            defaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            defaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            defaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 8);

            grid.DefaultCellStyle = defaultCellStyle;
        }
    }
}
