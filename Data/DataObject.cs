using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DataObject : IDataObject, IDisposable
    {
        #region Fields

        private const string DBConnection = "R8600376\\SNEAKQL";
        private const string BaseDatabase = "Medicine";
        readonly string ConnectionString = "data source=" + DBConnection +
              ";database=" + BaseDatabase +
              ";Trusted_Connection=Yes";

        #endregion Fields

        #region Properties

        public int ID { get; set; }

        public string BaseTable {get; set;}

        public DataRow DataRow { get; set; }

        public DataSet DataSet { get; }

        #endregion Properties

        #region Constructors

        public DataObject()
        {
            DataSet = new DataSet();
        }

        #endregion Constructors

        #region Database Methods

        public void Load()
        {
            DataSet.Clear();

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();
            connection.ChangeDatabase(BaseDatabase);

            SqlCommand cmd = new SqlCommand("Get" + BaseTable, connection);
            cmd.Parameters.Add(new SqlParameter("ID", ID));
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(DataSet);

            connection.Close();

            if(ID == 0)
            {
                DataSet.Tables[0].Rows.Add(DataSet.Tables[0].NewRow());
                DataSet.Tables[0].Rows[0]["ID"] = 0;
            }
        }

        public void Save(bool insert)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            connection.ChangeDatabase(BaseDatabase);
            SqlCommand cmd;

            if (insert)
            {
                cmd = new SqlCommand("Add" + BaseTable, connection);
            }
            else
            {
                cmd = new SqlCommand("Save" + BaseTable, connection);
            }

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCommandBuilder.DeriveParameters(cmd);

            foreach(SqlParameter param in cmd.Parameters)
            {
                if (param.ParameterName != "@RETURN_VALUE")
                {
                    param.Value = DataSet.Tables[0].Rows[0][param.ParameterName.Substring(1)];
                }
            }

            DataSet dsResult = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsResult);

            if(insert)
            {
                ID = Convert.ToInt32(dsResult.Tables[0].Rows[0]["ID"]);
                DataSet.Tables[0].Rows[0]["ID"] = ID;
            }
        }

        public void Delete()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            connection.ChangeDatabase(BaseDatabase);
            SqlCommand cmd = new SqlCommand("Delete" + BaseTable, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add(new SqlParameter("@ID", ID));

            cmd.ExecuteNonQuery();
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
                if (DataSet != null)
                {
                    DataSet.Dispose();
                }
            }
        }

        #endregion Database Methods
    }
}
