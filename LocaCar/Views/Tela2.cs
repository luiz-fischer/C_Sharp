using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace View
{
    public static class Tela2
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Form2());
        }
    }

	public partial class Form2 : Form 
    {

        Button btnConfirmar;

		public Form2()
        {
			this.Text = "--- MENU PRINCIPAL ---";

            btnConfirmar = new Button();
			btnConfirmar.Text = "Tela 2";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(25, 50);

            this.Controls.Add(btnConfirmar);

			this.Size = new Size(150,150);

		}

        private void btnConfirmarClick(object sender, EventArgs e) {
            // this.Hide();
            // Program frm2 = new Program();
            // frm2.Show();
		}

	}
}