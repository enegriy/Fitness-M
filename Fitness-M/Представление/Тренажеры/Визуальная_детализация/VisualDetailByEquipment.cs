using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    public partial class VisualDetailByEquipment : Form
    {
        private IList<FitnessEquipment> ListFitnessEquipment{get;set;}
        private DateTime DateVisit { get; set; }
        private TimeSpan TimeFrom { get; set; }
        private TimeSpan TimeTo { get; set; }

        private readonly string column_title = "ColumnTitle";
        bool isExistHeader = false;
        int storeCurrentFqId;

        public VisualDetailByEquipment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(
            IList<FitnessEquipment> listFitnessEq, 
            DateTime dateVisit,
            TimeSpan timeFrom,
            TimeSpan timeTo)
        {
            var frm = new VisualDetailByEquipment();

            frm.ListFitnessEquipment = listFitnessEq;
            frm.DateVisit = dateVisit;
            frm.TimeFrom = timeFrom;
            frm.TimeTo = timeTo;

            frm.ShowDialog();
            return frm;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Init();
            FillHeader();
            FillFitnessEqRow();
        }

        private void Init()
        {
            dtTimePicker.Value = DateVisit;
        }

        private void FillFitnessEqRow()
        {
            if (grid.Rows.Count > 0)
                grid.Rows.Clear();

            var feqController = new FitnessEquipmentController();

            foreach (var fe in ListFitnessEquipment)
            {
                int rowIndex = grid.Rows.Add();
                grid.Rows[rowIndex].Tag = fe.Id;
                grid.Rows[rowIndex].Cells[column_title].Value = fe.Title;

                var listBusyTime = feqController.GetListBusyTime(fe, DateVisit);
                foreach (var busyTime in listBusyTime)
                {
                    foreach (DataGridViewCell cell in grid.Rows[rowIndex].Cells)
                    {
                        var timeFromCol = grid.Columns[cell.ColumnIndex].Tag;
                        if (timeFromCol != null && timeFromCol is TimeSpan &&
                            ((TimeSpan)timeFromCol >= busyTime.DateFrom.TimeOfDay &&
                            (TimeSpan)timeFromCol <= busyTime.DateTo.TimeOfDay))
                        {
                            cell.Style.BackColor = Color.Red;
                            cell.Style.SelectionBackColor = Color.FromArgb(213, 0, 0);
                            cell.ToolTipText = string.Format("{0} - {1}", busyTime.DateFrom.TimeOfDay.ToShortTime(), busyTime.DateTo.TimeOfDay.ToShortTime());                  
                        }
                    }
                }
            }
        }

        private void FillHeader()
        {
            if (isExistHeader) return;

            TimeSpan tsStart = TimeFrom;
            TimeSpan tsFinish = TimeTo;

            TimeSpan tsStep = new TimeSpan(00, 10, 00);

            var tsCur = tsStart;
            while (tsCur.Minutes % 10 != 0)
            {
                tsCur = tsCur.Add(new TimeSpan(0, -1, 0));
            }

            //Добавить колонку для названия тренажера
            var col = new DataGridViewTextBoxColumn();
            col.Name = column_title;
            col.HeaderText = "";
            col.Frozen = true;
            col.Width = 150;
            grid.Columns.Add(col);

            while (tsCur <= tsFinish)
            {
                string headerName = "";
                if (tsCur.Minutes == 30 || tsCur.Minutes == 0)
                    headerName = string.Format("{0:00}:{1:00}", tsCur.Hours, tsCur.Minutes);

                col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("col_{0:00}:{1:00}", tsCur.Hours, tsCur.Minutes);
                col.HeaderText = headerName;
                col.Tag = tsCur;
                col.Width = 36;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                grid.Columns.Add(col);

                tsCur = tsCur.Add(tsStep);
            }

            isExistHeader = true;
        }

        private void Dt_ValueChanged(object sender, EventArgs e)
        {
            DateVisit = dtTimePicker.Value;
            FillHeader();
            FillFitnessEqRow();
        }

        private void OnCurrentCellChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null && grid.CurrentRow.Tag != null && 
                (int)grid.CurrentRow.Tag != storeCurrentFqId)
            {
                storeCurrentFqId = (int)grid.CurrentRow.Tag;
                var fq = ListFitnessEquipment.FirstOrDefault(x => x.Id == storeCurrentFqId);
                if (fq != null)
                    tbFitnessEq.Text = fq.Title;
            }

            if (grid.CurrentCell != null)
            {
                object tag = grid.Columns[grid.CurrentCell.ColumnIndex].Tag;
                if (tag is TimeSpan)
                {
                    tbTime.Text = ((TimeSpan)tag).ToShortTime();
                }
            }
        }

    }
}
