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
        /// <summary>
        /// Данные
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        public ClientsControl()
        {
            InitializeComponent();
        }

        private void OnClientControlLoad(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;

            InitDataGrid();
        }

        public void InitDataGrid()
        {
            GridHelper.SetGridStyle(dataGridView1);
            GridHelper.SetGridStyle(dataGridView2);
            GridHelper.SetGridStyle(dataGridView3);

            if (DataSet == null)
                throw new BussinesException("Не задан источник данных");

            var bindingClients = new BindingSource(DataSet.ListClients, "");
            var bindingTickets = new BindingSource(bindingClients, "ListTickets");
            var bindingVisits = new BindingSource(bindingClients, "ListVisit");

            dataGridView1.DataSource = bindingClients;
            dataGridView2.DataSource = bindingTickets;
            dataGridView3.DataSource = bindingVisits;
        }

        private void OnClientAdd_Click(object sender, EventArgs e)
        {
            var newClient = new Client();
            newClient.DateBirth = DateTime.Now;
            ClientFormEdit.FormShow(ActionState.Add, newClient);
            if (!newClient.IsEmpty)
            {
                DataSet.ListClients.Add(newClient);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataSet.ListClients;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = ((BindingSource)dataGridView1.DataSource).Current as Client;
            if (client != null)
            {
                ClientFormEdit.FormShow(ActionState.Edit, client);
            }
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить клиента ?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var client = ((BindingSource)dataGridView1.DataSource).Current as Client;
                if (client != null)
                {
                    client.Delete();
                    DataSet.ListClients.Remove(client);
                    dataGridView1.DataSource = DataSet.ListClients.ToArray();
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
                dataGridView1.DataSource = DataSet.ListClients;
            else
                dataGridView1.DataSource = DataSet.ListClients.Where(x => x.Number.ToString().IndexOf(txt) != -1 
                    || x.SurName.ToUpper().IndexOf(txt.ToUpper()) != -1).ToArray();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            KindTicketsFormSelect.FormShow(
                ActionState.Select, 
                ((BindingSource)dataGridView1.DataSource).Current as Client, 
                DataSet);
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            try
            {
                var source = dataGridView1.DataSource as BindingSource;
                TicketsController.CheckExistTickets(((Client)source.Current).ListTickets);
                PlanFormEdit.FormShow(DataSet, (Client)source.Current);
            }
            catch (BussinesException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void OnBtnDisable(object sender, EventArgs e)
        {
            try
            {
                var source = dataGridView3.DataSource as BindingSource;
                var currentVisit = (Visit)source.Current;
                if (currentVisit != null)
                {
                    if (currentVisit.VisitFrom != DateTime.MinValue || currentVisit.VisitTo != DateTime.MinValue)
                        throw new BussinesException("Нельзя анулировать сеанс который был начат или завершен!");

                    if (MessageBox.Show("Вы уверены что хотите анулировать посещение?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        dataGridView3.Refresh();
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnBtnViewVisitClick(object sender, EventArgs e)
        {
            var source = dataGridView3.DataSource as BindingSource;
            var currentVisit = (Visit)source.Current;
            if (currentVisit != null)
            {
                PlanFormEdit.FormViewVisit(currentVisit);
            }
        }

        private void OnMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var source = dataGridView3.DataSource as BindingSource;
            if (source == null)
                btnAddPlan_Click(sender, null);
            else
                OnBtnViewVisitClick(sender, null);
        }

        private void OnContextMenuOpening(object sender, CancelEventArgs e)
        {
            cmStartVisit.Enabled = false;
            cmFinishVisit.Enabled = false;

            var source = dataGridView3.DataSource as BindingSource;
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

        private void OnStartVisitClick(object sender, EventArgs e)
        {
            var source = dataGridView3.DataSource as BindingSource;
            var visit = (Visit)source.Current;
            visit.VisitFrom = DateTime.Now;
            visit.Update();
            dataGridView3.Refresh();

        }

        private void OnFinishVisitClick(object sender, EventArgs e)
        {
            var source = dataGridView3.DataSource as BindingSource;
            var visit = (Visit)source.Current;
            visit.VisitTo = DateTime.Now;
            visit.Update();
            dataGridView3.Refresh();
        }

    }
}
