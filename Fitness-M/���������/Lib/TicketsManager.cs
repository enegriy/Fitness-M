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
                kindTickets.Id = (int)reader["id"];
                kindTickets.Period = (int)reader["period"];
                if (reader["count_balls"] != System.DBNull.Value)
                    kindTickets.CountBalls = (int)reader["count_balls"];
                if (reader["count_visits"] != System.DBNull.Value)
                    kindTickets.CountVisits = (int)reader["count_visits"];
                kindTickets.IsOnlyGroup = (bool)reader["isonlygroup"];
                kindTickets.IsInactive = (bool)reader["isinactive"];
                listKinds.Add(kindTickets);
            }
            cmd.Dispose();
            CloseConnection();

            return listKinds;
        }

        protected object LoadKindTicketsAttributeById(string fildName, int id)
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
                sql = @"INSERT INTO kind_tickets (id, period, count_balls, count_visits, isonlygroup, isinactive) 
                        VALUES (NULL, @period, @count_balls, @count_visits, @isonlygroup, @isinactive)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@period", kindTickets.Period);
                cmd.Parameters.AddWithValue("@count_balls", kindTickets.CountBalls);
                cmd.Parameters.AddWithValue("@count_visits", kindTickets.CountVisits);
                cmd.Parameters.AddWithValue("@isonlygroup", kindTickets.IsOnlyGroup);
                cmd.Parameters.AddWithValue("@isinactive", kindTickets.IsInactive);

                try
                {
                    cmd.ExecuteNonQuery();
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

            kindTickets.Id = (int)LoadKindTicketsAttributeById("Id", kindTickets.Id);
        }


        public void Update(Client client)
        {
            if (client.Id != null || client.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE clients SET 
                    number = @number,
                    surname = @surname,
                    name = @name,
                    lastname = @lastname,
                    datebirth = @datebirth,
                    phone = @phone,
                    address = @address,
                    note = @note
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.Parameters.AddWithValue("@number", client.Number);
                cmd.Parameters.AddWithValue("@surname", client.SurName);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastname", client.LastName);
                cmd.Parameters.AddWithValue("@datebirth", client.DateBirth);
                cmd.Parameters.AddWithValue("@phone", client.Phone);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@note", client.Note);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void Delete(Client client)
        {
            if (client.Id != null || client.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"delete from clients where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}
