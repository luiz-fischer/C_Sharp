using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Cadastro
{

	public class CriarLocacao : Form 
    {
        Label lblCliente;
		Label lblDataDevolucao;
        Label lblAnoFabricacao;
		Label lblVeiculoLeve;
        Label lblVeiculoPesado;
        LinkLabel linkHelp;

        TextBox txtCliente;
        TextBox txtDataDevolucao;
        TextBox txtVeiculoLeve;
        TextBox txtVeiculoPesado;

        Button btnConfirmar;
        Button btnCancelar;
        
		public CriarLocacao()
        {
			this.Text = "--- Cadastro de Loações ---";

            lblCliente = new Label();
			lblCliente.Text = "Cliente: ";
			lblCliente.Location = new Point(20, 25);
            lblCliente.Size = new Size(100, 30);

            lblDataDevolucao = new Label();
            lblDataDevolucao.Text = "Data da Devolução:";
            lblDataDevolucao.Location = new Point(20, 55);
            lblDataDevolucao.Size = new Size(100, 30);

            lblVeiculoLeve = new Label();
			lblVeiculoLeve.Text = "Veiculo leve:";
			lblVeiculoLeve.Location = new Point(20,85);
            lblVeiculoLeve.Size = new Size(100,30);

            lblVeiculoPesado = new Label();
			lblVeiculoPesado.Text = "Veiculo Pesado:";    
			lblVeiculoPesado.Location = new Point(20,115);
            lblVeiculoPesado.Size = new Size(100,30);

            txtCliente = new TextBox();
			txtCliente.Location = new Point(130, 20);
			txtCliente.Size = new Size(150, 15);

            txtDataDevolucao = new TextBox();
			txtDataDevolucao.Location = new Point(130, 55);
			txtDataDevolucao.Size = new Size(150, 15);

            txtVeiculoLeve = new TextBox();
			txtVeiculoLeve.Location = new Point(130, 85);
			txtVeiculoLeve.Size = new Size(150, 15);

            txtVeiculoPesado = new TextBox();
			txtVeiculoPesado.Location = new Point(130, 115);
			txtVeiculoPesado.Size = new Size(100, 15);

            linkHelp = new LinkLabel();
			linkHelp.Location = new Point(350, 295);
			linkHelp.Size = new Size(100,30);
			linkHelp.Text = "Ajuda";
			linkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.helpLink);

            btnConfirmar = new Button();
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(100, 280);
			btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            btnCancelar = new Button();
			btnCancelar.Text = "Cancelar";
			btnCancelar.Size = new Size(100,30);
			btnCancelar.Location = new Point(210, 280);
			btnCancelar.Click += new EventHandler(this.btnCancelarClick);

            this.Controls.Add(linkHelp);

            this.Controls.Add(lblCliente);
            this.Controls.Add(txtCliente);
            this.Controls.Add(lblDataDevolucao);
            this.Controls.Add(txtDataDevolucao);
            this.Controls.Add(lblAnoFabricacao);
            this.Controls.Add(txtVeiculoLeve);
            this.Controls.Add(lblVeiculoLeve);
            this.Controls.Add(txtVeiculoPesado);
            this.Controls.Add(lblVeiculoPesado);
            this.Controls.Add(btnConfirmar);
			this.Controls.Add(btnCancelar);


			this.Size = new Size(400,350);

		}

        private void btnConfirmarClick(object sender, EventArgs e) {
			MessageBox.Show(
				$"Cliente: {this.txtCliente.Text}\n" +
                $"Data da Devolução: {this.txtDataDevolucao.Text}\n" +
                $"Veiculo Leve: {this.txtVeiculoLeve.Text}\n" +
                $"VeiculoPesado: {this.txtVeiculoPesado.Text}\n" +
				MessageBoxButtons.OK
			);

		}

        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e){
			this.linkHelp.LinkVisited = false;

			Process.Start(
				"https://portal.sc.senac.br/"
			);
		}

        private void btnCancelarClick(object sender, EventArgs e) {
			this.Close();
		}

	}
}