using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Менеджер объектов
    /// </summary>
    public class ObjectManager
    {
        private MySql.Data.MySqlClient.MySqlConnection m_Connection;

        public MySql.Data.MySqlClient.MySqlConnection Connection
        {
            get { return m_Connection; }
            set { m_Connection = value; }
        }

        public ObjectManager()
        {
            Connection = 
                new MySql.Data.MySqlClient.MySqlConnection(
                    ProgOptions.mConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (Connection.State != System.Data.ConnectionState.Open)
                    Connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException exc)
            {
                throw new ApplicationException(exc.Message);
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
                Connection.Close();
        }
    }
}
