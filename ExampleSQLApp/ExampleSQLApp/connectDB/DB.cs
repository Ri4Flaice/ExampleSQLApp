using MySql.Data.MySqlClient;

namespace ExampleSQLApp
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=; port=; username=; password=; database=");
        
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close(); 
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
