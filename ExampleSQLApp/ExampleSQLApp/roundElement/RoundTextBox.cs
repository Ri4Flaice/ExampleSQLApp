using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp.roundElement
{
    internal class RoundTextBox : TextBox
    {
        public void RoundTxtBox(TextBox textBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(textBox.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(textBox.Width - radius * 2, textBox.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, textBox.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            textBox.Region = new Region(path);
        }
    }
}
