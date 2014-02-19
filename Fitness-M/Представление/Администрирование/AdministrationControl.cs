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
            ConstraintByUser();

            tbTitle.Text = ParamsManager.GetParams<string>(ParamsConstant.FitnessClubName);
           
            var timeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom);
            var timeTo = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeTo);

            if (timeFrom == DateTime.MinValue)
                dtTimeFrom.Value = DateTime.Now;
            else
                dtTimeFrom.Value = timeFrom;

            if (timeTo == DateTime.MinValue)
                dtTimeTo.Value = DateTime.Now;
            else
                dtTimeTo.Value = timeTo;
        }
        
        private void OnLeave(object sender, EventArgs e)
        {
            if (m_IsValueChanged)
            {
                ParamsManager.SetParams(ParamsConstant.FitnessClubName, tbTitle.Text);
                ParamsManager.SetParams(ParamsConstant.WorkTimeFrom, dtTimeFrom.Value);
                ParamsManager.SetParams(ParamsConstant.WorkTimeTo, dtTimeTo.Value);
            }
        }

        private void ConstraintByUser()
        {
            if (CurrentUser.Role != Roles.Administrator)
            {
                tableLayoutPanel1.Enabled = false;
            }
        }

        

        private void OnTextChanged(object sender, EventArgs e)
        {
            m_IsValueChanged = true;
        }
    }
}
