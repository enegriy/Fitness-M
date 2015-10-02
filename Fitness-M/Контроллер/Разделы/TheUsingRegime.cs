using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	/// <summary>
	/// Используемый режим
	/// </summary>
	public class TheUsingRegime
	{
		/// <summary>
		/// Режим
		/// </summary>
		public Regimes Regime { get; set; }
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Форма
		/// </summary>
		public Type UserControlRegime { get; set; }
		/// <summary>
		/// .ctor
		/// </summary>
		public TheUsingRegime(Regimes regime, string name, Type userRegime)
		{
			Regime = regime;
			Name = name;
			UserControlRegime = userRegime;
		}
	}
}
