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
            timerForToday.Start();

            /**/
            var timeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom);
            var timeTo = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeTo);

            var curDate = DateTime.Now;

            VisualDetailByEquipment.FormShow(m_DataSet.ListFitnessEquipment, curDate, timeFrom.TimeOfDay, timeTo.TimeOfDay);
            /**/

            Scaner.OpenScaner();
        }

        private void OnFormClosing(object sender, FormClosedEventArgs e)
        {
            Scaner.CloseScanner();
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

            if (ctrl is ClientsControl)
                ctrl = new ClientsControl();

            ctrl.Dock = DockStyle.Fill;
            panelFormConteiner.Controls.Add(ctrl);

        }

        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearControls(panelFormConteiner);

            //Клиенты
            if (e.Node.Name == "1")
            {
                ClientsControl ctrl = new ClientsControl();
                ctrl.DataSet = m_DataSet;
                ctrl.Dock = DockStyle.Fill;
                panelFormConteiner.Controls.Add(ctrl);

            }
            //Абонементы
            else if (e.Node.Name == "2")
            {

                TicketsControl ctrl = new TicketsControl();
                ctrl.DataSet = m_DataSet;
                ctrl.Dock = DockStyle.Fill;
                panelFormConteiner.Controls.Add(ctrl);
            }
            //Тренажеры
            else if (e.Node.Name == "3")
            {
                FitnessEquipmentControl ctrl = new FitnessEquipmentControl();
                ctrl.DataSet = m_DataSet;
                ctrl.Dock = DockStyle.Fill;
                panelFormConteiner.Controls.Add(ctrl);
            }
            //График
            else if (e.Node.Name == "4")
            {
                FitnessEquipmentSchedule ctrl = new FitnessEquipmentSchedule();
                ctrl.DateVisit = DateTime.Now;
                ctrl.DataSet = m_DataSet;
                ctrl.Dock = DockStyle.Fill;
                ctrl.VisibleDateVisit = true;
                panelFormConteiner.Controls.Add(ctrl);
            }
            else if (e.Node.Name == "5")
            {
                AdministrationControl ctrl = new AdministrationControl();
                ctrl.Dock = DockStyle.Fill;
                panelFormConteiner.Controls.Add(ctrl);
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
