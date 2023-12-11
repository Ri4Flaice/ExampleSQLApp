using ExampleSQLApp.error;
using ExampleSQLApp.requests;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    internal class Finance
    {
        private DB _db;
        private MySqlConnection _connection;
        private FillTable _fillTable;
        private AddValue _addValue;
        private SelectData _selectData;
        private UpdateData _updateData;
        public Finance() 
        {
            _db = new DB();
            _connection = _db.GetConnection();
            _fillTable = new FillTable();
            _addValue = new AddValue();
            _selectData = new SelectData();
            _updateData = new UpdateData();
        }
        public DataTable FinanceDB()
        {
            string financeQuery = "SELECT f.idFinance AS 'Номер операции', f.name AS 'Наименование операции', f.dateTransaction AS 'Дата операции', " +
                "f.type AS 'Тип операции', f.total AS 'Сумма операции', f.category AS 'Категория операции', " +
                "f.products AS 'Товар', f.status AS 'Статус операции', " +
                "CONCAT(e.name, ' ', e.surname, ' ', e.patronymic) AS 'Ответственный', " +
                "f.shortDescription AS 'Краткое описание', f.infoCurrency AS 'Валюта' " +
                "FROM finance f " +
                "JOIN employee e ON f.idEmployee = e.idEmployee " +
                "WHERE f.idFinance IN (SELECT MIN(idFinance) FROM finance GROUP BY name, dateTransaction, type, total, category, products, status, idEmployee, shortDescription, infoCurrency)";

            return _fillTable.LoadDataIntoDataGridView(financeQuery);
        }
        public void addValueFinance(string nameDB, string nameColumns, string value)
        {
            _addValue.AddData(nameDB, nameColumns, value);
        }
        public List<string> ValueFinance(int id)
        {
            List<string> values = new List<string>();

            try
            {
                _db.openConnection();

                string name = $"SELECT name FROM finance WHERE idFinance = {id}";
                name = _selectData.Select(name, _connection);
                values.Add(name);

                string dateTransaction = $"SELECT DATE_FORMAT(dateTransaction, '%Y-%m-%d') FROM finance WHERE idFinance = {id}";
                dateTransaction = _selectData.Select(dateTransaction, _connection);
                string dateAsString = dateTransaction != null ? dateTransaction.ToString() : null;
                values.Add(dateAsString);

                string type = $"SELECT type FROM finance WHERE idFinance = {id}";
                type = _selectData.Select(type, _connection);
                values.Add(type);

                string total = $"SELECT CAST(total AS CHAR) FROM finance WHERE idFinance = {id}";
                total = _selectData.Select(total, _connection);
                values.Add(total);

                string infoCurrency = $"SELECT infoCurrency FROM finance WHERE idFinance = {id}";
                infoCurrency = _selectData.Select(infoCurrency, _connection);
                values.Add(infoCurrency);
                string category = $"SELECT category FROM finance WHERE idFinance = {id}"; 
                category = _selectData.Select(category, _connection);
                values.Add(category);
                string products = $"SELECT products FROM finance WHERE idFinance = {id}";
                products = _selectData.Select(products, _connection);
                values.Add(products);
                string status = $"SELECT status FROM finance WHERE idFinance = {id}";
                status = _selectData.Select(status, _connection);
                values.Add(status);

                string fullNameQuery = $"SELECT employee.name, employee.surname, employee.patronymic " +
                    $"FROM finance " +
                    $"JOIN employee ON finance.idEmployee = employee.idEmployee " +
                    $"WHERE finance.idFinance = {id}";

                MySqlCommand command = new MySqlCommand(fullNameQuery, _connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nameEmployee = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        string patronymic = reader["patronymic"].ToString();

                        string fullName = $"{nameEmployee} {surname} {patronymic}";

                        values.Add(fullName);
                    }
                }

                string shortDescription = $"SELECT shortDescription FROM finance WHERE idFinance = {id}"; 
                shortDescription = _selectData.Select(shortDescription, _connection);
                values.Add(shortDescription);

                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Finance), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return values;
        }
        public void changeValueFinance(List<string> values, int id)
        {
            try
            {
                _db.openConnection();

                string update = $"UPDATE finance SET " +
                    $"name = '{values[0]}', " +
                    $"dateTransaction = '{values[1]}', " +
                    $"type = '{values[2]}', " +
                    $"total = {int.Parse(values[3])}, " +
                    $"category = '{values[4]}', " +
                    $"products = '{values[5]}', " +
                    $"status = '{values[6]}', " +
                    $"idEmployee = {int.Parse(values[7])}, " +
                    $"shortDescription = '{values[8]}', " +
                    $"infoCurrency = '{values[9]}' " +
                    $"WHERE idFinance = {id}";

                _updateData.Update(update, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Finance), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }
        }
    }
}
