using ExampleSQLApp.error;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ExampleSQLApp.requests
{
    internal class AddValue
    {
        public void AddData(string nameDB, string nameColumns, string value)
        {
            DB db = new DB();
            MySqlConnection connection = db.GetConnection();

            try
            {
                db.openConnection();

                string addValue = $"INSERT INTO {nameDB} ({nameColumns}) VALUES ({value})";
                MySqlCommand command = new MySqlCommand(addValue, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(AddValue), ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
