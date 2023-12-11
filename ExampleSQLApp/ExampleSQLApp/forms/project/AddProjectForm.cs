using ExampleSQLApp.error;
using ExampleSQLApp.hideText;
using ExampleSQLApp.openForm;
using ExampleSQLApp.request;
using ExampleSQLApp.requests;
using ExampleSQLApp.roundElement;
using ExampleSQLApp.visibleLabel;
using ExampleSQLApp.Window;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class AddProjectForm : Form
    {
        Point lastPoint;
        private IntroductoryText _introductoryText;
        private string _formatDateStart;
        private string _formatDateEnd;
        private Project _project;
        private FindId _findId;
        private RoundBtn _roundBtn;
        public AddProjectForm()
        {
            InitializeComponent();
            _introductoryText = new IntroductoryText();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(sendToDbButton, 3);
            _project = new Project();
            _findId = new FindId();

            inputNameTextBox_Leave(inputNameTextBox, EventArgs.Empty);
            inputDescriptionRichTextBox_Leave(inputDescriptionRichTextBox, EventArgs.Empty);
            inputFullNameTextBox_Leave(inputFullNameTextBox, EventArgs.Empty);
            inputNameFinanceTextBox_Leave(inputNameFinanceTextBox, EventArgs.Empty);
            inputResultTextBox_Leave(inputResultTextBox, EventArgs.Empty);
            inputStatusTextBox_Leave(inputStatusTextBox, EventArgs.Empty);
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
            _introductoryText.TextBoxEnter(inputNameTextBox, "Введите название проекта");
        }
        private void inputNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputNameTextBox, "Введите название проекта");
        }
        private void inputNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputNameTextBox, valueNameProjectLabel, "Введите название проекта");
        }
        private void inputDescriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputDescriptionRichTextBox, "Введите описание проекта");
        }
        private void inputDescriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputDescriptionRichTextBox, "Введите описание проекта");
        }
        private void inputDescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleRichTextBox(inputDescriptionRichTextBox, valueDescriptionOperationLabel, "Введите описание проета");
        }
        private void DateOperationTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _formatDateStart = VisibleDate.Visible(DateStartProjectTimePicker, valueDateStartProjectLabel);
        }
        private void dateEndProjectTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _formatDateEnd = VisibleDate.Visible(dateEndProjectTimePicker, valueDateEndProjectLabel);
        }
        private void inputFullNameTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputFullNameTextBox, "Введите ФИО");
        }
        private void inputFullNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputFullNameTextBox, "Введите ФИО");
        }
        private void inputFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputFullNameTextBox, valueFullNameLabel, "Введите ФИО");
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
        private void inputResultTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputResultTextBox, "Введите результаты(необязательно)");
        }
        private void inputResultTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputResultTextBox, "Введите результаты(необязательно)");
        }
        private void inputResultTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputResultTextBox, valueResultLabel, "Введите результаты(необязательно)");
        }
        private void inputStatusTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputStatusTextBox, "Введите статус проекта");
        }
        private void inputStatusTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputStatusTextBox, "Введите статус проекта");
        }
        private void inputStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputStatusTextBox, valueStatusProjectLabel, "Введите статус проекта");
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
                employeeId = _findId.FindEmployeeId(name, surname, patronymic);

                string nameDB = "project";
                string nameColumns = "";
                string value = "";

                if (inputResultTextBox.Text != "Введите результаты(необязательно)" && valueDateEndProjectLabel.Visible == true)
                {
                    nameColumns = "name, description, dateStart, dateEnd, idEmployee, idFinance, result, status";
                    value = $"'{inputNameTextBox.Text}', '{inputDescriptionRichTextBox.Text}', '{_formatDateStart}', " +
                        $"'{_formatDateEnd}', '{employeeId}', '{int.Parse(inputNameFinanceTextBox.Text)}', " +
                        $"'{inputResultTextBox.Text}', '{inputStatusTextBox.Text}'";
                }
                else if (inputResultTextBox.Text != "Введите результаты(необязательно)" && valueDateEndProjectLabel.Visible == false)
                {
                    nameColumns = "name, description, dateStart, idEmployee, idFinance, result, status";
                    value = $"'{inputNameTextBox.Text}', '{inputDescriptionRichTextBox.Text}', '{_formatDateStart}', " +
                        $"'{employeeId}', '{int.Parse(inputNameFinanceTextBox.Text)}', " +
                        $"'{inputResultTextBox.Text}', '{inputStatusTextBox.Text}'";
                }
                else if (inputResultTextBox.Text == "Введите результаты(необязательно)" && valueDateEndProjectLabel.Visible == true)
                {
                    nameColumns = "name, description, dateStart, dateEnd, idEmployee, idFinance, status";
                    value = $"'{inputNameTextBox.Text}', '{inputDescriptionRichTextBox.Text}', '{_formatDateStart}', " +
                        $"'{_formatDateEnd}', '{employeeId}', '{int.Parse(inputNameFinanceTextBox.Text)}', " +
                        $"'{inputStatusTextBox.Text}'";
                }
                else if (inputResultTextBox.Text == "Введите результаты(необязательно)" && valueDateEndProjectLabel.Visible == false)
                {
                    nameColumns = "name, description, dateStart, idEmployee, idFinance, status";
                    value = $"'{inputNameTextBox.Text}', '{inputDescriptionRichTextBox.Text}', '{_formatDateStart}', " +
                        $"'{employeeId}', '{int.Parse(inputNameFinanceTextBox.Text)}', " +
                        $"'{inputStatusTextBox.Text}'";
                }

                _project.addValueProject(nameDB, nameColumns, value);
                MessageBox.Show("Данные успешно отправлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(AddProjectForm), ex.Message);
            }
        }
    }
}