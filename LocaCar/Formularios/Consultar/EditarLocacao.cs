using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class EditarLocacao : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnDeletar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.Label lblDadosCliente;
        private Library.Label lblDadosLocacao;
        private Library.Label lblDadosVeiculo;
        private Library.RichTextBox richTextBoxVeiculos;
        private Library.RichTextBox richTextBoxCliente;
        private Library.RichTextBox richTextBoxLocacao;

        int idLocacao;
        Model.Locacao Locacao;

        public EditarLocacao(Model.Locacao locacao)
        {
            InitializeComponent(locacao);
        }
        public void InitializeComponent(Model.Locacao locacao)
        {

            this.btnDeletar = new Library.Button("btnDeletar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.lblDadosLocacao = new Library.Label();
            this.lblDadosCliente = new Library.Label();
            this.lblDadosVeiculo = new Library.Label();
            this.richTextBoxLocacao = new Library.RichTextBox();
            this.richTextBoxCliente = new Library.RichTextBox();
            this.richTextBoxVeiculos = new Library.RichTextBox();
            //
            // btnDeletarLocacao
            this.btnDeletar.Click += new EventHandler(this.btnDeletarLocacao_Click);
            // 
            // lblDadosCliente
            this.lblDadosCliente.Text = "DADOS DO CLIENTE";
            this.lblDadosCliente.ForeColor = Color.Blue;
            this.lblDadosCliente.Location = new Point(19, 250);
            this.lblDadosCliente.Size = new Size(220, 25);
            this.lblDadosCliente.Font = new Font(FontFamily.GenericSansSerif, 14F, FontStyle.Bold);
            //
            // richTextBoxCliente
            Model.Cliente cliente = Controller.Cliente.GetCliente(locacao.IdCliente);
             this.richTextBoxCliente.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.richTextBoxCliente.Location = new Point(20, 275);
            this.richTextBoxCliente.Size = new Size(430, 200);
            this.richTextBoxCliente.Text =
                "\n" +
                "\n ID do Cliente:               "          + locacao.IdCliente.ToString() +
                "\n Nome Completo:                  "       + cliente.Nome +
                "\n Data Nascimento:        "               + cliente.DataDeNascimento +
                "\n CPF:                             "      + cliente.Cpf +
                "\n Total de Veículos:        "             + locacao.QtdeVeiculosLocados();
            //  
            // lblDadosVeiculo
            this.lblDadosVeiculo.Text = "DADOS DO VEÍCULO";
            this.lblDadosVeiculo.Location = new Point(469, 250);
            this.lblDadosVeiculo.Size = new Size(250, 20);
            this.lblDadosVeiculo.ForeColor = Color.Blue;
            this.lblDadosVeiculo.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            // 
            // richTextBoxVeiculos
            this.richTextBoxVeiculos.Text = "\n" + locacao.VeiculosLocados();
            this.richTextBoxVeiculos.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.richTextBoxVeiculos.Location = new Point(470, 275);
            this.richTextBoxVeiculos.Size = new Size(430, 200);
            // 
            // lblDadosLocacao
            this.lblDadosLocacao.Text = "DADOS DA LOCAÇÃO";
            this.lblDadosLocacao.Location = new Point(920, 250);
            this.lblDadosLocacao.Size = new Size(220, 25);
            this.lblDadosLocacao.ForeColor = Color.Blue;
            this.lblDadosLocacao.Font = new Font(FontFamily.GenericSansSerif, 14F, FontStyle.Bold);
            //
            // richTextBoxLocacao
            
            this.richTextBoxLocacao.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.richTextBoxLocacao.Location = new Point(919, 275);
            this.richTextBoxLocacao.Size = new Size(430, 200);
            Model.Veiculo veiculo = new Model.Veiculo();
            this.richTextBoxLocacao.Text =
                "\n ID da Locação:                        "       + locacao.IdLocacao.ToString() +
                "\n Data da Locação:                    "         + locacao.DataLocacao.ToString("dd/MM/yyyy") +
                "\n Data de Devolução:                 "          + locacao.GetDataDevolucao().ToString("dd/MM/yyyy") +
                "\n Quantidade de Dias:                "          + cliente.DiasParaDevolucao.ToString() +
                "\n Valor Por Dia:                          "     +  locacao.GetValorDiariaByLocacao() +
                "\n Total da Locação:                    "        + locacao.ValorTotalLocacao().ToString("C2");
            //      
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblDadosCliente);
            this.Controls.Add(this.lblDadosLocacao);
            this.Controls.Add(this.lblDadosVeiculo);
            this.Controls.Add(this.richTextBoxCliente);
            this.Controls.Add(this.richTextBoxLocacao);
            this.Controls.Add(this.richTextBoxVeiculos);
            this.Text = "       EDITAR LOCAÇÃO";
            this.idLocacao = locacao.IdLocacao;
            this.Locacao = locacao;

        }

        private void btnDeletarLocacao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Exluir Essa Locação?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Controller.Locacao.DeletarLocacao(idLocacao);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}