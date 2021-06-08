using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using LocaCar.Formularios.Cadastro;

namespace LocaCar.Formularios.Listar
{
    public class ListarCliente : Form
    {
        private Label lblNome;
        private Label lblCpf;
        private Label lblDataDeNascimento;
        private Label lblDiasParaDevolucao;
        private TextBox txtNome;
        private MaskedTextBox maskedCpf;
        private DateTimePicker dateDataDeNascimento;
        private NumericUpDown numericDiasParaDevolucao;
        private PictureBox imagemTitle;
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
        private Button btnConfirmar;
        private Button btnCancelar;
        private LinkLabel linkAjuda;
        private PictureBox imagemLogo;

        public ListarCliente()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new ListarCliente());
        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ListarCliente));
            this.lblNome = new Label();
            this.lblCpf = new Label();
            this.lblDataDeNascimento = new Label();
            this.lblDiasParaDevolucao = new Label();
            this.txtNome = new TextBox();
            this.maskedCpf = new MaskedTextBox();
            this.dateDataDeNascimento = new DateTimePicker();
            this.numericDiasParaDevolucao = new NumericUpDown();
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
            this.btnConfirmar = new Button();
            this.btnCancelar = new Button();
            this.linkAjuda = new LinkLabel();
            this.imagemLogo = new PictureBox();
            this.homeMenuPrincipal = new ToolStripMenuItem();
            this.sairMenuPrincipal = new ToolStripMenuItem();
            this.clienteCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLeveCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.imagemTitle = new PictureBox();
            // ((System.ComponentModel.ISupportInitialize)(this.numericDiasParaDevolucao)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
        
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new Point(9, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new Size(55, 18);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new Point(9, 225);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new Size(55, 18);
            this.lblCpf.TabIndex = 26;
            this.lblCpf.Text = "CPF";
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimento.Location = new Point(9, 275);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new Size(55, 18);
            this.lblDataDeNascimento.TabIndex = 26;
            this.lblDataDeNascimento.Text = "Data De Nascimento";
            // 
            // lblDiasParaDevolucao
            // 
            this.lblDiasParaDevolucao.AutoSize = true;
            this.lblDiasParaDevolucao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasParaDevolucao.Location = new Point(9, 325);
            this.lblDiasParaDevolucao.Name = "lblDiasParaDevolucao";
            this.lblDiasParaDevolucao.Size = new Size(55, 18);
            this.lblDiasParaDevolucao.TabIndex = 26;
            this.lblDiasParaDevolucao.Text = "Dias Para Devolução";
            // 
            // txtNome
            // 
            this.txtNome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new Point(445, 175);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = RightToLeft.No;
            this.txtNome.Size = new Size(233, 22);
            this.txtNome.TabIndex = 31;
            this.txtNome.TextAlign = HorizontalAlignment.Right;
            // 
            // maskedCpf
            // 
            this.maskedCpf.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maskedCpf.Location = new Point(597, 225);
            this.maskedCpf.Mask = "000.000.000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.RightToLeft = RightToLeft.No;
            this.maskedCpf.Size = new Size(80, 22);
            this.maskedCpf.TabIndex = 34;
            this.maskedCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // dateDataDeNascimento
            // 
            this.dateDataDeNascimento.Location = new Point(445, 275);
            this.dateDataDeNascimento.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateDataDeNascimento.Name = "dateDataDeNascimento";
            this.dateDataDeNascimento.Size = new Size(233, 20);
            this.dateDataDeNascimento.TabIndex = 34;
            // 
            // numericDiasParaDevolucao
            // 
            this.numericDiasParaDevolucao.Location = new Point(637, 325);
            this.numericDiasParaDevolucao.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericDiasParaDevolucao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDiasParaDevolucao.Name = "numericDiasParaDevolucao";
            this.numericDiasParaDevolucao.Size = new Size(41, 20);
            this.numericDiasParaDevolucao.TabIndex = 35;
            this.numericDiasParaDevolucao.TextAlign = HorizontalAlignment.Center;
            this.numericDiasParaDevolucao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.menuStrip1.TabIndex = 16;
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
            // sairMenuPrincipal
            // 
            // this.sairMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.seo_social_web_network_internet_322_icon_icons4;
            this.sairMenuPrincipal.Name = "sairMenuPrincipal";
            this.sairMenuPrincipal.Size = new Size(180, 22);
            this.sairMenuPrincipal.Text = "Sair";
            this.sairMenuPrincipal.Click += new System.EventHandler(this.sairMenuPrincipal_Click);
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
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = FlatStyle.System;
            this.btnConfirmar.ImeMode = ImeMode.NoControl;
            this.btnConfirmar.Location = new Point(445, 462);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new Size(90, 33);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.ImeMode = ImeMode.NoControl;
            this.btnCancelar.Location = new Point(541, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(90, 33);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // linkAjuda
            // 
            this.linkAjuda.AutoSize = true;
            this.linkAjuda.BorderStyle = BorderStyle.Fixed3D;
            this.linkAjuda.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            this.linkAjuda.ImeMode = ImeMode.NoControl;
            this.linkAjuda.Location = new Point(637, 480);
            this.linkAjuda.Name = "linkAjuda";
            this.linkAjuda.Size = new Size(41, 15);
            this.linkAjuda.TabIndex = 20;
            this.linkAjuda.TabStop = true;
            this.linkAjuda.Text = "Ajuda";
            this.linkAjuda.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkAjuda_LinkClicked);
            // 
            // imagemLogo
            // 
            this.imagemLogo.BorderStyle = BorderStyle.Fixed3D;
            this.imagemLogo.Load("C:\\Users\\Luiz\\Pictures\\download1.jpg");
            this.imagemLogo.ImeMode = ImeMode.NoControl;
            this.imagemLogo.Location = new Point(12, 373);
            this.imagemLogo.Name = "imagemLogo";
            this.imagemLogo.Size = new Size(131, 122);
            this.imagemLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemLogo.TabIndex = 23;
            this.imagemLogo.TabStop = false;
            // 
            // imagemTitle
            // 
            this.imagemTitle.BackgroundImageLayout = ImageLayout.Stretch;
            this.imagemTitle.BorderStyle = BorderStyle.Fixed3D;
            this.imagemTitle.Load("C:\\Users\\Luiz\\Pictures\\download.jpg");
            // this.imagemTitle.Image = global::WindowsFormsApp6.Properties.Resources.download;
            this.imagemTitle.ImeMode = ImeMode.NoControl;
            this.imagemTitle.Location = new Point(12, 27);
            this.imagemTitle.Name = "imagemTitle";
            this.imagemTitle.Size = new Size(666, 102);
            this.imagemTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagemTitle.TabIndex = 17;
            this.imagemTitle.TabStop = false;
            // 
            // homeMenuPrincipal
            // 
            // this.homeMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources._3643769_building_home_house_main_menu_start_1134165;
            this.homeMenuPrincipal.Name = "homeMenuPrincipal";
            this.homeMenuPrincipal.Size = new Size(180, 22);
            this.homeMenuPrincipal.Text = "Menu Principal";
            this.homeMenuPrincipal.Click += new System.EventHandler(this.homeMenuPrincipal_Click);
            // 
            // clienteCadastrarMenuPrincipal
            // 
            // this.clienteCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.user_icon_icons4;
            this.clienteCadastrarMenuPrincipal.Name = "clienteCadastrarMenuPrincipal";
            this.clienteCadastrarMenuPrincipal.Size = new Size(118, 22);
            this.clienteCadastrarMenuPrincipal.Text = "Cliente";
            this.clienteCadastrarMenuPrincipal.Click += new System.EventHandler(this.clienteCadastrarMenuPrincipal_Click);
            // 
            // locacaoCadastrarMenuPrincipal
            // 
            // this.locacaoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.rentacar_891164;
            this.locacaoCadastrarMenuPrincipal.Name = "locacaoCadastrarMenuPrincipal";
            this.locacaoCadastrarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoCadastrarMenuPrincipal.Text = "Locação";
            this.locacaoCadastrarMenuPrincipal.Click += new System.EventHandler(this.locacaoCadastrarMenuPrincipal_Click);
            // 
            // veiculoCadastrarMenuPrincipal
            // 
            this.veiculoCadastrarMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] {
            this.veiculoLeveCadastrarMenuPrincipal,
            this.veiculoPesadoCadastrarMenuPrincipal});
            // this.veiculoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources._4213473_auto_car_parking_rental_transport_transportation_vehicle_1153834;
            this.veiculoCadastrarMenuPrincipal.Name = "veiculoCadastrarMenuPrincipal";
            this.veiculoCadastrarMenuPrincipal.Size = new Size(118, 22);
            this.veiculoCadastrarMenuPrincipal.Text = "Veículo";
            // 
            // veiculoLeveCadastrarMenuPrincipal
            // 
            // this.veiculoLeveCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.car_132604;
            this.veiculoLeveCadastrarMenuPrincipal.Name = "veiculoLeveCadastrarMenuPrincipal";
            this.veiculoLeveCadastrarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoLeveCadastrarMenuPrincipal.Text = "Veículo Leve";
            this.veiculoLeveCadastrarMenuPrincipal.Click += new System.EventHandler(this.veiculoLeveCadastrarMenuPrincipal_Click);
            // 
            // veiculoPesadoCadastrarMenuPrincipal
            // 
            // this.veiculoPesadoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.Lorry_Green_icon_icons4;
            this.veiculoPesadoCadastrarMenuPrincipal.Name = "veiculoPesadoCadastrarMenuPrincipal";
            this.veiculoPesadoCadastrarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoPesadoCadastrarMenuPrincipal.Text = "Veículo Pesado";
            this.veiculoPesadoCadastrarMenuPrincipal.Click += new System.EventHandler(this.veiculoPesadoCadastrarMenuPrincipal_Click);
            // 
            // ajudaMenuPrincipal
            // 
            // this.ajudaMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.AJUDA2;
            this.ajudaMenuPrincipal.Name = "ajudaMenuPrincipal";
            this.ajudaMenuPrincipal.Size = new Size(180, 22);
            this.ajudaMenuPrincipal.Text = "Ajuda";
            this.ajudaMenuPrincipal.Click += new System.EventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            // resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(706, 546);
            this.BackColor = SystemColors.ActiveCaption;
            this.AcceptButton = this.btnConfirmar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.numericDiasParaDevolucao);
            this.Controls.Add(this.dateDataDeNascimento);
            this.Controls.Add(this.maskedCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDiasParaDevolucao);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "ListarCliente";
            this.Text = "       CADASTRAR CLIENTE";
            // this.Load += new EventHandler(this.ListarCliente_Load);
            this.menuStrip1.ResumeLayout(true);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasParaDevolucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);
            // this.PerformLayout();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                     $"Nome Completo: {this.txtNome.Text}\n" +
                     $"CPF: {this.maskedCpf.Text}\n" +
                     $"Data De Nascimento: {this.dateDataDeNascimento.Text}\n" +
                     $"Dias Para Devolução: {this.numericDiasParaDevolucao.Text}\n" +
                    MessageBoxButtons.OK
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ListarCliente criarCliente = new ListarCliente();
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
