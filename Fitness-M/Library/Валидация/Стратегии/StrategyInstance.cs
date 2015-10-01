using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	/// <summary>
	/// Экземпляры стратегий
	/// </summary>
	public class StrategyInstance
	{
		/// <summary>
		/// Список экзепляров стратегий 
		/// </summary>
		private static readonly List<IValidationStrategy> listStrategyInstance = 
			new List<IValidationStrategy>();

		/// <summary>
		/// Экземпляр стратегии
		/// </summary>
		public static IValidationStrategy GetStrategyInstance(Type strategyType)
		{
			IValidationStrategy strategy =
				listStrategyInstance.FirstOrDefault(x => x.GetType() == strategyType);

			if (strategy == null)
			{
				strategy = Activator.CreateInstance(strategyType) as IValidationStrategy;
				listStrategyInstance.Add(strategy);
			}

			return strategy;
		}

	}
}
