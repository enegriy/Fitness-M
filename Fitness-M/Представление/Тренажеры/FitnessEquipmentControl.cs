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
            GridHelper.SetGridStyle(dataGridView1);
            InitDataGridFitnessEquipment();
            ConstraintByUser();

        }

        private void ConstraintByUser()
        {
            if (CurrentUser.Role != Roles.Administrator)
            {
                flowLayoutPanel1.Enabled = false;
            }
        }

        private void InitDataGridFitnessEquipment()
        {
            var dataSource = new BindingSource(DataSet.ListFitnessEquipment, "");
            dataGridView1.DataSource = dataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion(
                "Вы уверены что хотите удалить объект?") == DialogResult.Yes)
            {
                try
                {
                    var source = (BindingSource)dataGridView1.DataSource;
                    var fq = (FitnessEquipment)source.Current;
                    if (fq != null)
                    {
                        fq.Delete();
                        source.Remove(fq);
                    }
                }
                catch (BussinesException ex)
                {
                    MessageHelper.ShowError(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fitnessEquipment = new FitnessEquipment();
            var frm = FitnessEquipmentFormEdit.FormShow(ActionState.Add, fitnessEquipment);
            if (!fitnessEquipment.IsEmpty)
            {
                var source = (BindingSource)dataGridView1.DataSource;
                source.Position = source.Add(fitnessEquipment);
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
