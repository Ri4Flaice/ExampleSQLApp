using MySql.Data.MySqlClient;

namespace ExampleSQLApp.requests
{
    public class UpdateData
    {
        public void Update(string value, MySqlConnection connection) 
        {
            string find = value;
            MySqlCommand command = new MySqlCommand(find, connection);
            object result = command.ExecuteScalar();
        }
    }
}
