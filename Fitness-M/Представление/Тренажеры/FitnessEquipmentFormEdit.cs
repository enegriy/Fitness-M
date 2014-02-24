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
    public partial class FitnessEquipmentFormEdit : Form
    {
        private FitnessEquipment m_CurrentFQ;

        private bool m_IsClosingForm = true;

        /// <summary>
        /// Действие
        /// </summary>
        private ActionState m_Action;
        /// <summary>
        /// Действие
        /// </summary>
        public ActionState Action
        {
            get { return m_Action; }
            set { m_Action = value; }
        }

        /// <summary>
        /// Значение заголовка окна
        /// </summary>
        public void SetFormTitle()
        {
            if (Action != null && Action == ActionState.Add)
                Text = "Добавить тренажер";
            else if (Action != null && Action == ActionState.Edit)
                Text = "Изменить тренажер";
            else Text = "Форма редактирования";
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, FitnessEquipment fitnessFQ)
        {
            if (fitnessFQ == null)
                throw new BussinesException("Не возможно открыть форму, не задан клиент!");

            var frm = new FitnessEquipmentFormEdit();
            frm.Action = action;
            frm.m_CurrentFQ = fitnessFQ;
            frm.ShowDialog();
            return frm;
        }

        public FitnessEquipmentFormEdit()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            SetFormTitle();
            BindingFQ();
        }

        /// <summary>
        /// Биндинг
        /// </summary>
        private void BindingFQ()
        {
            textBox1.DataBindings.Add("Text", m_CurrentFQ, "Title");
            numRunTime.DataBindings.Add("Value", m_CurrentFQ, "RunningTime",false,DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown2.DataBindings.Add("Value", m_CurrentFQ, "CountBalls");
        }

        private void OnValidating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validating(sender, e, ref m_IsClosingForm, errorProviderFQ);
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if ((DialogResult == DialogResult.OK && m_IsClosingForm) ||
                DialogResult == DialogResult.Cancel)
            {
                if (DialogResult == DialogResult.OK)
                {
                    if (Action == ActionState.Add)
                        m_CurrentFQ.Save();
                    else if (Action == ActionState.Edit)
                        m_CurrentFQ.Update();
                }

                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
