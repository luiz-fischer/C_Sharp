using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LocaCar
{
    public partial class CriarCliente : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.Label lblNome;
        private Library.Label lblDataNasc;
        private Library.Label lblCpf;
        private Library.Label lblDiasDevolucao;
        private Library.ComboBox cbDiasDevolucao;
        private ErrorProvider TextErrorNome;
        private ErrorProvider TextErrorNasc;
        private ErrorProvider TextErrorCpf;
        private ErrorProvider TextErrorDev;
        private Library.RichTextBox txtNome;
        private Library.MaskedTextBox mskTxtDtNasc;
        private Library.MaskedTextBox mskTxtCpf;
        private readonly Model.Cliente cliente;

        public CriarCliente(int id = 0)
        {
            try
            {
                cliente = Controller.Cliente.GetCliente(id);
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }
            InitializeComponent(id > 0);
        }

        public void InitializeComponent(bool isUpdate)
        {
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.btnConfirmar = new Library.Button("btnConfirmar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.cbDiasDevolucao = new Library.ComboBox("cbDiasDevolucao");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.txtNome = new Library.RichTextBox();
            this.lblDiasDevolucao = new Library.Label();
            this.lblCpf = new Library.Label();
            this.lblDataNasc = new Library.Label();
            this.lblNome = new Library.Label();
            this.mskTxtCpf = new Library.MaskedTextBox();
            this.mskTxtDtNasc = new Library.MaskedTextBox();
            //
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            //
            // lblNome 
            this.lblNome.Text = "Nome Completo :";
            this.lblNome.Location = new Point(230, 180);
            //
            // lblDataNasc
            this.lblDataNasc.Text = "Data de Nascimento :";
            this.lblDataNasc.Location = new Point(230, 220);
            //
            // lblCpf
            this.lblCpf.Text = "CPF :";
            this.lblCpf.Location = new Point(230, 260);
            //
            // lblDiasDevolucao
            this.lblDiasDevolucao.Text = "Dias Para Devolução :";
            this.lblDiasDevolucao.Location = new Point(230, 300);
            //
            // txtNome
            this.txtNome.Size = new Size(175, 20);
            this.txtNome.Location = new Point(955, 180);
            this.TextErrorNome = new ErrorProvider();
            //
            // mskTxtDtNasc
            this.mskTxtDtNasc.Mask = "00/00/0000";
            this.mskTxtDtNasc.Location = new Point(955, 220);
            this.TextErrorNasc = new ErrorProvider();
            //
            //  mskTxtCpf
            this.mskTxtCpf.Mask = "000,000,000-00";
            this.mskTxtCpf.Location = new Point(955, 260);
            this.TextErrorCpf = new ErrorProvider();
            //
            // cbDiasDevolucao
            this.TextErrorDev = new ErrorProvider();
            // 
            // Home 
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDiasDevolucao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskTxtDtNasc);
            this.Controls.Add(this.mskTxtCpf);
            this.Controls.Add(this.cbDiasDevolucao);

        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                Regex nome = new(@"^[a-zA-Z\s]");
                Regex nascimento = new(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]s|1[012])[- /.](19|20)\d\d$");
                Regex cpf = new(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$");
                if (!nome.IsMatch(this.txtNome.Text))
                {
                    this.TextErrorNome.SetError(this.txtNome, "Apenas letras!");
                }
                else if (!nascimento.IsMatch(this.mskTxtDtNasc.Text))
                {
                    this.TextErrorNasc.SetError(this.mskTxtDtNasc, "Formato Inválido!");
                }
                else if (!cpf.IsMatch(this.mskTxtCpf.Text))
                {
                    this.TextErrorCpf.SetError(this.mskTxtCpf, "CPF Inválido!");
                }
                else if (cbDiasDevolucao.SelectedItem == null)
                {
                    this.TextErrorDev.SetError(this.cbDiasDevolucao, "Quantidade de dias para devolução!");
                }
                else if ((txtNome.Text != string.Empty)
                && (mskTxtDtNasc.Text != string.Empty)
                && (mskTxtCpf.Text != string.Empty)
                && (cbDiasDevolucao.Text != string.Empty))
                {
                        if (cliente == null)
                    {
                        Controller.Cliente.CadastrarCliente(
                        txtNome.Text,
                        mskTxtDtNasc.Text,
                        mskTxtCpf.Text,
                        cbDiasDevolucao.Text == "1 Dia" ? 1 :
                        cbDiasDevolucao.Text == "5 Dias" ? 5 :
                        cbDiasDevolucao.Text == "10 Dias" ? 10 :
                        cbDiasDevolucao.Text == "15 Dias" ? 15 : 20
                        );
                        this.TextErrorNasc.SetError(this.txtNome, String.Empty);
                        this.TextErrorNasc.SetError(this.mskTxtDtNasc, String.Empty);
                        this.TextErrorCpf.SetError(this.mskTxtCpf, String.Empty);
                        this.TextErrorDev.SetError(this.cbDiasDevolucao, String.Empty);
                        MessageBox.Show("Cadastrado Com Sucesso!");

                    }
                    else
                    {
                        Controller.Cliente.AtualizaCliente(
                        cliente.IdCliente,
                        txtNome.Text,
                        mskTxtDtNasc.Text,
                        mskTxtCpf.Text,
                        cbDiasDevolucao.Text == "1 Dia" ? 1 :
                        cbDiasDevolucao.Text == "5 Dias" ? 5 :
                        cbDiasDevolucao.Text == "10 Dias" ? 10 :
                        cbDiasDevolucao.Text == "15 Dias" ? 15 : 20
                        );
                        MessageBox.Show("Alteração Feita!");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Preencha Todos Os Campos!");
            }
        }
    }
}