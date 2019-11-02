using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bos_desktop.src.Modules.Database;
using MySql.Data.MySqlClient;

namespace bos_desktop.src.Core
{
	class BaseModel
	{
		public MySqlConnection dbConnection;
		public MySqlCommand command;

		public BaseModel()
		{
			this.dbConnection = Connection.GetInstance().GetConnection();
			this.dbConnection.Open();
			this.command = this.dbConnection.CreateCommand();
		}

		public Int64 Insert(String table, Array data)
		{

			return 0;
		}


		public bool Update(String table, Array where, Array data)
		{
			return false;	
		}


		public bool Remove(String table, Int64 id, Array where) 
		{
			return false;
		}

		public String[] SelectItem(String table, Array where)
		{
			return new String[0];
		}

		public void selectMultiple(String table, Array where)
		{ 
			
		}
	}
}
