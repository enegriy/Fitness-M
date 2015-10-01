using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Контролы для валидации
	/// </summary>
	public class ControlsValidation
	{
		/// <summary>
		/// Контролы и стратегии
		/// </summary>
		private IDictionary<Control, List<IValidationStrategy>> controlsHasValidation =
			new Dictionary<Control, List<IValidationStrategy>>();

		/// <summary>
		/// Контролы
		/// </summary>
		public IEnumerable<Control> Controls
		{
			get { return controlsHasValidation.Keys; }
		}

		/// <summary>
		/// Стратегии
		/// </summary>
		public IEnumerable<IValidationStrategy> GetStrategy(Control ctrl)
		{
			if (controlsHasValidation.ContainsKey(ctrl))
				return controlsHasValidation[ctrl];
			return new IValidationStrategy[]{};
		}

		/// <summary>
		/// Добавить контрол и стратегию
		/// </summary>
		public void AddControlValidation(Control ctrl, IValidationStrategy strategy)
		{
			if (controlsHasValidation.ContainsKey(ctrl))
				controlsHasValidation[ctrl].Add(strategy);
			else
				controlsHasValidation.Add(ctrl,
					new List<IValidationStrategy>() {strategy});
		}
		/// <summary>
		/// Удалить стратегию для контрола
		/// </summary>
		public void RemoveControlValidation(Control ctrl, Type strategyType)
		{
			if (controlsHasValidation.ContainsKey(ctrl))
			{
				for (int i = controlsHasValidation[ctrl].Count; i > 0; i--)
				{
					if (controlsHasValidation[ctrl][i - 1].GetType() == strategyType)
						controlsHasValidation[ctrl].RemoveAt(i - 1);
				}
			}
		}
	}
}
