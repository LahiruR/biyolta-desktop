using System;
using MySql.Data.MySqlClient;

namespace bos_desktop.src.test
{
	class Test
	{
		public void Hello()
		{
			Console.WriteLine("Hello world");
		}

		private void testQuery(MySqlConnection connection)
		{
			connection.Open();

			MySqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM test.user";
			command.CommandType = System.Data.CommandType.Text;

			MySqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader.GetValue(1)); // cloumn 2
			}

			reader.Close();

			connection.Close();
		}
	}
}
