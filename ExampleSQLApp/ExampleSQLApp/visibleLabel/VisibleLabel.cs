using System.Windows.Forms;

namespace ExampleSQLApp.visibleLabel
{
    public class VisibleLabel
    {
        public static void VisibleTextBox(TextBox textBox, Label label, string value)
        {
            if (textBox.Text != value)
            {
                label.Visible = !string.IsNullOrWhiteSpace(textBox.Text);
                label.Text = textBox.Text;
            }
        }

        public static void VisibleRichTextBox(RichTextBox richTextBox, Label label, string value)
        {
            if (richTextBox.Text != value)
            {
                label.Visible = !string.IsNullOrWhiteSpace(richTextBox.Text);
                label.Text = richTextBox.Text;
            }
        }
    }
}
