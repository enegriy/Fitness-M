using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Клиент
    /// </summary>
    public sealed class Client: ClientManager, IBusinessObject
    {
        #region Prop
        private IList<Tickets> m_ListTickets;
        /// <summary>
        /// Спецификация абонементов всех
        /// </summary>
        public IList<Tickets> ListTickets 
        {
            get
            {
                if (m_ListTickets == null)
                {
                    m_ListTickets = new List<Tickets>();
                    var dataSet = ClientDataSet.Get();
                    var tickets = dataSet.ListTickets
                        .Where(x => x.ClientId == this.Id)
                        .Distinct()
                        .ToList();
                    ((List<Tickets>)m_ListTickets).AddRange(tickets);
                }

                return m_ListTickets;
            }
            set
            {
                m_ListTickets = value;
            }
        }

        /// <summary>
        /// Спецификация абонементов действующих
        /// </summary>
        public IList<Tickets> ListTicketsActive
        {
            get
            {
                return ListTickets.Where(x => x.Balance > 0 && x.DateFinish.Date >= DateTime.Now.Date).ToList();
            }
        }

        private IList<Visit> m_ListVisit;
        /// <summary>
        /// Спецификация посещений всех
        /// </summary>
        public IList<Visit> ListVisit
        {
            get
            {
                if (m_ListVisit == null )
                {
                    m_ListVisit = new List<Visit>();
                    var dataSet = ClientDataSet.Get();
                    var visits = dataSet.ListVisit
                        .Where(x => x.ClientId == this.Id)
                        .Distinct()
                        .ToList();
                    ((List<Visit>)m_ListVisit).AddRange(visits);
                }

                return m_ListVisit;
            }
            set
            {
                m_ListVisit = value;
            }
        }

        /// <summary>
        /// Спецификация посещений на текущую дату
        /// </summary>
        public IList<Visit> ListVisitActive
        {
            get
            {
                return ListVisit.Where(x => x.PlanFrom.Date >= DateTime.Now.Date).ToList();
            }
        }

        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public long Number { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Доп
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Пустая запись
        /// </summary>
        public bool IsEmpty
        {
            get { return Id == 0; }
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save()
        {
            Save(this);
        }

        /// <summary>
        /// Обновить
        /// </summary>
        public void Update()
        {
            Update(this);
        }

        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
        {
            Delete(this);
        }
        #endregion
    }
}
