using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Менеджер для работы с используемыми тренажерами 
    /// </summary>
    public class ClientUseFitnessEquipmentManager : ObjectManager
    {
        public ClientUseFitnessEquipmentManager()
            : base()
        {
        }

        public IList<ClientUseFitnessEquipment> LoadClientUseFitnessEquipments()
        {
            IList<ClientUseFitnessEquipment> listClientUseFitnessEquipment = new List<ClientUseFitnessEquipment>();

            OpenConnection();

            string sql = "select * from client_use_equipment;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var clientUseFitnessEquipment = new ClientUseFitnessEquipment();
                clientUseFitnessEquipment.Id = TryGetValue<int>(reader["id"]);
                clientUseFitnessEquipment.VisitId = TryGetValue<int>(reader["visit_id"]);
                clientUseFitnessEquipment.FitnessEquipmentId = TryGetValue<int>(reader["fitness_equipment_id"]);
                clientUseFitnessEquipment.TimeFrom = TryGetValue<TimeSpan>(reader["time_from"]);
                clientUseFitnessEquipment.TimeTo = TryGetValue<TimeSpan>(reader["time_to"]);

                listClientUseFitnessEquipment.Add(clientUseFitnessEquipment);
            }
            cmd.Dispose();
            CloseConnection();

            return listClientUseFitnessEquipment;
        }


        public void Save(ClientUseFitnessEquipment clientUseFitnessEquipment)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select count(*) as count from client_use_equipment where id = {0};", clientUseFitnessEquipment.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO client_use_equipment (id, visit_id, fitness_equipment_id, time_from, time_to) 
                        VALUES (NULL, @visit_id, @fitness_equipment_id, @time_from, @time_to)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@visit_id", clientUseFitnessEquipment.VisitId);
                cmd.Parameters.AddWithValue("@fitness_equipment_id", clientUseFitnessEquipment.FitnessEquipmentId);
                cmd.Parameters.AddWithValue("@time_from", clientUseFitnessEquipment.TimeFrom);
                cmd.Parameters.AddWithValue("@time_to", clientUseFitnessEquipment.TimeTo);

                try
                {
                    cmd.ExecuteNonQuery();
                    clientUseFitnessEquipment.Id = (int)cmd.LastInsertedId;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    throw;
                }

            }
            CloseConnection();
        }


        public void Update(ClientUseFitnessEquipment clientUseFitnessEquipment)
        {
            if (clientUseFitnessEquipment.Id != null || clientUseFitnessEquipment.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE client_use_equipment SET 
                    visit_id = @visit_id,
                    fitness_equipment_id = @fitness_equipment_id,
                    time_from = @time_from,
                    time_to = @time_to
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", clientUseFitnessEquipment.Id);
                cmd.Parameters.AddWithValue("@visit_id", clientUseFitnessEquipment.VisitId);
                cmd.Parameters.AddWithValue("@fitness_equipment_id", clientUseFitnessEquipment.FitnessEquipmentId);
                cmd.Parameters.AddWithValue("@time_from", clientUseFitnessEquipment.TimeFrom);
                cmd.Parameters.AddWithValue("@time_to", clientUseFitnessEquipment.TimeTo);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void Delete(ClientUseFitnessEquipment clientUseFitnessEquipment)
        {
            if (clientUseFitnessEquipment.Id != null || clientUseFitnessEquipment.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"delete from client_use_equipment where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", clientUseFitnessEquipment.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}
