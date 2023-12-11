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
    public partial class ChangeArchiveForm : Form
    {
        private int _id;
        private List<string> _values = new List<string>();
        private Archive _archive;
        private FindId _findId;
        private RoundBtn _roundBtn;
        Point lastPoint;
        public ChangeArchiveForm()
        {
            InitializeComponent();
            _archive = new Archive();
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
                _values = _archive.ValueArchive(_id);

                inputNameTextBox.Text = _values[0];
                inputTypeTextBox.Text = _values[1];
                inputLocationTextBox.Text = _values[2];
                inputStatusTextBox.Text = _values[3];

                string date = _values[4];
                string[] dateParts = date.Split('-');
                int year = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int day = int.Parse(dateParts[2]);
                DateArchivingTimePicker.Value = new DateTime(year, month, day);

                inputFullNameTextBox.Text = _values[5];
                inputNameFinanceTextBox.Text = _values[6];
            }
            catch (Exception ex)
            {
                WriteError.LogError(nameof(ChangeArchiveForm), ex.Message);
            }
        }
        private void ChangeSendToDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                _values[0] = inputNameTextBox.Text;
                _values[1] = inputTypeTextBox.Text;
                _values[2] = inputLocationTextBox.Text;
                _values[3] = inputStatusTextBox.Text;

                string year = DateArchivingTimePicker.Value.Year.ToString();
                string month = DateArchivingTimePicker.Value.Month.ToString();
                string day = DateArchivingTimePicker.Value.Day.ToString();
                string date = $"{year}-{month}-{day}";
                _values[4] = date;

                string fullname = inputFullNameTextBox.Text;
                string[] nameParts = fullname.Split(' ');
                int idEmpoyee = _findId.FindEmployeeId(nameParts[0], nameParts[1], nameParts[2]);
                _values[5] = idEmpoyee.ToString();

                string nameFinance = inputNameFinanceTextBox.Text;
                int idFinance = _findId.FindFinanceId(nameFinance);
                _values[6] = idFinance.ToString();

                _archive.changeValueArchive(_values, _id);

                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeArchiveForm), ex.Message);
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
