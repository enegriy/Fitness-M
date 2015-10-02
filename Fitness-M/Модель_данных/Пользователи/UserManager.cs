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
			try
			{
				string sql = "SELECT name FROM users ;";
				var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql);
				cmd.Connection = Connection;
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					listUserNames.Add(TryGetValue<string>(reader["name"]));
				}
				cmd.Dispose();
			}
			finally 
			{
				CloseConnection();
			}
			
			return listUserNames.ToArray();
		}

		public void SignUp(string name, string pasw, int role)
		{
			OpenConnection();
			try
			{
				var cmd = new MySql.Data.MySqlClient.MySqlCommand();
				cmd.Connection = Connection;

				string sql = string.Format("select id from users where name = '{0}' and passwd = '{1}' and role_number = {2};", name, pasw, role);
				cmd.CommandText = sql;
				var reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					CurrentUser.Id = (int)reader["id"];
					if (role == 1)
						CurrentUser.Role = Roles.User;
					else
						CurrentUser.Role = Roles.Administrator;
				}
				else
					throw new BussinesException("Пользователь с такими реквизитами не найден!");
			}
			finally
			{
				CloseConnection();
			}
		}
	}
}
