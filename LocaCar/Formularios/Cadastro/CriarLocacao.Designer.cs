using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LocaCar
{
    partial class CriarLocacao : Form
    {
        Library.Label lbl_BuscaCliente;
        Library.Label lbl_BuscaVeiculo;
        Library.ToolTip tt_BuscaCliente;
        Library.ToolTip tt_BuscaVeiculo;
        Library.RichTextBox rtxt_BuscaCliente; 
        Library.RichTextBox rtxt_BuscaVeiculo;
        Library.ListView lv_ListaClientes;
        Library.ListView lv_ListaVeiculos;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent)
        {
            this.BackColor = Color.DarkGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(500, 480);
            this.parent = parent;

            this.lbl_BuscaCliente = new Library.Label();
            this.lbl_BuscaCliente.Text = "Busca Cliente :";
            this.lbl_BuscaCliente.Location = new Point(30, 20);
            this.Controls.Add(lbl_BuscaCliente);

            this.lbl_BuscaVeiculo = new Library.Label();
            this.lbl_BuscaVeiculo.Text = "Busca Veiculo :";
            this.lbl_BuscaVeiculo.Location = new Point(30, 210);
            this.Controls.Add(lbl_BuscaVeiculo);

            this.tt_BuscaCliente = new Library.ToolTip();

            this.rtxt_BuscaCliente = new Library.RichTextBox();
            this.rtxt_BuscaCliente.Location = new Point(150, 20);
            this.Controls.Add(rtxt_BuscaCliente);
            this.tt_BuscaCliente.SetToolTip(rtxt_BuscaCliente, "Digite o nome ou selecione abaixo");
            this.rtxt_BuscaCliente.KeyPress += new KeyPressEventHandler(keypressed1);

            this.tt_BuscaVeiculo = new Library.ToolTip();

            this.rtxt_BuscaVeiculo = new Library.RichTextBox();
            this.rtxt_BuscaVeiculo.Location = new Point(150, 210);
            this.Controls.Add(rtxt_BuscaVeiculo);
            this.tt_BuscaVeiculo.SetToolTip(rtxt_BuscaVeiculo, "Digite a marca ou selecione abaixo");
            this.rtxt_BuscaVeiculo.KeyPress += new KeyPressEventHandler(keypressed2);

            this.lv_ListaClientes = new Library.ListView();
            this.lv_ListaClientes.Location = new Point(40, 50);
            this.lv_ListaClientes.Size = new Size(400, 120);
            List<Model.Cliente> listaCliente = (from cliente in Controller.Cliente.GetClientes() where cliente.Nome.Contains(rtxt_BuscaCliente.Text) select cliente).ToList();
            ListViewItem clientes = new ListViewItem();
            foreach (Model.Cliente cliente in Controller.Cliente.GetClientes())
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.Nome);
                lv_ListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lv_ListaCliente.SubItems.Add(cliente.Cpf);
                lv_ListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.lv_ListaClientes.MultiSelect = false;
            this.lv_ListaClientes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Dias Devolução", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaClientes);

            this.lv_ListaVeiculos = new Library.ListView();
            this.lv_ListaVeiculos.Location = new Point(40, 240);
            this.lv_ListaVeiculos.Size = new Size(400, 120);
            this.lv_ListaVeiculos.CheckBoxes = true;
            List<Model.Veiculo> listaVeiculo = (from veiculo in Controller.Veiculo.GetVeiculos() where veiculo.Marca.Contains(rtxt_BuscaVeiculo.Text) select veiculo).ToList();
            ListViewItem veiculos = new ListViewItem();
            foreach (Model.Veiculo veiculo in Controller.Veiculo.GetVeiculos())
            {
                ListViewItem lv_ListaVeiculo = new ListViewItem(veiculo.IdVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.Marca);
                lv_ListaVeiculo.SubItems.Add(veiculo.Modelo);
                lv_ListaVeiculo.SubItems.Add(veiculo.Ano);
                lv_ListaVeiculo.SubItems.Add(veiculo.Preco.ToString());
                lv_ListaVeiculos.Items.Add(lv_ListaVeiculo);
            }
            this.lv_ListaVeiculos.MultiSelect = false;
            this.lv_ListaVeiculos.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            this.lv_ListaVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Valor Locação", -2, HorizontalAlignment.Center);
            this.lv_ListaVeiculos.Columns.Add("Qtde Estoque", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaVeiculos);

            Task t = new Task(new Action(() => { RefreshForm(); }));
            t.Start();

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(80, 370);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(260, 370);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}