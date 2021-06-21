using System;
using System.Drawing;
using System.Windows.Forms;


namespace LocaCar
{
    public class Home : Form
    {
        public Home()
        {
            this.IsMdiContainer = true;

            MenuStrip ms = new MenuStrip();
            //
            // Homes
            ToolStripMenuItem homeMenuPrincipal = new ToolStripMenuItem("Home");

            ToolStripMenuItem homeMenuDropItem = new ToolStripMenuItem(
                "Home",
                null,
                new EventHandler(this.homeMenuPrincipal_Click)
                );
            ToolStripMenuItem sairMenuDropItem = new ToolStripMenuItem(
                "Sair",
                null,
                new EventHandler(this.sairMenuPrincipal_Click)
                );
            //
            // Cadastrar
            ToolStripMenuItem cadastrarMenuPrincipal = new ToolStripMenuItem("Cadastrar");
            ToolStripMenuItem cadastrarClienteMenuPrincipal = new ToolStripMenuItem(
                "Cliente",
                null,
                new EventHandler(this.clienteCadastrarMenuPrincipal_Click)
                );

            ToolStripMenuItem cadastrarLocacaoMenuPrincipal = new ToolStripMenuItem(
                "Locação",
                null,
                new EventHandler(this.locacaoCadastrarMenuPrincipal_Click)
                );
            ToolStripMenuItem cadastrarVeiculoMenuPrincipal = new ToolStripMenuItem(
                "Veículo",
                null,
                new EventHandler(this.veiculoCadastrarMenuPrincipal_Click)
                );
            //
            // Pesquisar
            ToolStripMenuItem pesquisarMenuPrincipal = new ToolStripMenuItem("Pesquisar");
            ToolStripMenuItem pesquisarClienteMenuPrincipal = new ToolStripMenuItem(
                "Cliente",
                null,
                new EventHandler(this.clientePesquisarMenuPrincipal_Click)
                );
            ToolStripMenuItem pesquisarLocacaoMenuPrincipal = new ToolStripMenuItem(
                "Locação",
                null,
                new EventHandler(this.locacaoPesquisarMenuPrincipal_Click)
                );
            ToolStripMenuItem pesquisarVeiculoMenuPrincipal = new ToolStripMenuItem(
                "Veículo",
                null,
                new EventHandler(this.veiculoPesquisarMenuPrincipal_Click)
                );
            //
            // Listar
            ToolStripMenuItem listarMenuPrincipal = new ToolStripMenuItem("Listar");
            ToolStripMenuItem listarClienteMenuPrincipal = new ToolStripMenuItem(
                "Clientes",
                null,
                new EventHandler(this.clienteListarMenuPrincipal_Click)
                );

            ToolStripMenuItem listarLocacaoMenuPrincipal = new ToolStripMenuItem(
                "Locações",
                null,
                new EventHandler(this.locacaoListarMenuPrincipal_Click)
                );

            ToolStripMenuItem listarVeiculoMenuPrincipal = new ToolStripMenuItem(
                "Veículos",
                null,
                new EventHandler(this.veiculoListarMenuPrincipal_Click)
                );
            //
            // Windows
            ToolStripMenuItem windowsMenuPrincipal = new ToolStripMenuItem("Windows");
            // Home
            homeMenuPrincipal.DropDownItems.Add(homeMenuDropItem);
            homeMenuPrincipal.DropDownItems.Add(sairMenuDropItem);
            // Cadastrar
            cadastrarMenuPrincipal.DropDownItems.Add(cadastrarClienteMenuPrincipal);
            cadastrarMenuPrincipal.DropDownItems.Add(cadastrarLocacaoMenuPrincipal);
            cadastrarMenuPrincipal.DropDownItems.Add(cadastrarVeiculoMenuPrincipal);
            // Pesquisar
            pesquisarMenuPrincipal.DropDownItems.Add(pesquisarClienteMenuPrincipal);
            pesquisarMenuPrincipal.DropDownItems.Add(pesquisarLocacaoMenuPrincipal);
            pesquisarMenuPrincipal.DropDownItems.Add(pesquisarVeiculoMenuPrincipal);
            // Listar
            listarMenuPrincipal.DropDownItems.Add(listarClienteMenuPrincipal);
            listarMenuPrincipal.DropDownItems.Add(listarLocacaoMenuPrincipal);
            listarMenuPrincipal.DropDownItems.Add(listarVeiculoMenuPrincipal);

            ms.MdiWindowListItem = windowsMenuPrincipal;

            ms.Items.Add(homeMenuPrincipal);
            ms.Items.Add(cadastrarMenuPrincipal);
            ms.Items.Add(pesquisarMenuPrincipal);
            ms.Items.Add(listarMenuPrincipal);
            ms.Items.Add(windowsMenuPrincipal);

            ms.Dock = DockStyle.Top;
            this.MainMenuStrip = ms;

            this.SetBounds(
                0,
                0,
                Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height
            );
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Font;
            ms.Font = new Font(FontFamily.GenericSansSerif, 8F, FontStyle.Bold);
            ms.Renderer = new MyRenderer();
            this.Controls.Add(ms);

        }

        private void homeMenuPrincipal_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
        private void sairMenuPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clienteCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.MdiParent = this;
            criarCliente.Text = "CADASTRAR CLIENTE " + this.MdiChildren.Length.ToString();
            criarCliente.Show();
        }
        private void locacaoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarLocacao criarLocacao = new CriarLocacao();
            criarLocacao.MdiParent = this;
            criarLocacao.Text = "CADASTRAR LOCAÇÃO " + this.MdiChildren.Length.ToString();
            criarLocacao.Show();
        }
        private void veiculoCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarVeiculo criarVeiculo = new CriarVeiculo();
            criarVeiculo.MdiParent = this;
            criarVeiculo.Text = "CADASTRAR VEÍCULO " + this.MdiChildren.Length.ToString();
            criarVeiculo.Show();
        }
        private void clientePesquisarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.MdiParent = this;
            consultarCliente.Text = "PESQUISAR CLIENTE " + this.MdiChildren.Length.ToString();
            consultarCliente.Show();
        }
        private void locacaoPesquisarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarLocacao consultarLocacao = new ConsultarLocacao();
            consultarLocacao.MdiParent = this;
            consultarLocacao.Text = "PESQUISAR LOCAÇÃO " + this.MdiChildren.Length.ToString();
            consultarLocacao.Show();
        }
        private void veiculoPesquisarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consultarVeiculo = new ConsultarVeiculo();
            consultarVeiculo.MdiParent = this;
            consultarVeiculo.Text = "PESQUISAR VEÍCULO " + this.MdiChildren.Length.ToString();
            consultarVeiculo.Show();
        }
        private void clienteListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarCliente listaCliente = new ListarCliente();
            listaCliente.MdiParent = this;
            listaCliente.Text = "LISTAR CLIENTE " + this.MdiChildren.Length.ToString();
            listaCliente.Show();
        }
        private void locacaoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarLocacoes listaLocacao = new ListarLocacoes();
            listaLocacao.MdiParent = this;
            listaLocacao.Text = "LISTAR LOCAÇÃO " + this.MdiChildren.Length.ToString();
            listaLocacao.Show();
        }
        private void veiculoListarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ListarVeiculo listaVeiculo = new ListarVeiculo();
            listaVeiculo.MdiParent = this;
            listaVeiculo.Text = "LISTAR VEÍCULOS " + this.MdiChildren.Length.ToString();
            listaVeiculo.Show();
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                {
                    e.Item.ForeColor = Color.DarkGray;
                    base.OnRenderMenuItemBackground(e);
                }
                else
                {
                    Pen pen = new Pen(Color.FromArgb(75, 75, 75));
                    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(75, 75, 75));
                    e.Item.Font = new Font(FontFamily.GenericSansSerif, 8.5F, FontStyle.Bold);
                    e.Item.ForeColor = Color.FromArgb(26, 157, 196);
                    Rectangle rectangle = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(solidBrush, rectangle);
                    e.Graphics.DrawRectangle(pen, 0, 0, rectangle.Width, rectangle.Height);

                    pen.Dispose();
                    solidBrush.Dispose();
                }
            }
        }
    }
}