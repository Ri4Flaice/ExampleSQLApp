using System.Windows.Forms;

namespace ExampleSQLApp.hideText
{
    internal class IntroductoryText
    {
        public void TextBoxEnter(TextBox textBox, string initialText)
        {
            if (textBox.Text == initialText)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }
        public void TextBoxLeave(TextBox textBox, string initialText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = initialText;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
        public void TextBoxEnter(RichTextBox textBox, string initialText)
        {
            if (textBox.Text == initialText)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }
        public void TextBoxLeave(RichTextBox textBox, string initialText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = initialText;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
