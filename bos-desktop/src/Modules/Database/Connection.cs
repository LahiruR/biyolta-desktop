using System;
using MySql.Data.MySqlClient;

namespace bos_desktop.src.Modules.Database
{
	public sealed class Connection
	{
		private static Connection connection = null;
		private MySqlConnection dbConnection = null;

		private Connection() { }

		public static Connection GetInstance()
		{
			if (connection == null)
			{
				connection = new Connection();
			}

			return connection;
		}

		public MySqlConnection GetConnection()
		{
			MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();

			connectionStringBuilder.Add("Database", "test");
			connectionStringBuilder.Add("Data Source", "localhost");
			connectionStringBuilder.Add("User Id", "root");
			connectionStringBuilder.Add("Password", "");

			dbConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);

			return dbConnection;
		}

	}
}
