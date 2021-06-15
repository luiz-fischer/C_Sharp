using System;
using System.Drawing;
using System.Windows.Forms;


namespace Library
{
    public class ButtonCancelar : System.Windows.Forms.Button
    {
        public ButtonCancelar() { 
           
            this.DialogResult = DialogResult.Cancel;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatAppearance.BorderSize = 3;
            this.ImeMode = ImeMode.NoControl;
            this.Location = new Point(541, 468);
            this.Name = "btnCancelar";
            this.Size = new Size(90, 33);
            this.TabIndex = 39;
            this.Text = "Cancelar";
            this.UseVisualStyleBackColor = true;
            this.Click += new EventHandler(this.btnCancelar_Click);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}