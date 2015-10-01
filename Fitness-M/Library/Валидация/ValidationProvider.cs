using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Провайдер валидации
	/// </summary>
	public class ValidationProvider
	{
		#region Fields
		/// <summary>
		/// провайдер ошибок
		/// </summary>
		private ErrorProvider errorProvider;

		/// <summary>
		/// Список контролов не прошедших валидацию
		/// </summary>
		private ControlsInvalid controlsInvalid = new ControlsInvalid();

		/// <summary>
		/// Контролы для валидации
		/// </summary>
		private ControlsValidation controlsValidation = new ControlsValidation();
		#endregion


		#region Event
		/// <summary>
		/// Событие на изменения состояния валидации
		/// </summary>
		public event Action<bool> OnValidationChange;

		/// <summary>
		/// Запуск события
		/// </summary>
		private void ExecuteValidationChange(bool isValid)
		{
			var eventValidation = OnValidationChange;

			if (eventValidation != null)
				eventValidation(isValid);
		}
		#endregion


		#region PublicMethod
		/// <summary>
		/// .ctor
		/// </summary>
		public ValidationProvider(ErrorProvider aErrorProvider)
		{
			//Наш супер провайдер ошибок
			errorProvider = aErrorProvider;
		}

		/// <summary>
		/// Добавить валидацию
		/// </summary>
		public void AddValidation(Control ctrl, Type strategyType)
		{
			//Получить экземпляр стратегии
			var strategy = StrategyInstance.GetStrategyInstance(strategyType);

			//Проверяю что точно стратегия
			if (strategy != null)
				controlsValidation.AddControlValidation(ctrl, strategy);
		}

		/// <summary>
		/// Удалить валидацию
		/// </summary>
		public void RemoveValidation(Control ctrl, Type strategyType)
		{
			controlsValidation.RemoveControlValidation(ctrl, strategyType);
		}

		/// <summary>
		/// проверить контрол
		/// </summary>
		public void Validate(Control ctrl)
		{
			var strategies = controlsValidation.GetStrategy(ctrl);

			foreach (var strategy in strategies)
			{
				if (!strategy.Do(ctrl, errorProvider))
					controlsInvalid.AddControlInvalid(ctrl);
				else
					controlsInvalid.RemoveControlInvalid(ctrl);
			}

			ExecuteValidationChange(IsValid);
		}

		/// <summary>
		/// Проверить
		/// </summary>
		public void Validate()
		{
			foreach (var ctrl in controlsValidation.Controls)
				Validate(ctrl);
		}

		/// <summary>
		/// Валидный/не валидный
		/// </summary>
		public bool IsValid
		{
			get { return controlsInvalid.IsEmpty(); }
		}
		#endregion
	}
}
