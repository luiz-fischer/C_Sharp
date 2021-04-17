using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Cadastro
{

	public class CriarVeiculoPesado : Form 
    {
        Label lblMarca;
		Label lblModelo;
        Label lblAnoFabricacao;
		Label lblPreco;
        Label lblRestricao;
        LinkLabel linkHelp;

        TextBox txtMarca;
        TextBox txtModelo;
        TextBox txtAnoFabricacao;
        TextBox txtPreco;
        TextBox txtRestricao;

        Button btnConfirmar;
        Button btnCancelar;
        
		public CriarVeiculoPesado()
        {
			this.Text = "--- Cadastro de Veículo Pesado ---";

            lblMarca = new Label();
			lblMarca.Text = "Marca: ";
			lblMarca.Location = new Point(20, 25);
            lblMarca.Size = new Size(100, 30);

            lblModelo = new Label();
            lblModelo.Text = "Modelo:";
            lblModelo.Location = new Point(20, 55);
            lblModelo.Size = new Size(100, 30);

            lblAnoFabricacao = new Label();
            lblAnoFabricacao.Text = "Ano de Fabricação:";
            lblAnoFabricacao.Location = new Point(20,85);
            lblAnoFabricacao.Size = new Size(100, 30);

            lblPreco = new Label();
			lblPreco.Text = "Preço para Locação:";
			lblPreco.Location = new Point(20,115);
            lblPreco.Size = new Size(100,30);

            lblRestricao = new Label();
			lblRestricao.Text = "Restrição do Veículo:";    
			lblRestricao.Location = new Point(20,145);
            lblRestricao.Size = new Size(100,30);

            txtMarca = new TextBox();
			txtMarca.Location = new Point(130, 20);
			txtMarca.Size = new Size(150, 15);

            txtModelo = new TextBox();
			txtModelo.Location = new Point(130, 55);
			txtModelo.Size = new Size(150, 15);

            txtAnoFabricacao = new TextBox();
			txtAnoFabricacao.Location = new Point(130, 85);
			txtAnoFabricacao.Size = new Size(150, 15);

            txtPreco = new TextBox();
			txtPreco.Location = new Point(130, 115);
			txtPreco.Size = new Size(100, 15);

            txtRestricao = new TextBox();
			txtRestricao.Location = new Point(130, 145);
			txtRestricao.Size = new Size(100, 15);

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

            this.Controls.Add(lblMarca);
            this.Controls.Add(txtMarca);
            this.Controls.Add(lblModelo);
            this.Controls.Add(txtModelo);
            this.Controls.Add(lblAnoFabricacao);
            this.Controls.Add(txtAnoFabricacao);
            this.Controls.Add(lblPreco);
            this.Controls.Add(txtPreco);
            this.Controls.Add(lblRestricao);
            this.Controls.Add(txtRestricao);
            this.Controls.Add(btnConfirmar);
			this.Controls.Add(btnCancelar);


			this.Size = new Size(400,350);

		}

        private void btnConfirmarClick(object sender, EventArgs e) {
			MessageBox.Show(
				$"Marca: {this.txtMarca.Text}\n" +
                $"Modelo: {this.txtModelo.Text}\n" +
                $"Ano de Fabricação: {this.txtAnoFabricacao.Text}\n" +
                $"Preço de Locação: {this.txtPreco.Text}\n" +
                $"Restrição do Veículo: {this.txtRestricao.Text}\n" +
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