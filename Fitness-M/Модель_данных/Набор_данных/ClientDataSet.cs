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

        #region Tables
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

        private IList<KindTickets> m_ListKindTickets;
        /// <summary>
        /// Вид тикетов
        /// </summary>
        public IList<KindTickets> ListKindTickets
        {
            get { return m_ListKindTickets; }
            set { m_ListKindTickets = value; }
        }

        private IList<ClientUseFitnessEquipment> m_ListUseFitnessEquipment;
        /// <summary>
        /// Вид тикетов
        /// </summary>
        public IList<ClientUseFitnessEquipment> ListUseFitnessEquipment
        {
            get { return m_ListUseFitnessEquipment; }
            set { m_ListUseFitnessEquipment = value; }
        }
        #endregion


        
        

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
            m_This.LoadData();
            return m_This;
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
            LoadUseFitnessEquipment();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Загрузить список клиентов
        /// </summary>
        private void LoadClients()
        {
            ListClients = (new ClientManager()).LoadCliets();
        }
        /// <summary>
        /// Загрузить список видов абонементов
        /// </summary>
        private void LoadKindTickets()
        {
            ListKindTickets = (new TicketsManager()).LoadKindTickets();
        }

        /// <summary>
        /// Загрузить абонементы 
        /// </summary>
        private void LoadTickets()
        {
            ListTickets = (new TicketsManager()).LoadTickets();
        }

        /// <summary>
        /// Загрузить тренажеры
        /// </summary>
        private void LoadFitnessEquipments()
        {
            ListFitnessEquipment = (new FitnessEquipmentManager()).LoadFitnessEquipment();
        }

        /// <summary>
        /// Загрузить посещения
        /// </summary>
        private void LoadVisits()
        {
            ListVisit = (new VisitManager()).LoadVisit();
        }

        /// <summary>
        /// Загрузить используемых тренажеров
        /// </summary>
        private void LoadUseFitnessEquipment()
        {
            ListUseFitnessEquipment = (new ClientUseFitnessEquipmentManager()).LoadClientUseFitnessEquipments();
        }

        /// <summary>
        /// Загрузить абонементы на текущую дату 
        /// </summary>
        /*private void LoadTicketsOnCurrentDate()
        {
            ListTickets = (new TicketsManager()).LoadTickets();
            ListTickets = ListTickets.Where(tck =>
                tck.DateFinish.Date >= DateTime.Now.Date &&
                tck.Balance > 0).ToList();
        }*/

        /// <summary>
        /// Загрузить на текущую дату
        /// </summary>
        /*private void LoadVisitsOnCurrentDate()
        {
            ListVisit = (new VisitManager()).LoadVisit();
            ListVisit = ListVisit.Where(vst =>
                vst.PlanFrom.Date >= DateTime.Now.Date ||
                vst.VisitFrom.Date >= DateTime.Now.Date).ToList();
        }*/


        /// <summary>
        /// Установить спецификацию для клиентов
        /// </summary>
        /*private void SetSpecificationForClients()
        {
            if (ListClients != null && ListTickets != null)
            {
                for (int i = 0; i < ListClients.Count; i++)
                {
                    ListClients[i].ListTickets = ListTickets.Where(x => x.ClientId == ListClients[i].Id).ToArray();
                }
            }
        }*/

        /// <summary>
        /// Установить спецификацию посещений для клиентов
        /// </summary>
        /*private void SetSpecificationVisitForClients()
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
        }*/

        #endregion

    }
}
