using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class ButtonConfirmar : System.Windows.Forms.Button
    {

       
        public ButtonConfirmar() {
            this.FlatStyle = FlatStyle.System;
            this.ImeMode = ImeMode.NoControl;
            this.Location = new Point(445, 468);
            this.Name = "btnConfirmar";
            this.Size = new Size(90, 33);
            this.TabIndex = 40;
            this.Text = "Confirmar";
            this.UseVisualStyleBackColor = true;
        }

    }
}