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
    public partial class ClientsControl : UserControl
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

        public ClientsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        private void OnClientControlLoad(object sender, EventArgs e)
        {
            //Стили и сточники данных для грида
            InitDataGrid();
        }

        /// <summary>
        /// Инициализация грида
        /// </summary>
        public void InitDataGrid()
        {
            GridHelper.SetGridStyle(gridClients);
            GridHelper.SetGridStyle(gridTickets);
            GridHelper.SetGridStyle(gridVisits);

            if (DataSet == null)
                throw new BussinesException("Не задан источник данных");

            SetBinding(DataSet.ListClients);
        }

        /// <summary>
        /// Биндинг для гридов
        /// </summary>
        private void SetBinding(IList<Client> listClient)
        {
            var bindingClients = new BindingSource(listClient, "");
            var bindingTickets = new BindingSource(bindingClients, "ListTicketsActive");
            var bindingVisits = new BindingSource(bindingClients, "ListVisitActive");

            gridClients.DataSource = bindingClients;
            gridTickets.DataSource = bindingTickets;
            gridVisits.DataSource = bindingVisits;
        }

        /// <summary>
        /// Добавить клиента
        /// </summary>
        private void OnClientAdd_Click(object sender, EventArgs e)
        {
            var newClient = new Client();
            newClient.DateBirth = DateTime.Now;

            ClientFormEdit.FormShow(ActionState.Add, newClient);
            if (!newClient.IsEmpty)
            {
                var source = (BindingSource)gridClients.DataSource;
                source.Position = source.Add(newClient);
            }
        }

        /// <summary>
        /// Изменить клиента
        /// </summary>
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var client = ((BindingSource)gridClients.DataSource).Current as Client;
            if (client != null)
            {
                var frm = ClientFormEdit.FormShow(ActionState.Edit, client);
            }
            gridClients.Refresh();
        }

        /// <summary>
        /// Удалить клиента
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var client = ((BindingSource)gridClients.DataSource).Current as Client;

                var clientController = new ClientController();
                clientController.CheckConstrainsClient(client);

                if (MessageHelper.ShowQuestion(
                    "Вы уверены что хотите удалить клиента ?") == DialogResult.Yes)
                {
                    if (client != null)
                    {
                        foreach (var visit in client.ListVisit)
                            visit.Delete();

                        foreach (var ticket in client.ListTickets)
                            ticket.Delete();

                        client.Delete();

                        ((BindingSource)gridClients.DataSource).Remove(client);
                        //DataSet.ListClients.Remove(client);
                        //gridClients.DataSource = DataSet.ListClients.ToArray();
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError("Удаление невозможно! "+exc.Message);
            }
        }

        /// <summary>
        /// Поиск
        /// </summary>
        private void OnFindChange(object sender, EventArgs e)
        {
            var txt = textBoxFind.Text;
            if (string.IsNullOrEmpty(txt))
            {
                SetBinding(DataSet.ListClients.ToArray());
            }
            else
            {
                var listClient = DataSet.ListClients.Where(x => x.Number.ToString().IndexOf(txt) != -1
                    || x.SurName.ToUpper().IndexOf(txt.ToUpper()) != -1).ToArray();

                SetBinding(listClient);
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
        }

        /// <summary>
        /// Новый абонемент
        /// </summary>
        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            var ticketController = new TicketsController();
            try
            {
                var source = (BindingSource)gridClients.DataSource;
                var client = source.Current as Client;
                if (client == null)
                    throw new BussinesException("Клиент не выбран!");

                ticketController.CheckExistTwoKindTicket(client);

                var kindTicketSelected = KindTicketsFormSelect.FormShow(
                    client,
                    DataSet);

                if (kindTicketSelected != null)
                {
                    var ticket = ticketController
                        .CreateTicket(client, kindTicketSelected, DataSet);

                    DataSet.ListTickets.Add(ticket);

                    client.ListTickets.Add(ticket);

                    var ticketSource = (BindingSource)gridTickets.DataSource;
                    ticketSource.Position = ticketSource.Add(ticket);
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Добавить бронь
        /// </summary>
        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            try
            {
                var source = gridClients.DataSource as BindingSource;
                var client = (Client)source.Current;

                CheckDebt(client);

                var visit = PlanFormEdit.FormShow(DataSet, client);
                if (visit != null)
                {
                    DataSet.ListVisit.Add(visit);
                    ((BindingSource)gridVisits.DataSource).Add(visit);

                    client.ListVisit.Add(visit);
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        private void CheckDebt(Client client)
        {
            foreach (var ticket in client.ListTicketsActive)
            {
                if (ticket.Debt > 0 && (ticket.PayBefore.Date - DateTime.Now.Date).Days < 0)
                {
                    throw new BussinesException("Не оплачен абонемент!");
                }
            }

            foreach (var ticket in client.ListTicketsActive)
            {
                if (ticket.Debt > 0 && (ticket.PayBefore.Date - DateTime.Now.Date).Days < 14)
                {
                    MessageHelper.ShowInfo(string.Format("У клиента есть задолжность {0}р. по оплате абонемента!", ticket.Debt));
                    break;
                }
            }

            
        }

        /// <summary>
        /// Анулировать
        /// </summary>
        private void OnBtnDisable(object sender, EventArgs e)
        {
            try
            {
                var source = gridVisits.DataSource as BindingSource;
                var sourceClient = gridClients.DataSource as BindingSource;
                var currentVisit = (Visit)source.Current;
                var currentClient = (Client)sourceClient.Current;

                if (currentVisit != null)
                {
                    if (currentVisit.VisitFrom != DateTime.MinValue || currentVisit.VisitTo != DateTime.MinValue)
                        throw new BussinesException("Нельзя анулировать сеанс который был начат или завершен!");

                    if (MessageHelper.ShowQuestion(
                        "Вы уверены что хотите анулировать посещение?") == DialogResult.Yes)
                    {
                        //Если анулируем групповой сеанс
                        if (currentVisit.IsOnlyGroup)
                        {
                            TicketsController.ReturnGroupVisit(currentClient.ListTickets);
                        }
                        else//Иначе тренажеры
                        {
                            int countBalls = currentVisit.ClientUseFitnessEquipmentSpec.Sum(x => x.FitnessEquipmentRef.CountBalls);
                            TicketsController.ReturnBalls(currentClient.ListTickets, countBalls);
                        }

                        currentVisit.IsDisabled = true;
                        currentVisit.Update();
                        gridVisits.Refresh();
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Просмотреть запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnViewVisitClick(object sender, EventArgs e)
        {
            var source = gridVisits.DataSource as BindingSource;
            var currentVisit = (Visit)source.Current;
            if (currentVisit != null)
            {
                PlanFormEdit.FormViewVisit(currentVisit);
            }
        }

        /// <summary>
        /// Просмотреть запись(двойное нажатие мышки)
        /// </summary>
        private void OnMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var source = gridVisits.DataSource as BindingSource;
            if (source == null)
                btnAddPlan_Click(sender, null);
            else
                OnBtnViewVisitClick(sender, null);
        }

        /// <summary>
        /// Доступность контекстного меню
        /// </summary>
        private void OnContextMenuOpening(object sender, CancelEventArgs e)
        {
            cmStartVisit.Enabled = false;
            cmFinishVisit.Enabled = false;

            var source = gridVisits.DataSource as BindingSource;
            if (source.Current != null)
            {
                var visit = (Visit)source.Current;
                if (visit.VisitFrom == DateTime.MinValue)
                {
                    cmStartVisit.Enabled = true;
                    cmFinishVisit.Enabled = false;
                }
                else if (visit.VisitTo == DateTime.MinValue)
                {
                    cmStartVisit.Enabled = false;
                    cmFinishVisit.Enabled = true;
                }
            }
            
            
        }

        /// <summary>
        /// Начать сеанс
        /// </summary>
        private void OnStartVisitClick(object sender, EventArgs e)
        {
            try
            {
                var source = gridVisits.DataSource as BindingSource;
                var visit = (Visit)source.Current;

                if (visit.IsDisabled)
                    throw new BussinesException("Нельзя начать или закончить посещение если оно анулировано!");
                
                var dateVisit = DateTime.Now;
                if (MessageHelper.ShowQuestion(
                    string.Format("Начать посещение в {0} ?", dateVisit.ToString("HH:mm"))) == DialogResult.Yes)
                {
                    visit.VisitFrom = DateTime.Now;
                    visit.Update();
                    gridVisits.Refresh();
                }
            }

            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Закончить сеанс
        /// </summary>
        private void OnFinishVisitClick(object sender, EventArgs e)
        {
            try
            {
                var source = gridVisits.DataSource as BindingSource;
                var visit = (Visit)source.Current;

                if (visit.IsDisabled)
                    throw new BussinesException("Нельзя начать или закончить посещение если оно анулировано!");
                
                var dateVisit = DateTime.Now;
                if (MessageHelper.ShowQuestion(
                    string.Format("Закончить посещение в {0} ?", dateVisit.ToString("HH:mm"))) == DialogResult.Yes)
                {
                    visit.VisitTo = dateVisit;
                    visit.Update();
                    gridVisits.Refresh();
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        /// <summary>
        /// Нажатие кнопки мыши на гриде
        /// </summary>
        private void OnCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridHelper.OnCellMouseDown((DataGridView)sender, e);
        }

        /// <summary>
        /// Долг
        /// </summary>
        private void btnDebt_Click(object sender, EventArgs e)
        {
            var ticket = ((BindingSource)gridTickets.DataSource).Current;
            if (ticket != null)
            {
                if (DebtFormEdit.FormShow((Tickets)ticket) == DialogResult.OK)
                    gridTickets.Refresh();
            }
        }

        private void OnCellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var currObj = (Tickets)gridTickets.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 3)
                e.Value = currObj.Debt == 0 ? "" : currObj.Debt.ToString();
            else if (e.ColumnIndex == 4)
                e.Value = currObj.PayBefore == DateTime.MinValue ? "" : currObj.PayBefore.ToString("dd.MM.yyyy");
        }

        private void OnClientCellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                var currObj = (Client)gridClients.Rows[e.RowIndex].DataBoundItem;
                e.Value = currObj.Code != null && currObj.Code != 0 ? true : false;
            }
        }

        private void OnOpeningContextClient(object sender, CancelEventArgs e)
        {
            if (((BindingSource)gridClients.DataSource).Current == null)
            {
                cmChangeClient.Enabled = false;
                cmDeleteClient.Enabled = false;
            }
        }

        private void OnDblClickClient(object sender, DataGridViewCellEventArgs e)
        {
            var source = gridClients.DataSource as BindingSource;
            if (source != null && source.Current != null)
                btnEditClient_Click(sender, null);
        }

        private void OnShowTicket_Click(object sender, EventArgs e)
        {
            var ticket = (Tickets)((BindingSource)gridTickets.DataSource).Current;
            if (ticket != null)
                TicketDetailsFormEdit.Show(ticket);
        }

        private void OnCellDblClickTicket(object sender, DataGridViewCellEventArgs e)
        {
            OnShowTicket_Click(sender, null);
        }

        private void OnTicketDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var ticket = (Tickets)((BindingSource)gridTickets.DataSource).Current;
                var client = (Client)((BindingSource)gridClients.DataSource).Current;

                if (ticket != null)
                {
                    if (MessageHelper.ShowQuestion("Вы уверены что хотите удалить абонемент?") == DialogResult.Yes)
                    {
                        if ((ticket.KindTicketsRef.IsOnlyGroup && ticket.Balance < ticket.KindTicketsRef.CountVisits) ||
                            (!ticket.KindTicketsRef.IsOnlyGroup && ticket.Balance < ticket.KindTicketsRef.CountBalls))
                            throw new BussinesException("Нельзя удалить абонемент по нему существуют посещения!");

                        var ticketSource = (BindingSource)gridTickets.DataSource;
                        ticketSource.Remove(ticket);
                        DataSet.ListTickets.Remove(ticket);
                        client.ListTickets.Remove(ticket);
                        ticket.Delete();
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageHelper.ShowError(exc.Message);
            }
        }

        private void OnBtnContract_Click(object sender, EventArgs e)
        {
            var ticket = (Tickets)((BindingSource)gridTickets.DataSource).Current;

            if (ticket != null)
                ReportContract.ShowReport(ticket);
        }

        private void OnDigitalCard_Click(object sender, EventArgs e)
        {
            var client = (Client)((BindingSource)gridClients.DataSource).Current;
            if ((client.Code != 0 &&
                MessageHelper.ShowQuestion("У клиента существует электронная карта,\nхотите переопределить её?") == DialogResult.Yes) ||
                client.Code == 0)
            {
                DigitalCardEditForm.ShowForm(client);
            }
        }



    }
}
