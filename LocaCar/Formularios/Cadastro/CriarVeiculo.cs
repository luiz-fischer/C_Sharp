using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
 
namespace LocaCar
{
    partial class CriarVeiculo : Form
    {

        Library.PictureBox imagemTitle;
        Library.PictureBox imagemLogo;
        Library.Button btnConfirmar;
        Library.Button btnCancelar;
        Library.LinkLabelAjuda linkAjuda;
        private Label lbl_Marca;
        private Label lbl_Modelo;
        private Label lbl_AnoFab;
        private Label lbl_Preco;
        private Label lbl_Cor;
        private Label lbl_Restricao;
        private RichTextBox txtMarca;
        private RichTextBox txtModelo;
        private MaskedTextBox txtAno;
        private RichTextBox txtCor;
        private RichTextBox txtRestricao;
        private ComboBox cbPreco;
        Model.Veiculo veiculo;
        public CriarVeiculo(int id = 0)
        {
            try
            {
                veiculo = Controller.Veiculo.GetVeiculo(id);
            }
            catch
            {

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
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            //
            // btnConfirmar
            // 
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca = new Label();
            this.lbl_Marca.Text = "Marca :";
            this.lbl_Marca.Location = new Point(10, 150);
            this.lbl_Marca.Size = new Size(200, 20);
            this.lbl_Marca.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_Marca);
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo = new Label();
            this.lbl_Modelo.Text = "Modelo:";
            this.lbl_Modelo.Location = new Point(10, 175);
            this.lbl_Modelo.Size = new Size(200, 20);
            this.lbl_Modelo.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_Modelo);
            // 
            // lbl_AnoFab
            // 
            this.lbl_AnoFab = new Label();
            this.lbl_AnoFab.Text = "Ano fabricação :";
            this.lbl_AnoFab.Location = new Point(10, 200);
            this.lbl_AnoFab.Size = new Size(200, 20);
            this.lbl_AnoFab.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_AnoFab);
            // 
            // lbl_Cor
            // 
            this.lbl_Cor = new Label();
            this.lbl_Cor.Text = "Cor :";
            this.lbl_Cor.Location = new Point(10, 225);
            this.lbl_Cor.Size = new Size(200, 20);
            this.lbl_Cor.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_Cor);
            // 
            // lbl_Restricao
            // 
            this.lbl_Restricao = new Label();
            this.lbl_Restricao.Text = "Restrição :";
            this.lbl_Restricao.Location = new Point(10, 250);
            this.lbl_Restricao.Size = new Size(200, 20);
            this.lbl_Restricao.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_Restricao);
            // 
            // lbl_Preco
            // 
            this.lbl_Preco = new Label();
            this.lbl_Preco.Text = "Valor da Locação :";
            this.lbl_Preco.Location = new Point(10, 275);
            this.lbl_Preco.Size = new Size(200, 20);
            this.lbl_Preco.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.Controls.Add(lbl_Preco);
            // 
            // txtMarca
            // 
            this.txtMarca = new RichTextBox();
            this.txtMarca.Size = new Size(170, 20);
            this.txtMarca.Location = new Point(500, 150);
            this.Controls.Add(txtMarca);
            // 
            // txtModelo
            // 
            this.txtModelo = new RichTextBox();
            this.txtModelo.Location = new Point(500, 175);
            this.txtModelo.Size = new Size(170, 20);
            this.Controls.Add(txtModelo);
            // 
            // txtAno
            // 
            this.txtAno = new MaskedTextBox();
            this.txtAno.Mask = "0000";
            this.txtAno.Location = new Point(500, 200);
            this.txtAno.Size = new Size(30, 20);
            this.Controls.Add(txtAno);
            // 
            // txtCor
            // 
            this.txtCor = new RichTextBox();
            this.txtCor.Location = new Point(500, 225);
            this.txtCor.Size = new Size(170, 20);
            this.Controls.Add(txtCor);
            // 
            // txtRestricao
            // 
            this.txtRestricao = new RichTextBox();
            this.txtRestricao.Location = new Point(500, 250);
            this.txtRestricao.Size = new Size(170, 20);
            this.Controls.Add(txtRestricao);
            // 
            // cbPreco
            // 
            this.cbPreco = new ComboBox();
            this.cbPreco.Items.Add("R$ 50,00");
            this.cbPreco.Items.Add("R$ 100,00");
            this.cbPreco.Items.Add("R$ 150,00");
            this.cbPreco.Items.Add("R$ 200,00");
            this.cbPreco.Items.Add("R$ 250,00");
            this.cbPreco.AutoCompleteMode = AutoCompleteMode.Append;
            this.cbPreco.Location = new Point(500, 275);
            this.cbPreco.Size = new Size(170, 20);
            this.Controls.Add(cbPreco);
            // 
            // Home
            //  
            this.SetBounds(
                0,
                0,
                Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height
            );
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(imagemLogo);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(linkAjuda);
            this.Controls.Add(imagemTitle);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);

        }
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((txtMarca.Text != string.Empty)
                && (txtModelo.Text != string.Empty)
                && (txtAno.Text != string.Empty)
                && (txtCor.Text != string.Empty)
                && (txtRestricao.Text != string.Empty)
                && (cbPreco.Text != string.Empty))
                {
                    if (veiculo == null)
                    {
                        Controller.Veiculo.CadastrarVeiculo(
                        txtMarca.Text,
                        txtModelo.Text,
                        txtAno.Text,
                        txtCor.Text,
                        txtRestricao.Text,
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
                        txtMarca.Text,
                        txtModelo.Text,
                        txtAno.Text,
                        txtCor.Text,
                        txtRestricao.Text,
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