using System.Data.SqlClient;
using System.ComponentModel;
using System.Text;

namespace ConnectTest
{
	class SQLConnect
	{
		static void Main(string[] args)
		{
			string connString;
			SqlConnection cnn;

			connString = @"Data Source=SURFACE-LAPTOP-\MSSQLSERVER01;Initial Catalog=291Project;User Id=admin;Password=12345";
			cnn = new SqlConnection(connString);
			cnn.Open();
			cnn.Close();
		}
	}
}