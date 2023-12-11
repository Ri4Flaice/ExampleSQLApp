using ExampleSQLApp.error;
using ExampleSQLApp.roundElement;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        private RoundBtn _roundBtn;
        private RoundTextBox _roundTextBox;
        Point lastPoint;
        private int _count = 0;
        public LoginForm()
        {
            InitializeComponent();
            _roundBtn = new RoundBtn();
            _roundTextBox = new RoundTextBox();
            _roundBtn.RoundButton(buttonLogin, 3);
            _roundTextBox.RoundTxtBox(loginField, 3);
            _roundTextBox.RoundTxtBox(passField, 3);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = loginField.Text;
                string passUser = passField.Text;

                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `email` = @uL AND `pass` = @uP", db.GetConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    int isAdminValue = Convert.ToInt32(table.Rows[0]["isAdmin"]);

                    if (isAdminValue == 1)
                    {
                        UserCredentials userCredentials = new UserCredentials();
                        userCredentials.UserName = table.Rows[0]["name"].ToString();
                        userCredentials.UserSurname = table.Rows[0]["surname"].ToString();
                        userCredentials.UserPatronymic = table.Rows[0]["patronymic"].ToString();
                        userCredentials.UserPost = table.Rows[0]["post"].ToString();

                        Properties.Settings.Default.UserName = userCredentials.UserName;
                        Properties.Settings.Default.UserSurname = userCredentials.UserSurname;
                        Properties.Settings.Default.UserPatronymic = userCredentials.UserPatronymic;
                        Properties.Settings.Default.UserPost = userCredentials.UserPost;
                        Properties.Settings.Default.Save();

                        OpenMainForm();
                    }
                }
                else
                {
                    CloseForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                WriteError.LogError(nameof(LoginForm), ex.Message);
            }
        }
        private void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
            };
            mainForm.Show();
            this.Hide();
        }
        private void CloseForm()
        {
            _count++;
            MessageBox.Show("Доступ запрещен.");
            if (_count == 3)
            {
                this.Close();
            }
        }
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
