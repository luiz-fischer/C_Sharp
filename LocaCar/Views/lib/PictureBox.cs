using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class PictureBox : System.Windows.Forms.PictureBox
    {
        public PictureBox()
        {   
            this.BorderStyle = BorderStyle.Fixed3D;
            this.ImeMode = ImeMode.NoControl;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TabIndex = 41;
            this.TabStop = false;
            this.Load("C:\\LocaCar\\Imagens\\download1.jpg");
        }
    }
}