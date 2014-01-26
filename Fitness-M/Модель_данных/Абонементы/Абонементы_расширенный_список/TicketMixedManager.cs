using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс для работы с тикетами с доп информацией по клиентам
    /// </summary>
    public class TicketMixedManager : ObjectManager
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public TicketMixedManager() :base()
        {
        }
        
        /// <summary>
        /// Получить список тикетов с доп информацией по клиентам
        /// </summary>
        public IList<TicketMixed> GetListTicketMixed()
        {

            IList<TicketMixed> listTicketMixed = new List<TicketMixed>();

            string sql = @"select 
                          t.id as ticketID, t.datefinish, balance, 
                          kt.count_balls, kt.count_visits, kt.price,
                          c.number, c.surname, c.name, c.lastname, c.phone
                        from tickets t
                        left join kind_tickets kt on t.kind_tickets_id = kt.id
                        left join clients c on t.client_id = c.id";

            OpenConnection();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ticketMixed = new TicketMixed();
                ticketMixed.TicketId = (int)reader["ticketID"];
                ticketMixed.DateFinish = (DateTime)reader["datefinish"];
                ticketMixed.Balance = (int)reader["balance"];
                ticketMixed.CountBalls = (int)reader["count_balls"];
                ticketMixed.CountVisits = (int)reader["count_visits"];
                ticketMixed.Price = (decimal)reader["price"];
                ticketMixed.ClientNumber = (long)reader["number"];
                ticketMixed.Surname = reader["surname"].ToString();
                ticketMixed.Name = reader["name"].ToString();
                ticketMixed.Lastname = reader["lastname"].ToString();
                ticketMixed.Phone = reader["phone"].ToString();

                listTicketMixed.Add(ticketMixed);
            }

            CloseConnection();

            return listTicketMixed;
        }
    }
}
