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
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Formulario());
        }
    }

	public class Formulario : Form 
    {
        Label lblNome;
		Label lblCpf;
        Label lblDtNasc;
		Label lblDiasdev;
        MonthCalendar mcCalendar;


        TextBox txtNome;
        MaskedTextBox txtCpf;
        MaskedTextBox txtDtNasc;
        // ComboBox cbDiasdev;
		NumericUpDown numDiasDev;

        Button btnConfirmar;
        Button btnCancelar;

		public Formulario()
        {
			this.Text = "----- Bem Vindo a Locadora de Veículos LocaCar -----";

            lblNome = new Label();
			lblNome.Text = "Nome Completo: ";
			lblNome.Location = new Point(20, 25);
            lblNome.Size = new Size(100, 30);

            lblCpf = new Label();
            lblCpf.Text = "C.P.F.:";
            lblCpf.Location = new Point(20, 55);
            lblCpf.Size = new Size(100, 30);

            lblDtNasc = new Label();
            lblDtNasc.Text = "Data de Nascimento:";
            lblDtNasc.Location = new Point(20,85);
            lblDtNasc.Size = new Size(100, 30);

            lblDiasdev = new Label();
			lblDiasdev.Text = "Dias Para Devolução:";
			lblDiasdev.Location = new Point(20,250);
            lblDiasdev.Size = new Size(100,30);

            txtNome = new TextBox();
			txtNome.Location = new Point(130, 20);
			txtNome.Size = new Size(300, 15);

            txtCpf = new MaskedTextBox();
			txtCpf.Location = new Point(130, 50);
			txtCpf.Size = new Size(100, 25);
            txtCpf.Mask = "000,000,000-00";

            // txtDtNasc = new MaskedTextBox();
			// txtDtNasc.Location = new Point(130, 300);
			// txtDtNasc.Size = new Size(80, 25);
            // txtDtNasc.Mask = "00/00/0000";
			
			numDiasDev = new NumericUpDown();
			numDiasDev.Location = new Point(130, 250);
			numDiasDev.Size = new Size(100,18);
			numDiasDev.Maximum = 20;
			numDiasDev.Minimum = 5;
			numDiasDev.Increment = 5;
			numDiasDev.ReadOnly = true;

            mcCalendar = new MonthCalendar();
			mcCalendar.Location = new Point(130, 85);

            btnConfirmar = new Button();
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(150, 380);
			btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            btnCancelar = new Button();
			btnCancelar.Text = "Cancelar";
			btnCancelar.Size = new Size(100,30);
			btnCancelar.Location = new Point(270, 380);
			btnCancelar.Click += new EventHandler(this.btnCancelarClick);

            this.Controls.Add(mcCalendar);

            this.Controls.Add(lblNome);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtNome);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDtNasc);
            // this.Controls.Add(txtDtNasc);
            this.Controls.Add(lblDiasdev);
            this.Controls.Add(numDiasDev);
            this.Controls.Add(btnConfirmar);
			this.Controls.Add(btnCancelar);
			this.Size = new Size(500,450);

		}

        private void btnConfirmarClick(object sender, EventArgs e) {
			MessageBox.Show(
				$"Nome: {this.txtNome.Text}\n" +
                $"C.P.F.: {this.txtCpf.Text}\n" +
                $"Data de Nascimento: {this.txtDtNasc.Text}\n" +
				MessageBoxButtons.OK
			);

		}

        private void btnCancelarClick(object sender, EventArgs e) {
			this.Close();
		}

	}
}