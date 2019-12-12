using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{

    public class DataConnection
    {
        public SqlConnection conn;
        public SqlTransaction transaction;

        public DataConnection()
        {
            string strProject = "R8600376\\SNEAKQL";
            string strDatabase = "Medicine";

            string strconn = "data source=" + strProject +
              ";database=" + strDatabase +
              ";Trusted_Connection=Yes";
            conn = new SqlConnection(strconn);
        }

        private void openConnection()
        {
            conn.Close(); //ensure it's not already open
            conn.Open();
            transaction = conn.BeginTransaction();
        }

        private void closeConnection()
        {
            transaction.Commit();
            conn.Close();
        }

        public DataSet GetDataSet(string proc)
        {
            openConnection();
            SqlCommand proceedure = new SqlCommand(proc, conn, transaction);
            proceedure.ExecuteNonQuery();
            closeConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(proceedure);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public DataSet GetDataSet(string proc, ArrayList param)
        {
            openConnection();
            SqlCommand procedure = new SqlCommand(proc, conn, transaction);
            procedure.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in param)
            {
                procedure.Parameters.Add(parameter);
            }
            procedure.ExecuteNonQuery();
            closeConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(procedure);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void InsertUpdateDelete(string proc, ArrayList param)
        {
            openConnection();
            SqlCommand procedure = new SqlCommand(proc, conn, transaction);
            procedure.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in param)
            {
                procedure.Parameters.Add(parameter);
            }
            procedure.ExecuteNonQuery();
            closeConnection();
        }
    }
}
