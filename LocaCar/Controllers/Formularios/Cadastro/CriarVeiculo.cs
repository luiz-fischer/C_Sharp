using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class CriarVeiculo : Form
    {

        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ComboBox cbPreco;
        private Library.Label lbl_Marca;
        private Library.Label lbl_Modelo;
        private Library.Label lbl_AnoFab;
        private Library.Label lbl_Preco;
        private Library.Label lbl_Cor;
        private Library.Label lbl_Restricao;
        private Library.RichTextBox richTextBoxMarca;
        private Library.RichTextBox richTextBoxModelo;
        private Library.MaskedTextBox mskTxtAno;
        private Library.RichTextBox richTextBoxCor;
        private Library.RichTextBox richTextBoxRestricao;
        protected readonly Model.Veiculo veiculo;
        public CriarVeiculo(int id = 0)
        {
            try
            {
                veiculo = Controller.Veiculo.GetVeiculo(id);
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO: \n" + exception);
            }
            InitializeComponent(id > 0);
        }

        public void InitializeComponent(bool isUpdate)
        {

            this.btnConfirmar = new Library.Button("btnConfirmar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.cbPreco = new Library.ComboBox("cbPreco");
            this.lbl_Preco = new Library.Label();
            this.lbl_Restricao = new Library.Label();
            this.lbl_Cor = new Library.Label();
            this.lbl_AnoFab = new Library.Label();
            this.lbl_Modelo = new Library.Label();
            this.lbl_Marca = new Library.Label();
            this.richTextBoxMarca = new Library.RichTextBox();
            this.richTextBoxModelo = new Library.RichTextBox();
            this.mskTxtAno = new Library.MaskedTextBox();
            this.richTextBoxCor = new Library.RichTextBox();
            this.richTextBoxRestricao = new Library.RichTextBox();
            //
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            // 
            // lbl_Marca
            this.lbl_Marca.Text = "Marca :";
            this.lbl_Marca.Location = new Point(230, 180);
            // 
            // lbl_Modelo
            this.lbl_Modelo.Text = "Modelo:";
            this.lbl_Modelo.Location = new Point(230, 220);
            // 
            // lbl_AnoFab
            this.lbl_AnoFab.Text = "Ano fabricação :";
            this.lbl_AnoFab.Location = new Point(230, 260);
            // 
            // lbl_Cor
            this.lbl_Cor.Text = "Cor :";
            this.lbl_Cor.Location = new Point(230, 300);
            // 
            // lbl_Restricao
            this.lbl_Restricao.Text = "Restrição :";
            this.lbl_Restricao.Location = new Point(230, 340);
            // 
            // lbl_Preco
            this.lbl_Preco.Text = "Valor da Locação :";
            this.lbl_Preco.Location = new Point(230, 380);
            // 
            // richTextBoxMarca
            this.richTextBoxMarca.Size = new Size(170, 20);
            this.richTextBoxMarca.Location = new Point(955, 180);
            // 
            // richTextBoxModelo
            this.richTextBoxModelo.Location = new Point(955, 220);
            this.richTextBoxModelo.Size = new Size(170, 20);
            // 
            // mskTxtAno
            this.mskTxtAno.Mask = "0000";
            this.mskTxtAno.Location = new Point(955, 260);
            this.mskTxtAno.Size = new Size(30, 20);
            // 
            // richTextBoxCor
            this.richTextBoxCor.Location = new Point(955, 300);
            this.richTextBoxCor.Size = new Size(170, 20);
            // 
            // richTextBoxRestricao
            this.richTextBoxRestricao.Location = new Point(955, 340);
            this.richTextBoxRestricao.Size = new Size(170, 20);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.cbPreco);
            this.Controls.Add(this.richTextBoxRestricao);
            this.Controls.Add(this.richTextBoxCor);
            this.Controls.Add(this.mskTxtAno);
            this.Controls.Add(this.richTextBoxModelo);
            this.Controls.Add(this.richTextBoxMarca);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_Restricao);
            this.Controls.Add(this.lbl_Cor);
            this.Controls.Add(this.lbl_AnoFab);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.lbl_Marca);

        }
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((richTextBoxMarca.Text != string.Empty)
                && (richTextBoxModelo.Text != string.Empty)
                && (mskTxtAno.Text != string.Empty)
                && (richTextBoxCor.Text != string.Empty)
                && (richTextBoxRestricao.Text != string.Empty)
                && (cbPreco.Text != string.Empty))
                {
                    if (veiculo == null)
                    {
                        Controller.Veiculo.CadastrarVeiculo(
                        richTextBoxMarca.Text,
                        richTextBoxModelo.Text,
                        mskTxtAno.Text,
                        richTextBoxCor.Text,
                        richTextBoxRestricao.Text,
                        cbPreco.Text == "R$ 50,00" ? 50.00 :
                        cbPreco.Text == "R$ 100,00" ? 100.00 :
                        cbPreco.Text == "R$ 150,00" ? 150.00 :
                        cbPreco.Text == "R$ 200,00" ? 200.00 : 250.00
                        );
                        MessageBox.Show("Cadastrado Com Sucesso!");

                    }
                    else
                    {
                        Controller.Veiculo.AtualizarVeiculo(
                        veiculo.IdVeiculo,
                        richTextBoxMarca.Text,
                        richTextBoxModelo.Text,
                        mskTxtAno.Text,
                        richTextBoxCor.Text,
                        richTextBoxRestricao.Text,
                        cbPreco.Text == "R$ 50,00" ? 50.00 :
                        cbPreco.Text == "R$ 100,00" ? 100.00 :
                        cbPreco.Text == "R$ 150,00" ? 150.00 :
                        cbPreco.Text == "R$ 200,00" ? 200.00 : 250.00
                        );
                        MessageBox.Show("Alteração Realizada!");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos em Branco!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Campos em Branco!");
            }
        }
    }
}