using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LocaCar 
{
    partial class CriarLocacao : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvListarClientes;
        private Library.ListView lvlListarVeiculos;
        private Library.Label lblCliente;
        private Library.Label lblVeiculo;
        protected readonly Model.Locacao locacao;

        public CriarLocacao(int id = 0)
        {
            try
            {
                locacao = Controller.Locacao.GetLocacao(id);
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO: \n" + exception);
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
            this.lvListarClientes = new Library.ListView();
            this.lvlListarVeiculos = new Library.ListView();
            this.lblCliente = new Library.Label();
            this.lblVeiculo = new Library.Label();
            //
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            //
            // lblCliente
            this.lblCliente.Text = "Selecione um Cliente Para Registrar a Locação!";
            this.lblCliente.Location = new Point(470, 115);
            //
            // lvListarClientes
            this.imagemLogo.Size = new Size(100, 90);
            this.imagemLogo.Location = new Point(12, 580);
            //
            // lvListarClientes
            this.lvListarClientes.Location = new Point(12, 145);
            List<Model.Cliente> listaClientes = Controller.Cliente.GetClientes();
            foreach (Model.Cliente cliente in listaClientes)
            {
                ListViewItem lv_ListaCliente = new(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.Nome);
                lv_ListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lv_ListaCliente.SubItems.Add(cliente.Cpf);
                lv_ListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lvListarClientes.Items.Add(lv_ListaCliente);
            }
            //
            // lvListarClientes
            this.lvListarClientes.MultiSelect = false;
            this.lvListarClientes.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lvListarClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("Dias Para Devolução", -2, HorizontalAlignment.Center);
            //
            // lblVeiculo
            this.lblVeiculo.Text = "Selecione um Veículo Para Registrar a Locação!";
            this.lblVeiculo.Location = new Point(470, 348);
            //
            // lvlListarVeiculos
            this.lvlListarVeiculos.Location = new Point(12, 376);
            this.lvlListarVeiculos.MultiSelect = true;
            this.lvlListarVeiculos.CheckBoxes = true;
            List<Model.Veiculo> listaVeiculos = Controller.Veiculo.GetVeiculos();
            foreach (Model.Veiculo veiculo in listaVeiculos)
            {
                ListViewItem lv_ListaVeiculo = new(veiculo.IdVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.Marca);
                lv_ListaVeiculo.SubItems.Add(veiculo.Modelo);
                lv_ListaVeiculo.SubItems.Add(veiculo.Ano);
                lv_ListaVeiculo.SubItems.Add(veiculo.Cor);
                lv_ListaVeiculo.SubItems.Add(veiculo.Restricao);
                lv_ListaVeiculo.SubItems.Add(veiculo.Preco.ToString());
                lvlListarVeiculos.Items.Add(lv_ListaVeiculo);
            }
            //
            // lvlListarVeiculos
            this.lvlListarVeiculos.MultiSelect = false;
            this.lvlListarVeiculos.Columns.Add("ID Veículo", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            this.lvlListarVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Ano", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Cor", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Restrição", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Valor Locação", -2, HorizontalAlignment.Center);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lvListarClientes);
            this.Controls.Add(this.lvlListarVeiculos);

        }
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((lvListarClientes.SelectedItems.Count > 0) && (lvlListarVeiculos.CheckedItems.Count > 0))
                {
                    string IdCliente = this.lvListarClientes.SelectedItems[0].Text;
                    Model.Cliente cliente = Controller.Cliente.GetCliente(Int32.Parse(IdCliente));
                    Model.Locacao locacao = Controller.Locacao.Add(cliente);

                    foreach (ListViewItem Veiculo in this.lvlListarVeiculos.CheckedItems)
                    {
                        Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(Int32.Parse(Veiculo.Text));
                        locacao.AdicionarVeiculo(veiculo);
                    }
                    MessageBox.Show("Locação Realizada!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione o Cliente e Pelo Menos Um Veiculo!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Selecione o Cliente e Pelo Menos Um Veiculo!");
            }
        }
      
    }
}