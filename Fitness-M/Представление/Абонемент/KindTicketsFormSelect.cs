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

        /// <summary>
        /// Вид тикета который был выбран
        /// </summary>
        public KindTickets KindTicketsSelected
        {
            get;
            set;
        }
        #endregion

        private bool m_IsClosingForm = true;

        
        public KindTicketsFormSelect()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static KindTickets FormShow(Client client, ClientDataSet dataSet)
        {
            if (client == null)
                throw new BussinesException("Не возможно открыть форму, не задан клиент!");

            var frm = new KindTicketsFormSelect();

            //Показываю только действующие абонементы
            var activeTickets = dataSet.ListKindTickets.Where(x => 
                x.IsInactive == false).ToArray();
            frm.DataSource = activeTickets;
            frm.m_Client = client;

            if (frm.ShowDialog() == DialogResult.OK)
                return frm.KindTicketsSelected;
            return null;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var ticketController = new TicketsController();

                if (DialogResult == DialogResult.OK)
                {
                    var currentKindTicket = ((BindingSource)gridKindTickets.DataSource).Current as KindTickets;
                    if (currentKindTicket == null)
                        throw new BussinesException("Не выбран абонемент!");

                    if (currentKindTicket.IsOnlyGroup)
                    {
                        if (ticketController.IsExistTicketOnlyGroup(m_Client))
                            throw new BussinesException("У клиента уже существует абонемент на групповые занятия!");
                    }
                    else
                    {
                        if (ticketController.IsExistTicketOnFitnessEq(m_Client))
                            throw new BussinesException("У клиента существует абонемент с неиспользуемыми баллами!");
                    }

                    KindTicketsSelected = currentKindTicket;
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Двойное нажатие
        /// </summary>
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var source = gridKindTickets.DataSource as BindingSource;
            if (source.Current != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        
    }
}
