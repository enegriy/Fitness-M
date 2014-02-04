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
    public partial class AdministrationControl : UserControl
    {
        //Флаг изменения значений на этой вкладки
        bool m_IsValueChanged = false;

        public AdministrationControl()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbTitle.Text = ParamsManager.GetParams<string>(ParamsConstant.FitnessClubName);
            var timeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom);
            if (timeFrom == DateTime.MinValue)
                dtTimeFrom.Value = DateTime.Now;
            else
                dtTimeFrom.Value = timeFrom;
        }
        
        private void OnLeave(object sender, EventArgs e)
        {
            ParamsManager.SetParams(ParamsConstant.FitnessClubName, tbTitle.Text);
            ParamsManager.SetParams(ParamsConstant.WorkTimeFrom, dtTimeFrom.Value);
        }

        

        private void OnTextChanged(object sender, EventArgs e)
        {

        }
    }
}
