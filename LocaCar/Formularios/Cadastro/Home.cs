using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using LocaCar;

namespace Locacar
{
    public class Home : Form
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
        private ToolStripMenuItem veiculoLeveCadastrarMenuPrincipal;
        private ToolStripMenuItem veiculoPesadoCadastrarMenuPrincipal;
        private ToolStripMenuItem excluirMenuPrincipal;
        private ToolStripMenuItem clienteExcluirMenuPrincipal;
        private ToolStripMenuItem locacaoExcluirMenuPrincipal;
        private ToolStripMenuItem veiculoExcluirMenuPrincipal;
        private ToolStripMenuItem veiculoLeveExcluirMenuPrincipal;
        private ToolStripMenuItem veiculoPesadoExcluirMenuPrincipal;
        private ToolStripMenuItem pesquisarMenuPrincipal;
        private ToolStripMenuItem clientePesquisarMenuPrincipal;
        private ToolStripMenuItem locacaoPesquisarMenuPrincipal;
        private ToolStripMenuItem veiculoListarMenuPrincipal;
        private ToolStripMenuItem veiculoLevelistarMenuPrincipal;
        private ToolStripMenuItem veiculoPesadolistarMenuPrincipal;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem ajudaMenuPrincipal;

        public Home()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Home());
        }
        private void InitializeComponent()
        {

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Home));
            this.btnConfirmar = new Button();
            this.btnCancelar = new Button();
            this.linkAjuda = new LinkLabel();
            this.menuStrip1 = new MenuStrip();
            this.menuPrincipal = new ToolStripMenuItem();
            this.cadastrarMenuPrincipal = new ToolStripMenuItem();
            this.excluirMenuPrincipal = new ToolStripMenuItem();
            this.clienteExcluirMenuPrincipal = new ToolStripMenuItem();
            this.locacaoExcluirMenuPrincipal = new ToolStripMenuItem();
            this.veiculoExcluirMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLeveExcluirMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadoExcluirMenuPrincipal = new ToolStripMenuItem();
            this.pesquisarMenuPrincipal = new ToolStripMenuItem();
            this.clientePesquisarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoPesquisarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoListarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLevelistarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadolistarMenuPrincipal = new ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new ToolStripMenuItem();
            this.ajudaMenuPrincipal = new ToolStripMenuItem();
            this.imagemLogo = new PictureBox();
            this.homeMenuPrincipal = new ToolStripMenuItem();
            this.sairMenuPrincipal = new ToolStripMenuItem();
            this.clienteCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLeveCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.imagemTitle = new PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
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
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
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
            this.excluirMenuPrincipal,
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
            // excluirMenuPrincipal
            // 
            this.excluirMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clienteExcluirMenuPrincipal,
            this.locacaoExcluirMenuPrincipal,
            this.veiculoExcluirMenuPrincipal});
            this.excluirMenuPrincipal.Name = "excluirMenuPrincipal";
            this.excluirMenuPrincipal.Size = new Size(54, 20);
            this.excluirMenuPrincipal.Text = "Excluir";
            // 
            // clienteExcluirMenuPrincipal
            // 
            this.clienteExcluirMenuPrincipal.Name = "clienteExcluirMenuPrincipal";
            this.clienteExcluirMenuPrincipal.Size = new Size(118, 22);
            this.clienteExcluirMenuPrincipal.Text = "Cliente";
            // 
            // locacaoExcluirMenuPrincipal
            // 
            this.locacaoExcluirMenuPrincipal.Name = "locacaoExcluirMenuPrincipal";
            this.locacaoExcluirMenuPrincipal.Size = new Size(118, 22);
            this.locacaoExcluirMenuPrincipal.Text = "Locação";
            // 
            // veiculoExcluirMenuPrincipal
            // 
            this.veiculoExcluirMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.veiculoLeveExcluirMenuPrincipal,
            this.veiculoPesadoExcluirMenuPrincipal});
            this.veiculoExcluirMenuPrincipal.Name = "veiculoExcluirMenuPrincipal";
            this.veiculoExcluirMenuPrincipal.Size = new Size(118, 22);
            this.veiculoExcluirMenuPrincipal.Text = "Veículo";
            // 
            // veiculoLeveExcluirMenuPrincipal
            // 
            this.veiculoLeveExcluirMenuPrincipal.Name = "veiculoLeveExcluirMenuPrincipal";
            this.veiculoLeveExcluirMenuPrincipal.Size = new Size(153, 22);
            this.veiculoLeveExcluirMenuPrincipal.Text = "Veículo Leve";
            // 
            // veiculoPesadoExcluirMenuPrincipal
            // 
            this.veiculoPesadoExcluirMenuPrincipal.Name = "veiculoPesadoExcluirMenuPrincipal";
            this.veiculoPesadoExcluirMenuPrincipal.Size = new Size(153, 22);
            this.veiculoPesadoExcluirMenuPrincipal.Text = "Veículo Pesado";
            // 
            // pesquisarMenuPrincipal
            // 
            this.pesquisarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.clientePesquisarMenuPrincipal,
            this.locacaoPesquisarMenuPrincipal,
            this.veiculoListarMenuPrincipal});
            this.pesquisarMenuPrincipal.Name = "pesquisarMenuPrincipal";
            this.pesquisarMenuPrincipal.Size = new Size(69, 20);
            this.pesquisarMenuPrincipal.Text = "Listar";
            // 
            // clientePesquisarMenuPrincipal
            // 
            this.clientePesquisarMenuPrincipal.Name = "clientePesquisarMenuPrincipal";
            this.clientePesquisarMenuPrincipal.Size = new Size(118, 22);
            this.clientePesquisarMenuPrincipal.Text = "Cliente";
            this.clientePesquisarMenuPrincipal.Click += new EventHandler(this.clienteListarMenuPrincipal_Click);

            // 
            // locacaoPesquisarMenuPrincipal
            // 
            this.locacaoPesquisarMenuPrincipal.Name = "locacaoPesquisarMenuPrincipal";
            this.locacaoPesquisarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoPesquisarMenuPrincipal.Text = "Locação";
            // veiculoListarMenuPrincipal
            // 
            this.veiculoListarMenuPrincipal.Name = "veiculoListarMenuPrincipal";
            this.veiculoListarMenuPrincipal.Size = new Size(118, 22);
            this.veiculoListarMenuPrincipal.Text = "Veículos";
            this.veiculoListarMenuPrincipal.Click += new EventHandler(this.veiculoListarMenuPrincipal_Click);

            // 
            // veiculoListarMenuPrincipal
            // 
            this.veiculoListarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.veiculoLevelistarMenuPrincipal,
            this.veiculoPesadolistarMenuPrincipal});
            this.veiculoListarMenuPrincipal.Name = "veiculoListarMenuPrincipal";
            this.veiculoListarMenuPrincipal.Size = new Size(118, 22);
            this.veiculoListarMenuPrincipal.Text = "Veículo";
            // // 
            // // veiculoLevelistarMenuPrincipal
            // // 
            // this.veiculoLevelistarMenuPrincipal.Name = "veiculoLevelistarMenuPrincipal";
            // this.veiculoLevelistarMenuPrincipal.Size = new Size(153, 22);
            // this.veiculoLevelistarMenuPrincipal.Text = "Veículo Leve";
            // this.veiculoLevelistarMenuPrincipal.Click += new EventHandler(this.veiculoLeveListarMenuPrincipal_Click);
            // // 
            // // veiculoPesadolistarMenuPrincipal
            // // 
            // this.veiculoPesadolistarMenuPrincipal.Name = "veiculoPesadolistarMenuPrincipal";
            // this.veiculoPesadolistarMenuPrincipal.Size = new Size(153, 22);
            // this.veiculoPesadolistarMenuPrincipal.Text = "Veículo Pesado";
            // this.veiculoPesadolistarMenuPrincipal.Click += new EventHandler(this.veiculoPesadoListarMenuPrincipal_Click);
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
            this.veiculoCadastrarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.veiculoLeveCadastrarMenuPrincipal,
            this.veiculoPesadoCadastrarMenuPrincipal});
            this.veiculoCadastrarMenuPrincipal.Name = "veiculoCadastrarMenuPrincipal";
            this.veiculoCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoCadastrarMenuPrincipal.Text = "Veículo";
            // 
            // veiculoLeveCadastrarMenuPrincipal
            // 
            this.veiculoLeveCadastrarMenuPrincipal.Name = "veiculoLeveCadastrarMenuPrincipal";
            this.veiculoLeveCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoLeveCadastrarMenuPrincipal.Text = "Veículo Leve";
            this.veiculoLeveCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoLeveCadastrarMenuPrincipal_Click);
            // 
            // veiculoPesadoCadastrarMenuPrincipal
            // 
            this.veiculoPesadoCadastrarMenuPrincipal.Name = "veiculoPesadoCadastrarMenuPrincipal";
            this.veiculoPesadoCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoPesadoCadastrarMenuPrincipal.Text = "Veículo Pesado";
            this.veiculoPesadoCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoPesadoCadastrarMenuPrincipal_Click);
            // 
            // imagemTitle
            // 
            this.imagemTitle.BackgroundImageLayout = ImageLayout.Stretch;
            this.imagemTitle.BorderStyle = BorderStyle.Fixed3D;
            this.imagemTitle.Load("C:\\Users\\Luiz\\Pictures\\download.jpg");
            this.imagemTitle.ImeMode = ImeMode.NoControl;
            this.imagemTitle.Location = new Point(12, 33);
            this.imagemTitle.Name = "imagemTitle";
            this.imagemTitle.Size = new Size(666, 102);
            this.imagemTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemTitle.TabIndex = 36;
            this.imagemTitle.TabStop = false;
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
            this.Text = "       MENU PRINCIPAL";
            this.menuStrip1.ResumeLayout(true);
            this.menuStrip1.PerformLayout(); 
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);

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
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                     $"Beleza!\n" +
                    MessageBoxButtons.OK
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
            // CriarLocacao criarLocacao = new CriarLocacao(this);
            // criarLocacao.Show();
        }

        private void veiculoLeveCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            // CriarVeiculoLeve criarVeiculoLeve = new CriarVeiculoLeve();
            // criarVeiculoLeve.Show();
        }

        private void veiculoPesadoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
        //     CriarVeiculoPesado criarVeiculoPesado = new CriarVeiculoPesado();
        //     criarVeiculoPesado.Show();
        }

        private void clienteListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            // ListarCliente listaClienteClick = new ListarCliente();
            // listaClienteClick.Show();
        }
        private void veiculoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarVeiculo listaVeiculoLeve = new ListarVeiculo();
            listaVeiculoLeve.Show();
        }
        private void veiculoPesadoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            // ListarVeiculoPesado listaVeiculoPesado = new ListarVeiculoPesado();
            // listaVeiculoPesado.Show();
        }

    }
}