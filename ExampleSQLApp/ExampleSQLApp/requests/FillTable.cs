using MySql.Data.MySqlClient;
using System.Data;

namespace ExampleSQLApp
{
    internal class FillTable
    {
        private MySqlDataAdapter _adapter;
        private DataTable _dataTable;

        public DataTable LoadDataIntoDataGridView(string request)
        {
            DB db = new DB();
            MySqlConnection connection = db.GetConnection();

            try
            {
                _adapter = new MySqlDataAdapter(request, connection);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);

                return _dataTable;
            }
            finally
            {
                _adapter?.Dispose();
            }
        }
    }
}
