using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace LocaCar
{
    partial class CriarVeiculo : Form
    {

        private PictureBox imagemTitle;
        private PictureBox imagemLogo;
        private Button btnConfirmar;
        private Button btnCancelar;
        private LinkLabel linkAjuda;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipal;
        private ToolStripMenuItem homeMenuPrincipal;
        private ToolStripMenuItem sairMenuPrincipal;
        private ToolStripMenuItem cadastrarMenuPrincipal;
        private ToolStripMenuItem clienteCadastrarMenuPrincipal;
        private ToolStripMenuItem locacaoCadastrarMenuPrincipal;
        private ToolStripMenuItem veiculoCadastrarMenuPrincipal;
        private ToolStripMenuItem consultarMenuPrincipal;
        private ToolStripMenuItem clienteConsultarMenuPrincipal;
        private ToolStripMenuItem locacaoConsultarMenuPrincipal;
        private ToolStripMenuItem veiculoConsultarMenuPrincipal;
        private ToolStripMenuItem pesquisarMenuPrincipal;
        private ToolStripMenuItem clienteListarMenuPrincipal;
        private ToolStripMenuItem locacaoListarMenuPrincipal;
        private ToolStripMenuItem veiculoPesqusiarMenuPrincipal;
        private ToolStripMenuItem veiculoListarMenuPrincipal;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem ajudaMenuPrincipal;

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
        Form form;
        Model.Veiculo veiculo;
        public CriarVeiculo(Form form, int id = 0)
        {
            try
            {
                veiculo = Controller.Veiculo.GetVeiculo(id);
            }
            catch
            {

            }
            InitializeComponent(form, id > 0);
        }

        public void InitializeComponent(Form form, bool isUpdate)
        {

            this.btnConfirmar = new Button();
            this.btnCancelar = new Button();
            this.linkAjuda = new LinkLabel();
            this.menuStrip1 = new MenuStrip();
            this.menuPrincipal = new ToolStripMenuItem();
            this.cadastrarMenuPrincipal = new ToolStripMenuItem();
            this.consultarMenuPrincipal = new ToolStripMenuItem();
            this.clienteConsultarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoConsultarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoConsultarMenuPrincipal = new ToolStripMenuItem();
            this.pesquisarMenuPrincipal = new ToolStripMenuItem();
            this.clienteListarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoListarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesqusiarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoListarMenuPrincipal = new ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new ToolStripMenuItem();
            this.ajudaMenuPrincipal = new ToolStripMenuItem();
            this.imagemLogo = new PictureBox();
            this.homeMenuPrincipal = new ToolStripMenuItem();
            this.sairMenuPrincipal = new ToolStripMenuItem();
            this.clienteCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.imagemTitle = new PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            //
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = FlatStyle.System;
            this.btnConfirmar.ImeMode = ImeMode.NoControl;
            this.btnConfirmar.Location = new Point(445, 468);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new Size(90, 33);
            this.btnConfirmar.TabIndex = 40;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.ImeMode = ImeMode.NoControl;
            this.btnCancelar.Location = new Point(541, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(90, 33);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // linkAjuda
            // 
            this.linkAjuda.AutoSize = true;
            this.linkAjuda.BorderStyle = BorderStyle.Fixed3D;
            this.linkAjuda.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            this.linkAjuda.ImeMode = ImeMode.NoControl;
            this.linkAjuda.Location = new Point(637, 486);
            this.linkAjuda.Name = "linkAjuda";
            this.linkAjuda.Size = new Size(41, 15);
            this.linkAjuda.TabIndex = 38;
            this.linkAjuda.TabStop = true;
            this.linkAjuda.Text = "Ajuda";
            this.linkAjuda.LinkClicked += new LinkLabelLinkClickedEventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.menuPrincipal,
            this.cadastrarMenuPrincipal,
            this.consultarMenuPrincipal,
            this.pesquisarMenuPrincipal,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = RightToLeft.No;
            this.menuStrip1.Size = new Size(690, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.homeMenuPrincipal,
            this.sairMenuPrincipal});
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new Size(50, 20);
            this.menuPrincipal.Text = "Menu";
            // 
            // cadastrarMenuPrincipal
            // 
            this.cadastrarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clienteCadastrarMenuPrincipal,
            this.locacaoCadastrarMenuPrincipal,
            this.veiculoCadastrarMenuPrincipal});
            this.cadastrarMenuPrincipal.Name = "cadastrarMenuPrincipal";
            this.cadastrarMenuPrincipal.Size = new Size(69, 20);
            this.cadastrarMenuPrincipal.Text = "Cadastrar";
            // 
            // consultarMenuPrincipal
            // 
            this.consultarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clienteConsultarMenuPrincipal,
            this.locacaoConsultarMenuPrincipal,
            this.veiculoConsultarMenuPrincipal});
            this.consultarMenuPrincipal.Name = "consultarMenuPrincipal";
            this.consultarMenuPrincipal.Size = new Size(54, 20);
            this.consultarMenuPrincipal.Text = "Consultar";
            // 
            // clienteConsultarMenuPrincipal
            // 
            this.clienteConsultarMenuPrincipal.Name = "clienteConsultarMenuPrincipal";
            this.clienteConsultarMenuPrincipal.Size = new Size(118, 22);
            this.clienteConsultarMenuPrincipal.Text = "Cliente";
            this.clienteConsultarMenuPrincipal.Click += new EventHandler(this.clienteConsultarMenuPrincipal_Click);
            // 
            // locacaoConsultarMenuPrincipal
            // 
            this.locacaoConsultarMenuPrincipal.Name = "locacaoConsultarMenuPrincipal";
            this.locacaoConsultarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoConsultarMenuPrincipal.Text = "Locação";
            this.locacaoConsultarMenuPrincipal.Click += new EventHandler(this.locacaoConsultarMenuPrincipal_Click);
            // 
            // veiculoConsultarMenuPrincipal
            // 
            this.veiculoConsultarMenuPrincipal.Name = "veiculoConsultarMenuPrincipal";
            this.veiculoConsultarMenuPrincipal.Size = new Size(118, 22);
            this.veiculoConsultarMenuPrincipal.Text = "Veículo";
            this.veiculoConsultarMenuPrincipal.Click += new EventHandler(this.veiculoConsultarMenuPrincipal_Click);
            // 
            // pesquisarMenuPrincipal
            // 
            this.pesquisarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clienteListarMenuPrincipal,
            this.locacaoListarMenuPrincipal,
            this.veiculoListarMenuPrincipal});
            this.pesquisarMenuPrincipal.Name = "pesquisarMenuPrincipal";
            this.pesquisarMenuPrincipal.Size = new Size(69, 20);
            this.pesquisarMenuPrincipal.Text = "Listar";
            // 
            // clienteListarMenuPrincipal
            // 
            this.clienteListarMenuPrincipal.Name = "clienteListarMenuPrincipal";
            this.clienteListarMenuPrincipal.Size = new Size(118, 22);
            this.clienteListarMenuPrincipal.Text = "Cliente";
            this.clienteListarMenuPrincipal.Click += new EventHandler(this.clienteListarMenuPrincipal_Click);
            // 
            // locacaoListarMenuPrincipal
            // 
            this.locacaoListarMenuPrincipal.Name = "locacaoListarMenuPrincipal";
            this.locacaoListarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoListarMenuPrincipal.Text = "Locação";
            this.locacaoListarMenuPrincipal.Click += new EventHandler(this.locacaoListarMenuPrincipal_Click);
            // 
            // veiculoListarMenuPrincipal
            // 
            this.veiculoListarMenuPrincipal.Name = "veiculoListarMenuPrincipal";
            this.veiculoListarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoListarMenuPrincipal.Text = "Veículo";
            this.veiculoListarMenuPrincipal.Click += new EventHandler(this.veiculoListarMenuPrincipal_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.ajudaMenuPrincipal});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaMenuPrincipal
            // 
            this.ajudaMenuPrincipal.Name = "ajudaMenuPrincipal";
            this.ajudaMenuPrincipal.Size = new Size(180, 22);
            this.ajudaMenuPrincipal.Text = "Ajuda";
            this.ajudaMenuPrincipal.Click += new EventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // imagemLogo
            // 
            this.imagemLogo.BorderStyle = BorderStyle.Fixed3D;
            this.imagemLogo.Load("C:\\LocaCar\\Imagens\\download1.jpg");
            this.imagemLogo.ImeMode = ImeMode.NoControl;
            this.imagemLogo.Location = new Point(12, 379);
            this.imagemLogo.Name = "imagemLogo";
            this.imagemLogo.Size = new Size(131, 122);
            this.imagemLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemLogo.TabIndex = 41;
            this.imagemLogo.TabStop = false;
            // 
            // homeMenuPrincipal
            // 
            this.homeMenuPrincipal.Name = "homeMenuPrincipal";
            this.homeMenuPrincipal.Size = new Size(154, 22);
            this.homeMenuPrincipal.Text = "Menu Principal";
            this.homeMenuPrincipal.Click += new EventHandler(this.homeMenuPrincipal_Click);
            // 
            // sairMenuPrincipal
            // 
            this.sairMenuPrincipal.Name = "sairMenuPrincipal";
            this.sairMenuPrincipal.Size = new Size(154, 22);
            this.sairMenuPrincipal.Text = "Sair";
            this.sairMenuPrincipal.Click += new EventHandler(this.sairMenuPrincipal_Click);
            // 
            // clienteCadastrarMenuPrincipal
            // 
            this.clienteCadastrarMenuPrincipal.Name = "clienteCadastrarMenuPrincipal";
            this.clienteCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.clienteCadastrarMenuPrincipal.Text = "Cliente";
            this.clienteCadastrarMenuPrincipal.Click += new EventHandler(this.clienteCadastrarMenuPrincipal_Click);
            // 
            // locacaoCadastrarMenuPrincipal
            // 
            this.locacaoCadastrarMenuPrincipal.Name = "locacaoCadastrarMenuPrincipal";
            this.locacaoCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.locacaoCadastrarMenuPrincipal.Text = "Locação";
            this.locacaoCadastrarMenuPrincipal.Click += new EventHandler(this.locacaoCadastrarMenuPrincipal_Click);
            // 
            // veiculoCadastrarMenuPrincipal
            // 
            this.veiculoCadastrarMenuPrincipal.Name = "veiculoCadastrarMenuPrincipal";
            this.veiculoCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoCadastrarMenuPrincipal.Text = "Veículo";
            this.veiculoCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoCadastrarMenuPrincipal_Click);
            // 
            // imagemTitle
            // 
            this.imagemTitle.BackgroundImageLayout = ImageLayout.Stretch;
            this.imagemTitle.BorderStyle = BorderStyle.Fixed3D;
            this.imagemTitle.Load("C:\\LocaCar\\Imagens\\download1.jpg");
            this.imagemTitle.ImeMode = ImeMode.NoControl;
            this.imagemTitle.Location = new Point(12, 33);
            this.imagemTitle.Name = "imagemTitle";
            this.imagemTitle.Size = new Size(666, 102);
            this.imagemTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemTitle.TabIndex = 36;
            this.imagemTitle.TabStop = false;
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
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new Size(706, 546);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imagemTitle);
            this.Name = "Home";
            this.Text = "       CADASTRAR VEÍCULO";
            this.menuStrip1.ResumeLayout(true);
            this.menuStrip1.PerformLayout();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajudaMenuPrincipal_Click(object sender, EventArgs e)
        {
            Process processoLink = new Process();
            try
            {
                processoLink.StartInfo.UseShellExecute = true;
                processoLink.StartInfo.FileName = "https://portal.sc.senac.br/";
                processoLink.Start();
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro Link: " + error.Message);
            }
        }

        private void homeMenuPrincipal_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void sairMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.Show();
        }

        private void locacaoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarLocacao criarLocacao = new CriarLocacao(this);
            criarLocacao.Show();
        }
        private void veiculoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarVeiculo criarVeiculo = new CriarVeiculo(this);
            criarVeiculo.Show();
        }

        private void clienteListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarCliente listaCliente = new ListarCliente();
            listaCliente.Show();
        }
        private void locacaoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarLocacoes listaLocacao = new ListarLocacoes();
            listaLocacao.Show();
        }

        private void veiculoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarVeiculo listaVeiculo = new ListarVeiculo();
            listaVeiculo.Show();
        }
        private void clienteConsultarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }
        private void locacaoConsultarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarLocacao consultarLocacao = new ConsultarLocacao(this);
            consultarLocacao.Show();
        }
        private void veiculoConsultarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consultarVeiculo = new ConsultarVeiculo(this);
            consultarVeiculo.Show();
        }

        // private void LoadForm(object sender, EventArgs e)
        // {
        //     this.txtMarca.Text = veiculo.Marca;
        //     this.txtModelo.Text = veiculo.Modelo;
        //     this.txtAno.Text = veiculo.Ano;
        //     this.txtCor.Text = veiculo.Cor;
        //     this.txtRestricao.Text = veiculo.Restricao;
        //     this.cbPreco.SelectedValue = veiculo.Preco;
        // }
    }
}