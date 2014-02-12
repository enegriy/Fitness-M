using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Пользовательский набор данных
    /// </summary>
    public class ClientDataSet
    {
        private static ClientDataSet m_This;

        private IList<Client> m_ListClients;
        /// <summary>
        /// Список клиентов
        /// </summary>
        public IList<Client> ListClients
        {
            get { return m_ListClients; }
            set { m_ListClients = value; }
        }


        private IList<Tickets> m_ListTickets;
        /// <summary>
        /// Список абонентов
        /// </summary>
        public IList<Tickets> ListTickets
        {
            get { return m_ListTickets; }
            set { m_ListTickets = value; }
        }

        private IList<FitnessEquipment> m_ListFitnessEquipment;
        /// <summary>
        /// Список тренажеров
        /// </summary>
        public IList<FitnessEquipment> ListFitnessEquipment
        {
            get { return m_ListFitnessEquipment; }
            set { m_ListFitnessEquipment = value; }
        }

        private IList<Visit> m_ListVisit;
        /// <summary>
        /// Список посещений
        /// </summary>
        public IList<Visit> ListVisit
        {
            get { return m_ListVisit; }
            set { m_ListVisit = value; }
        }

        /// <summary>
        /// Пустой список тикетов
        /// </summary>
        public bool IsEmptyListTickets
        {
            get { return (ListTickets == null || ListTickets.Count == 0); }
        }

        /// <summary>
        /// Пустой список клиентов
        /// </summary>
        public bool IsEmptyListCliets
        {
            get { return (ListClients == null || ListClients.Count == 0); }
        }

        /// <summary>
        /// Пустой список клиентов
        /// </summary>
        public bool IsEmptyListVisit
        {
            get { return (ListVisit == null || ListVisit.Count == 0); }
        }

        /// <summary>
        /// Пустой список тренажеров
        /// </summary>
        public bool IsEmptyListFitnessEquipment
        {
            get { return (ListFitnessEquipment == null || ListFitnessEquipment.Count == 0); }
        }


        private IList<KindTickets> m_ListKindTickets;
        /// <summary>
        /// Вид тикетов
        /// </summary>
        public IList<KindTickets> ListKindTickets
        {
            get { return m_ListKindTickets; }
            set { m_ListKindTickets = value; }
        }

        /// <summary>
        /// Пустой список видов тикетов
        /// </summary>
        public bool IsEmptyListKindTickets
        {
            get { return (ListKindTickets == null || ListKindTickets.Count == 0); }
        }

        #region PublicMethods
        /// <summary>
        /// Конструктор
        /// </summary>
        private ClientDataSet() { }
        /// <summary>
        /// Загрузить данные
        /// </summary>
        public static ClientDataSet Get()
        {
            if (m_This != null) return m_This;
            m_This = new ClientDataSet();
            return m_This;
        }

        /// <summary>
        /// Загрузить список клиентов
        /// </summary>
        public void LoadClients()
        {
            ListClients = (new ClientManager()).LoadCliets();
        }
        /// <summary>
        /// Загрузить список видов абонементов
        /// </summary>
        public void LoadKindTickets()
        {
            ListKindTickets = (new TicketsManager()).LoadKindTickets();
        }

        /// <summary>
        /// Загрузить абонементы 
        /// </summary>
        public void LoadTickets()
        {
            ListTickets = (new TicketsManager()).LoadTickets();
        }

        /// <summary>
        /// Загрузить посещения
        /// </summary>
        public void LoadVisits()
        {
            ListVisit = (new VisitManager()).LoadVisit();
        }

        /// <summary>
        /// Загрузить тренажеры
        /// </summary>
        public void LoadFitnessEquipments()
        {
            ListFitnessEquipment = (new FitnessEquipmentManager()).LoadFitnessEquipment();
        }

        /// <summary>
        /// Установить спецификацию для клиентов
        /// </summary>
        public void SetSpecificationForClients()
        {
            if (ListClients != null && ListTickets != null)
            {
                for (int i = 0; i < ListClients.Count; i++)
                {
                    ListClients[i].ListTickets = ListTickets.Where(x => x.ClientId == ListClients[i].Id).ToArray();
                }
            }
        }

        /// <summary>
        /// Установить спецификацию посещений для клиентов
        /// </summary>
        public void SetSpecificationVisitForClients()
        {
            if (ListClients != null && ListTickets != null)
            {
                for (int i = 0; i < ListClients.Count; i++)
                {
                    if (ListClients[i].ListVisit == null)
                        ListClients[i].ListVisit = new List<Visit>();

                    var listVisit = ListVisit.Where(x => x.ClientId == ListClients[i].Id).ToArray();
                    foreach (var visit in listVisit)
                    {
                        ListClients[i].ListVisit.Add(visit);
                    }
                }
            }
        }

        /// <summary>
        /// Загрузить все данные
        /// </summary>
        public void LoadData()
        {
            LoadClients();
            LoadTickets();
            LoadKindTickets();
            LoadFitnessEquipments();
            LoadVisits();
            SetSpecificationForClients();
            SetSpecificationVisitForClients();
        }

        #endregion
    }
}
