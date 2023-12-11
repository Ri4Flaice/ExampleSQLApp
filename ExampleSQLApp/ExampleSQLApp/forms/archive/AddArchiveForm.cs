using ExampleSQLApp.error;
using ExampleSQLApp.hideText;
using ExampleSQLApp.openForm;
using ExampleSQLApp.request;
using ExampleSQLApp.requests;
using ExampleSQLApp.roundElement;
using ExampleSQLApp.visibleLabel;
using ExampleSQLApp.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class AddArchiveForm : Form
    {
        Point lastPoint;
        private IntroductoryText _introductoryText;
        private string _formatDate;
        private Archive _archive;
        private FindId _findId;
        private RoundBtn _roundBtn;
        public AddArchiveForm()
        {
            InitializeComponent();
            _introductoryText = new IntroductoryText();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(sendToDbButton, 3);
            _archive = new Archive();
            _findId = new FindId();

            inputNameTextBox_Leave(inputNameTextBox, EventArgs.Empty);
            inputTypeTextBox_Leave(inputTypeTextBox, EventArgs.Empty);
            inputLocationTextBox_Leave(inputLocationTextBox, EventArgs.Empty);
            inputStatusTextBox_Leave(inputStatusTextBox, EventArgs.Empty);
            inputFullNameTextBox_Leave(inputFullNameTextBox, EventArgs.Empty);
            inputNameFinanceTextBox_Leave(inputNameFinanceTextBox, EventArgs.Empty);
        }
        private void exitMenuPicture_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new MainForm());
        }
        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void inputNameTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputNameTextBox, "Введите название документа");
        }
        private void inputNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputNameTextBox, "Введите название документа");
        }
        private void inputNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputNameTextBox, valueNameLabel, "Введите название документа");
        }
        private void inputTypeTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputTypeTextBox, "Введите тип документа");
        }
        private void inputTypeTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputTypeTextBox, "Введите тип документа");
        }
        private void inputTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputTypeTextBox, valueTypeLabel, "Введите тип документа");
        }
        private void inputLocationTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputLocationTextBox, "Введите местоположение документа");
        }
        private void inputLocationTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputLocationTextBox, "Введите местоположение документа");
        }
        private void inputLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputLocationTextBox, valueLocationLabel, "Введите местоположение документа");
        }
        private void inputStatusTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputStatusTextBox, "Введите статус документа");
        }
        private void inputStatusTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputStatusTextBox, "Введите статус документа");
        }
        private void inputStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputStatusTextBox, valueStatusLabel, "Введите статус документа");
        }
        private void DateArchivingTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _formatDate = VisibleDate.Visible(DateArchivingTimePicker, valueDateArchivingLabel);
        }
        private void inputFullNameTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputFullNameTextBox, "Введите ФИО(необязательно)");
        }
        private void inputFullNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputFullNameTextBox, "Введите ФИО(необязательно)");
        }
        private void inputFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputFullNameTextBox, valueFullNameLabel, "Введите ФИО(необязательно)");
        }
        private void inputNameFinanceTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputNameFinanceTextBox, "Введите номер финансовой операции");
        }
        private void inputNameFinanceTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputNameFinanceTextBox, "Введите номер финансовой операции");
        }
        private void inputNameFinanceTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputNameFinanceTextBox, valueNameFinanceOperationLabel, "Введите номер финансовой операции");
        }
        private void inputNameFinanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
        private void sendToDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullNameTextBox = inputFullNameTextBox.Text;
                string[] values = fullNameTextBox.Split(' ');
                string name = values[0];
                string surname = values[1];
                string patronymic = string.Join("", values.Skip(2));

                int employeeId = 0;

                if (inputFullNameTextBox.Text != "Введите ФИО(необязательно)")
                {
                    employeeId = _findId.FindEmployeeId(name, surname, patronymic);
                }

                if (employeeId == 0)
                {
                    string nameDB = "archive";
                    string nameColumns = "name, type, location, status, dateArchiving, idFinance";
                    string value = $"'{inputNameTextBox.Text}', '{inputTypeTextBox.Text}', '{inputLocationTextBox.Text}', " +
                        $"'{inputStatusTextBox.Text}', '{_formatDate}', {int.Parse(inputNameFinanceTextBox.Text)}";

                    _archive.addValueArchive(nameDB, nameColumns, value);
                    MessageBox.Show("Данные успешно отправлены");
                }
                else
                {
                    string nameDB = "archive";
                    string nameColumns = "name, type, location, status, dateArchiving, idEmployee, idFinance";
                    string value = $"'{inputNameTextBox.Text}', '{inputTypeTextBox.Text}', '{inputLocationTextBox.Text}', " +
                        $"'{inputStatusTextBox.Text}', '{_formatDate}', {employeeId}, {int.Parse(inputNameFinanceTextBox.Text)}";

                    _archive.addValueArchive(nameDB, nameColumns, value);
                    MessageBox.Show("Данные успешно отправлены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(AddArchiveForm), ex.Message);
            }
        }
    }
}
