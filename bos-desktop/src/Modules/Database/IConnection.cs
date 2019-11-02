using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bos_desktop.src.Modules.Database
{
	interface IConnection<Connection>
	{
		Connection GetConnection();
	}
}
