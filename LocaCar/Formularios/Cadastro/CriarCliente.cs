using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LocaCar
{
    public partial class CriarCliente : Form
    {
        Library.PictureBox imagemTitle;
        Library.PictureBox imagemLogo;
        Library.Button btnConfirmar;
        Library.Button btnCancelar;
        Library.LinkLabelAjuda linkAjuda;
        private Label lblNome;
        private Label lblDataNasc;
        private Label lblCpf;
        private Label lblDiasDevolucao;
        private ErrorProvider TextErrorNome;
        private ErrorProvider TextErrorNasc;
        private ErrorProvider TextErrorCpf;
        private ErrorProvider TextErrorDev;
        private RichTextBox txtNome;
        private MaskedTextBox txtDtNasc;
        private MaskedTextBox txtCpf;
        private ComboBox cbDiasDevolucao;
        Model.Cliente cliente;

        public CriarCliente(int id = 0)
        {
            try
            {
                cliente = Controller.Cliente.GetCliente(id);
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
            this.cbDiasDevolucao = new ComboBox();
            this.txtCpf = new MaskedTextBox();
            this.txtDtNasc = new MaskedTextBox();
            this.txtNome = new RichTextBox();
            this.lblDiasDevolucao = new Label();
            this.lblCpf = new Label();
            this.lblDataNasc = new Label();
            this.lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            //
            // btnConfirmar
            //
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            //
            // lblNome
            // 
            this.lblNome.Text = "Nome Completo :";
            this.lblNome.Location = new Point(10, 150);
            this.lblNome.Size = new Size(200, 20);
            this.lblNome.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            //
            // lblDataNasc
            // 
            this.lblDataNasc.Text = "Data de Nascimento :";
            this.lblDataNasc.Location = new Point(10, 175);
            this.lblDataNasc.Size = new Size(200, 20);
            this.lblDataNasc.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            //
            // lblCpf
            // 
            this.lblCpf.Text = "CPF :";
            this.lblCpf.Location = new Point(10, 200);
            this.lblCpf.Size = new Size(200, 20);
            this.lblCpf.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            //
            // lblDiasDevolucao
            // 
            this.lblDiasDevolucao.Text = "Dias Para Devolução :";
            this.lblDiasDevolucao.Location = new Point(10, 225);
            this.lblDiasDevolucao.Size = new Size(200, 20);
            this.lblDiasDevolucao.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            //
            // txtNome
            // 
            this.txtNome.Size = new Size(175, 20);
            this.txtNome.Location = new Point(500, 150);
            this.TextErrorNome = new ErrorProvider();
            //
            // txtDtNasc
            // 
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Size = new Size(80, 20);
            this.txtDtNasc.Location = new Point(500, 175);
            this.TextErrorNasc = new ErrorProvider();
            //
            // txtCpf
            // 
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.ReadOnly = isUpdate;
            this.TextErrorCpf = new ErrorProvider();
            this.txtCpf.Location = new Point(500, 200);
            this.txtCpf.Size = new Size(100, 20);
            //
            // cbDiasDevolucao
            // 
            this.cbDiasDevolucao.Items.Add("1 Dia");
            this.cbDiasDevolucao.Items.Add("5 Dias");
            this.cbDiasDevolucao.Items.Add("10 Dias");
            this.cbDiasDevolucao.Items.Add("15 Dias");
            this.cbDiasDevolucao.Items.Add("20 Dias");
            this.cbDiasDevolucao.AutoCompleteMode = AutoCompleteMode.Append;
            this.cbDiasDevolucao.Location = new Point(500, 225);
            this.cbDiasDevolucao.Size = new Size(170, 20);
            this.TextErrorDev = new ErrorProvider();
            // 
            // Home
            //  
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
            this.Controls.Add(lblNome);
            this.Controls.Add(lblDataNasc);
            this.Controls.Add(lblCpf);
            this.Controls.Add(lblDiasDevolucao);
            this.Controls.Add(txtNome);
            this.Controls.Add(txtDtNasc);
            this.Controls.Add(txtCpf);
            this.Controls.Add(cbDiasDevolucao);
            this.Text = "       CADASTRAR CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);

        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                Regex nome = new Regex(@"^[a-zA-Z0-9\s]");
                Regex nascimento = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]s|1[012])[- /.](19|20)\d\d$");
                Regex cpf = new Regex(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$");
                if ((!nome.IsMatch(this.txtNome.Text)))
                {
                    this.TextErrorNome.SetError(this.txtNome, "Apenas letras!");
                }
                else if (!nascimento.IsMatch(this.txtDtNasc.Text))
                {
                    this.TextErrorNasc.SetError(this.txtDtNasc, "Formato Inválido!");
                }
                else if (!cpf.IsMatch(this.txtCpf.Text))
                {
                    this.TextErrorCpf.SetError(this.txtCpf, "CPF Inválido!");
                }
                else if (cbDiasDevolucao.SelectedItem == null)
                {
                    this.TextErrorDev.SetError(this.cbDiasDevolucao, "Quantidade de dias para devolução!");
                }
                else if ((txtNome.Text != string.Empty)
                && (txtDtNasc.Text != string.Empty)
                && (txtCpf.Text != string.Empty)
                && (cbDiasDevolucao.Text != string.Empty))
                {
                    if (cliente == null)
                    {
                        Controller.Cliente.CadastrarCliente(
                        txtNome.Text,
                        txtDtNasc.Text,
                        txtCpf.Text,
                        cbDiasDevolucao.Text == "1 Dia" ? 1 :
                        cbDiasDevolucao.Text == "5 Dias" ? 5 :
                        cbDiasDevolucao.Text == "10 Dias" ? 10 :
                        cbDiasDevolucao.Text == "15 Dias" ? 15 : 20
                        );
                        this.TextErrorNasc.SetError(this.txtNome, String.Empty);
                        this.TextErrorNasc.SetError(this.txtDtNasc, String.Empty);
                        this.TextErrorCpf.SetError(this.txtCpf, String.Empty);
                        this.TextErrorDev.SetError(this.cbDiasDevolucao, String.Empty);
                        MessageBox.Show("Cadastrado Com Sucesso!");

                    }
                    else
                    {
                        Controller.Cliente.AtualizaCliente(
                        cliente.IdCliente,
                        txtNome.Text,
                        txtDtNasc.Text,
                        txtCpf.Text,
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