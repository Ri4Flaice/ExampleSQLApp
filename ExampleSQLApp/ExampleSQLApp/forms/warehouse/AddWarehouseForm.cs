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
    public partial class AddWarehouseForm : Form
    {
        Point lastPoint;
        private IntroductoryText _introductoryText;
        private string _formatDate;
        private Warehouse _warehouse;
        private FindId _findId;
        private RoundBtn _roundBtn;
        public AddWarehouseForm()
        {
            InitializeComponent();
            _introductoryText = new IntroductoryText();
            _roundBtn = new RoundBtn();
            _roundBtn.RoundButton(sendToDbButton, 3);
            _warehouse = new Warehouse();
            _findId = new FindId();

            inputNameTextBox_Leave(inputNameTextBox, EventArgs.Empty);
            inputNameFinanceTextBox_Leave(inputNameFinanceTextBox, EventArgs.Empty);
            inputCategoryTextBox_Leave(inputCategoryTextBox, EventArgs.Empty);
            inputStatusTextBox_Leave(inputStatusTextBox, EventArgs.Empty);
            inputSupplierTextBox_Leave(inputSupplierTextBox, EventArgs.Empty);
            inputFullNameTextBox_Leave(inputFullNameTextBox, EventArgs.Empty);
            locationTextBox_Leave(inputLocationTextBox, EventArgs.Empty);
            inputDescriptionRichTextBox_Leave(inputDescriptionRichTextBox, EventArgs.Empty);
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
            _introductoryText.TextBoxEnter(inputNameTextBox, "Введите название оборудования");
        }
        private void inputNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputNameTextBox, "Введите название оборудования");
        }
        private void inputNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputNameTextBox, valueNameEquipmentLabel, "Введите название оборудования");
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
        private void inputCategoryTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputCategoryTextBox, "Введите категорию оборудования");
        }
        private void inputCategoryTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputCategoryTextBox, "Введите категорию оборудования");
        }
        private void inputCategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputCategoryTextBox, valueCategoryOperationLabel, "Введите категорию оборудования");
        }
        private void inputStatusTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputStatusTextBox, "Введите статус оборудования");
        }
        private void inputStatusTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputStatusTextBox, "Введите статус оборудования");
        }
        private void inputStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputStatusTextBox, valueStatusOperationLabel, "Введите статус оборудования");
        }
        private void DateOperationTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _formatDate = VisibleDate.Visible(DateOperationTimePicker, valueDateOperationLabel);
        }
        private void inputSupplierTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputSupplierTextBox, "Введите наименование поставищка");
        }
        private void inputSupplierTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputSupplierTextBox, "Введите наименование поставищка");
        }
        private void inputSupplierTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputSupplierTextBox, valueSupplierLabel, "Введите наименование поставищка");
        }
        private void inputFullNameTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputFullNameTextBox, "Введите ФИО (необязательно)");
        }
        private void inputFullNameTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputFullNameTextBox, "Введите ФИО (необязательно)");
        }
        private void inputFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputFullNameTextBox, valueFullNameLabel, "Введите ФИО (необязательно)");
        }
        private void locationTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputLocationTextBox, "Введите местоположение");
        }
        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputLocationTextBox, "Введите местоположение");
        }
        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleTextBox(inputLocationTextBox, valueLocationLabel, "Введите местоположение");
        }
        private void inputDescriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            _introductoryText.TextBoxEnter(inputDescriptionRichTextBox, "Введите описание(необязательно)");
        }
        private void inputDescriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            _introductoryText.TextBoxLeave(inputDescriptionRichTextBox, "Введите описание(необязательно)");
        }
        private void inputDescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            VisibleLabel.VisibleRichTextBox(inputDescriptionRichTextBox, valueDescriptionOperationLabel, "Введите описание(необязательно)");
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

                if (inputFullNameTextBox.Text != "Введите ФИО (необязательно)")
                {
                    employeeId = _findId.FindEmployeeId(name, surname, patronymic);
                }

                string description = " ";
                if (inputDescriptionRichTextBox.Text != "Введите описание(необязательно)")
                {
                    description = inputDescriptionRichTextBox.Text;
                }

                if (employeeId == 0)
                {
                    string nameDB = "warehouse";
                    string nameColumns = "name, idFinance, category, status, deliveryDate, supplier, location, notesrefences";
                    string value = $"'{inputNameTextBox.Text}', '{int.Parse(inputNameFinanceTextBox.Text)}', '{inputCategoryTextBox.Text}', '{inputStatusTextBox.Text}', " +
                        $"'{_formatDate}', '{inputSupplierTextBox.Text}', " +
                        $"'{inputLocationTextBox.Text}', '{description}'";

                    _warehouse.addValueWarehouse(nameDB, nameColumns, value);
                    MessageBox.Show("Данные успешно отправлены");
                }
                else
                {
                    string nameDB = "warehouse";
                    string nameColumns = "name, idFinance, category, status, deliveryDate, supplier, idEmployee, location, notesrefences";
                    string value = $"'{inputNameTextBox.Text}', '{int.Parse(inputNameFinanceTextBox.Text)}', '{inputCategoryTextBox.Text}', '{inputStatusTextBox.Text}', " +
                        $"'{_formatDate}', '{inputSupplierTextBox.Text}', '{employeeId}', " +
                        $"'{inputLocationTextBox.Text}', '{description}'";

                    _warehouse.addValueWarehouse(nameDB, nameColumns, value);
                    MessageBox.Show($"Данные успешно отправлены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(AddWarehouseForm), ex.Message);
            }
        }
    }
}
