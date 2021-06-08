using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LocaCar
{
    public partial class CriarLocacao : Form
    {
        public CriarLocacao(Form parent)
        {
            InitializeComponent(parent);
        }

        public void RefreshForm()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.RefreshForm));
            }
            Application.DoEvents();
        }

        private void keypressed1(Object o, KeyPressEventArgs e)
        {
            lv_ListaClientes.Items.Clear();
            List<Model.Cliente> listaCliente = (from cliente in Controller.Cliente.GetClientes() where cliente.Nome.Contains(rtxt_BuscaCliente.Text, StringComparison.OrdinalIgnoreCase) select cliente).ToList();
            ListViewItem clientes = new ListViewItem();
            foreach (Model.Cliente cliente in listaCliente)
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.Nome);
                lv_ListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lv_ListaCliente.SubItems.Add(cliente.Cpf);
                lv_ListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.Refresh();
            Application.DoEvents();
        }

        private void keypressed2(Object o, KeyPressEventArgs e)
        {
            lv_ListaVeiculos.Items.Clear();
            List<Model.Veiculo> listaVeiculo = (from veiculo in Controller.Veiculo.GetVeiculos() where veiculo.Marca.Contains(rtxt_BuscaVeiculo.Text, StringComparison.OrdinalIgnoreCase) select veiculo).ToList();
            ListViewItem veiculos = new ListViewItem();
            foreach (Model.Veiculo veiculo in listaVeiculo)
            {
                ListViewItem lv_ListaVeiculo = new ListViewItem(veiculo.IdVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.Marca);
                lv_ListaVeiculo.SubItems.Add(veiculo.Modelo);
                lv_ListaVeiculo.SubItems.Add(veiculo.Ano);
                lv_ListaVeiculo.SubItems.Add(veiculo.Preco.ToString());
                lv_ListaVeiculos.Items.Add(lv_ListaVeiculo);
            }
            this.Refresh();
            Application.DoEvents();
        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((lv_ListaClientes.SelectedItems.Count > 0) && (lv_ListaVeiculos.CheckedItems.Count > 0))
                {
                    string IdCliente = this.lv_ListaClientes.SelectedItems[0].Text;
                    Model.Cliente cliente = Controller.Cliente.GetCliente(Int32.Parse(IdCliente));
                    Model.Locacao locacao = Controller.Locacao.Add(cliente);

                    foreach (ListViewItem Veiculo in this.lv_ListaVeiculos.CheckedItems)
                    {
                        Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(Int32.Parse(Veiculo.Text));
                        locacao.AdicionarVeiculo(veiculo);
                    }
                    MessageBox.Show("Locação Realizada!");
                    this.Close();
                    this.parent.Show();
                }
                else
                {
                    MessageBox.Show("Selecione o Cliente e Pelo Menos Um Veiculo 1!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Selecione o Cliente e Pelo Menos Um Veiculo 22222!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}