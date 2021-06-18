using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class EditarVeiculo : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnAlterar;
        private Library.Button btnDeletar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.Label lblDadosVeiculo;
        private Library.RichTextBox richTextBoxVeiculos;
        int idVeiculo;
        Model.Veiculo Veiculo;

        public EditarVeiculo(Model.Veiculo veiculo)
        {
            InitializeComponent(veiculo);
        }

        public void InitializeComponent(Model.Veiculo veiculo)
        {
            this.btnDeletar = new Library.Button("btnDeletar");
            this.btnAlterar = new Library.Button("btnAlterar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.lblDadosVeiculo = new Library.Label();
            this.richTextBoxVeiculos = new Library.RichTextBox();
            //
            // btnDeletar
            this.btnDeletar.Click += new EventHandler(this.btnDeletarVeiculo_Click);
            //
            // btnAlterar
            this.btnAlterar.Click += new EventHandler(this.btnAlterarVeiculo_Click);
            //  
            // lblDadosVeiculo
            this.lblDadosVeiculo.Text = "DADOS DO VEÍCULO";
            this.lblDadosVeiculo.ForeColor = Color.Blue;
            this.lblDadosVeiculo.Location = new Point(585, 220);
            this.lblDadosVeiculo.Size = new Size(300, 25);
            this.lblDadosVeiculo.Font = new Font(FontFamily.GenericSansSerif, 14F, FontStyle.Bold);
            // 
            // richTextBoxVeiculos
            this.richTextBoxVeiculos.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.richTextBoxVeiculos.Text =
                "\nID do Veículo:                       "            + veiculo.IdVeiculo +
                "\nMarca:                                   "       + veiculo.Marca +
                "\nModelo:                                 "        + veiculo.Modelo +
                "\nAno de Fabricação:              "                + veiculo.Ano +        
                "\nCor do Veículo:                     "            + veiculo.Cor +
                "\nRestrição:                             "         + veiculo.Restricao +
                "\nValor da Locação:                "               + veiculo.Preco.ToString("C2");
            this.richTextBoxVeiculos.Location = new Point(500, 250); ;
            this.richTextBoxVeiculos.Size = new Size(430, 200);
            //  
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblDadosVeiculo);
            this.Controls.Add(this.richTextBoxVeiculos);
            this.Text = "       EDITAR VEÍCULO";
            this.idVeiculo = veiculo.IdVeiculo;
            this.Veiculo = veiculo;

        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            CriarVeiculo criarCliente = new CriarVeiculo(idVeiculo);
            criarCliente.Show();
        }
        private void btnDeletarVeiculo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Realmente Exluir Esse Veículo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Controller.Veiculo.DeletarVeiculo(idVeiculo);
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