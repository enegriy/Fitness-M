using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	public interface IBusinessObject
	{
		/// <summary>
		/// Сохранить
		/// </summary>
		void Save();

		/// <summary>
		/// Обновить
		/// </summary>
		void Update();

		/// <summary>
		/// Удалить
		/// </summary>
		void Delete();

		/// <summary>
		/// Пустой
		/// </summary>
		bool IsEmpty { get; }
	}
}
