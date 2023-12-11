using ExampleSQLApp.requests;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;
using ExampleSQLApp.error;

namespace ExampleSQLApp.request
{
    internal class Archive
    {
        private DB _db;
        private MySqlConnection _connection;
        private FillTable _fillTable;
        private AddValue _addValue;
        private SelectData _selectData;
        private UpdateData _updateData;
        public Archive()
        {
            _db = new DB();
            _connection = _db.GetConnection();
            _fillTable = new FillTable();
            _addValue = new AddValue();
            _selectData = new SelectData();
            _updateData = new UpdateData();
        }
        public DataTable ArchiveDB()
        {
            string archiveQuery = "SELECT w.idDocument AS 'Номер документа', w.name AS 'Наименование документа', w.type AS 'Тип документа', " +
                "w.location AS 'Местоположение', w.status AS 'Статус документа', w.dateArchiving AS 'Дата архивации', " +
                "CONCAT(e.name, ' ', e.surname, ' ', e.patronymic) AS 'Ответственный', " +
                "f.name AS 'Наименование операции' " +
                "FROM archive w " +
                "JOIN finance f ON w.idFinance = f.idFinance " +
                "JOIN employee e ON w.idEmployee = e.idEmployee";

            return _fillTable.LoadDataIntoDataGridView(archiveQuery);
        }
        public void addValueArchive(string nameDB, string nameColumns, string value)
        {
            _addValue.AddData(nameDB, nameColumns, value);
        }
        public List<string> ValueArchive(int id)
        {
            List<string> values = new List<string>();

            try
            {
                _db.openConnection();

                string name = $"SELECT name FROM archive WHERE idDocument = {id}";
                name = _selectData.Select(name, _connection);
                values.Add(name);

                string type = $"SELECT type FROM archive WHERE idDocument = {id}";
                type = _selectData.Select(type, _connection);
                values.Add(type);

                string location = $"SELECT location FROM archive WHERE idDocument = {id}";
                location = _selectData.Select(location, _connection);
                values.Add(location);
                
                string status = $"SELECT status FROM archive WHERE idDocument = {id}";
                status = _selectData.Select(status, _connection);
                values.Add(status);

                string date = $"SELECT DATE_FORMAT(dateArchiving, '%Y-%m-%d') FROM archive WHERE idDocument = {id}";
                date = _selectData.Select(date, _connection);
                string dateAsString = date != null ? date.ToString() : null;
                values.Add(dateAsString);

                string fullNameQuery = $"SELECT employee.name, employee.surname, employee.patronymic " +
                    $"FROM archive " +
                    $"JOIN employee ON archive.idEmployee = employee.idEmployee " +
                    $"WHERE archive.idDocument = {id}";

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

                string nameFinance = $"SELECT finance.name " +
                    $"FROM archive " +
                    $"JOIN finance ON archive.idFinance = finance.idFinance " +
                    $"WHERE archive.idDocument = {id}";
                nameFinance = _selectData.Select(nameFinance, _connection);
                values.Add(nameFinance);

                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Archive), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return values;
        }
        public void changeValueArchive(List<string> values, int id)
        {
            try
            {
                _db.openConnection();

                string update = $"UPDATE archive SET " +
                    $"name = '{values[0]}', " +
                    $"type = '{values[1]}', " +
                    $"location = '{values[2]}', " +
                    $"status = '{values[3]}', " +
                    $"dateArchiving = '{values[4]}', " +
                    $"idEmployee = {int.Parse(values[5])}, " +
                    $"idFinance = '{int.Parse(values[6])}' " +
                    $"WHERE idDocument = {id}";

                _updateData.Update(update, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Archive), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }
        }
    }
}
