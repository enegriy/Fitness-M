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
        IList<Client> m_ListClients;

        public ClientsControl()
        {
            InitializeComponent();
        }

        private void OnClientControlLoad(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitDataGrid();
        }

        public void InitDataGrid()
        {
            m_ListClients = Client.FindAll();
            dataGridView1.DataSource = m_ListClients;
        }

        private void OnClientAdd_Click(object sender, EventArgs e)
        {
            var newClient = new Client();
            newClient.DateBirth = DateTime.Now;
            ClientFormEdit.FormShow(ActionState.Add, newClient);
            if (!newClient.IsEmpty)
            {
                m_ListClients.Add(newClient);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = m_ListClients;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = GetSelectedClient();
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
                var client = GetSelectedClient();
                if (client != null)
                {
                    client.Delete();
                    m_ListClients.Remove(client);
                    dataGridView1.DataSource = m_ListClients.ToArray();
                }
            }
        }

        private Client GetSelectedClient()
        {
            long number = (long)dataGridView1.CurrentRow.Cells["clmNumber"].Value;
            var client = m_ListClients.FirstOrDefault(x => x.Number == number);
            return client;
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
                dataGridView1.DataSource = m_ListClients;
            else
                dataGridView1.DataSource = m_ListClients.Where(x => x.Number.ToString().IndexOf(txt) != -1 
                    || x.SurName.ToUpper().IndexOf(txt.ToUpper()) != -1).ToArray();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
        }
    }
}
