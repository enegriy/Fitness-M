using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Мэнеджер для работы с клиентами
    /// </summary>
    public class ClientManager : ObjectManager
    {
        public ClientManager() : base()
        {
        }

        public IList<Client> LoadCliets()
        {
            IList<Client> listClients = new List<Client>();

            OpenConnection();

            string sql = "select * from clients order by number;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var client = new Client();
                client.Id = TryGetValue<int>(reader["id"]);
                client.Number = TryGetValue<long>(reader["number"]);
                client.SurName = TryGetValue<string>(reader["surname"]);
                client.Name = TryGetValue<string>(reader["name"]);
                client.LastName = TryGetValue<string>(reader["lastname"]);
                client.DateBirth = TryGetValue<DateTime>(reader["datebirth"]);
                client.Phone = TryGetValue<string>(reader["phone"]);
                client.Address = TryGetValue<string>(reader["address"]);
                client.Note = TryGetValue<string>(reader["note"]);
                client.Code = TryGetValue<uint>(reader["code"]);
                listClients.Add(client);
            }
            cmd.Dispose();
            CloseConnection();

            return listClients;
        }

        protected object LoadAttributeByNumber(string fildName, long number)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select {0} from clients where number = {1} ", fildName, number);
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }


        public void Save(Client client)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format( "select count(*) as count from clients where id = {0};",client.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO clients (id, number, surname, name, lastname, datebirth, phone, address, note, code) 
                        VALUES (NULL, @number, @surname, @name, @lastname, @datebirth, @phone, @address, @note, @code)";
                
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@number", client.Number);
                cmd.Parameters.AddWithValue("@surname", client.SurName);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastname", client.LastName);
                cmd.Parameters.AddWithValue("@datebirth", client.DateBirth);
                cmd.Parameters.AddWithValue("@phone", client.Phone);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@note", client.Note);
                cmd.Parameters.AddWithValue("@code", client.Code);

                try
                {
                    cmd.ExecuteNonQuery();
                    client.Id = (int)cmd.LastInsertedId;
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
                    note = @note,
                    code = @code
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
                cmd.Parameters.AddWithValue("@code", client.Code);

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

        public long GenerateNumber()
        {
            OpenConnection();
            long num;
            try
            {
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"select max(number) from clients;";
                cmd.CommandText = sql;
                num = (long)cmd.ExecuteScalar();
                num++;
            }
            catch
            {
                num = 1;
            }
            finally
            {
                CloseConnection();
            }
            return num;
        }
    }
}
