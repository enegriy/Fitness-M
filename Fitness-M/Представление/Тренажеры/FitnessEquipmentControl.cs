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
    public partial class FitnessEquipmentControl : UserControl
    {
        /// <summary>
        /// Данные
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        public FitnessEquipmentControl()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitDataGridFitnessEquipment();
        }

        private void InitDataGridFitnessEquipment()
        {
            var dataSource = new BindingSource(DataSet.ListFitnessEquipment, "");
            dataGridView1.DataSource = dataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить объект?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var fq = (FitnessEquipment)((BindingSource)dataGridView1.DataSource).Current as FitnessEquipment;
                if (fq != null)
                {
                    fq.Delete();
                    DataSet.ListFitnessEquipment.Remove(fq);
                    dataGridView1.DataSource = DataSet.ListFitnessEquipment.ToArray();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fitnessEquipment = new FitnessEquipment();
            var frm = FitnessEquipmentFormEdit.FormShow(ActionState.Add, fitnessEquipment);
            if (!fitnessEquipment.IsEmpty)
            {
                DataSet.ListFitnessEquipment.Add(fitnessEquipment);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataSet.ListFitnessEquipment;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var fitnessEquipment = ((BindingSource)dataGridView1.DataSource).Current as FitnessEquipment;
            var frm = FitnessEquipmentFormEdit.FormShow(ActionState.Edit, fitnessEquipment);
            dataGridView1.Refresh();
        }
    }
}
