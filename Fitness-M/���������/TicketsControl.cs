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
        private IList<KindTickets> m_ListKindTickets;

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
            m_ListKindTickets = KindTickets.FindAll();
            dataGridView1.DataSource = m_ListKindTickets;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TicketsFormEdit.FormShow(ActionState.Add, new KindTickets());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TicketsFormEdit.FormShow(ActionState.Edit, new KindTickets());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить вид шаблона ?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kindTicket = GetSelectedKindTicket();
                if (kindTicket != null)
                {
                    kindTicket.Delete();
                    m_ListKindTickets.Remove(kindTicket);
                    dataGridView1.DataSource = m_ListKindTickets.ToArray();
                }
            }
        }

        private KindTickets GetSelectedKindTicket()
        {
            int Id = (int)dataGridView1.CurrentRow.Cells["clmId"].Value;
            var kindTicket = m_ListKindTickets.FirstOrDefault(x => x.Id == Id);
            return kindTicket;
        }
    }
}
