using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Класс параметров
    /// </summary>
    public static class ParamsManager
    {
        /// <summary>
        /// Получить параметр
        /// </summary>
        public static T GetParams<T>(string title)
        {
            var om = new ObjectManager();
            om.OpenConnection();

            string sql = string.Format("select value from parameters where title = '{0}';", title);
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);

            cmd.Connection = om.Connection;
            var value = cmd.ExecuteScalar();

            om.CloseConnection();

            if (value is T)
                return (T)value;

            return default(T);
        }

        /// <summary>
        /// Получить дату и время
        /// </summary>
        public static DateTime TryGetParamsDateTime(string title)
        {
            var om = new ObjectManager();
            om.OpenConnection();

            string sql = string.Format("select value from parameters where title = '{0}';", title);
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);

            cmd.Connection = om.Connection;
            var value = cmd.ExecuteScalar();            

            om.CloseConnection();

            DateTime rslt;
            try
            {
                rslt = DateTime.Parse(value.ToString());
            }
            catch
            {
                rslt = DateTime.Now;
            }

            return rslt;
        }

        /// <summary>
        /// Установить параметр
        /// </summary>
        public static void SetParams(string title, object value)
        {
            var om = new ObjectManager();
            om.OpenConnection();

            string sql = string.Format("select count(*) from parameters where title = '{0}';", title);
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
            cmd.Connection = om.Connection;
            long count = (long)cmd.ExecuteScalar();

            string valAsStr = "";
            if (value is DateTime)
                valAsStr = ((DateTime)value).ToString("yyyy-MM-dd HH:mm");
            else
                valAsStr = value.ToString();

            if (count == 0)
            {
                sql = string.Format("insert into parameters(title, value) values('{0}','{1}');",
                    title, valAsStr);
            }
            else
            {
                sql = string.Format("UPDATE parameters SET value= '{0}' WHERE title='{1}'", valAsStr, title);
            }

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            

            om.CloseConnection();
           
        }
    }

    /// <summary>
    /// Константы наименований параметров
    /// </summary>
    public static class ParamsConstant
    {
        /// <summary>
        /// Название фитнес клуба
        /// </summary>
        public static string FitnessClubName 
        {
            get { return "PConst.FitnessClubName"; } 
        }


        /// <summary>
        /// Время начала работы
        /// </summary>
        public static string WorkTimeFrom
        {
            get { return "PConst.WorkTimeFrom"; }
        }

        /// <summary>
        /// Время окончания работы
        /// </summary>
        public static string WorkTimeTo
        {
            get { return "PConst.WorkTimeTo"; }
        }

    }
}
