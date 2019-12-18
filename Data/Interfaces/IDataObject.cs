using System.Data;

namespace Data
{
    interface IDataObject
    {
        int ID { get; set; }

        string BaseTable { get; set; }

        DataRow DataRow { get; set; }

        DataSet DataSet { get; }

        void Save(bool Insert);
        void Load();
        void Delete();
    }
}
