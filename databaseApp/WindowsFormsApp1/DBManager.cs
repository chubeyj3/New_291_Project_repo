using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	class DBManager
	{
		private SqlConnection conn = null;

		public DBManager(string serverName, string dbName, string username, string password)
		{
			string connString = @"Data Source=" + serverName
			+ ";Initial Catalog=" + dbName + "; User Id=" + username
			+ ";Password=" + password;

			this.conn = new SqlConnection(connString);
			this.conn.Open();
		}

		public DBManager(string connectionString)
		{
			this.conn = new SqlConnection(connectionString);
			this.conn.Open();
		}

		public SqlDataReader query(string sql_query)
		{
			SqlCommand comm = new SqlCommand(sql_query, this.conn);
			SqlDataReader dataReader = comm.ExecuteReader();

			return dataReader;
		}

        public SqlDataAdapter query_adapter(string sql_query)
        {
            SqlCommand comm = new SqlCommand(sql_query, this.conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);

            return da;
        }

		public void closeConnection()
		{
			this.conn.Dispose();
		}
	}
}
