using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp.Window
{
    public class WindowMove
    {
        public static void MoveForm(Form form, MouseEventArgs e, Point lastPoint)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - lastPoint.X;
                form.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
