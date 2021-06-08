using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class PictureBox : System.Windows.Forms.PictureBox
    {
        public PictureBox()
        {   
            this.Location = new Point(5, 0);
            this.Size = new Size(460, 80);
            this.ClientSize = new Size(460, 75);
            this.BackColor = ColorTranslator.FromHtml("#38323e");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}