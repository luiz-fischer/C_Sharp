using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace LocaCar
{

public class Program {
    public static void Main() {
			Application.EnableVisualStyles();
            Application.Run(new Menu());
        }
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

			btnCadastrarVeiculoLeve = new Button();
			btnCadastrarVeiculoLeve.Text = "Cadastrar Veiculo Leve";
			btnCadastrarVeiculoLeve.Size = new Size(100,30);
			btnCadastrarVeiculoLeve.Location = new Point(25, 100);
			btnCadastrarVeiculoLeve.Click += new EventHandler(this.acaoCadastrarVeiculoLeve);

			btnCadastrarVeiculoPesado = new Button();
			btnCadastrarVeiculoPesado.Text = "Cadastrar Veiculo Pesado";
			btnCadastrarVeiculoPesado.Size = new Size(100,30);
			btnCadastrarVeiculoPesado.Location = new Point(25, 150);
			btnCadastrarVeiculoPesado.Click += new EventHandler(this.acaoCadastrarVeiculoPesado);

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

		private void acaoCadastrarVeiculoLeve(object sender, EventArgs e) 
        {
                CriarVeiculoLeve criarVeiculoLeve = new CriarVeiculoLeve();
                criarVeiculoLeve.Show();

		}

		private void acaoCadastrarVeiculoPesado(object sender, EventArgs e) 
        {
                CriarVeiculoPesado criarVeiculoPesado = new CriarVeiculoPesado();
                criarVeiculoPesado.Show();

		}

		private void acaoCadastrarLocacao(object sender, EventArgs e) 
        {
                CriarLocacao criarLocacao = new CriarLocacao();
                criarLocacao.Show();

		}
       
	}
}
