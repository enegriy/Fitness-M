using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Fitness_M
{
    public static class ValidationHelper
    {
        public static void Validating(object sender, CancelEventArgs e,
            ref bool IsClosingForm, ErrorProvider errorProvider)
        {
            if (sender is TextBox)
            {
                var ctrl = (TextBox)sender;
                if (string.IsNullOrEmpty(ctrl.Text))
                {
                    IsClosingForm = false;
                    if(errorProvider != null) errorProvider.SetError(ctrl, "Значение не может быть пустым");
                }
                else
                {
                    IsClosingForm = true;
                    if (errorProvider != null) errorProvider.SetError(ctrl, "");
                }
            }

        }
    }
}
