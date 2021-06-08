using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class RichTextBox : System.Windows.Forms.RichTextBox
    {
        public RichTextBox()
        {    
            this.Location = new Point(150, 20);
            this.Size = new Size(300, 20);
            this.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
            this.SelectionColor = System.Drawing.Color.Black;
        }
    }
}