using System;
using System.Windows.Forms;
using System.Drawing;

namespace LocaCar.Views
{
    static partial class CriarCliente
    {
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Formulario());
        }
    }

	public partial class Formulario : Form 
    {
        Label lblNome;
		Label lblCpf;
        Label lblDtNasc;
		Label lblDiasdev;
        // MonthCalendar mcCalendar;
        LinkLabel linkHelp;

        TextBox txtNome;
        MaskedTextBox txtCpf;
        MaskedTextBox txtDtNasc;
        // ComboBox cbDiasdev;
		NumericUpDown numDiasDev;

        Button btnConfirmar;
        Button btnCancelar;
        
        // WebBrowser webBrowse;

		public Formulario()
        {
			this.Text = "--- Locadora de Veículos ---";

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
			lblDiasdev.Location = new Point(20,120);
            lblDiasdev.Size = new Size(100,30);

            txtNome = new TextBox();
			txtNome.Location = new Point(130, 20);
			txtNome.Size = new Size(300, 15);

            txtCpf = new MaskedTextBox();
			txtCpf.Location = new Point(130, 50);
			txtCpf.Size = new Size(100, 25);
            txtCpf.Mask = "000,000,000-00";

            txtDtNasc = new MaskedTextBox();
			txtDtNasc.Location = new Point(130, 85);
			txtDtNasc.Size = new Size(80, 25);
            txtDtNasc.Mask = "00/00/0000";
			
			numDiasDev = new NumericUpDown();
			numDiasDev.Location = new Point(130, 120);
			numDiasDev.Size = new Size(100,18);
			numDiasDev.Maximum = 20;
			numDiasDev.Minimum = 5;
			numDiasDev.Increment = 5;
			numDiasDev.ReadOnly = true;

            // mcCalendar = new MonthCalendar();
			// mcCalendar.Location = new Point(130, 85);

            linkHelp = new LinkLabel();
			linkHelp.Location = new Point(350, 295);
			linkHelp.Size = new Size(100,30);
			linkHelp.Text = "Ajuda";
			linkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.helpLink);

            btnConfirmar = new Button();
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(100, 280);

            btnCancelar = new Button();
			btnCancelar.Text = "Cancelar";
			btnCancelar.Size = new Size(100,30);
			btnCancelar.Location = new Point(210, 280);
			btnCancelar.Click += new EventHandler(this.btnCancelarClick);

            // this.Controls.Add(mcCalendar);
            this.Controls.Add(linkHelp);

            this.Controls.Add(lblNome);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtNome);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDtNasc);
            this.Controls.Add(txtDtNasc);
            this.Controls.Add(lblDiasdev);
            this.Controls.Add(numDiasDev);
            this.Controls.Add(btnConfirmar);
			this.Controls.Add(btnCancelar);
            // this.Controls.Add(webBrowse);

			this.Size = new Size(400,350);

		}

        private void btnConfirmarClick(object sender, EventArgs e) {
			MessageBox.Show(
				$"Nome: {this.txtNome.Text}\n" +
                $"C.P.F.: {this.txtCpf.Text}\n" +
                $"Data de Nascimento: {this.txtDtNasc.Text}\n" +
                $"Dias para Devolução: {this.numDiasDev.Text}\n" +
				MessageBoxButtons.OK
			);

		}

        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e){
			this.linkHelp.LinkVisited = true;

			Process.Start(
				"https://portal.sc.senac.br/"
			);
		}

        private void btnCancelarClick(object sender, EventArgs e) {
			this.Close();
		}

	}
}