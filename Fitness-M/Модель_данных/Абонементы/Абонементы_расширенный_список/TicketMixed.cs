using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс для информационного списка тикетов с доп информацией по клиентам
    /// </summary>
    public class TicketMixed
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int TicketId { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime DateFinish { get; set; }
        /// <summary>
        /// Остаток
        /// </summary>
        public int Balance { get; set; }
        /// <summary>
        /// Количество баллов
        /// </summary>
        public int CountBalls { get; set; }
        /// <summary>
        /// Количество посещений
        /// </summary>
        public int CountVisits { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Долг
        /// </summary>
        public decimal Debt { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public long ClientNumber { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FUllName 
        {
            get 
            {
                string rslt = Surname + " "+Name;
                if (!string.IsNullOrEmpty(Lastname))
                {
                    rslt += " " + Lastname;
                }
                return rslt;
            }
        }

    }
}
