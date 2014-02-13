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
        public Tickets CreateTicket(Client client, KindTickets kindTickets)
        {
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

            return ticket;
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

        /// <summary>
        /// Проверить существование 2х видов абонементов у клиента
        /// </summary>
        public void CheckExistTwoKindTicket(Client client)
        {
            var listTicket = client.ListTickets.Where(x =>
                x.DateFinish.Date > DateTime.Now && x.Balance > 0);

            var isExistOnlyGroup = listTicket.Any(x =>
                x.GetKindTickets(x.KindTicketsId).IsOnlyGroup == true);

            var isExistNotOnlyGroup = listTicket.Any(x =>
                x.GetKindTickets(x.KindTicketsId).IsOnlyGroup == false);

            if (isExistNotOnlyGroup && isExistOnlyGroup)
                throw new BussinesException("Не возможно добавить новый абонемент, у клиента уже есть абонемент на групповые и не групповые занятия!");
        }

        /// <summary>
        /// Существует абонемент на тренажеры(по баллам)
        /// </summary>
        public bool IsExistTicketOnFitnessEq(Client client)
        {
            var listTicket = client.ListTickets.Where(x =>
                x.DateFinish.Date > DateTime.Now && x.Balance > 0);

            return listTicket.Any(x =>
                x.GetKindTickets(x.KindTicketsId).IsOnlyGroup == false);
        }

        /// <summary>
        /// Существует абонемент на групповую тренировку
        /// </summary>
        public bool IsExistTicketOnlyGroup(Client client)
        {
            var listTicket = client.ListTickets.Where(x =>
                x.DateFinish.Date > DateTime.Now && x.Balance > 0);

            return listTicket.Any(x =>
                x.GetKindTickets(x.KindTicketsId).IsOnlyGroup == true);
        }
    }
}
