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
        #region Prop
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

        private decimal m_Debt;
        /// <summary>
        /// Долг
        /// </summary>
        public decimal Debt
        {
            get { return m_Debt; }
            set { m_Debt = value; }
        }

        private DateTime m_PayBefore;
        /// <summary>
        /// Оплатить до
        /// </summary>
        public DateTime PayBefore
        {
            get { return m_PayBefore; }
            set { m_PayBefore = value; }
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
        #endregion

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

        #region ReferenceProp
        private Client m_ClientRef;
        /// <summary>
        /// Ссылка на клиента
        /// </summary>
        public Client ClientRef
        {
            get
            {
                if (m_ClientRef == null)
                {
                    var dataSet = ClientDataSet.Get();
                    m_ClientRef = dataSet.ListClients.FirstOrDefault(x => x.Id == ClientId);
                }
                return m_ClientRef;
            }
            set
            {
                m_ClientRef = value;
            }
        }


        private KindTickets m_KindTicketsRef;
        /// <summary>
        /// Ссылка на Вид абонемент
        /// </summary>
        public KindTickets KindTicketsRef
        {
            get 
            {
                if (m_KindTicketsRef == null)
                {
                    var dataSet = ClientDataSet.Get();
                    m_KindTicketsRef = dataSet.ListKindTickets.FirstOrDefault(x => x.Id == KindTicketsId);
                }
                return m_KindTicketsRef; 
            }
            set 
            { 
                m_KindTicketsRef = value; 
            }
        }
        #endregion
    }
}
