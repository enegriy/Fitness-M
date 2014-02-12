using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Менеджер абонементов
    /// </summary>
    public class TicketsManager : ObjectManager
    {
        public TicketsManager()
            : base()
        {
        }
        #region Kind Ticket
        public IList<KindTickets> LoadKindTickets()
        {
            IList<KindTickets> listKinds = new List<KindTickets>();

            OpenConnection();

            string sql = "SELECT * FROM kind_tickets order by isinactive;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var kindTickets = new KindTickets();
                kindTickets.Id = TryGetValue<int>(reader["id"]);
                kindTickets.Period = TryGetValue<int>(reader["period"]);
                kindTickets.CountBalls = TryGetValue<int>(reader["count_balls"]);
                kindTickets.CountVisits = TryGetValue<int>(reader["count_visits"]);
                kindTickets.IsOnlyGroup = TryGetValue<bool>(reader["isonlygroup"]);
                kindTickets.IsInactive = TryGetValue<bool>(reader["isinactive"]);
                kindTickets.Price = TryGetValue<decimal>(reader["price"]);
                listKinds.Add(kindTickets);
            }
            cmd.Dispose();
            CloseConnection();

            return listKinds;
        }

        public KindTickets GetKindTickets(int id)
        {
            KindTickets kindTickets=null;

            OpenConnection();

            string sql = "SELECT * FROM kind_tickets where id = {0};";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(string.Format(sql, id));
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                kindTickets = new KindTickets();
                kindTickets.Id = TryGetValue<int>(reader["id"]);
                kindTickets.Period = TryGetValue<int>(reader["period"]);
                kindTickets.CountBalls = TryGetValue<int>(reader["count_balls"]);
                kindTickets.CountVisits = TryGetValue<int>(reader["count_visits"]);
                kindTickets.IsOnlyGroup = TryGetValue<bool>(reader["isonlygroup"]);
                kindTickets.IsInactive = TryGetValue<bool>(reader["isinactive"]);
                kindTickets.Price = TryGetValue<decimal>(reader["price"]);
            }
            cmd.Dispose();
            CloseConnection();

            return kindTickets;
        }

        public IList<Tickets> LoadTickets()
        {
            IList<Tickets> listTickets = new List<Tickets>();

            OpenConnection();

            string sql = "SELECT * FROM tickets;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var tickets = new Tickets();
                tickets.Id = TryGetValue<int>(reader["id"]);
                tickets.DateFinish = TryGetValue<DateTime>(reader["datefinish"]);
                tickets.Balance = TryGetValue<int>(reader["balance"]);
                tickets.ClientId = TryGetValue<int>(reader["client_id"]);
                tickets.KindTicketsId = TryGetValue<int>(reader["kind_tickets_id"]);
                tickets.Debt = TryGetValue<decimal>(reader["debt"]);
                tickets.PayBefore = TryGetValue<DateTime>(reader["pay_before"]);
                listTickets.Add(tickets);
            }
            cmd.Dispose();
            CloseConnection();

            return listTickets;
        }

        public object LoadKindTicketsAttributeById(string fildName, int id)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select {0} from kind_tickets where Id = {1} ", fildName, id);
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }

        public void SaveKindTickets(KindTickets kindTickets)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select count(*) as count from kind_tickets where id = {0};", kindTickets.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO kind_tickets (id, period, count_balls, count_visits, isonlygroup, isinactive, price) 
                        VALUES (NULL, @period, @count_balls, @count_visits, @isonlygroup, @isinactive, @price)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@period", kindTickets.Period);
                cmd.Parameters.AddWithValue("@count_balls", kindTickets.CountBalls);
                cmd.Parameters.AddWithValue("@count_visits", kindTickets.CountVisits);
                cmd.Parameters.AddWithValue("@isonlygroup", kindTickets.IsOnlyGroup);
                cmd.Parameters.AddWithValue("@isinactive", kindTickets.IsInactive);
                cmd.Parameters.AddWithValue("@price", kindTickets.Price);

                try
                {
                    cmd.ExecuteNonQuery();
                    kindTickets.Id = (int)cmd.LastInsertedId;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        throw new BussinesException("Вид шаблона с таким набором значений в базе уже существует!", ex);
                    }
                    else throw;
                }

            }
            CloseConnection();
        }

        public void SaveTickets(Tickets tickets)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select count(*) as count from tickets where id = {0};", tickets.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO tickets (id, datefinish, balance, client_id, kind_tickets_id, debt, pay_before) 
                        VALUES (NULL, @date_finish, @balance, @client_id, @kind_tickets_id, @debt, @pay_before);";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@date_finish", tickets.DateFinish);
                cmd.Parameters.AddWithValue("@balance", tickets.Balance);
                cmd.Parameters.AddWithValue("@client_id", tickets.ClientId);
                cmd.Parameters.AddWithValue("@kind_tickets_id", tickets.KindTicketsId);
                cmd.Parameters.AddWithValue("@debt", tickets.Debt);
                cmd.Parameters.AddWithValue("@pay_before", tickets.PayBefore);

                try
                {
                    cmd.ExecuteNonQuery();
                    tickets.Id = (int)cmd.LastInsertedId;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        throw new BussinesException("Вид шаблона с таким набором значений в базе уже существует!", ex);
                    }
                    else throw;
                }

            }
            CloseConnection();
        }


        public void UpdateKindTickets(KindTickets kindTickets)
        {
            if (kindTickets.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE kind_tickets SET 
                    period = @period,
                    count_balls = @count_balls,
                    count_visits = @count_visits,
                    isonlygroup = @isonlygroup,
                    isinactive = @isinactive,
                    price = @price
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", kindTickets.Id);
                cmd.Parameters.AddWithValue("@period", kindTickets.Period);
                cmd.Parameters.AddWithValue("@count_balls", kindTickets.CountBalls);
                cmd.Parameters.AddWithValue("@count_visits", kindTickets.CountVisits);
                cmd.Parameters.AddWithValue("@isonlygroup", kindTickets.IsOnlyGroup);
                cmd.Parameters.AddWithValue("@isinactive", kindTickets.IsInactive);
                cmd.Parameters.AddWithValue("@price", kindTickets.Price);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void UpdateTickets(Tickets tickets)
        {
            if (tickets.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE tickets SET 
                    balance = @balance,
                    datefinish = @date_finish,
                    client_id = @client_id,
                    debt = @debt,
                    pay_before = @pay_before,
                    kind_tickets_id = @kind_tickets_id
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", tickets.Id);
                cmd.Parameters.AddWithValue("@balance", tickets.Balance);
                cmd.Parameters.AddWithValue("@date_finish", tickets.DateFinish);
                cmd.Parameters.AddWithValue("@client_id", tickets.ClientId);
                cmd.Parameters.AddWithValue("@kind_tickets_id", tickets.KindTicketsId);
                cmd.Parameters.AddWithValue("@debt", tickets.Debt);
                cmd.Parameters.AddWithValue("@pay_before", tickets.PayBefore);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void DeleteKindTickets(KindTickets kindTickets)
        {
            if (kindTickets.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"delete from kind_tickets where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", kindTickets.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void DeleteTickets(Tickets tickets)
        {
            if (tickets.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"delete from tickets where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", tickets.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
        #endregion
    }
}
