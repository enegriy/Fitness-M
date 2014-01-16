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
        public BrowseForm()
        {
            InitializeComponent();
        }

        private void OnBrowseFormLoad(object sender, EventArgs e)
        {
            SetRegims(treeViewRegims);
        }

        /// <summary>
        /// Установить режимы
        /// </summary>
        /// <param name="treeViewRegims"></param>
        private void SetRegims(TreeView treeViewRegims)
        {
            treeViewRegims.Nodes.Add("1","Клиенты");
            treeViewRegims.Nodes.Add("2", "Абонементы");
            treeViewRegims.Nodes.Add("3", "Тренажеры");
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
                //ClientsControl ctrl = new ClientsControl();
                //treeViewRegims.Controls.Add(ctrl);
            }
        }

        private void ClearControls(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                control.Controls.RemoveAt(i);
            }
        }
    }
}
