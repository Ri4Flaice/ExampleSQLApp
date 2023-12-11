using System.Windows.Forms;

namespace ExampleSQLApp.visibleLabel
{
    public class VisibleDate
    {
        public static string Visible(DateTimePicker dateTimePicker, Label label)
        {
            string formatDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            label.Text = formatDate;

            label.Visible = !string.IsNullOrWhiteSpace(formatDate);
            label.Text = formatDate;

            return formatDate;
        }
    }
}
