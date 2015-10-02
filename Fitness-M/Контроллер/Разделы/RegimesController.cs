using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	/// <summary>
	/// Контроллер режимой/разделов
	/// </summary>
	public static class RegimesController
	{
		private static InstanceObject<UserRegime> instanceObjectRegime = 
			new InstanceObject<UserRegime>(); 

		/// <summary>
		/// UsingRegims
		/// </summary>
		private static List<TheUsingRegime> m_UsingRegims;
		/// <summary>
		/// Используемые режимы
		/// </summary>
		public static List<TheUsingRegime> UsingRegims 
		{
			get
			{
				if (m_UsingRegims == null)
					m_UsingRegims = FillUsingRegimes();
				return m_UsingRegims;
			}
		}

		/// <summary>
		/// Заполнить Используемые режимы
		/// </summary>
		/// <returns></returns>
		private static List<TheUsingRegime> FillUsingRegimes()
		{
			List<TheUsingRegime> usingRegimes = new List<TheUsingRegime>();
			usingRegimes.Add(new TheUsingRegime(Regimes.Clients, "Клиенты", typeof(ClientsControl)));
			usingRegimes.Add(new TheUsingRegime(Regimes.Abonements, "Абонементы", typeof(TicketsControl)));
			usingRegimes.Add(new TheUsingRegime(Regimes.FitnessEqupment, "Тренажеры", typeof(FitnessEquipmentControl)));
			usingRegimes.Add(new TheUsingRegime(Regimes.FEScheduler, "График загрузки тренажеров", typeof(VisualDetailSchedule)));
			usingRegimes.Add(new TheUsingRegime(Regimes.Administaration, "Администрирование", typeof(AdministrationControl)));
			return usingRegimes;
		}

		/// <summary>
		/// Активировать
		/// </summary>
		public static UserRegime Activate(TheUsingRegime usingRegime, ClientDataSet dataSet)
		{
			var instanceRegime = instanceObjectRegime.GetInstance(usingRegime.UserControlRegime);
			instanceRegime.DataSet = dataSet;
			return instanceRegime;
		}
	}
}
