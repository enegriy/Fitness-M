using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	public class UserManager : ObjectManager
	{
		/// <summary>
		/// Получить имена пользователей системы
		/// </summary>
		/// <returns></returns>
		public string[] GetUsersName()
		{
			IList<string> listUserNames = new List<string>();

			OpenConnection();

			string sql = "SELECT name FROM users ;";
			var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
			cmd.Connection = Connection;
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				listUserNames.Add(TryGetValue<string>(reader["name"]));
			}
			cmd.Dispose();
			CloseConnection();

			return listUserNames.ToArray();
		}
	}
}
