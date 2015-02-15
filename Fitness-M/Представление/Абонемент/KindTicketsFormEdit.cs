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
    public partial class KindTicketsFormEdit : Form
    {
        private KindTickets m_KindTicketSnapshot;
        private KindTickets m_KindTickets;

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
                Text = "Добавить вид абонемента";
            else if (Action != null && Action == ActionState.Edit)
                Text = "Изменить вид абонемента";
            else 
                Text = "Форма редактирования";
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, KindTickets kindTickets)
        {
            if (kindTickets == null)
                throw new BussinesException("Не возможно открыть форму!");

            var frm = new KindTicketsFormEdit();
            frm.Action = action;
            frm.m_KindTickets = kindTickets;
            frm.ShowDialog();
            return frm;
        }

        public KindTicketsFormEdit()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            m_KindTicketSnapshot = m_KindTickets.SnapShot();
            SetFormTitle();
            BindingClient();

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if ((DialogResult == DialogResult.OK && m_IsClosingForm) ||
                    DialogResult == DialogResult.Cancel)
                {
                    if (DialogResult == DialogResult.OK)
                    {
                        if (Action == ActionState.Add)
                            m_KindTickets.Save();
                        else if (Action == ActionState.Edit)
                            m_KindTickets.Update();
                    }
                    else if (DialogResult == DialogResult.Cancel)
                    {
                        m_KindTickets.RestoreBySnapShot(m_KindTicketSnapshot);
                    }

                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
            catch (BussinesException exc)
            {
                e.Cancel = true;
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Биндинг
        /// </summary>
        private void BindingClient()
        {
            numericUpDown4.DataBindings.Add("Value", m_KindTickets, "Price",false,DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Value", m_KindTickets, "Period", false, DataSourceUpdateMode.OnPropertyChanged);
            numCountVisit.DataBindings.Add("Value", m_KindTickets, "CountVisits", false, DataSourceUpdateMode.OnPropertyChanged);
            checkBox2.DataBindings.Add("Checked", m_KindTickets, "IsInactive", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }

}
