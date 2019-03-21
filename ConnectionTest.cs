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

			//string connString;
			//SqlConnection cnn;

			//connString = @"Data Source=" + dataSource + ";Initial Catalog=" + dbName
			//	+ ";User Id=" + username + ";Password=" + password;
			//cnn = new SqlConnection(connString);
			//cnn.Open();


			//SqlCommand comm;
			//SqlDataReader dataReader;
			//string sql;

			//sql = "SELECT FirstName FROM Patient";
			//comm = new SqlCommand(sql, cnn);
			//dataReader = comm.ExecuteReader();

			//while (dataReader.Read())
			//{
			//	System.Console.WriteLine(dataReader.GetValue(0));
			//}


			//cnn.Close();
		}
	}
}