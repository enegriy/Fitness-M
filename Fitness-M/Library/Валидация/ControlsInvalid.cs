using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Невалидные контролы
	/// </summary>
	public class ControlsInvalid
	{
		/// <summary>
		/// Контролы не прошедшие валидацию
		/// </summary>
		List<Control> controlInvalid = new List<Control>(); 

		/// <summary>
		/// Добавить
		/// </summary>
		public void AddControlInvalid(Control ctrl)
		{
			if(!controlInvalid.Contains(ctrl))
				controlInvalid.Add(ctrl);
		}

		/// <summary>
		/// Удалить
		/// </summary>
		public void RemoveControlInvalid(Control ctrl)
		{
			controlInvalid.Remove(ctrl);
		}

		/// <summary>
		/// Пустой список контролов
		/// </summary>
		/// <returns></returns>
		public bool IsEmpty()
		{
			return !controlInvalid.Any();
		}
	}
}
