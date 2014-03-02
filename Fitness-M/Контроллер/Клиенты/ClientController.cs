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


        /// <summary>
        /// Действие на событие Код был отсканирован
        /// </summary>
        public static void ActionCodeWasScaned(uint code)
        {
            var listClients = ClientDataSet.Get().ListClients;
            var client = listClients.FirstOrDefault(x => x.Code == code);
            if (client == null)
            {
                MessageHelper.ShowError("Электронная карточка не назначена клиенту!");
            }
            else
            {
                var listVisit = client.ListVisit.Where(x => x.PlanFrom.Date == DateTime.Now.Date && x.IsDisabled == false).ToArray();
                if (listVisit.Any())
                {
                    ArrivedAndDepartedEditFrom.FormShow(listVisit);
                }
                else
                {
                    MessageHelper.ShowError(string.Format( "Для клиента {0} не найдено ни одного забронированного посещения!",client.FullName));
                }
            }
        }


    }
}
