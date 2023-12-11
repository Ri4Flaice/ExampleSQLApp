using ExampleSQLApp.error;
using ExampleSQLApp.openForm;
using ExampleSQLApp.request;
using ExampleSQLApp.requests;
using ExampleSQLApp.roundElement;
using ExampleSQLApp.Window;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class ChangeWarehouseForm : Form
    {
        private int _id;
        private List<string> _values = new List<string>();
        private Warehouse _warehouse;
        private FindId _findId;
        private RoundBtn _roundBtn;
        Point lastPoint;

        public ChangeWarehouseForm()
        {
            InitializeComponent();
            _warehouse = new Warehouse();
            _findId = new FindId();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(findIdButton, 3);
            _roundBtn.RoundButton(ChangeSendToDbButton, 3);
        }
        private void exitMenuPicture_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new MainForm());
        }
        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void findIdButton_Click(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(valueIdTextBox.Text);
                _values = _warehouse.ValueWarehouse(_id);

                valueNameTextBox.Text = _values[0];
                valueNameFinanceTextBox.Text = _values[1];
                valueCategoryTextBox.Text = _values[2];
                valueStatusTextBox.Text = _values[3];

                string date = _values[4];
                string[] dateParts = date.Split('-');
                int year = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int day = int.Parse(dateParts[2]);
                DateTimePicker.Value = new DateTime(year, month, day);

                valueSupplierTextBox.Text = _values[5];
                valueFullNameTextBox.Text = _values[6];
                valueLocationTextBox.Text = _values[7];
                valueDescriptionRichTextBox.Text = _values[8];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeWarehouseForm), ex.Message);
            }
        }
        private void ChangeSendToDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                _values[0] = valueNameTextBox.Text;

                string nameFinance = valueNameFinanceTextBox.Text;
                int idFinance = _findId.FindFinanceId(nameFinance);
                _values[1] = idFinance.ToString();

                _values[2] = valueCategoryTextBox.Text;
                _values[3] = valueStatusTextBox.Text;

                string year = DateTimePicker.Value.Year.ToString();
                string month = DateTimePicker.Value.Month.ToString();
                string day = DateTimePicker.Value.Day.ToString();
                string date = $"{year}-{month}-{day}";
                _values[4] = date;

                _values[5] = valueSupplierTextBox.Text;
            
                string fullname = valueFullNameTextBox.Text;
                string[] nameParts = fullname.Split(' ');
                int idEmpoyee = _findId.FindEmployeeId(nameParts[0], nameParts[1], nameParts[2]);
                _values[6] = idEmpoyee.ToString();

                _values[7] = valueLocationTextBox.Text;
                _values[8] = valueDescriptionRichTextBox.Text;

                _warehouse.changeValueWarehouse(_values, _id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeWarehouseForm), ex.Message);
            }
        }
        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            WindowMove.MoveForm(this, e, lastPoint);
        }
        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
