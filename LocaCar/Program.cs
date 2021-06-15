using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{

public class Program {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Home());
        }

	public class Menu : Form {

		Button btnCadastrarCliente;
		Button btnCadastrarVeiculoLeve;
		Button btnCadastrarVeiculoPesado;
		Button btnCadastrarLocacao;
		public Menu() {

            btnCadastrarCliente = new Button();
			btnCadastrarCliente.Text = "Cadastrar Clientes";
			btnCadastrarCliente.Size = new Size(100,30);
			btnCadastrarCliente.Location = new Point(25, 50);
			btnCadastrarCliente.Click += new EventHandler(this.acaoCadastrarCliente);

			btnCadastrarLocacao = new Button();
			btnCadastrarLocacao.Text = "Cadastrar Locações";
			btnCadastrarLocacao.Size = new Size(100,30);
			btnCadastrarLocacao.Location = new Point(25, 200);
			btnCadastrarLocacao.Click += new EventHandler(this.acaoCadastrarLocacao);


            this.Controls.Add(btnCadastrarCliente);
			this.Controls.Add(btnCadastrarVeiculoLeve);
			this.Controls.Add(btnCadastrarVeiculoPesado);
			this.Controls.Add(btnCadastrarLocacao);
			this.Size = new Size(350,350);

		}

        private void acaoCadastrarCliente(object sender, EventArgs e) 
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.Show();

		}


		private void acaoCadastrarLocacao(object sender, EventArgs e) 
        {
                CriarLocacao criarLocacao = new CriarLocacao(this);
                criarLocacao.Show();

		}
	}
}
}