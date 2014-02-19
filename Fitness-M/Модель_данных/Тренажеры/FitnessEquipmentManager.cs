using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Менеджер для тренажеров
    /// </summary>
    public class FitnessEquipmentManager : ObjectManager
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FitnessEquipmentManager() : base() { }

        /// <summary>
        /// Получить тренажер по Ид
        /// </summary>
        public FitnessEquipment Get(int Id)
        {
            OpenConnection();

            FitnessEquipment fitnessEquipment = null;

            string sql = "select * from fitness_equipment where id = @id;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;

            cmd.Parameters.AddWithValue("@id", Id);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fitnessEquipment = new FitnessEquipment();
                fitnessEquipment.Id = TryGetValue<int>(reader["id"]);
                fitnessEquipment.Title = TryGetValue<string>(reader["title"]);
                fitnessEquipment.RunningTime = TryGetValue<int>(reader["running_time"]);
                fitnessEquipment.CountBalls = TryGetValue<int>(reader["count_balls"]);
            }
            cmd.Dispose();
            CloseConnection();

            return fitnessEquipment;
        }

        /// <summary>
        /// Загрузить все тренажеры 
        /// </summary>
        public IList<FitnessEquipment> LoadFitnessEquipment()
        {
            IList<FitnessEquipment> listFitnessEquipment = new List<FitnessEquipment>();

            OpenConnection();

            string sql = "select * from fitness_equipment order by title;";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var fitnessEquipment = new FitnessEquipment();
                fitnessEquipment.Id = TryGetValue<int>(reader["id"]);
                fitnessEquipment.Title = TryGetValue<string>(reader["title"]);
                fitnessEquipment.RunningTime = TryGetValue<int>(reader["running_time"]);
                fitnessEquipment.CountBalls = TryGetValue<int>(reader["count_balls"]);

                listFitnessEquipment.Add(fitnessEquipment);
            }
            cmd.Dispose();
            CloseConnection();

            return listFitnessEquipment;
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save(FitnessEquipment fitnessEquipment) 
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = string.Format("select count(*) as count from fitness_equipment where id = {0};", fitnessEquipment.Id);
            cmd.CommandText = sql;
            var count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                sql = @"INSERT INTO fitness_equipment (id, title, running_time, count_balls) 
                        VALUES (NULL, @title, @running_time, @count_balls)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@title", fitnessEquipment.Title);
                cmd.Parameters.AddWithValue("@running_time", fitnessEquipment.RunningTime);
                cmd.Parameters.AddWithValue("@count_balls", fitnessEquipment.CountBalls);

                try
                {
                    cmd.ExecuteNonQuery();
                    fitnessEquipment.Id = (int)cmd.LastInsertedId;
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
        public void Update(FitnessEquipment fitnessEquipment) 
        {
            if (fitnessEquipment.Id != null || fitnessEquipment.Id != 0)
            {
                OpenConnection();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = Connection;

                string sql = @"UPDATE fitness_equipment SET 
                    title = @title,
                    running_time = @running_time,
                    count_balls = @count_balls
                    WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@title", fitnessEquipment.Title);
                cmd.Parameters.AddWithValue("@running_time", fitnessEquipment.RunningTime);
                cmd.Parameters.AddWithValue("@count_balls", fitnessEquipment.CountBalls);
                cmd.Parameters.AddWithValue("@id", fitnessEquipment.Id);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete(FitnessEquipment fitnessEquipment) 
        {
            if (fitnessEquipment.Id != null || fitnessEquipment.Id != 0)
            {
                OpenConnection();
                try
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    cmd.Connection = Connection;

                    CheckDeleteFitnessEquipment(fitnessEquipment.Id);

                    string sql = @"delete from fitness_equipment where id = @id";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", fitnessEquipment.Id);
                    cmd.ExecuteNonQuery();
                }
                catch (BussinesException ex)
                {
                    throw;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        /// <summary>
        /// Проверить можно удалить тренажер
        /// </summary>
        /// <param name="p"></param>
        private void CheckDeleteFitnessEquipment(int fitnessEquipmentId)
        {
            OpenConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Connection;

            string sql = @"select COUNT(*) from client_use_equipment
                            where fitness_equipment_id  = @id ";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", fitnessEquipmentId);
            var count = (long)cmd.ExecuteScalar();

            if (count > 0)
                throw new BussinesException("Нельзя удалить тренажер, на нем занимаются клиенты!");
        }
    }
}
