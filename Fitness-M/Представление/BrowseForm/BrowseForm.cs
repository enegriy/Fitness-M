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
    public partial class BrowseForm : Form
    {
        private ClientDataSet m_DataSet;

        public BrowseForm()
        {
            InitializeComponent();
        }

        private void OnBrowseFormLoad(object sender, EventArgs e)
        {
            SetRegims(treeViewRegims);
            m_DataSet = ClientDataSet.Get();
            m_DataSet.LoadData();
            timerForToday.Start();
        }

        /// <summary>
        /// Установить режимы
        /// </summary>
        /// <param name="treeViewRegims"></param>
        private void SetRegims(TreeView treeViewRegims)
        {
            treeViewRegims.Nodes.Add("1", "Клиенты");
            treeViewRegims.Nodes.Add("2", "Абонементы");
            treeViewRegims.Nodes.Add("3", "Тренажеры");
            treeViewRegims.Nodes.Add("4", "График");
            treeViewRegims.Nodes.Add("5", "Администрирование");
        }

        private void SetUserControl(UserControl ctrl)
        {
            try
            {
                if (ctrl is ClientsControl)
                    ctrl = new ClientsControl();

                ctrl.Dock = DockStyle.Fill;
                panelFormConteiner.Controls.Add(ctrl);
            }
            catch (BussinesException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearControls(panelFormConteiner);

            //Клиенты
            if (e.Node.Name == "1")
            {
                try
                {
                    ClientsControl ctrl = new ClientsControl();
                    ctrl.DataSet = m_DataSet;
                    ctrl.Dock = DockStyle.Fill;
                    panelFormConteiner.Controls.Add(ctrl);
                }
                catch (BussinesException ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }                
            }
            //Абонементы
            else if (e.Node.Name == "2")
            {
                try
                {
                    TicketsControl ctrl = new TicketsControl();
                    ctrl.DataSet = m_DataSet;
                    ctrl.Dock = DockStyle.Fill;
                    panelFormConteiner.Controls.Add(ctrl);
                }
                catch (BussinesException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Тренажеры
            else if (e.Node.Name == "3")
            {
                try
                {
                    FitnessEquipmentControl ctrl = new FitnessEquipmentControl();
                    ctrl.DataSet = m_DataSet;
                    ctrl.Dock = DockStyle.Fill;
                    panelFormConteiner.Controls.Add(ctrl);
                }
                catch (BussinesException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //График
            else if (e.Node.Name == "4")
            {
                try
                {
                    FitnessEquipmentSchedule ctrl = new FitnessEquipmentSchedule();
                    ctrl.DataSet = m_DataSet;
                    ctrl.Dock = DockStyle.Fill;
                    panelFormConteiner.Controls.Add(ctrl);
                }
                catch (BussinesException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Node.Name == "5")
            {
                try
                {
                    AdministrationControl ctrl = new AdministrationControl();
                    //ctrl.DataSet = m_DataSet;
                    ctrl.Dock = DockStyle.Fill;
                    panelFormConteiner.Controls.Add(ctrl);
                }
                catch (BussinesException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearControls(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                control.Controls.RemoveAt(i);
            }
        }

        private void timerForToday_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
