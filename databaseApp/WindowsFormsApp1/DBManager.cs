using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPT291_Project
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
			conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch
            {
                string message = "Error connecting to SQL Database.";
                string title = "Database Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                conn.Dispose();
                Application.Exit();
              
    
            }
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
