using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    public partial class VisualDetailSchedule : UserControl
    {
        #region Prop
        /// <summary>
        /// Список тренажеров
        /// </summary>
        public IList<FitnessEquipment> ListFitnessEquipment { get; set; }
        /// <summary>
        /// Список тренажеров забронировынный сейчас
        /// </summary>
        public IList<FitnessEquipmentWillBeReserve> ListFitnessEquipmentWillBeReserve { get; set; }
        /// <summary>
        /// Дата посещения
        /// </summary>
        public DateTime DateVisit { get; set; }
        /// <summary>
        /// Время работы с
        /// </summary>
        public TimeSpan TimeFrom { get; set; }
        /// <summary>
        /// Время работы по
        /// </summary>
        public TimeSpan TimeTo { get; set; }
        /// <summary>
        /// Контрол используется
        /// </summary>
        public UseControl ToUseControl { get; set; }
        
        #endregion

        #region Field
        
        private readonly string column_title = "ColumnTitle";
        bool isExistHeader = false;
        int storeCurrentFqId;
        
        #endregion

        public VisualDetailSchedule()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Init();
            FillHeader();
            FillFitnessEqRow();
        }

        private void Init()
        {
            ListFitnessEquipmentWillBeReserve = new List<FitnessEquipmentWillBeReserve>();
            dtTimePicker.Value = DateVisit;

            if (ToUseControl == UseControl.AsRegim)
            {
                dtTimePicker.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                tbFitnessEq.Visible = false;
                tbTime.Visible = false;
                btnPrint.Visible = true;
                btnAdd.Visible = false;
                btnClose.Visible = false;
            }
            else
            {
                dtTimePicker.Enabled = false;
                label2.Visible = true;
                label3.Visible = true;
                tbFitnessEq.Visible = true;
                tbTime.Visible = true;
                btnPrint.Visible = false;
                btnAdd.Visible = true;
                btnClose.Visible = true;
            }
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
                grid.Rows[rowIndex].ReadOnly = true;

                var listBusyTime = feqController.GetListBusyTime(fe, DateVisit);

                foreach (var busyTime in listBusyTime)
                {
                    foreach (DataGridViewCell cell in grid.Rows[rowIndex].Cells)
                    {
                        var timeFromCol = grid.Columns[cell.ColumnIndex].Tag;
                        if (timeFromCol != null && timeFromCol is TimeSpan &&
                            ((TimeSpan)timeFromCol >= busyTime.DateFrom.TimeOfDay &&
                            (TimeSpan)timeFromCol < busyTime.DateTo.TimeOfDay))
                        {
                            cell.Style.BackColor = Color.FromArgb(250, 110, 120);
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

        private void OnClickBtnPrint(object sender, EventArgs e)
        {
            ReportFitnessEquipmentBusy.ShowReport(dtTimePicker.Value.Date);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int fqId = (int)grid.CurrentRow.Tag;

                var fitnessEq = ListFitnessEquipment.FirstOrDefault(x => x.Id == fqId);
                var timeReserve = (TimeSpan)grid.Columns[grid.CurrentCell.ColumnIndex].Tag;
                var timeFinish = timeReserve.Add(new TimeSpan(0, fitnessEq.RunningTime, 0));

                CheckTime(fitnessEq, DateVisit, timeReserve, timeFinish);

                var fitEqWillBeReserve = new FitnessEquipmentWillBeReserve();
                fitEqWillBeReserve.FitnessEquipmentReserve = fitnessEq;
                fitEqWillBeReserve.TimeFrom = timeReserve;
                fitEqWillBeReserve.TimeTo = timeFinish;

                ListFitnessEquipmentWillBeReserve.Add(fitEqWillBeReserve);

                FillArea(timeReserve, timeFinish);
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        private void FillArea(TimeSpan timeStart ,TimeSpan timeFinish)
        {
            foreach (DataGridViewCell cell in grid.CurrentRow.Cells)
            {
                var timeFromCol = grid.Columns[cell.ColumnIndex].Tag;
                if (timeFromCol != null && timeFromCol is TimeSpan &&
                    ((TimeSpan)timeFromCol >= timeStart &&
                    (TimeSpan)timeFromCol < timeFinish))
                {
                    cell.Style.BackColor = Color.FromArgb(255, 170, 80);
                    cell.Style.SelectionBackColor = Color.FromArgb(255, 130, 20);
                    cell.ToolTipText = string.Format("{0} - {1}", timeStart.ToShortTime(), timeFinish.ToShortTime());
                }
            }
        }

        private void CheckTime(
            FitnessEquipment fitnessEquipment,
            DateTime dateVisit,
            TimeSpan timeStart,
            TimeSpan timeFinish)
        {
            bool isFreePeriod = false;
            
            isFreePeriod = !ListFitnessEquipmentWillBeReserve.Any(x =>
                x.FitnessEquipmentReserve == fitnessEquipment && 
                (x.TimeFrom <= timeFinish && 
                x.TimeTo >= timeStart));

            if (isFreePeriod)
            {
                isFreePeriod = false;

                var feqController = new FitnessEquipmentController();

                var listFreeTime = feqController.GetListFreeTime(fitnessEquipment, dateVisit, GetWorkPeriod());


                foreach (var freeTime in listFreeTime)
                {
                    if (freeTime.DateFrom.TimeOfDay <= timeStart &&
                        freeTime.DateTo.TimeOfDay >= timeFinish)
                        isFreePeriod = true;
                }
            }

            if (!isFreePeriod)
            {
                throw new BussinesException(string.Format("Невозможно записаться на {0} - {1}!",
                        timeStart.ToShortTime(),
                        timeFinish.ToShortTime()));
            }
        }

        /// <summary>
        /// Получить пероид работы на текущий день
        /// </summary>
        /// <returns></returns>
        private DateFromAndDateTo GetWorkPeriod()
        {
            var timeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom);
            var timeTo = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeTo);

            var dateFrom = new DateTime(DateVisit.Year, DateVisit.Month, DateVisit.Day, timeFrom.Hour, timeFrom.Minute, 0);
            var dateTo = new DateTime(DateVisit.Year, DateVisit.Month, DateVisit.Day, timeTo.Hour, timeTo.Minute, 0);

            return new DateFromAndDateTo(dateFrom, dateTo);
        }
    }
}
