using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    /// <summary>
    /// Стратегия валидации
    /// </summary>
    public interface IValidationStrategy
    {
		/// <summary>
		/// Выполнить
		/// </summary>
        bool Do(Control ctrl, ErrorProvider provider);
    }
}
