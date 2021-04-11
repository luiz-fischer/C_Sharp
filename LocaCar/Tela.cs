using System;
using System.Windows.Forms;
using System.Drawing;
using Repository;
using Views;

namespace LocaCar
{
    public class Tela
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Menu());
        }
    }

	public partial class Menu : Form 
    {

        Button btnConfirmar;

		public Menu()
        {
			this.Text = "--- MENU PRINCIPAL ---";

            btnConfirmar = new Button();
			btnConfirmar.Text = "Cadastrar Clientes";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(25, 50);
			btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            this.Controls.Add(btnConfirmar);

			this.Size = new Size(150,150);

		}

        public void btnConfirmarClick(object sender, EventArgs e)
        {
            // MessageBox.Show("Tem certeza ?");
            // Application.Run(new Form2()); 
            Form2 form2 = new Form2(this); // Declara o form2
            form2.Show();
		}

	}
}