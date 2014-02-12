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
            var bindingTickets = new BindingSource(bindingClients, "ListTickets");
            var bindingVisits = new BindingSource(bindingClients, "ListVisit");

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
                ((BindingSource)gridClients.DataSource).Add(newClient);
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
                ClientFormEdit.FormShow(ActionState.Edit, client);
            }
            gridClients.Refresh();
        }

        /// <summary>
        /// Удалить клиента
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion(
                "Вы уверены что хотите удалить клиента ?") == DialogResult.Yes)
            {
                var client = ((BindingSource)gridClients.DataSource).Current as Client;
                if (client != null)
                {
                    client.Delete();
                    DataSet.ListClients.Remove(client);
                    gridClients.DataSource = DataSet.ListClients.ToArray();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InitDataGrid();
            OnFindChange(sender, e);
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
            KindTicketsFormSelect.FormShow(
                ActionState.Select, 
                ((BindingSource)gridClients.DataSource).Current as Client, 
                DataSet);
        }

        /// <summary>
        /// Добавить бронь
        /// </summary>
        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            var source = gridClients.DataSource as BindingSource;

            PlanFormEdit.FormShow(DataSet, (Client)source.Current);
        }

        /// <summary>
        /// Анулировать
        /// </summary>
        private void OnBtnDisable(object sender, EventArgs e)
        {
            try
            {
                var source = gridVisits.DataSource as BindingSource;
                var currentVisit = (Visit)source.Current;
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
                            
                        }
                        else//Иначе тренажеры
                        {
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
                    gridVisits.Refresh();
            }
        }

    }
}
