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
        /// <summary>
        /// Данные
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        public TicketsControl()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitDataGrid();
        }

        public void InitDataGrid()
        {
            if (DataSet == null) 
                throw new ApplicationException("Не задан источник данных");

            dataGridView1.DataSource = DataSet.ListKindTickets;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var kindTickets = new KindTickets();
            TicketsFormEdit.FormShow(ActionState.Add, kindTickets);
            if (!kindTickets.IsEmpty)
            {
                DataSet.ListKindTickets.Add(kindTickets);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataSet.ListKindTickets;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var kindTicket = GetSelectedKindTicket();
            if (kindTicket != null)
            {
                TicketsFormEdit.FormShow(ActionState.Edit, kindTicket);
            }
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить вид шаблона ?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kindTicket = GetSelectedKindTicket();
                if (kindTicket != null)
                {
                    kindTicket.Delete();
                    DataSet.ListKindTickets.Remove(kindTicket);
                    dataGridView1.DataSource = DataSet.ListKindTickets.ToArray();
                }
            }
        }

        private KindTickets GetSelectedKindTicket()
        {
            int Id = (int)dataGridView1.CurrentRow.Cells["clmId"].Value;
            var kindTicket = DataSet.ListKindTickets.FirstOrDefault(x => x.Id == Id);
            return kindTicket;
        }
    }
}
