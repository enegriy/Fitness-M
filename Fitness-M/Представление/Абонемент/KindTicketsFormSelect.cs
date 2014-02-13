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
    public partial class KindTicketsFormSelect : Form
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
        /// Клиент для которого добавляем абонемент
        /// </summary>
        private Client m_Client;

        /// <summary>
        /// Источник данных
        /// </summary>
        public object DataSource
        {
            set
            {
                GridHelper.SetGridStyle(gridKindTickets);
                gridKindTickets.DataSource = new BindingSource(value, "");
            }
        }
        #endregion

        private bool m_IsClosingForm = true;

        
        public KindTicketsFormSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Значение заголовка окна
        /// </summary>
        public void SetFormTitle()
        {
            if (Action != null && Action == ActionState.Select)
                Text = "Выбрать абонемент";
            else
                Text = "Форма редактирования";
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            SetFormTitle();
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, Client client, ClientDataSet dataSet)
        {
            if (client == null)
                throw new BussinesException("Не возможно открыть форму, не задан клиент!");

            var frm = new KindTicketsFormSelect();
            var activeTickets = dataSet.ListKindTickets.Where(x => x.IsInactive == false).ToArray();
            frm.DataSource = activeTickets;
            frm.Action = action;
            frm.m_Client = client;
            frm.DataSet = dataSet;
            frm.ShowDialog();
            return frm;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    var ticketController = new TicketsController();

                    object currentKindTicket = ((BindingSource)gridKindTickets.DataSource).Current;
                    if (currentKindTicket == null)
                        throw new BussinesException("Не выбран абонемент!");

                    if (((KindTickets)currentKindTicket).IsOnlyGroup)
                    {
                        if (ticketController.IsExistTicketOnlyGroup(m_Client))
                            throw new BussinesException("У клиента уже существует абонемент на групповые занятия!");
                    }
                    else
                    {
                        if (ticketController.IsExistTicketOnFitnessEq(m_Client))
                            throw new BussinesException("У клиента существует абонемент с неиспользуемыми баллами!");
                    }

                    var newTicket = ticketController.CreateTicket(m_Client, (KindTickets)currentKindTicket);
                    DataSet.ListTickets.Add(newTicket);
                    DataSet.SetSpecificationForClients();
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
                e.Cancel = true;
            }
        }

        
    }
}
