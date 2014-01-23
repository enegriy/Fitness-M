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
    }
}
