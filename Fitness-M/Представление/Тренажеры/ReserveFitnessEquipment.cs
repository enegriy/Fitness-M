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
        private bool m_IsClosingForm = true;

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


        

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (DialogResult == DialogResult.OK && m_IsClosingForm)
            {
                try
                {
                    var fitnessEquipment = fitnessEquipmentSchedule1.FitnessEquipmentSelected;

                    var timeStart = TimeHelper.CompileDate(tbTime.Text);

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

                    e.Cancel = false;
                }
                catch (BussinesException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                
            }
            else if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false; ;
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

        private void OnTimeValidating(object sender, CancelEventArgs e)
        {
            var time = tbTime.Text.Replace(" ", "").Replace(":","");
            if (string.IsNullOrEmpty(time))
            {
                m_IsClosingForm = false;
                errorProvider1.SetError((Control)sender, "Значение не может быть пустым");
            }
            else
            {
                m_IsClosingForm = true;
                errorProvider1.SetError((Control)sender, "");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
