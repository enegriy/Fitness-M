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
        public IList<TicketMixed> GetListTicketMixed(TicketFilter filter)
        {

            IList<TicketMixed> listTicketMixed = new List<TicketMixed>();

            string sql = @"select 
                              t.id as ticketID, t.datefinish, balance, 
                              kt.count_balls, kt.count_visits, kt.price,
                              c.number, c.surname, c.name, c.lastname, c.phone
                            from tickets t
                            left join kind_tickets kt on t.kind_tickets_id = kt.id
                            left join clients c on t.client_id = c.id";

            if (filter != null)
            {
                StringBuilder builder = new StringBuilder();

                if (filter.ClientNumber != 0)
                {
                    if(builder.Length == 0)
                        builder.Append(" where ");
                    else
                        builder.Append(" and ");

                    builder.AppendFormat(" c.number = {0}", filter.ClientNumber);
                }

                if (!string.IsNullOrEmpty(filter.ClientSurname))
                {
                    if (builder.Length == 0)
                        builder.Append(" where ");
                    else
                        builder.Append(" and ");

                    builder.AppendFormat(" c.surname like '%{0}%'", filter.ClientSurname);
                }


                if (filter.NotExistTickets)
                {
                    if (builder.Length == 0)
                        builder.Append(" where ");
                    else
                        builder.Append(" and ");

                    builder.Append(" not exists (select * from tickets where client_id = c.id and datefinish > curdate()) ");
                }

                if (filter.Period > 0)
                {
                    var curDate = System.DateTime.Now.Date;

                    switch (filter.Period)
                    {
                        case 1: curDate = curDate.AddDays(2); break;
                        case 2: curDate = curDate.AddDays(7); break;
                        case 3: curDate = curDate.AddDays(10); break;
                        case 4: curDate = curDate.AddDays(15); break;
                    }

                    if (builder.Length == 0)
                        builder.Append(" where ");
                    else
                        builder.Append(" and ");

                    builder.AppendFormat("(t.datefinish >= curdate() and t.datefinish <= '{0}')",curDate.ToString("yyyy-MM-dd"));
                }

                if (builder.Length == 0)
                    builder.Append(" where ");
                else
                    builder.Append(" and ");

                builder.AppendFormat(" t.balance <= {0} ", filter.Balance);
                
                sql = string.Concat(sql, builder.ToString());
            }

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
