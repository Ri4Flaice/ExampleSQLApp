using ExampleSQLApp.error;
using ExampleSQLApp.requests;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ExampleSQLApp.request
{
    internal class Warehouse
    {
        private DB _db;
        private MySqlConnection _connection;
        private FillTable _fillTable;
        private AddValue _addValue;
        private SelectData _selectData;
        private UpdateData _updateData;
        public Warehouse()
        {
            _db = new DB();
            _connection = _db.GetConnection();
            _fillTable = new FillTable();
            _addValue = new AddValue();
            _selectData = new SelectData();
            _updateData = new UpdateData();
        }
        public DataTable WarehouseDB()
        {
            string warehouseQuery = "SELECT w.idEquipment AS 'Номер оборудования', w.name AS 'Наименование оборудования', f.name AS 'Наименование операции', " +
                "w.category AS 'Категория оборудования', w.status AS 'Статус оборудования', w.deliveryDate AS 'Дата поставки', w.supplier AS 'Поставщик', " +
                "CONCAT(e2.name, ' ', e2.surname, ' ', e2.patronymic) AS 'Ответственный',  w.location AS 'Местоположение оборудования', " +
                "w.notesrefences AS 'Примечание' " +
                "FROM warehouse w " +
                "JOIN finance f ON w.idFinance = f.idFinance " +
                "JOIN employee e1 ON f.idEmployee = e1.idEmployee " +
                "JOIN employee e2 ON w.idEmployee = e2.idEmployee";

            return _fillTable.LoadDataIntoDataGridView(warehouseQuery);
        }
        public void addValueWarehouse(string nameDB, string nameColumns, string value)
        {
            _addValue.AddData(nameDB, nameColumns, value);
        }
        public List<string> ValueWarehouse(int id)
        {
            List<string> values = new List<string>();

            try
            {
                _db.openConnection();

                string name = $"SELECT name FROM warehouse WHERE idEquipment = {id}";
                name = _selectData.Select(name, _connection);
                values.Add(name);

                string nameFinance = $"SELECT finance.name " +
                    $"FROM warehouse " +
                    $"JOIN finance ON warehouse.idFinance = finance.idFinance " +
                    $"WHERE warehouse.idEquipment = {id}";
                nameFinance = _selectData.Select(nameFinance, _connection);
                values.Add(nameFinance);

                string category = $"SELECT category FROM warehouse WHERE idEquipment = {id}";
                category = _selectData.Select(category, _connection);
                values.Add(category);

                string status = $"SELECT status FROM warehouse WHERE idEquipment = {id}";
                status = _selectData.Select(status, _connection);
                values.Add(status);

                string dateTransaction = $"SELECT DATE_FORMAT(deliveryDate, '%Y-%m-%d') FROM warehouse WHERE idEquipment = {id}";
                dateTransaction = _selectData.Select(dateTransaction, _connection);
                string dateAsString = dateTransaction != null ? dateTransaction.ToString() : null;
                values.Add(dateAsString);

                string supplier = $"SELECT supplier FROM warehouse WHERE idEquipment = {id}";
                supplier = _selectData.Select(supplier, _connection);
                values.Add(supplier);

                string fullNameQuery = $"SELECT employee.name, employee.surname, employee.patronymic " +
                    $"FROM warehouse " +
                    $"JOIN employee ON warehouse.idEmployee = employee.idEmployee " +
                    $"WHERE warehouse.idEquipment = {id}";

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

                string location = $"SELECT location FROM warehouse WHERE idEquipment = {id}";
                location = _selectData.Select(location, _connection);
                values.Add(location);

                string shortDescription = $"SELECT notesrefences FROM warehouse WHERE idEquipment = {id}";
                shortDescription = _selectData.Select(shortDescription, _connection);
                values.Add(shortDescription);

                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Warehouse), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }

            return values;
        }
        public void changeValueWarehouse(List<string> values, int id)
        {
            try
            {
                _db.openConnection();

                string update = $"UPDATE warehouse SET " +
                    $"name = '{values[0]}', " +
                    $"idFinance = {int.Parse(values[1])}, " +
                    $"category = '{values[2]}', " +
                    $"status = '{values[3]}', " +
                    $"deliveryDate = '{values[4]}', " +
                    $"supplier = '{values[5]}', " +
                    $"idEmployee = {int.Parse(values[6])}, " +
                    $"location = '{values[7]}', " +
                    $"notesrefences = '{values[8]}' " +
                    $"WHERE idEquipment = {id}";

                _updateData.Update(update, _connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(Warehouse), ex.Message);
            }
            finally
            {
                _db.closeConnection();
            }
        }
    }
}
