using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	/// <summary>
	/// Работа с экземплярами по типу
	/// </summary>
	public class InstanceObject<T> where T : class
	{
		/// <summary>
		/// Список экзепляров 
		/// </summary>
		private readonly List<T> _listInstanceObject = new List<T>();

		/// <summary>
		/// Получить Экземпляр 
		/// </summary>
		public T GetInstance(Type typeInstance)
		{
			T instance = _listInstanceObject.FirstOrDefault(x => 
				x.GetType() == typeInstance);

			if (instance == null)
			{
				instance = (T)Activator.CreateInstance(typeInstance);
				_listInstanceObject.Add(instance);
			}

			return instance;
		}
	}
}
