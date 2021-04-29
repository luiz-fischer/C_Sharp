using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace LocaCar.Formularios.Cadastro
{
    public class CriarVeiculoLeve : Form
    {

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
        private ToolStripMenuItem veiculoPesqusiarMenuPrincipal;
        private ToolStripMenuItem veiculoLevePesquisarMenuPrincipal;
        private ToolStripMenuItem veiculoPesadoPesquisarMenuPrincipal;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem ajudaMenuPrincipal;
        private PictureBox imagemTitle;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblAnoDeFabricacao;
        private Label lblPreco;
        private Label lblCor;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCor;
        private MaskedTextBox maskedAnoFabricacao;
        private MaskedTextBox maskedPreco;

        public CriarVeiculoLeve()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CriarVeiculoLeve());
        }
        private void InitializeComponent()
        {

            ComponentResourceManager resources = new ComponentResourceManager(typeof(CriarVeiculoLeve));
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
            this.veiculoPesqusiarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLevePesquisarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadoPesquisarMenuPrincipal = new ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new ToolStripMenuItem();
            this.ajudaMenuPrincipal = new ToolStripMenuItem();
            this.lblMarca = new Label();
            this.lblModelo = new Label();
            this.lblAnoDeFabricacao = new Label();
            this.lblPreco = new Label();
            this.lblCor = new Label();
            this.txtMarca = new TextBox();
            this.txtModelo = new TextBox();
            this.txtCor = new TextBox();
            this.maskedAnoFabricacao = new MaskedTextBox();
            this.maskedPreco = new MaskedTextBox();
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
            ((ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = FlatStyle.System;
            this.btnConfirmar.ImeMode = ImeMode.NoControl;
            this.btnConfirmar.Location = new Point(445, 468);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new Size(90, 33);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.ImeMode = ImeMode.NoControl;
            this.btnCancelar.Location = new Point(541, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(90, 33);
            this.btnCancelar.TabIndex = 23;
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
            this.linkAjuda.TabIndex = 22;
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
            this.menuStrip1.TabIndex = 21;
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
            this.veiculoPesqusiarMenuPrincipal});
            this.pesquisarMenuPrincipal.Name = "pesquisarMenuPrincipal";
            this.pesquisarMenuPrincipal.Size = new Size(69, 20);
            this.pesquisarMenuPrincipal.Text = "Pesquisar";
            // 
            // clientePesquisarMenuPrincipal
            // 
            this.clientePesquisarMenuPrincipal.Name = "clientePesquisarMenuPrincipal";
            this.clientePesquisarMenuPrincipal.Size = new Size(118, 22);
            this.clientePesquisarMenuPrincipal.Text = "Cliente";
            // 
            // locacaoPesquisarMenuPrincipal
            // 
            this.locacaoPesquisarMenuPrincipal.Name = "locacaoPesquisarMenuPrincipal";
            this.locacaoPesquisarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoPesquisarMenuPrincipal.Text = "Locação";
            // 
            // veiculoPesqusiarMenuPrincipal
            // 
            this.veiculoPesqusiarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.veiculoLevePesquisarMenuPrincipal,
            this.veiculoPesadoPesquisarMenuPrincipal});
            this.veiculoPesqusiarMenuPrincipal.Name = "veiculoPesqusiarMenuPrincipal";
            this.veiculoPesqusiarMenuPrincipal.Size = new Size(118, 22);
            this.veiculoPesqusiarMenuPrincipal.Text = "Veículo";
            // 
            // veiculoLevePesquisarMenuPrincipal
            // 
            this.veiculoLevePesquisarMenuPrincipal.Name = "veiculoLevePesquisarMenuPrincipal";
            this.veiculoLevePesquisarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoLevePesquisarMenuPrincipal.Text = "Veículo Leve";
            // 
            // veiculoPesadoPesquisarMenuPrincipal
            // 
            this.veiculoPesadoPesquisarMenuPrincipal.Name = "veiculoPesadoPesquisarMenuPrincipal";
            this.veiculoPesadoPesquisarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoPesadoPesquisarMenuPrincipal.Text = "Veículo Pesado";
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
            // this.ajudaMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.AJUDA;
            this.ajudaMenuPrincipal.Name = "ajudaMenuPrincipal";
            this.ajudaMenuPrincipal.Size = new Size(180, 22);
            this.ajudaMenuPrincipal.Text = "Ajuda";
            this.ajudaMenuPrincipal.Click += new EventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new Point(9, 174);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new Size(55, 18);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new Point(9, 211);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new Size(64, 18);
            this.lblModelo.TabIndex = 27;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAnoDeFabricacao
            // 
            this.lblAnoDeFabricacao.AutoSize = true;
            this.lblAnoDeFabricacao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoDeFabricacao.Location = new Point(9, 257);
            this.lblAnoDeFabricacao.Name = "lblAnoDeFabricacao";
            this.lblAnoDeFabricacao.Size = new Size(149, 18);
            this.lblAnoDeFabricacao.TabIndex = 28;
            this.lblAnoDeFabricacao.Text = "Ano de Fabricação";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new Point(9, 297);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new Size(161, 18);
            this.lblPreco.TabIndex = 29;
            this.lblPreco.Text = "Preço para Locação";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new Point(9, 336);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new Size(120, 18);
            this.lblCor.TabIndex = 30;
            this.lblCor.Text = "Cor do Veículo";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new Point(445, 170);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.RightToLeft = RightToLeft.Yes;
            this.txtMarca.Size = new Size(233, 22);
            this.txtMarca.TabIndex = 31;
            this.txtMarca.TextAlign = HorizontalAlignment.Right;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new Point(445, 207);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.RightToLeft = RightToLeft.Yes;
            this.txtModelo.Size = new Size(233, 22);
            this.txtModelo.TabIndex = 32;
            this.txtModelo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCor
            // 
            this.txtCor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new Point(541, 332);
            this.txtCor.Name = "txtCor";
            this.txtCor.RightToLeft = RightToLeft.Yes;
            this.txtCor.Size = new Size(137, 22);
            this.txtCor.TabIndex = 33;
            this.txtCor.TextAlign = HorizontalAlignment.Right;
            // 
            // maskedAnoFabricacao
            // 
            this.maskedAnoFabricacao.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maskedAnoFabricacao.Location = new Point(623, 253);
            this.maskedAnoFabricacao.Mask = "0000";
            this.maskedAnoFabricacao.Name = "maskedAnoFabricacao";
            this.maskedAnoFabricacao.RightToLeft = RightToLeft.Yes;
            this.maskedAnoFabricacao.Size = new Size(55, 22);
            this.maskedAnoFabricacao.TabIndex = 34;
            this.maskedAnoFabricacao.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedPreco
            // 
            this.maskedPreco.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maskedPreco.Location = new Point(612, 293);
            this.maskedPreco.Mask = "0000,00";
            this.maskedPreco.Name = "maskedPreco";
            this.maskedPreco.RightToLeft = RightToLeft.No;
            this.maskedPreco.Size = new Size(66, 22);
            this.maskedPreco.TabIndex = 35;
            this.maskedPreco.TextAlign = HorizontalAlignment.Right;
            // 
            // imagemLogo
            // 
            this.imagemLogo.BorderStyle = BorderStyle.Fixed3D;
            this.imagemLogo.Load("C:\\Users\\Luiz\\Pictures\\download1.jpg");
            // this.imagemLogo.Image = global::WindowsFormsApp6.Properties.Resources.download__1_;
            this.imagemLogo.ImeMode = ImeMode.NoControl;
            this.imagemLogo.Location = new Point(12, 379);
            this.imagemLogo.Name = "imagemLogo";
            this.imagemLogo.Size = new Size(131, 122);
            this.imagemLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemLogo.TabIndex = 25;
            this.imagemLogo.TabStop = false;
            // 
            // homeMenuPrincipal
            // 
            // this.homeMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources._3643769_building_home_house_main_menu_start_1134162;
            this.homeMenuPrincipal.Name = "homeMenuPrincipal";
            this.homeMenuPrincipal.Size = new Size(180, 22);
            this.homeMenuPrincipal.Text = "Menu Principal";
            this.homeMenuPrincipal.Click += new EventHandler(this.homeMenuPrincipal_Click);
            // 
            // sairMenuPrincipal
            // 
            // this.sairMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.seo_social_web_network_internet_322_icon_icons1;
            this.sairMenuPrincipal.Name = "sairMenuPrincipal";
            this.sairMenuPrincipal.Size = new Size(180, 22);
            this.sairMenuPrincipal.Text = "Sair";
            this.sairMenuPrincipal.Click += new EventHandler(this.sairMenuPrincipal_Click);
            // 
            // clienteCadastrarMenuPrincipal
            // 
            // this.clienteCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.user_icon_icons2;
            this.clienteCadastrarMenuPrincipal.Name = "clienteCadastrarMenuPrincipal";
            this.clienteCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.clienteCadastrarMenuPrincipal.Text = "Cliente";
            this.clienteCadastrarMenuPrincipal.Click += new EventHandler(this.clienteCadastrarMenuPrincipal_Click);
            // 
            // locacaoCadastrarMenuPrincipal
            // 
            // this.locacaoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.rentacar_891162;
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
            // this.veiculoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources._4213473_auto_car_parking_rental_transport_transportation_vehicle_1153832;
            this.veiculoCadastrarMenuPrincipal.Name = "veiculoCadastrarMenuPrincipal";
            this.veiculoCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoCadastrarMenuPrincipal.Text = "Veículo";
            // 
            // veiculoLeveCadastrarMenuPrincipal
            // 
            // this.veiculoLeveCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.car_132602;
            this.veiculoLeveCadastrarMenuPrincipal.Name = "veiculoLeveCadastrarMenuPrincipal";
            this.veiculoLeveCadastrarMenuPrincipal.Size = new Size(180, 22);
            this.veiculoLeveCadastrarMenuPrincipal.Text = "Veículo Leve";
            this.veiculoLeveCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoLeveCadastrarMenuPrincipal_Click);
            // 
            // veiculoPesadoCadastrarMenuPrincipal
            // 
            // this.veiculoPesadoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.Lorry_Green_icon_icons2;
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
            // this.imagemTitle.Image = global::WindowsFormsApp6.Properties.Resources.download;
            this.imagemTitle.ImeMode = ImeMode.NoControl;
            this.imagemTitle.Location = new Point(12, 33);
            this.imagemTitle.Name = "imagemTitle";
            this.imagemTitle.Size = new Size(666, 102);
            this.imagemTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemTitle.TabIndex = 20;
            this.imagemTitle.TabStop = false;
            // 
            // CriarVeiculoLeve
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new Size(690, 507);
            this.Controls.Add(this.maskedPreco);
            this.Controls.Add(this.maskedAnoFabricacao);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblAnoDeFabricacao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imagemTitle);
            // this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarVeiculoLeve";
            this.Text = "CADASTRO VEÍCULO LEVE";
            // this.Load += new EventHandler(this.CriarVeiculoLeve_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)(this.imagemLogo)).EndInit();
            ((ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                System.Diagnostics.Process.Start(
                    "https://portal.sc.senac.br/"
                );
            }
        }

        private void ajudaMenuPrincipal_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start(
                    "https://portal.sc.senac.br/"
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                     $"Marca: {this.txtMarca.Text}\n" +
                     $"Modelo: {this.txtModelo.Text}\n" +
                     $"Ano de Fabricação: {this.maskedAnoFabricacao.Text}\n" +
                     $"Preço da Diária: {this.maskedPreco.Text}\n" +
                     $"Cor do Veículo: {this.txtCor.Text}\n" +
                    MessageBoxButtons.OK
                );
            }
        }

        private void homeMenuPrincipal_Click(object sender, EventArgs e)
        {
            // Home home = new Home();
            // home.Show();
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
            CriarLocacao criarLocacao = new CriarLocacao();
            criarLocacao.Show();
        }

        private void veiculoLeveCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarVeiculoLeve criarVeiculoLeve = new CriarVeiculoLeve();
            criarVeiculoLeve.Show();
        }

        private void veiculoPesadoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarVeiculoPesado criarVeiculoPesado = new CriarVeiculoPesado();
            criarVeiculoPesado.Show();
        }

    }
}
