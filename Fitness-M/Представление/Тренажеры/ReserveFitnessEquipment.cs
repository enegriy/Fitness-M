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
    public partial class ReserveFitnessEquipment : Form
    {
        #region Prop

        /// <summary>
        /// Набор данных
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        private FitnessEquipmentWillBeReserve m_FitnessEquipmentWillBeReserve = null;
        /// <summary>
        /// Выбранный тренажер
        /// </summary>
        public FitnessEquipmentWillBeReserve FitnessEquipmentWillBeReserve
        {
            get { return m_FitnessEquipmentWillBeReserve; }
        }

        #endregion

        /// <summary>
        /// Показать форму
        /// </summary>
        public static ReserveFitnessEquipment FormShow(
            ClientDataSet dataSet, 
            DateTime visitDate)
        {
            var frm = new ReserveFitnessEquipment();
            frm.DataSet = dataSet;

            frm.fitnessEquipmentSchedule1.DataSet = dataSet;
            frm.fitnessEquipmentSchedule1.DateVisit = visitDate;

            if (frm.ShowDialog() == DialogResult.OK)
                return frm;
            return null;

        }

        public ReserveFitnessEquipment()
        {
            InitializeComponent();
        }


        private void CheckTime(
            FitnessEquipment fitnessEquipment, 
            DateTime dateVisit,
            TimeSpan timeStart, 
            TimeSpan timeFinish)
        {
            var listFreeTime = fitnessEquipment.ListFreeTime.Where(x => x.DateFrom.Date == dateVisit);

            foreach (var freeTime in listFreeTime)
            {
                if (freeTime.DateFrom.TimeOfDay > timeStart || 
                    freeTime.DateTo.TimeOfDay < timeFinish)
                    throw new BussinesException(string.Format("Невозможно записаться на {0} - {1}!",
                        timeStart.ToString(),
                        timeFinish.ToString()));
            }
        }


        private TimeSpan CompileDate(string time)
        {
            var index = time.IndexOf(":");
            var hour_str = time.Substring(0, index);
            var min_str = time.Substring(index+1, (time.Length-index)-1);

            if (string.IsNullOrEmpty(hour_str))
                hour_str = "0";

            if (string.IsNullOrEmpty(min_str))
                min_str = "0";

            int hour = int.Parse(hour_str);
            int min = int.Parse(min_str);

            if ((hour < 0 || hour > 23) || (min < 0 || min > 59))
            {
                tbTime.Focus();
                throw new BussinesException("Некорректно введено время записи!");
            }
            return new TimeSpan(hour,min,0);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    var fitnessEquipment = fitnessEquipmentSchedule1.FitnessEquipmentSelected;

                    var timeStart = CompileDate(tbTime.Text);

                    var timeFinish = timeStart.Add(
                        new TimeSpan(0, fitnessEquipment.RunningTime,0));

                    CheckTime(
                        fitnessEquipment, 
                        fitnessEquipmentSchedule1.DateVisit.Date,
                        timeStart, 
                        timeFinish);

                    m_FitnessEquipmentWillBeReserve = new FitnessEquipmentWillBeReserve();
                    m_FitnessEquipmentWillBeReserve.FitnessEquipmentReserve = fitnessEquipment;
                    m_FitnessEquipmentWillBeReserve.TimeFrom = timeStart;
                    m_FitnessEquipmentWillBeReserve.TimeTo = timeFinish;
                }
                catch (BussinesException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            
        }

        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbTime.Text))
            {
                tbTime.SelectionStart = 0;
                tbTime.SelectionLength = tbTime.Text.Length;
            }
        }
    }
}
