using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс фильтр для отбора абонементов
    /// </summary>
    public class TicketFilter
    {
        #region Prop
        private int m_ClientNumber;
        /// <summary>
        /// Ид клиента
        /// </summary>
        public int ClientNumber
        {
            get
            {
                return m_ClientNumber;
            }
            set 
            {
                m_ClientNumber = value; 
            }
        }

        private string m_ClientSurname;
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string ClientSurname 
        {
            get
            {
                return m_ClientSurname;
            }
            set
            {
                m_ClientSurname = DeleteSpecSymbol(value);
            }
        }

        private int m_Balance;
        /// <summary>
        /// Остаток
        /// </summary>
        public int Balance 
        {
            get
            {
                return m_Balance;
            }
            set
            {
                m_Balance = value;
            }
        }

        private int m_Period;
        /// <summary>
        /// Абонемент заканчивается
        /// </summary>
        public int Period
        {
            get
            {
                return m_Period;
            }
            set
            {
                m_Period = value;
            }
        }

        private bool m_NotExistTickets;
        /// <summary>
        /// Нет действующих абонементов
        /// </summary>
        public bool NotExistTickets
        {
            get
            {
                return m_NotExistTickets;
            }
            set
            {
                m_NotExistTickets = value;
            }
        }
        #endregion

        private string DeleteSpecSymbol(string value)
        {
            return value.Replace("'","").Replace("\"","").Replace(";","").Replace("`","").Replace("/","");
        }
    }
}
