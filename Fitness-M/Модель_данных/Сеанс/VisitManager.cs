using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Мэнэджер для работы с посещениями
    /// </summary>
    public class VisitManager : ObjectManager
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public VisitManager()
            : base()
        { }

        /// <summary>
        /// Загрузить посещения
        /// </summary>
        public IList<Visit> LoadVisit()
        {
            IList<Visit> listVisits = new List<Visit>();

            OpenConnection();

            string sql = "select * from visits order by client_id;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var visit = new Visit();
                visit.Id = TryGetValue<int>(reader["id"]);
                visit.ClientId = TryGetValue<int>(reader["client_id"]);
                visit.PlanFrom = TryGetValue<DateTime>(reader["plan_from"]);
                visit.PlanTo = TryGetValue<DateTime>(reader["plan_to"]);
                visit.VisitFrom = TryGetValue<DateTime>(reader["visit_from"]);
                visit.VisitTo = TryGetValue<DateTime>(reader["visit_to"]);
                visit.IsDisabled = TryGetValue<bool>(reader["is_disabled"]);
                visit.IsOnlyGroup = TryGetValue<bool>(reader["isonlygroup"]);
                listVisits.Add(visit);
            }
            reader.Close();
            cmd.Dispose();
            CloseConnection();

            foreach (var visit in listVisits)
            {
                visit.ClientUseFitnessEquipmentSpec = GetSpecificationClientUseFitnessEquipment(visit.Id);
            }

            return listVisits;
        }

        /// <summary>
        /// Получить спецификацию для посещений
        /// </summary>
        public IList<ClientUseFitnessEquipment> GetSpecificationClientUseFitnessEquipment(int visitId)
        {
            IList<ClientUseFitnessEquipment> listClientUseFQ = new List<ClientUseFitnessEquipment>();
            OpenConnection();

            string sql = string.Format( "select * from client_use_equipment where visit_id = {0}",visitId);

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

                listClientUseFQ.Add(clientUseFitnessEquipment);
            }
            cmd.Dispose();
            CloseConnection();

            return listClientUseFQ;
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save(Visit visit)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select count(*) as count from visits where id = {0};", visit.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO visits (id, client_id, plan_from, plan_to, visit_from, visit_to, is_disabled, isonlygroup) 
                        VALUES (NULL, @client_id, @plan_from, @plan_to, @visit_from,  @visit_to,  @is_disabled, @isonlygroup)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@client_id", visit.ClientId);
                cmd.Parameters.AddWithValue("@plan_from", visit.PlanFrom);
                cmd.Parameters.AddWithValue("@plan_to", visit.PlanTo);
                cmd.Parameters.AddWithValue("@visit_from", visit.VisitFrom);
                cmd.Parameters.AddWithValue("@visit_to", visit.VisitTo);
                cmd.Parameters.AddWithValue("@is_disabled", visit.IsDisabled);
                cmd.Parameters.AddWithValue("@isonlygroup", visit.IsOnlyGroup);

                try
                {
                    cmd.ExecuteNonQuery();
                    visit.Id = (int)cmd.LastInsertedId;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    throw new BussinesException(ex.Message, ex);
                }

            }
            CloseConnection();
        }
        /// <summary>
        /// Обновить
        /// </summary>
        public void Update(Visit visit)
        {
            if (visit.Id != null || visit.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE visits SET 
                    client_id = @client_id,
                    plan_from = @plan_from,
                    plan_to = @plan_to,
                    visit_from = @visit_from,
                    visit_to = @visit_to,
                    is_disabled = @is_disabled,
                    isonlygroup = @isonlygroup
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@client_id", visit.ClientId);
                cmd.Parameters.AddWithValue("@plan_from", visit.PlanFrom);
                cmd.Parameters.AddWithValue("@plan_to", visit.PlanTo);
                cmd.Parameters.AddWithValue("@visit_from", visit.VisitFrom);
                cmd.Parameters.AddWithValue("@visit_to", visit.VisitTo);
                cmd.Parameters.AddWithValue("@is_disabled", visit.IsDisabled);
                cmd.Parameters.AddWithValue("@isonlygroup", visit.IsOnlyGroup);
                cmd.Parameters.AddWithValue("@id", visit.Id);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete(Visit visit)
        {
            if (visit.Id != null || visit.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"delete from visits where id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", visit.Id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}