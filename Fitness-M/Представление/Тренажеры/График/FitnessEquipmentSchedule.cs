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
    public partial class FitnessEquipmentSchedule : UserControl
    {
        /// <summary>
        /// Данные
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        /// <summary>
        /// Дата посещений
        /// </summary>
        public DateTime DateVisit
        {
            get;
            set;
        }


        public FitnessEquipmentSchedule()
        {
            InitializeComponent();
        }


        private void FitnessEquipmentSchedule_Load(object sender, EventArgs e)
        {
            DateVisit = new DateTime(2014, 1, 30);
            if (DateVisit == null) throw new BussinesException("Не задана дата посещения!");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            SetTimeToFitnessEquipment(DataSet.ListFitnessEquipment);
            var bindingFq = new BindingSource(DataSet.ListFitnessEquipment, "");
            var bindingFt = new BindingSource(bindingFq, "ListFreeTime");

            dataGridView1.DataSource = bindingFq;
            dataGridView2.DataSource = bindingFt;
        }

        private void SetTimeToFitnessEquipment(IList<FitnessEquipment> listFitnessEquipment)
        {
            var feqController = new FitnessEquipmentController();
            var dateFrom = new DateTime(DateVisit.Year, DateVisit.Month, DateVisit.Day, 8, 0, 0);
            var dateTo = new DateTime(DateVisit.Year, DateVisit.Month, DateVisit.Day, 18, 0, 0);
            var workPeriod = new DateFromAndDateTo(dateFrom, dateTo);

            foreach (FitnessEquipment fq in listFitnessEquipment)
            {
                fq.ListFreeTime = feqController.GetListFreeTime(fq, DateVisit, workPeriod);
            }
        }
    }
}