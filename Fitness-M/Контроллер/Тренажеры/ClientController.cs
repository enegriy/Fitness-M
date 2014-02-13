using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс для клиентов
    /// </summary>
    public class ClientController
    {
        /// <summary>
        /// Проверить связи у клиента
        /// </summary>
        /// <param name="client"></param>
        public void CheckConstrainsClient(Client client)
        {
            var activeTickets = client.ListTickets.Any(x =>
                x.DateFinish >= DateTime.Now.Date &&
                x.Balance > 0);

            if (activeTickets)
                throw new BussinesException("У клиента есть не использованные абонементы!");

            var activeVisits = client.ListVisit.Any(x => x.PlanFrom > DateTime.Now);

            if (activeVisits)
                throw new BussinesException("У клиента есть бронь на посещения!");

        }

    }
}
