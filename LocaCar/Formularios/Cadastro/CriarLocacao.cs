using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace LocaCar.Formularios.Cadastro
{
    public class CriarLocacao : Form
    {
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
        private PictureBox imagemLogo;
        private Button btnConfirmar;
        private Button btnCancelar;
        private LinkLabel linkAjuda;
        private Label lblCliente;
        private Label lblDataDevolucao;
        private CheckBox checkBoxVeiculoLeve;
        private CheckBox checkBox1;
        private ComboBox comboBoxVeiculoLeve;
        private ComboBox comboBoxVeiculoPesado;
        private TextBox txtCliente;
        private DateTimePicker dateDataDevolucao;
        public CriarLocacao()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CriarLocacao());
        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CriarLocacao));
            this.menuStrip1 = new MenuStrip();
            this.menuPrincipal = new ToolStripMenuItem();
            this.sairMenuPrincipal = new ToolStripMenuItem();
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
            this.btnConfirmar = new Button();
            this.btnCancelar = new Button();
            this.linkAjuda = new LinkLabel();
            this.lblCliente = new Label();
            this.lblDataDevolucao = new Label();
            this.checkBoxVeiculoLeve = new CheckBox();
            this.checkBox1 = new CheckBox();
            this.comboBoxVeiculoLeve = new ComboBox();
            this.comboBoxVeiculoPesado = new ComboBox();
            this.txtCliente = new TextBox();
            this.dateDataDevolucao = new DateTimePicker();
            this.imagemLogo = new PictureBox();
            this.imagemTitle = new PictureBox();
            this.homeMenuPrincipal = new ToolStripMenuItem();
            this.clienteCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.locacaoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoLeveCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.veiculoPesadoCadastrarMenuPrincipal = new ToolStripMenuItem();
            this.ajudaMenuPrincipal = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
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
            this.sairMenuPrincipal.Click += new EventHandler(this.sairMenuPrincipal_Click);
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
            this.ajudaToolStripMenuItem.Click += new EventHandler(this.ajudaToolStripMenuItem_Click);
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
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
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
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
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
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new Point(12, 158);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new Size(39, 13);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new Point(12, 204);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new Size(102, 13);
            this.lblDataDevolucao.TabIndex = 25;
            this.lblDataDevolucao.Text = "Data Da Devolução";
            this.lblDataDevolucao.Click += new EventHandler(this.label1_Click);
            // 
            // checkBoxVeiculoLeve
            // 
            this.checkBoxVeiculoLeve.AutoSize = true;
            this.checkBoxVeiculoLeve.Location = new Point(12, 253);
            this.checkBoxVeiculoLeve.Name = "checkBoxVeiculoLeve";
            this.checkBoxVeiculoLeve.RightToLeft = RightToLeft.Yes;
            this.checkBoxVeiculoLeve.Size = new Size(90, 17);
            this.checkBoxVeiculoLeve.TabIndex = 28;
            this.checkBoxVeiculoLeve.Text = "Veículo Leve";
            this.checkBoxVeiculoLeve.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(12, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = RightToLeft.Yes;
            this.checkBox1.Size = new Size(102, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Veículo Pesado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxVeiculoLeve
            // 
            this.comboBoxVeiculoLeve.AllowDrop = true;
            this.comboBoxVeiculoLeve.FormattingEnabled = true;
            this.comboBoxVeiculoLeve.Items.AddRange(new object[] {
            "Fiesta",
            "Gol",
            "Corsa",
            "Celta"});
            this.comboBoxVeiculoLeve.Location = new Point(519, 249);
            this.comboBoxVeiculoLeve.Name = "comboBoxVeiculoLeve";
            this.comboBoxVeiculoLeve.Size = new Size(159, 21);
            this.comboBoxVeiculoLeve.TabIndex = 31;
            // 
            // comboBoxVeiculoPesado
            // 
            this.comboBoxVeiculoPesado.FormattingEnabled = true;
            this.comboBoxVeiculoPesado.Items.AddRange(new object[] {
            "Scania",
            "Mercedes-Benz Axor 2644",
            "Iveco Strails"});
            this.comboBoxVeiculoPesado.Location = new Point(519, 302);
            this.comboBoxVeiculoPesado.Name = "comboBoxVeiculoPesado";
            this.comboBoxVeiculoPesado.Size = new Size(159, 21);
            this.comboBoxVeiculoPesado.TabIndex = 32;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new Point(369, 151);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.RightToLeft = RightToLeft.Yes;
            this.txtCliente.Size = new Size(309, 20);
            this.txtCliente.TabIndex = 33;
            // 
            // dateDataDevolucao
            // 
            this.dateDataDevolucao.Location = new Point(445, 198);
            this.dateDataDevolucao.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateDataDevolucao.Name = "dateDataDevolucao";
            this.dateDataDevolucao.Size = new Size(233, 20);
            this.dateDataDevolucao.TabIndex = 34;
            // 
            // imagemLogo
            // 
            this.imagemLogo.BorderStyle = BorderStyle.Fixed3D;
			this.imagemLogo.Load("C:\\Users\\Luiz\\Pictures\\download1.jpg");
            // this.imagemLogo.Image = global::WindowsFormsApp6.Properties.Resources.download__1_;
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
            this.homeMenuPrincipal.Click += new EventHandler(this.homeMenuPrincipal_Click);
            // 
            // clienteCadastrarMenuPrincipal
            // 
            // this.clienteCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.user_icon_icons4;
            this.clienteCadastrarMenuPrincipal.Name = "clienteCadastrarMenuPrincipal";
            this.clienteCadastrarMenuPrincipal.Size = new Size(118, 22);
            this.clienteCadastrarMenuPrincipal.Text = "Cliente";
            this.clienteCadastrarMenuPrincipal.Click += new EventHandler(this.clienteCadastrarMenuPrincipal_Click);
            // 
            // locacaoCadastrarMenuPrincipal
            // 
            // this.locacaoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.rentacar_891164;
            this.locacaoCadastrarMenuPrincipal.Name = "locacaoCadastrarMenuPrincipal";
            this.locacaoCadastrarMenuPrincipal.Size = new Size(118, 22);
            this.locacaoCadastrarMenuPrincipal.Text = "Locação";
            this.locacaoCadastrarMenuPrincipal.Click += new EventHandler(this.locacaoCadastrarMenuPrincipal_Click);
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
            this.veiculoLeveCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoLeveCadastrarMenuPrincipal_Click);
            // 
            // veiculoPesadoCadastrarMenuPrincipal
            // 
            // this.veiculoPesadoCadastrarMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.Lorry_Green_icon_icons4;
            this.veiculoPesadoCadastrarMenuPrincipal.Name = "veiculoPesadoCadastrarMenuPrincipal";
            this.veiculoPesadoCadastrarMenuPrincipal.Size = new Size(153, 22);
            this.veiculoPesadoCadastrarMenuPrincipal.Text = "Veículo Pesado";
            this.veiculoPesadoCadastrarMenuPrincipal.Click += new EventHandler(this.veiculoPesadoCadastrarMenuPrincipal_Click);
            // 
            // ajudaMenuPrincipal
            // 
            // this.ajudaMenuPrincipal.Image = global::WindowsFormsApp6.Properties.Resources.AJUDA2;
            this.ajudaMenuPrincipal.Name = "ajudaMenuPrincipal";
            this.ajudaMenuPrincipal.Size = new Size(180, 22);
            this.ajudaMenuPrincipal.Text = "Ajuda";
            this.ajudaMenuPrincipal.Click += new EventHandler(this.ajudaMenuPrincipal_Click);
            // 
            // CriarLocacao
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new Size(706, 546);
            this.Controls.Add(this.dateDataDevolucao);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.comboBoxVeiculoPesado);
            this.Controls.Add(this.comboBoxVeiculoLeve);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxVeiculoLeve);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.menuStrip1);
            // this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarLocacao";
            this.Text = "       CADASTRAR LOCAÇÃO";
            this.menuStrip1.ResumeLayout(true);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);
            // this.PerformLayout();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                     $"Cliente: {this.txtCliente.Text}\n" +
                     $"Data Da Devolução: {this.dateDataDevolucao.Text}\n" +
                     $"Veiculo Leve: {this.comboBoxVeiculoLeve.Text}\n" +
                     $"Veículo Pesado: {this.comboBoxVeiculoPesado.Text}\n" +
                    MessageBoxButtons.OK
                );
            }
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

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
