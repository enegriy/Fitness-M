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
    public partial class TicketsControl : UserControl
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
        #endregion

        private TicketFilter m_Filter = new TicketFilter();
        private TicketMixedManager ticketMixManager = new TicketMixedManager();

        public TicketsControl()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            ConstraintByUser();
            InitDataGridKindTickets();
            InitDataGridTickets();
        }

        private void ConstraintByUser()
        {
            if (CurrentUser.Role != Roles.Administrator)
            {
                gridKindTicket.Enabled = false;
                panel1.Enabled = false;
            }
        }

        private void InitDataGridTickets()
        {
            GridHelper.SetGridStyle(gridAllTickets);

            m_Filter.Balance = (int)numBalance.Value;

            gridAllTickets.DataSource = new BindingSource(
                ticketMixManager.GetListTicketMixed(m_Filter), "");
        }

        public void InitDataGridKindTickets()
        {
            if (DataSet == null) 
                throw new BussinesException("Не задан источник данных");

            GridHelper.SetGridStyle(gridKindTicket);
            gridKindTicket.DataSource = new BindingSource(DataSet.ListKindTickets,"");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var kindTickets = new KindTickets();
            KindTicketsFormEdit.FormShow(ActionState.Add, kindTickets);
            if (!kindTickets.IsEmpty)
            {
                ((BindingSource)gridKindTicket.DataSource).Add(kindTickets);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var kindTicket = GetSelectedKindTicket();

                if (kindTicket.UseKindTicket())
                    throw new BussinesException("Нельзя изменить, абонементы этого виды были проданы клиентам!");

                if (kindTicket != null)
                {
                    KindTicketsFormEdit.FormShow(ActionState.Edit, kindTicket);
                }
                gridKindTicket.Refresh();
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var kindTicket = GetSelectedKindTicket();

                if (kindTicket.UseKindTicket())
                    throw new BussinesException("Нельзя удалить, абонементы этого виды были проданы клиентам!");

                if (MessageHelper.ShowQuestion(
                    "Вы уверены что хотите удалить вид шаблона ?") == DialogResult.Yes)
                {
                    if (kindTicket != null)
                    {
                        kindTicket.Delete();
                        DataSet.ListKindTickets.Remove(kindTicket);
                        gridKindTicket.DataSource = new BindingSource(DataSet.ListKindTickets, "");
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Выделенный абонемент
        /// </summary>
        /// <returns></returns>
        private KindTickets GetSelectedKindTicket()
        {
            return (KindTickets)((BindingSource)gridKindTicket.DataSource).Current;
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("Вы хотите снять абонемент данного типа с продажи?") == DialogResult.Yes)
            {
                var kindTickets = GetSelectedKindTicket();
                if(!kindTickets.IsInactive)
                    kindTickets.DoInactive();
            }

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("Вы хотите ввести абонемент данного типа в продажу?") == DialogResult.Yes)
            {
                var kindTickets = GetSelectedKindTicket();
                if (kindTickets.IsInactive)
                    kindTickets.DoActive();
            }

        }

        private void OnBtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                m_Filter.ClientNumber = string.IsNullOrEmpty(tbClientNumber.Text) ?
                    0 :
                    int.Parse(tbClientNumber.Text);
            }
            catch (FormatException)
            {
                m_Filter.ClientNumber = 0;
            }
            m_Filter.ClientSurname = tbClientSurname.Text;
            m_Filter.Period = cbPeriod.SelectedIndex;
            m_Filter.NotExistTickets = cbNotExist.Checked;
            m_Filter.Balance = (int)numBalance.Value;

            var listTickets = ticketMixManager.GetListTicketMixed(m_Filter);
            gridAllTickets.DataSource = new BindingSource(
                listTickets, "");
            
        }

        private void OnCellValueNeed(object sender, DataGridViewCellValueEventArgs e)
        {
            var currObj = (TicketMixed)gridAllTickets.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 9)
                e.Value = currObj.Debt == 0 ? "" : currObj.Debt.ToString();
        }

    }
}
