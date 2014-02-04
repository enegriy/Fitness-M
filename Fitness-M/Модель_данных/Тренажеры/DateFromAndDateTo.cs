using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс даты начала и окончания,
    /// используется для определения 
    /// периодов занятых и свободных тренажеров
    /// </summary>
    public class DateFromAndDateTo
    {
        /// <summary>
        /// Дата с
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Дата по
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public DateFromAndDateTo(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public DateFromAndDateTo() { }
    }
}
