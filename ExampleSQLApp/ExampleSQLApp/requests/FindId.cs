using ExampleSQLApp.error;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ExampleSQLApp.requests
{
    internal class FindId
    {
        private DB _db;
        private MySqlConnection _connection;
        private SelectData _selectData;
        public FindId()
        {
            _db = new DB();
            _connection = _db.GetConnection();
            _selectData = new SelectData();
        }
        public int FindEmployeeId(string name, string surname, string patronymic)
        {
            int employeeId = 0;

            try
            {
                _db.openConnection();

                string findEmployee = $"SELECT idEmployee FROM employee WHERE name = '{name}' AND surname = '{surname}' AND patronymic = '{patronymic}';";
                employeeId = _selectData.FindId(findEmployee, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(FindId), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return employeeId;
        }
        public int FindFinanceId(string nameFinance)
        {
            int financeId = 0;

            try
            {
                _db.openConnection();

                string findFinance = $"SELECT idFinance FROM finance WHERE name = '{nameFinance}';";
                financeId = _selectData.FindId(findFinance, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(FindId), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return financeId;
        }
    }
}
