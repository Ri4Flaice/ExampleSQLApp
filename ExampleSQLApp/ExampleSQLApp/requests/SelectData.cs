using MySql.Data.MySqlClient;

namespace ExampleSQLApp.requests
{
    internal class SelectData
    {
        public string Select(string value, MySqlConnection connection)
        {
            string find = value;
            MySqlCommand command = new MySqlCommand(find, connection);
            object result = command.ExecuteScalar();
            find = (string)result;

            return find;
        }
        public int FindId(string value, MySqlConnection connection)
        {
            string find = value;
            MySqlCommand command = new MySqlCommand(find, connection);
            object result = command.ExecuteScalar();
            int resultInt = (int)result;

            return resultInt;
        }
    }
}
