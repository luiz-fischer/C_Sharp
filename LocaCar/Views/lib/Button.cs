using System;
using System.Drawing;
using System.Windows.Forms;


namespace Library 
{
    public class Button : System.Windows.Forms.Button
    {
        public Button(string caseSwitch)
        {
            this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatAppearance.BorderSize = 3;
            this.ImeMode = ImeMode.NoControl;
            this.Size = new Size(90, 33);
            this.TabIndex = 39;
            this.UseVisualStyleBackColor = true;

            switch (caseSwitch)
            {
                case "btnConfirmar":
                    this.FlatStyle = FlatStyle.System;
                    this.Location = new Point(445, 468);
                    this.Name = "btnConfirmar";
                    this.Text = "Confirmar";
                    break;

                case "btnCancelar":
                    this.DialogResult = DialogResult.Cancel;
                    this.Location = new Point(541, 468);
                    this.Name = "btnCancelar";
                    this.Text = "Cancelar";
                    this.Click += new EventHandler(this.btnCancelar_Click);
                    break;
                    
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}