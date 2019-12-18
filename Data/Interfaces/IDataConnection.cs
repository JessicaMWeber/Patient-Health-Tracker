using System.Collections;
using System.Data;

namespace Data
{
    interface IDataConnection
    {
        DataSet GetDataSet(string proc);

        DataSet GetDataSet(string proc, ArrayList param);

        void InsertUpdateDelete(string proc, ArrayList param);
    }
}
