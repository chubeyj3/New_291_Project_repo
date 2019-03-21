using System.Data.SqlClient;
using System.ComponentModel;
using System.Text;

namespace CMPT291_Project
{
	class ConnectTest
	{
		static void Main(string[] args)
		{
			string dataSource = @"SURFACE-LAPTOP-\MSSQLSERVER01";
			string dbName = "291Project";
			string username = "admin";
			string password = "12345";

			DBManager db = new DBManager(dataSource, dbName, username, password);
			SqlDataReader dr = db.query("SELECT FirstName FROM Patient");

			while (dr.Read())
			{
				System.Console.WriteLine(dr.GetValue(0));
			}

			db.closeConnection();
		}
	}
}
