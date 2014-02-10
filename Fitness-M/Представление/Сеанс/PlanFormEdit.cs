using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    public partial class PlanFormEdit : Form
    {
        /// <summary>
        /// Набор данных
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        private TimeSpan m_PeriodTrainingStart;
        private TimeSpan m_PeriodTrainingFinish;
        /// <summary>
        /// Период тренировки с
        /// </summary>
        public TimeSpan PeriodTrainingStart
        {
            get { return m_PeriodTrainingStart; }
        }
        /// <summary>
        /// Период тренировки по
        /// </summary>
        public TimeSpan PeriodTrainingFinish
        {
            get { return m_PeriodTrainingFinish; }
        }

        /// <summary>
        /// Показать форму
        /// </summary>
        public static void FormShow(ClientDataSet dataSet)
        {
            var frm = new PlanFormEdit();
            frm.DataSet = dataSet;
            frm.ShowDialog();
        }

        

        public PlanFormEdit()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void InitGrid()
        {
            grid1.AutoGenerateColumns = false;
            var source = new BindingSource(new List<FitnessEquipmentWillBeReserve>(), "");
            grid1.DataSource = source;
        }

        private void btnAddFQ_Click(object sender, EventArgs e)
        {
            var curDate = System.DateTime.Now.Date;
            var visDate = dtDateVisit.Value.Date;

            if (curDate > visDate)
                throw new BussinesException("Нельзя бронировать на дату меньше текущей!");

            try
            {
                var frm = ReserveFitnessEquipment.FormShow(DataSet, visDate);
                if (frm != null)
                {
                    var fitnessWillBeReserve = frm.FitnessEquipmentWillBeReserve;

                    ((BindingSource)grid1.DataSource).Add(fitnessWillBeReserve);

                    SetPeriodTraining(fitnessWillBeReserve.TimeFrom, fitnessWillBeReserve.TimeTo);
                }
            }
            catch (BussinesException ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void SetPeriodTraining(TimeSpan timeFrom, TimeSpan timeTo)
        {
            if (timeFrom < m_PeriodTrainingStart || string.IsNullOrEmpty(tbTimeFrom.Text))
            {
                m_PeriodTrainingStart = timeFrom;
                tbTimeFrom.Text = timeFrom.ToShortTime();
            }
            if (timeTo > m_PeriodTrainingFinish || string.IsNullOrEmpty(tbTimeTo.Text))
            {
                m_PeriodTrainingFinish = timeTo;
                tbTimeTo.Text = timeTo.ToShortTime();
            } 
        }

        private void RecalcPeriodTraining()
        {
            var source = grid1.DataSource as BindingSource;
            if (source.Count == 0)
            {
                tbTimeFrom.Text = "";
                tbTimeTo.Text = "";
            }
            else
            {
                var listSource = (List<FitnessEquipmentWillBeReserve>)source.List;
                m_PeriodTrainingStart = listSource.Where(x => x.TimeFrom == listSource.Min(s => s.TimeFrom)).Select(x => x.TimeFrom).First();
                m_PeriodTrainingFinish = listSource.Where(x => x.TimeTo == listSource.Max(s => s.TimeTo)).Select(x => x.TimeTo).First();
                tbTimeFrom.Text = m_PeriodTrainingStart.ToShortTime();
                tbTimeTo.Text = m_PeriodTrainingFinish.ToShortTime();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var source = (BindingSource) grid1.DataSource;
            if (source.Current == null) return;

            if (MessageBox.Show(
                "Вы уверены что хоитет удалить объект?", 
                "Вопрос", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                source.RemoveCurrent();
                grid1.Refresh();
                RecalcPeriodTraining();
            }
        }

        private void OnCellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var currObj = (FitnessEquipmentWillBeReserve)grid1.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 1)
                e.Value = currObj.FitnessEquipmentReserve.Title;
            else if (e.ColumnIndex == 2)
                e.Value = currObj.FitnessEquipmentReserve.CountBalls;
            else if (e.ColumnIndex == 3)
                e.Value = currObj.TimeFrom.ToShortTime();
            else if (e.ColumnIndex == 4)
                e.Value = currObj.TimeTo.ToShortTime();
        }

        private void OnDateVisitChanged(object sender, EventArgs e)
        {
            ((BindingSource)grid1.DataSource).Clear();
            tbTimeFrom.Text = "";
            tbTimeTo.Text = "";
        }

        
    }
}
