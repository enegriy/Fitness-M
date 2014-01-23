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
        /// <summary>
        /// Клиент для которого добавляем абонемент
        /// </summary>
        private Client m_Client;

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
        /// Выбранный вид тикета
        /// </summary>
        public int SelectedIdKindTickets { get; set; }

        /// <summary>
        /// Источник данных
        /// </summary>
        public object DataSource 
        { 
            set 
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = value; 
            } 
        }

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


        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedIdKindTickets = (int)dataGridView1.CurrentRow.Cells["clmId"].Value;
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, Client client, ClientDataSet dataSet)
        {
            if (client == null)
                throw new BussinesException("Не возможно открыть форму, не задан клиент!");

            var frm = new KindTicketsFormSelect();
            frm.DataSource = dataSet.ListKindTickets;
            frm.Action = action;
            frm.m_Client = client;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var ticketController = new TicketsController();
                ticketController.DataSet = dataSet;
                ticketController.CreateTicket(client, frm.SelectedIdKindTickets);
            }
                
            return frm;
        }

        
    }
}
