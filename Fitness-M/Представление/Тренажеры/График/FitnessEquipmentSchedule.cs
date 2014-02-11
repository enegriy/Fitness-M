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
    public partial class FitnessEquipmentSchedule : UserControl
    {

        #region Prop

        /// <summary>
        /// Данные
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        /// <summary>
        /// Дата посещений
        /// </summary>
        public DateTime DateVisit
        {
            get;
            set;
        }

        /// <summary>
        /// Показать дату посещения
        /// </summary>
        public bool VisibleDateVisit
        {
            get;
            set;
        }

        /// <summary>
        /// Тренажер
        /// </summary>
        public FitnessEquipment FitnessEquipmentSelected
        {
            get { return m_FitnessEquipmentSelected; }
        }

        /// <summary>
        /// Свободное время
        /// </summary>
        public DateFromAndDateTo FreeTimeSelected
        {
            get { return m_FreeTimeSelected; }
        }

        #endregion

        #region Field

        /// <summary>
        /// Период работы
        /// </summary>
        private DateFromAndDateTo m_WorkPeriod = null;
        /// <summary>
        /// Тренажер
        /// </summary>
        private FitnessEquipment m_FitnessEquipmentSelected = null;
        /// <summary>
        /// Свободное время
        /// </summary>
        private DateFromAndDateTo m_FreeTimeSelected = null;

        #endregion

        public FitnessEquipmentSchedule()
        {
            InitializeComponent();
        }


        private void FitnessEquipmentSchedule_Load(object sender, EventArgs e)
        {
            if (DateVisit == null || DateVisit == DateTime.MinValue) 
                throw new BussinesException("Не задана дата посещения!");

            GridHelper.SetGridStyle(dataGridView1);
            GridHelper.SetGridStyle(dataGridView2);

            dtVisit.Value = DateVisit;

            SetVisibleVisit();
            
        }

        private void SetVisibleVisit()
        {
            if (VisibleDateVisit)
            {
                label1.Visible = true;
                dtVisit.Visible = true;
            }
            else
            {
                label1.Visible = false;
                dtVisit.Visible = false;
            }
        }

        private void FillDataGrids()
        {
            SetTimeToFitnessEquipment(DataSet.ListFitnessEquipment);
            var bindingFq = new BindingSource(DataSet.ListFitnessEquipment, "");
            var bindingFt = new BindingSource(bindingFq, "ListFreeTime");

            dataGridView1.DataSource = bindingFq;
            dataGridView2.DataSource = bindingFt;

            bindingFq.CurrentChanged += OnFitnessEqChange;
            OnFitnessEqChange(bindingFq, null);

            bindingFt.CurrentChanged += OnFreeTimeChange;
            OnFreeTimeChange(bindingFt, null);
        }

        private void SetTimeToFitnessEquipment(IList<FitnessEquipment> listFitnessEquipment)
        {
            m_WorkPeriod = GetWorkPeriod();

            var feqController = new FitnessEquipmentController();

            foreach (FitnessEquipment fq in listFitnessEquipment)
            {
                fq.ListFreeTime = feqController.GetListFreeTime(fq, DateVisit, m_WorkPeriod);
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

        private void OnValueChanged(object sender, EventArgs e)
        {
            DateVisit = dtVisit.Value;
            FillDataGrids();
        }

        public void OnFitnessEqChange(object sender, EventArgs e)
        {
            var dataSource = (BindingSource)sender;
            m_FitnessEquipmentSelected = (FitnessEquipment)dataSource.Current;
        }

        public void OnFreeTimeChange(object sender, EventArgs e)
        {
            var dataSource = (BindingSource)sender;
            m_FreeTimeSelected = (DateFromAndDateTo)dataSource.Current;
        }


    }
}