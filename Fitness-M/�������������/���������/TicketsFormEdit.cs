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
    public partial class TicketsFormEdit : Form
    {
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

        public TicketsFormEdit()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            SetFormTitle();
            BindingClient();

        }

        /// <summary>
        /// Биндинг
        /// </summary>
        private void BindingClient()
        {
            numericUpDown4.DataBindings.Add("Value", m_KindTickets, "Price");
            numericUpDown1.DataBindings.Add("Value", m_KindTickets, "Period");
            numericUpDown2.DataBindings.Add("Value", m_KindTickets, "CountBalls");
            numericUpDown3.DataBindings.Add("Value", m_KindTickets, "CountVisits");
            checkBox1.DataBindings.Add("Checked", m_KindTickets, "IsOnlyGroup");
            checkBox2.DataBindings.Add("Checked", m_KindTickets, "IsInactive");
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, KindTickets kindTickets)
        {
            if (kindTickets == null)
                throw new BussinesException("Не возможно открыть форму!");

            var frm = new TicketsFormEdit();
            frm.Action = action;
            frm.m_KindTickets = kindTickets;
            frm.ShowDialog();
            return frm;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
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

                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

    }

}
