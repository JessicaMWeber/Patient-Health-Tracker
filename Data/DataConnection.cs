using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data
{

    public class DataConnection : IDataConnection, IDisposable
    {
        #region Fields

        public SqlConnection conn;
        public SqlTransaction transaction;

        #endregion Fields

        #region Constructors

        public DataConnection()
        {
            string strProject = "R8600376\\SNEAKQL";
            string strDatabase = "Medicine";

            string strconn = "data source=" + strProject +
              ";database=" + strDatabase +
              ";Trusted_Connection=Yes";
            conn = new SqlConnection(strconn);
        }

        #endregion Constructors

        #region Private Methods

        private void OpenConnection()
        {
            conn.Close(); //ensure it's not already open
            conn.Open();
            transaction = conn.BeginTransaction();
        }

        private void CloseConnection()
        {
            transaction.Commit();
            conn.Close();
        }

        #endregion Private Methods

        #region Database Methods

        public DataSet GetDataSet(string proc)
        {
            OpenConnection();
            SqlCommand procedure = new SqlCommand(proc, conn, transaction);
            procedure.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(procedure);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            CloseConnection();
            return ds;
        }

        public DataSet GetDataSet(string proc, ArrayList param)
        {
            OpenConnection();
            SqlCommand procedure = new SqlCommand(proc, conn, transaction);
            procedure.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in param)
            {
                procedure.Parameters.Add(parameter);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(procedure);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            CloseConnection();
            return ds;
        }

        public DataSet Exec(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, conn, transaction);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            CloseConnection();

            return ds;
        }

        public void InsertUpdateDelete(string proc, ArrayList param)
        {
            OpenConnection();
            SqlCommand procedure = new SqlCommand(proc, conn, transaction);
            procedure.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in param)
            {
                procedure.Parameters.Add(parameter);
            }
            procedure.ExecuteNonQuery();
            CloseConnection();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

        #endregion Database Methods
    }
}
