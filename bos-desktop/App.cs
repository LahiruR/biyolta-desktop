using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using bos_desktop.src.test;
using bos_desktop.src.Modules.Database;

namespace bos_desktop
{
	static class App
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Test test = new Test();
			test.Hello();

			MySql.Data.MySqlClient.MySqlConnection connection = Connection.GetInstance().GetConnection();
			Console.WriteLine("Hello Console log");

			/*Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());*/
		}
	}
}
