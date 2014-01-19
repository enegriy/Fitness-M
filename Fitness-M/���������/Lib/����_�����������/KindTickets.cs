using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Виды абонементов
    /// </summary>
    public class KindTickets : TicketsManager, IBusinessObject 
    {
        /// <summary>
        /// Индтификатор
        /// </summary>
        private int m_Id;
        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        /// <summary>
        /// Период действия
        /// </summary>
        private int m_Period;
        /// <summary>
        /// Период действия
        /// </summary>
        public int Period
        {
            get { return m_Period; }
            set { m_Period = value; }
        }

        /// <summary>
        /// Количество баллов
        /// </summary>
        private int m_CountBalls;
        /// <summary>
        /// Количество баллов
        /// </summary>
        public int CountBalls
        {
            get { return m_CountBalls; }
            set { m_CountBalls = value; }
        }

        /// <summary>
        /// Количество посещений
        /// </summary>
        private int m_CountVisits;
        /// <summary>
        /// Количество посещений
        /// </summary>
        public int CountVisits
        {
            get { return m_CountVisits; }
            set { m_CountVisits = value; }
        }

        /// <summary>
        /// Только групповые занятия
        /// </summary>
        private bool m_IsOnlyGroup;
        /// <summary>
        /// Только групповые занятия
        /// </summary>
        public bool IsOnlyGroup
        {
            get { return m_IsOnlyGroup; }
            set { m_IsOnlyGroup = value; }
        }


        /// <summary>
        /// Недействителен
        /// </summary>
        private bool m_IsInactive;
        /// <summary>
        /// Недействителен
        /// </summary>
        public bool IsInactive
        {
            get { return m_IsInactive; }
            set { m_IsInactive = value; }
        }

        #region Public Methods
        /// <summary>
        /// Поднять всех клиентов
        /// </summary>
        /// <returns></returns>
        public static IList<KindTickets> FindAll()
        {
            var tm = new TicketsManager();
            return tm.LoadKindTickets();
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save()
        {

        }
        /// <summary>
        /// Обновить
        /// </summary>
        public void Update()
        {

        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
        { 

        }
        #endregion
    }
}
