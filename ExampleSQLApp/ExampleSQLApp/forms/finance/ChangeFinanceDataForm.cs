using ExampleSQLApp.error;
using ExampleSQLApp.requests;
using ExampleSQLApp.roundElement;
using ExampleSQLApp.Window;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class ChangeFinanceDataForm : Form
    {
        private int _id;
        private List<string> _values = new List<string>();
        private Finance _finance;
        private FindId _findId;
        private RoundBtn _roundBtn;
        Point lastPoint;
        public ChangeFinanceDataForm()
        {
            InitializeComponent();
            _finance = new Finance();
            _findId = new FindId();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(findIdButton, 3);
            _roundBtn.RoundButton(ChangeSendToDbButton, 3);
        }

        private void ChangeFinanceDataForm_Load(object sender, EventArgs e)
        {

        }
        private void exitMenuPicture_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
            };
            mainForm.Show();
            this.Hide();
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
                _values = _finance.ValueFinance(_id);

                valueNameTextBox.Text = _values[0];

                string date = _values[1];
                string[] dateParts = date.Split('-');
                int year = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int day = int.Parse(dateParts[2]);
                DateOperationTimePicker.Value = new DateTime(year, month, day);

                valueTypeTextBox.Text = _values[2];
                valueTotalTextBox.Text = _values[3];
                valueCurrencyTextBox.Text = _values[4];
                valueCategoryTextBox.Text = _values[5];
                valueProductsRichTextBox.Text = _values[6];
                valueStatusTextBox.Text = _values[7];
                valueFullNameTextBox.Text = _values[8];
                valueDescriptionRichTextBox.Text = _values[9];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeFinanceDataForm), ex.Message);
            }
        }
        private void ChangeSendToDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                _values[0] = valueNameTextBox.Text;

                string year = DateOperationTimePicker.Value.Year.ToString();
                string month = DateOperationTimePicker.Value.Month.ToString();
                string day = DateOperationTimePicker.Value.Day.ToString();
                string date = $"{year}-{month}-{day}";
                _values[1] = date;

                _values[2] = valueTypeTextBox.Text;
                _values[3] = valueTotalTextBox.Text.ToString();
                _values[4] = valueCategoryTextBox.Text;
                _values[5] = valueProductsRichTextBox.Text;
                _values[6] = valueStatusTextBox.Text;

                string fullname = valueFullNameTextBox.Text;
                string[] nameParts = fullname.Split(' ');
                int idEmpoyee = _findId.FindEmployeeId(nameParts[0], nameParts[1], nameParts[2]);
                _values[7] = idEmpoyee.ToString();

                _values[8] = valueDescriptionRichTextBox.Text;
                _values[9] = valueCurrencyTextBox.Text;

                _finance.changeValueFinance(_values, _id);

                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeFinanceDataForm), ex.Message);
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
