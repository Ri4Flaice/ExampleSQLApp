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
    public partial class ChangeProjectForm : Form
    {
        private int _id;
        private List<string> _values = new List<string>();
        private Project _project;
        private FindId _findId;
        private RoundBtn _roundBtn;
        Point lastPoint;
        public ChangeProjectForm()
        {
            InitializeComponent();
            _project = new Project();
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
                _values = _project.ValueProject(_id);

                inputNameTextBox.Text = _values[0];
                inputDescriptionRichTextBox.Text = _values[1];

                string dateStart = _values[2];
                string[] dateStartParts = dateStart.Split('-');
                int yearStart = int.Parse(dateStartParts[0]);
                int monthStart = int.Parse(dateStartParts[1]);
                int dayStart = int.Parse(dateStartParts[2]);
                DateStartProjectTimePicker.Value = new DateTime(yearStart, monthStart, dayStart);

                string dateEnd = _values[3];
                string[] dateEndParts = dateEnd.Split('-');
                int yearEnd = int.Parse(dateEndParts[0]);
                int monthEnd = int.Parse(dateEndParts[1]);
                int dayEnd = int.Parse(dateEndParts[2]);
                dateEndProjectTimePicker.Value = new DateTime(yearEnd, monthEnd, dayEnd);

                inputFullNameTextBox.Text = _values[4];
                inputNameFinanceTextBox.Text = _values[5];
                inputResultTextBox.Text = _values[6];
                inputStatusTextBox.Text = _values[7];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeProjectForm), ex.Message);
            }
        }
        private void ChangeSendToDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                _values[0] = inputNameTextBox.Text;
                _values[1] = inputDescriptionRichTextBox.Text;

                string yearStart = DateStartProjectTimePicker.Value.Year.ToString();
                string monthStart = DateStartProjectTimePicker.Value.Month.ToString();
                string dayStart = DateStartProjectTimePicker.Value.Day.ToString();
                string dateStart = $"{yearStart}-{monthStart}-{dayStart}";
                _values[2] = dateStart;

                string yearEnd = dateEndProjectTimePicker.Value.Year.ToString();
                string monthEnd = dateEndProjectTimePicker.Value.Month.ToString();
                string dayEnd = dateEndProjectTimePicker.Value.Day.ToString();
                string dateEnd = $"{yearEnd}-{monthEnd}-{dayEnd}";
                _values[3] = dateEnd;

                string fullname = inputFullNameTextBox.Text;
                string[] nameParts = fullname.Split(' ');
                int idEmpoyee = _findId.FindEmployeeId(nameParts[0], nameParts[1], nameParts[2]);
                _values[4] = idEmpoyee.ToString();

                string nameFinance = inputNameFinanceTextBox.Text;
                int idFinance = _findId.FindFinanceId(nameFinance);
                _values[5] = idFinance.ToString();

                _values[6] = inputResultTextBox.Text;
                _values[7] = inputStatusTextBox.Text;

                _project.changeValueProject(_values, _id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(ChangeProjectForm), ex.Message);
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
