using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Абонементы
    /// </summary>
    public class Tickets : TicketsManager, IBusinessObject 
    {
        private int m_Id;
        /// <summary>
        /// Идентити
        /// </summary>
        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        private DateTime m_DateFinish;
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime DateFinish
        {
            get { return m_DateFinish; }
            set { m_DateFinish = value; }
        }

        private int m_Balance;
        /// <summary>
        /// Баланс(Остаток)
        /// </summary>
        public int Balance
        {
            get { return m_Balance; }
            set { m_Balance = value; }
        }

        private int m_ClientId;
        /// <summary>
        /// Клиент
        /// </summary>
        public int ClientId
        {
            get { return m_ClientId; }
            set { m_ClientId = value; }
        }

        private int m_KindTicketsId;
        /// <summary>
        /// Вид абонемент
        /// </summary>
        public int KindTicketsId
        {
            get { return m_KindTicketsId; }
            set { m_KindTicketsId = value; }
        }

        /// <summary>
        /// Пустой
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return Id == 0;
            }
        }



        #region Public Methods

        /// <summary>
        /// Поднять всех клиентов
        /// </summary>
        /// <returns></returns>
        public static IList<Tickets> FindAll()
        {
            var tm = new TicketsManager();
            return tm.LoadTickets();
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save()
        {
            SaveTickets(this);
        }
        /// <summary>
        /// Обновить
        /// </summary>
        public void Update()
        {
            UpdateTickets(this);
        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
        {
            DeleteTickets(this);
        }

        #endregion
    }
}
