using System.Windows.Forms;

namespace ExampleSQLApp.openForm
{
    public class OpenFormController : Form
    {
        public static void OpenForm(Form currentForm, Form newForm)
        {   
            newForm.FormClosed += (s, args) =>
            {
                currentForm.Close();
            };
            newForm.Show();
            currentForm.Hide();
        }
    }
}
