using ExampleSQLApp.error;
using ExampleSQLApp.openForm;
using ExampleSQLApp.request;
using ExampleSQLApp.roundElement;
using ExampleSQLApp.searchInfo;
using ExampleSQLApp.Window;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    { 
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _post;

        private RoundBtn _roundBtn;
        private RoundTextBox _roundTextBox;

        Point lastPoint;

        private Finance _finance;
        private Warehouse _warehouse;
        private Project _project;
        private Archive _archive;
        private string[] _nameColumns;
        public MainForm()
        {
            InitializeComponent();
            _roundBtn = new RoundBtn();
            _roundTextBox = new RoundTextBox();
            _roundBtn.RoundButton(btnSearch, 3);
            _roundTextBox.RoundTxtBox(txtSearch, 3);

            _name = Properties.Settings.Default.UserName;
            _surname = Properties.Settings.Default.UserSurname;
            _patronymic = Properties.Settings.Default.UserPatronymic;
            _post = Properties.Settings.Default.UserPost;

            _finance = new Finance();
            _warehouse = new Warehouse();
            _project = new Project();
            _archive = new Archive();
            DisplayData();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void DisplayData()
        {
            userNameLabel.Text = _name;
            userSurnameLabel.Text = _surname;
            userPatronymicLabel.Text = _patronymic;
            userPostLabel.Text = _post;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            SearchInfo searchInfo = new SearchInfo(dataGridViewDB, _nameColumns, searchValue);
        }
        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            WindowMove.MoveForm(this, e, lastPoint);
        }
        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FinanceViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable financeData = _finance.FinanceDB();
                dataGridViewDB.DataSource = financeData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(MainForm), ex.Message);
            }

            _nameColumns = new string[] { "Номер операции", "Наименование операции", "Дата операции", "Тип операции",
                "Сумма операции", "Категория операции", "Товар", "Статус операции", "Ответственный",
                "Краткое описание", "Валюта"};
        }
        private void addFinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new AddFinanceDataForm());
        }
        private void changeFinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new ChangeFinanceDataForm());
        }
        private void viewWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable warehouseData = _warehouse.WarehouseDB();
                dataGridViewDB.DataSource = warehouseData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(MainForm), ex.Message);
            }

            _nameColumns = new string[] { "Номер оборудования", "Наименование оборудования", "Наименование операции",
                "Категория оборудования", "Статус оборудования", "Дата поставки", "Поставщик",
                "Ответственный", "Местоположение оборудования", "Примечание"};
        }
        private void addWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new AddWarehouseForm());
        }
        private void changeWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new ChangeWarehouseForm());
        }
        private void projectViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable projectData = _project.ProjectDB();
                dataGridViewDB.DataSource = projectData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(MainForm), ex.Message);
            }

            _nameColumns = new string[] { "Номер проекта", "Наименование проекта", "Описание", "Начало проекта",
                "Конец проекта", "Ответственный", "Наименование операции",
                "Результат", "Статус"};
        }
        private void projectAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new AddProjectForm());
        }
        private void projectChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new ChangeProjectForm());
        }
        private void archiveViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable archiveData = _archive.ArchiveDB();
                dataGridViewDB.DataSource = archiveData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(MainForm), ex.Message);
            }

            _nameColumns = new string[] { "Номер документа", "Наименование документа", "Тип документа", "Местоположение",
                "Статус документа", "Дата архивации", "Ответственный", "Наименование операции"};
        }
        private void archiveAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new AddArchiveForm());
        }
        private void archiveChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormController.OpenForm(this, new ChangeArchiveForm());
        }
    }
}