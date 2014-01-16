using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Мэнеджер для работы с клиентами
    /// </summary>
    public class ClientManager
    {
        private static MySql.Data.MySqlClient.MySqlConnection m_Connection;
        static ClientManager()
        {
            m_Connection = 
                new MySql.Data.MySqlClient.MySqlConnection(
                    ProgOptions.mConnectionString);
        }

        public static void OpenConnection()
        {
            if (m_Connection.State != System.Data.ConnectionState.Open)
                m_Connection.Open();
        }

        public static void CloseConnection()
        {
            if (m_Connection.State != System.Data.ConnectionState.Closed)
                m_Connection.Close();
        }

        public static IList<Client> LoadCliets()
        {
            IList<Client> listClients = new List<Client>();

            OpenConnection();

            string sql = "select * from clients order by number;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = m_Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var client = new Client();
                client.Id = (int)reader["id"];
                client.Number = (long)reader["number"];
                client.SurName = reader["surname"].ToString();
                client.Name = reader["name"].ToString();
                client.LastName = reader["lastname"].ToString();
                client.DateBirth = (DateTime)reader["datebirth"];
                client.Phone = reader["phone"].ToString();
                client.Address = reader["address"].ToString();
                client.Note = reader["note"].ToString();
                listClients.Add(client);
            }
            cmd.Dispose();
            CloseConnection();

            return listClients;
        }

        public static object LoadAttributeByNumber(string fildName, long number)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = m_Connection;

            string sql = string.Format("select {0} from clients where number = {1} ", fildName, number);
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }


        public static void Save(Client client)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = m_Connection;

            string sql = string.Format( "select count(*) as count from clients where id = {0};",client.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO clients (id, number, surname, name, lastname, datebirth, phone, address, note) 
                        VALUES (NULL, @number, @surname, @name, @lastname, @datebirth, @phone, @address, @note)";
                
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@number", client.Number);
                cmd.Parameters.AddWithValue("@surname", client.SurName);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastname", client.LastName);
                cmd.Parameters.AddWithValue("@datebirth", client.DateBirth);
                cmd.Parameters.AddWithValue("@phone", client.Phone);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@note", client.Note);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    if (ex.Number == 1062) {
                        throw new BussinesException("Клиент с таким набором значений в базе уже существует!", ex);
                    }
                    else throw;
                }

            }
            CloseConnection();

            client.Id = (int)LoadAttributeByNumber("Id", client.Number);
        }


        public static void Update(Client client)
        {
            if (client.Id != null || client.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = m_Connection;

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

        public static void Delete(Client client)
        {
            if (client.Id != null || client.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = m_Connection;

                string sql = @"delete from clients where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}
