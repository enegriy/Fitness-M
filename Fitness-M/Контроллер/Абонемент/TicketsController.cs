using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Абонемент
    /// </summary>
    public class TicketsController
    {
        public ClientDataSet DataSet { get; set; }

        public void CreateTicket(Client client, int kindTicketsId)
        {
            var kindTickets = DataSet.ListKindTickets.FirstOrDefault(x => x.Id == kindTicketsId);

            var ticket = new Tickets();
            ticket.ClientId = client.Id;
            ticket.KindTicketsId = kindTickets.Id;
            if (kindTickets.IsOnlyGroup)
            {
                ticket.Balance = kindTickets.CountVisits;
            }
            else
            {
                ticket.Balance = kindTickets.CountBalls;
            }
            ticket.DateFinish = DateTime.Now.AddMonths(kindTickets.Period);

            ticket.Save();

            if (DataSet != null)
            {
                DataSet.ListTickets.Add(ticket);
                DataSet.SetSpecificationForClients();
            }
        }

        /// <summary>
        /// Проверить наличие абонементов
        /// </summary>
        public static void CheckExistTickets(IList<Tickets> listTicket)
        {
            bool isExistTicket = false;
            foreach (var ticket in listTicket)
            {
                if (ticket.DateFinish > DateTime.Now && ticket.Balance > 0)
                {
                    isExistTicket = true;
                    break;
                }
            }

            if (!isExistTicket)
                throw new BussinesException("У вас нет доступных абонементов!");
        }

        /// <summary>
        /// Списать групповое занятие
        /// </summary>
        public static void DeductGroupVisit(IList<Tickets> listTicket)
        {
            TicketsManager ticketManager = new TicketsManager();

            var ticket = listTicket.FirstOrDefault(x => 
                x.DateFinish > System.DateTime.Now && 
                x.Balance > 0 && 
                ticketManager.GetKindTickets(x.KindTicketsId).IsOnlyGroup);

            ticket.Balance -= 1;
            ticket.Update();

        }
    }
}
