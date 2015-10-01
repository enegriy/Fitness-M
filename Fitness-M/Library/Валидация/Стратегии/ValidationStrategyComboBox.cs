using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Стратегия для комбобокса
	/// </summary>
    public class ValidationStrategyComboBox : IValidationStrategy
    {
		/// <summary>
		/// Выполнить
		/// </summary>
        public bool Do(Control ctrl, ErrorProvider provider)
        {
            bool valid = false;
            var cb = (ComboBox)ctrl;

            if (cb.SelectedIndex == 0)
            {
                if (provider != null) 
					provider.SetError(ctrl, "Значение не может быть пустым");
            }
            else
            {
                if (provider != null) 
					provider.SetError(ctrl, "");

                valid = true;
            }
            return valid;
        }
    }
}
