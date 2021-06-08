using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            this.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Anchor = AnchorStyles.None;
        }
    }
}