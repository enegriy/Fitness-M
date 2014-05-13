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
    public partial class HistoryVisitsBrowseForm : Form
    {
        public HistoryVisitsBrowseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клиент
        /// </summary>
        private Client m_Client { get; set; }

        /// <summary>
        /// Показать форму редактирования
        /// </summary>
        public static void FormShow(Client client)
        {
            if (client == null)
                throw new BussinesException("Выберите клиента!");

            var frm = new HistoryVisitsBrowseForm();
            frm.m_Client = client;
            frm.ShowDialog();
        }

        private void HistoryVisitsBrowseForm_Load(object sender, EventArgs e)
        {
            lblFio.Text = m_Client.FullName;
            GridHelper.SetGridStyle(gridVisits);
        }
    }
}
