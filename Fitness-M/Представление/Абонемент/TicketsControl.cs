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

        public TicketsControl()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            InitDataGridKindTickets();
            InitDataGridTickets();
        }

        private void InitDataGridTickets()
        {
            GridHelper.SetGridStyle(gridAllTickets);
            gridAllTickets.DataSource = new BindingSource( new TicketMixedManager().GetListTicketMixed(),"");
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
    }
}
