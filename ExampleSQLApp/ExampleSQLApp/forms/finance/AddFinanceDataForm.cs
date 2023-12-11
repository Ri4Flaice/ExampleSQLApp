using ExampleSQLApp.error;
using ExampleSQLApp.hideText;
using ExampleSQLApp.openForm;
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
    public partial class AddFinanceDataForm : Form
    {
        Point lastPoint;
        private IntroductoryText _introductoryText;
        private string _formatDate;
        private Finance _finance;
        private FindId _findId;
        private RoundBtn _roundBtn;
        public AddFinanceDataForm()
        {
            InitializeComponent();
            _introductoryText = new IntroductoryText();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(sendToDbButton, 3);
            _finance = new Finance();
            _findId = new FindId();

            inputNameTextBox_Leave(inputNameTextBox, EventArgs.Empty);
            inputTypeTextBox_Leave(inputTypeTextBox, EventArgs.Empty);
            inputTotalTextBox_Leave(inputTotalTextBox, EventArgs.Empty);
            inputCategoryTextBox_Leave(inputCategoryTextBox, EventArgs.Empty);
            inputProductsRichTextBox_Leave(inputProductsRichTextBox, EventArgs.Empty);
            inputStatusTextBox_Leave(inputStatusTextBox, EventArgs.Empty);
            inputFullNameTextBox_Leave(inputFullNameTextBox, EventArgs.Empty);
            inputDescriptionRichTextBox_Leave(inputDescriptionRichTextBox, EventArgs.Empty);

        }
        private void exitMenuPicture_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new MainForm());
        }
        private void inputNameTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputNameTextBox, "Введите название операции");
        }
        private void inputNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputNameTextBox, "Введите название операции");
        }
        private void inputNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputNameTextBox, valueNameOperationLabel, "Введите название операции");
        }
        private void DateOperationTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _formatDate = VisibleDate.Visible(DateOperationTimePicker, valueDateOperationLabel);
        }
        private void inputTypeTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputTypeTextBox, "Введите тип операции");
        }
        private void inputTypeTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputTypeTextBox, "Введите тип операции");
        }
        private void inputTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputTypeTextBox, valueTypeOperationLabel, "Введите тип операции");
        }
        private void inputTotalTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputTotalTextBox, "Введите сумму операции");
        }
        private void inputTotalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void inputTotalTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputTotalTextBox, "Введите сумму операции");
        }
        private void inputTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputTotalTextBox, valueTotalOperationLabel, "Введите сумму операции");
        }
        private void inputCurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            inputCurrencyTextBox.Text = inputCurrencyTextBox.Text.ToUpper();
            inputCurrencyTextBox.SelectionStart = inputCurrencyTextBox.Text.Length;
            inputCurrencyTextBox.SelectionLength = 0;

            valueCurrencyLabel.Visible = !string.IsNullOrWhiteSpace(inputCurrencyTextBox.Text);
            valueCurrencyLabel.Text = inputCurrencyTextBox.Text;
        }
        private void inputCategoryTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputCategoryTextBox, "Введите категорию операции");
        }
        private void inputCategoryTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputCategoryTextBox, "Введите категорию операции");
        }
        private void inputCategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputCategoryTextBox, valueCategoryOperationLabel, "Введите категорию операции");
        }
        private void inputProductsRichTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputProductsRichTextBox, "Введите товары");
        }
        private void inputProductsRichTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputProductsRichTextBox, "Введите товары");
        }
        private void inputProductsRichTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleRichTextBox(inputProductsRichTextBox, valueProductsOperationLabel, "Введите товары");
        }
        private void inputStatusTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputStatusTextBox, "Введите статус операции");
        }
        private void inputStatusTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputStatusTextBox, "Введите статус операции");
        }
        private void inputStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputStatusTextBox, valueStatusOperationLabel, "Введите статус операции");
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
        private void inputDescriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputDescriptionRichTextBox, "Введите описание операции (необязательно)");
        }
        private void inputDescriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputDescriptionRichTextBox, "Введите описание операции (необязательно)");
        }
        private void inputDescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleRichTextBox(inputDescriptionRichTextBox, valueDescriptionOperationLabel, "Введите описание операции (необязательно)");
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

                int employeeId = _findId.FindEmployeeId(name, surname, patronymic);

                string description = "";
                if (inputDescriptionRichTextBox.Text != "Введите описание операции (необязательно)")
                {
                    description = inputDescriptionRichTextBox.Text;
                }

                string nameDB = "finance";
                string nameColumns = "name, dateTransaction, type, total, category, products, status, idEmployee, shortDescription, infoCurrency";
                string value = $"'{inputNameTextBox.Text}', '{_formatDate}', '{inputTypeTextBox.Text}', {long.Parse(inputTotalTextBox.Text)}, " +
                    $"'{inputCategoryTextBox.Text}', '{inputProductsRichTextBox.Text}', '{inputStatusTextBox.Text}', " +
                    $"{employeeId}, '{description}', '{inputCurrencyTextBox.Text}'";

                _finance.addValueFinance(nameDB, nameColumns, value);
                MessageBox.Show("Данные успешно отправлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(AddFinanceDataForm), ex.Message);
            }
        }
        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
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
