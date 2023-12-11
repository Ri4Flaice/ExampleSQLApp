using ExampleSQLApp.requests;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;
using ExampleSQLApp.error;

namespace ExampleSQLApp.request
{
    internal class Project
    {
        private DB _db;
        private MySqlConnection _connection;
        private FillTable _fillTable;
        private AddValue _addValue;
        private SelectData _selectData;
        private UpdateData _updateData;
        public Project()
        {
            _db = new DB();
            _connection = _db.GetConnection();
            _fillTable = new FillTable();
            _addValue = new AddValue();
            _selectData = new SelectData();
            _updateData = new UpdateData();
        }
        public DataTable ProjectDB()
        {
            string projectQuery = "SELECT w.idProject AS 'Номер проекта', w.name AS 'Наименование проекта', w.description AS 'Описание', " +
                "w.dateStart AS 'Начало проекта', w.dateEnd AS 'Конец проекта', " +
                "CONCAT(e.name, ' ', e.surname, ' ', e.patronymic) AS 'Ответственный', " +
                "f.name AS 'Наименование операции', w.result AS 'Результат', w.status AS 'Статус' " +
                "FROM project w " +
                "JOIN finance f ON w.idFinance = f.idFinance " +
                "JOIN employee e ON w.idEmployee = e.idEmployee";

            return _fillTable.LoadDataIntoDataGridView(projectQuery);
        }
        public void addValueProject(string nameDB, string nameColumns, string value)
        {
            _addValue.AddData(nameDB, nameColumns, value);
        }
        public List<string> ValueProject(int id)
        {
            List<string> values = new List<string>();

            try
            {
                _db.openConnection();

                string name = $"SELECT name FROM project WHERE idProject = {id}";
                name = _selectData.Select(name, _connection);
                values.Add(name);

                string shortDescription = $"SELECT description FROM project WHERE idProject = {id}";
                shortDescription = _selectData.Select(shortDescription, _connection);
                values.Add(shortDescription);

                string dateStart = $"SELECT DATE_FORMAT(dateStart, '%Y-%m-%d') FROM project WHERE idProject = {id}";
                dateStart = _selectData.Select(dateStart, _connection);
                string dateStartAsString = dateStart != null ? dateStart.ToString() : null;
                values.Add(dateStartAsString);

                string dateEnd = $"SELECT DATE_FORMAT(dateEnd, '%Y-%m-%d') FROM project WHERE idProject = {id}";
                dateEnd = _selectData.Select(dateEnd, _connection);
                string dateEndAsString = dateEnd != null ? dateEnd.ToString() : null;
                values.Add(dateEndAsString);

                string fullNameQuery = $"SELECT employee.name, employee.surname, employee.patronymic " +
                    $"FROM project " +
                    $"JOIN employee ON project.idEmployee = employee.idEmployee " +
                    $"WHERE project.idProject = {id}";

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
                    $"FROM project " +
                    $"JOIN finance ON project.idFinance = finance.idFinance " +
                    $"WHERE project.idProject = {id}";
                nameFinance = _selectData.Select(nameFinance, _connection);
                values.Add(nameFinance);

                string result = $"SELECT result FROM project WHERE idProject = {id}";
                result = _selectData.Select(result, _connection);
                values.Add(result);

                string status = $"SELECT status FROM project WHERE idProject = {id}";
                status = _selectData.Select(status, _connection);
                values.Add(status);

                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Project), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return values;
        }
        public void changeValueProject(List<string> values, int id)
        {
            try
            {
                _db.openConnection();

                string update = $"UPDATE project SET " +
                    $"name = '{values[0]}', " +
                    $"description = '{values[1]}', " +
                    $"dateStart = '{values[2]}', " +
                    $"dateEnd = '{values[3]}', " +
                    $"idEmployee = {int.Parse(values[4])}, " +
                    $"idFinance = {int.Parse(values[5])}, " +
                    $"result = '{values[6]}', " +
                    $"status = '{values[7]}' " +
                    $"WHERE idProject = {id}";

                _updateData.Update(update, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Project), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }
        }
    }
}
