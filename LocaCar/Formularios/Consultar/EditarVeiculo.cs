using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;

namespace LocaCar
{
    partial class EditarVeiculo : Form
    {
        private PictureBox imagemTitle;
        private PictureBox imagemLogo;
        private Button btnDeletarCliente;
        private Button btnAlterarCliente;
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
        private ToolStripMenuItem listarMenuPrincipal;
        private ToolStripMenuItem clienteListarMenuPrincipal;
        private ToolStripMenuItem locacaoListarMenuPrincipal;
        private ToolStripMenuItem veiculoPesqusiarMenuPrincipal;
        private ToolStripMenuItem veiculoListarMenuPrincipal;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem ajudaMenuPrincipal;
        private Label lblIdVeiculo;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblAno;
        private Label lblCor;
        private Label lblRestricao;
        private Label lblPreco;
        Form form;

        int idVeiculo;
        Model.Veiculo Veiculo;

        public EditarVeiculo(Form form, Model.Veiculo veiculo)
        {
            InitializeComponent(form, veiculo);
        }

        public void InitializeComponent(Form form, Model.Veiculo veiculo)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Home));
            this.btnDeletarCliente = new Button();
            this.btnAlterarCliente = new Button();
            this.btnCancelar = new Button();
            this.linkAjuda = new LinkLabel();
            this.menuStrip1 = new MenuStrip();
            this.menuPrincipal = new ToolStripMenuItem();
            this.cadastrarMenuPrincipal = new ToolStripMenuItem();
            this.consultarMenuPrincipal = new ToolStripMenuItem();
            this.clienteConsultarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoConsultarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoConsultarMenuPrincipal = new ToolStripMenuItem();
            this.listarMenuPrincipal = new ToolStripMenuItem();
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
            this.lblPreco = new Label();
            this.lblRestricao = new Label();
            this.lblCor = new Label();
            this.lblAno = new Label();
            this.lblModelo = new Label();
            this.lblMarca = new Label();
            this.lblIdVeiculo = new Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            //
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.FlatStyle = FlatStyle.System;
            this.btnDeletarCliente.ImeMode = ImeMode.NoControl;
            this.btnDeletarCliente.Location = new Point(349, 468);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new Size(90, 33);
            this.btnDeletarCliente.TabIndex = 40;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            this.btnDeletarCliente.Click += new EventHandler(this.btnDeletarVeiculo_Click);
            //
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.FlatStyle = FlatStyle.System;
            this.btnAlterarCliente.ImeMode = ImeMode.NoControl;
            this.btnAlterarCliente.Location = new Point(445, 468);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new Size(90, 33);
            this.btnAlterarCliente.TabIndex = 40;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new EventHandler(this.btnAlterarVeiculo_Click);
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
            this.linkAjuda.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkAjuda_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.menuPrincipal,
            this.cadastrarMenuPrincipal,
            this.consultarMenuPrincipal,
            this.listarMenuPrincipal,
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
            this.clienteConsultarMenuPrincipal.Click += new EventHandler(this.clienteConsultarMenuPrinciapl_Click);
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
            // listarMenuPrincipal
            // 
            this.listarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clienteListarMenuPrincipal,
            this.locacaoListarMenuPrincipal,
            this.veiculoListarMenuPrincipal});
            this.listarMenuPrincipal.Name = "listarMenuPrincipal";
            this.listarMenuPrincipal.Size = new Size(69, 20);
            this.listarMenuPrincipal.Text = "Listar";
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
            // lblIdVeiculo
            //
            this.lblIdVeiculo.Text = "ID do Veículo: " + veiculo.IdVeiculo;
            this.lblIdVeiculo.Location = new Point(200, 175);
            this.lblIdVeiculo.Size = new Size(600, 30);
            this.lblIdVeiculo.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblIdVeiculo.ForeColor = Color.Black;
            //
            // lblMarca
            //
            this.lblMarca.Text = "Marca: " + veiculo.Marca;
            this.lblMarca.Location = new Point(200, 225);
            this.lblMarca.Size = new Size(700, 30);
            this.lblMarca.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblMarca.ForeColor = Color.Black;
            //
            // lblModelo
            //
            this.lblModelo.Text = "Modelo: " + veiculo.Modelo;
            this.lblModelo.Location = new Point(200, 275);
            this.lblModelo.Size = new Size(600, 30);
            this.lblModelo.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblModelo.ForeColor = Color.Black;
            //
            // lblAno
            //
            this.lblAno.Text = "Ano de Fabricação: " + veiculo.Ano;
            this.lblAno.Location = new Point(200, 325);
            this.lblAno.Size = new Size(600, 30);
            this.lblAno.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblAno.ForeColor = Color.Black;
            //
            // lblCor
            //
            this.lblCor.Text = "Cor do Veículo: " + veiculo.Preco.ToString();
            this.lblCor.Location = new Point(200, 375);
            this.lblCor.Size = new Size(600, 30);
            this.lblCor.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblCor.ForeColor = Color.Black;
            //
            // lblRestricao
            //
            this.lblRestricao.Text = "Restrição: " + veiculo.Preco.ToString();
            this.lblRestricao.Location = new Point(200, 375);
            this.lblRestricao.Size = new Size(600, 30);
            this.lblRestricao.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblRestricao.ForeColor = Color.Black;
            //
            // lblPreco
            //
            this.lblPreco.Text = "Valor da Locação: " + veiculo.Preco.ToString();
            this.lblPreco.Location = new Point(200, 375);
            this.lblPreco.Size = new Size(600, 30);
            this.lblPreco.Font = new Font(FontFamily.GenericSansSerif, 16F, FontStyle.Bold);
            this.lblPreco.ForeColor = Color.Black;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new Size(706, 546);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(lblPreco);
            this.Controls.Add(lblRestricao);
            this.Controls.Add(lblCor);
            this.Controls.Add(lblAno);
            this.Controls.Add(lblModelo);
            this.Controls.Add(lblMarca);
            this.Controls.Add(lblIdVeiculo);
            this.Name = "Home";
            this.Text = "       EDITAR VEÍCULO";
            this.menuStrip1.ResumeLayout(true);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);
            this.idVeiculo = veiculo.IdVeiculo;
            this.Veiculo = veiculo;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                Process.Start(
                    "https://portal.sc.senac.br/"
                );
            }
        }
        private void ajudaMenuPrincipal_Click(object sender, EventArgs e)
        {
            {
                Process.Start(
                    "https://portal.sc.senac.br/"
                );
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
            CriarCliente criarCliente = new CriarCliente(this);
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
        private void clienteConsultarMenuPrinciapl_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente(this);
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

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            CriarVeiculo criarCliente = new CriarVeiculo(this, idVeiculo);
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