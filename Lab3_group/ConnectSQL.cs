using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_group
{
	class ConnectSQL
	{
		string con;
		public ConnectSQL()
		{
			con = @"Data Source=DESKTOP-L7519H2\MSSQSERVER05;Initial Catalog=QLSVNhom;Integrated Security=True";
		}
		
		public SqlConnection getConnect()
		{
			return new SqlConnection(con);
		}
	}
}
