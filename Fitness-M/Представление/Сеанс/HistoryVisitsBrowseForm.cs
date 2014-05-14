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
            FillGrid(dateStart.Value, dateFinish.Value);
        }


        private void FillGrid(DateTime dateStart, DateTime dateFinish)
        {
            var listVisit = m_Client.ListVisit.Where(x => x.PlanFrom.Date >= dateStart.Date && x.PlanFrom.Date <= dateFinish.Date).OrderBy(x=>x.PlanFrom);
            if (listVisit == null || !listVisit.Any())
            {
                gridVisits.DataSource = null;
            }
            else
            {
                var bindingVisits = new BindingSource(listVisit, "");
                gridVisits.DataSource = bindingVisits;
            }
        }

        private void OnChangePeriod(object sender, EventArgs e)
        {
            if (dateStart.Value > dateFinish.Value)
            {
                MessageHelper.ShowError("Не правильно указан период!");
                return;
            }

            FillGrid(dateStart.Value, dateFinish.Value);
        }

        private void gridVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var source = gridVisits.DataSource as BindingSource;
            if (source != null)
            {
                var currentVisit = (Visit)source.Current;
                if (currentVisit != null)
                {
                    PlanFormEdit.FormViewVisit(currentVisit);
                }
            }
        }
    }
}
