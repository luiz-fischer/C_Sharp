using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class MaskedTextBox : System.Windows.Forms.MaskedTextBox
    {
        public MaskedTextBox()
        {
            this.Location = new Point(150, 100);
            this.Size = new Size(170, 20);
        }
    }
}