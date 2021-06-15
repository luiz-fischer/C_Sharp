using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.View;
using System.Diagnostics;

namespace LocaCar
{
    partial class ConsultarLocacao : Form
    {
        private PictureBox imagemTitle;
        private PictureBox imagemLogo;
        private Button btnConfirmar;
        private Button btnCancelar;
        private LinkLabel linkAjuda;
        private ListView lvListaLocacoes;

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
        private Label lblLocacao;
        Form form;
        public ConsultarLocacao(Form form)
        {
            InitializeComponent(form);
        }

        public void InitializeComponent(Form form)
        {
            this.form = form;
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
            this.lvListaLocacoes = new ListView();
            this.lblLocacao = new Label();
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
            this.linkAjuda.LinkClicked += new LinkLabelLinkClickedEventHandler(this.ajudaMenuPrincipal_Click);
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
            // locacaoListarMenuPrincipal
            // 
            this.locacaoListarMenuPrincipal.Name = "locacaoListarMenuPrincipal";
            this.locacaoListarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoListarMenuPrincipal.Text = "Locação";
            this.locacaoListarMenuPrincipal.Click += new EventHandler(this.locacaoListarMenuPrincipal_Click);
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
            this.imagemLogo.Load("C:\\LocaCar\\Imagens\\imagemLogo.jpg");
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
            this.imagemTitle.Load("C:\\LocaCar\\Imagens\\imagemTitle.jpg");
            this.imagemTitle.ImeMode = ImeMode.NoControl;
            this.imagemTitle.Location = new Point(12, 33);
            this.imagemTitle.Name = "imagemTitle";
            this.imagemTitle.Size = new Size(666, 102);
            this.imagemTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemTitle.TabIndex = 36;
            this.imagemTitle.TabStop = false;
            //
            // lblLocacao
            //
            this.lblLocacao.Text = "Selecione uma Locação para Consultar/Exlcuir/Alterar!";
            this.lblLocacao.Location = new Point(150, 155);
            this.lblLocacao.Size = new Size(500, 15);
            this.lblLocacao.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.ForeColor = Color.Black;
            //
            // lvListarVeiculo
            //
            this.lvListaLocacoes.Location = new Point(12, 175);
            this.lvListaLocacoes.Size = new Size(670, 200);
            this.lvListaLocacoes.Font = new Font(this.Font, FontStyle.Bold);
            this.lvListaLocacoes.View = Details;
            this.lvListaLocacoes.FullRowSelect = true;
            this.lvListaLocacoes.GridLines = true;
            this.lvListaLocacoes.AllowColumnReorder = true;
            this.lvListaLocacoes.Sorting = SortOrder.None;
            this.lvListaLocacoes.MultiSelect = true;

            foreach (Model.Locacao locacao in Controller.Locacao.GetLocacoes())
            {

                    ListViewItem lvListaLocacao = new ListViewItem(locacao.IdLocacao.ToString());
                    Model.Cliente cliente = Controller.Cliente.GetCliente(locacao.IdCliente);
                    Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(locacao.IdLocacao);
                    lvListaLocacao.SubItems.Add(cliente.Nome.ToString());
                    lvListaLocacao.SubItems.Add(cliente.Cpf.ToString());
                    lvListaLocacao.SubItems.Add(locacao.DataLocacao.ToString("dd/MM/yyyy"));
                    lvListaLocacao.SubItems.Add(locacao.GetDataDevolucao().ToString("dd/MM/yyyy"));
                    lvListaLocacao.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                    lvListaLocacao.SubItems.Add(veiculo.Preco.ToString("C2"));
                    lvListaLocacao.SubItems.Add(locacao.ValorTotalLocacao().ToString("C2"));
                    lvListaLocacoes.Items.Add(lvListaLocacao);
            }
            this.lvListaLocacoes.MultiSelect = false;
            this.lvListaLocacoes.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Nome Completo", -2, HorizontalAlignment.Left);
            this.lvListaLocacoes.Columns.Add("C.P.F.", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Data Da Locação", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Data Da Devolução", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Quantidade de Dias", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Valor da Diária", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Valor Total Locação", -2, HorizontalAlignment.Center);
            this.Controls.Add(lvListaLocacoes);
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
            this.Controls.Add(this.lblLocacao);
            this.Name = "Home";
            this.Text = "       CONSULTAR LOCAÇÕES";
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string idLocacao = this.lvListaLocacoes.SelectedItems[0].Text;
                Model.Locacao locacao = Controller.Locacao.GetLocacao(Int32.Parse(idLocacao));
                EditarLocacao editarLocacao = new EditarLocacao(this, locacao);
                editarLocacao.Show();
            }
            catch
            {
                MessageBox.Show("Selecione uma Locação!");
            }
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
            ConsultarLocacao consultarCliente = new ConsultarLocacao(this);
            consultarCliente.Show();
        }
        private void veiculoConsultarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consultarVeiculo = new ConsultarVeiculo(this);
            consultarVeiculo.Show();
        }

    }

}