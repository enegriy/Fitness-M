using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Стратегия на пусто не пусто
	/// </summary>
    public class ValidationStrategyNotNull : IValidationStrategy
    {
		/// <summary>
		/// Выполнить
		/// </summary>
        public bool Do(Control ctrl, ErrorProvider provider)
        {
            bool valid = false;
            var tb = (TextBox)ctrl;
            if (string.IsNullOrEmpty(tb.Text))
            {
                if (provider != null) provider.SetError(ctrl, "Значение не может быть пустым");
            }
            else
            {
                if (provider != null) provider.SetError(ctrl, "");
                valid = true;
            }
            return valid;
        }
    }
}
