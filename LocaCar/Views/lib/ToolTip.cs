using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class ToolTip : System.Windows.Forms.ToolTip
    {

        public ToolTip()
        {
            this.AutoPopDelay = 5000;
            this.InitialDelay = 1000;
            this.ReshowDelay = 500;
            this.ShowAlways = true;
        }
    }
}