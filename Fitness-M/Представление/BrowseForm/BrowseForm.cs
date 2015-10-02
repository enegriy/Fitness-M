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

        private void OnForm_Load(object sender, EventArgs e)
        {
            SetRegims(treeViewRegims);
            m_DataSet = ClientDataSet.Get();
            timerForToday.Start();

            Scaner.OpenScaner();
        }

        private void OnForm_Closing(object sender, FormClosedEventArgs e)
        {
            Scaner.CloseScanner();
        }


		/// <summary>
		/// Установить режимы
		/// </summary>
		private void SetRegims(TreeView treeViewRegims)
		{
			foreach (var usingRegime in RegimesController.UsingRegims)
				treeViewRegims.Nodes.Add(usingRegime.Regime.ToString(), usingRegime.Name);
		}


        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearControls(panelFormConteiner);

        	var usingRegime = RegimesController.UsingRegims.FirstOrDefault(x => x.Regime.ToString() == e.Node.Name);
			if(usingRegime != null)
			{
				var regime = RegimesController.Activate(usingRegime, m_DataSet);
				regime.Dock = DockStyle.Fill;

				if (regime is VisualDetailSchedule)
				{
					((VisualDetailSchedule)regime).DateVisit = DateTime.Now;
					((VisualDetailSchedule)regime).ListFitnessEquipment = m_DataSet.ListFitnessEquipment;
					((VisualDetailSchedule)regime).TimeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom).TimeOfDay;
					((VisualDetailSchedule)regime).TimeTo = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeTo).TimeOfDay;
					((VisualDetailSchedule)regime).ToUseControl = UseControl.AsRegim;
				}

				panelFormConteiner.Controls.Add(regime);
			}
        }


        private void ClearControls(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
                control.Controls.RemoveAt(i);
        }


        private void timerForToday_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }


    }
}
