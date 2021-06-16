using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.View;
using System.Diagnostics;
using Library;

namespace LocaCar 
{
    partial class CriarLocacao : Form
    {
        Library.PictureBox imagemTitle;
        Library.PictureBox imagemLogo;
        Library.Button btnConfirmar;
        Library.Button btnCancelar;
        Library.LinkLabelAjuda linkAjuda;
       
        private ListView lvListarClientes;
        private ListView lvlListarVeiculos;
        private Label lblCliente;
        private Label lblVeiculo;
        Form form;
        Model.Locacao locacao;

        public CriarLocacao(Form form, int id = 0)
        {
            try
            {
                locacao = Controller.Locacao.GetLocacao(id);
            }
            catch
            {

            }
            InitializeComponent(form);
        }
        public void InitializeComponent(Form form)
        {
            this.btnConfirmar = new Library.Button("btnConfirmar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.lvListarClientes = new ListView();
            this.lvlListarVeiculos = new ListView();
            this.lblCliente = new Label();
            this.lblVeiculo = new Label(); 
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).BeginInit();
            this.SuspendLayout();
            //
            // btnConfirmar
            // 
            this.btnConfirmar.Click += new EventHandler(this.btn_ConfirmarClick);
             //
            // lblCliente
            //
            this.lblCliente.Text = "Selecione um Cliente Para Registrar a Locação!";
            this.lblCliente.Location = new Point(12, 135);
            this.lblCliente.Size = new Size(400, 15);
            this.lblCliente.Font = new Font(FontFamily.GenericSansSerif, 10F, FontStyle.Bold);
            this.ForeColor = Color.Black;
            //
            // lvListarClientes
            //
            this.lvListarClientes.Location = new Point(12, 150);
            this.lvListarClientes.Size = new Size(665, 100);
            this.lvListarClientes.Font = new Font(this.Font, FontStyle.Bold);
            this.lvListarClientes.View = Details;
            this.lvListarClientes.FullRowSelect = true;
            this.lvListarClientes.GridLines = true;
            this.lvListarClientes.AllowColumnReorder = true;
            this.lvListarClientes.Sorting = SortOrder.None;
            this.lvListarClientes.MultiSelect = true;

            foreach (Model.Cliente cliente in Controller.Cliente.GetClientes())
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.Nome);
                lv_ListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lv_ListaCliente.SubItems.Add(cliente.Cpf);
                lv_ListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lvListarClientes.Items.Add(lv_ListaCliente);
            }
            //
            // lvListarClientes
            //
            this.lvListarClientes.MultiSelect = false;
            this.lvListarClientes.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lvListarClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lvListarClientes.Columns.Add("Dias Para Devolução", -2, HorizontalAlignment.Center);
            this.Controls.Add(lvListarClientes);
            //
            // lblVeiculo
            //
            this.lblVeiculo.Text = "Selecione um Veículo Para Registrar a Locação!";
            this.lblVeiculo.Location = new Point(12, 250);
            this.lblVeiculo.Size = new Size(400, 15);
            this.lblVeiculo.Font = new Font(FontFamily.GenericSansSerif, 10F, FontStyle.Bold);
            //
            // lvlListarVeiculos
            //
            this.ForeColor = Color.Black;
            this.lvlListarVeiculos.Location = new Point(12, 265);
            this.lvlListarVeiculos.Size = new Size(665, 120);
            this.lvlListarVeiculos.Font = new Font(this.Font, FontStyle.Bold);
            this.lvlListarVeiculos.View = Details;
            this.lvlListarVeiculos.FullRowSelect = true;
            this.lvlListarVeiculos.GridLines = true;
            this.lvlListarVeiculos.AllowColumnReorder = true;
            this.lvlListarVeiculos.Sorting = SortOrder.None;
            this.lvlListarVeiculos.MultiSelect = true;
            this.lvlListarVeiculos.CheckBoxes = true;

            foreach (Model.Veiculo veiculo in Controller.Veiculo.GetVeiculos())
            {
                ListViewItem lv_ListaVeiculo = new ListViewItem(veiculo.IdVeiculo.ToString());
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
            //
            this.lvlListarVeiculos.MultiSelect = false;
            this.lvlListarVeiculos.Columns.Add("ID Veículo", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            this.lvlListarVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Ano", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Cor", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Restrição", -2, HorizontalAlignment.Center);
            this.lvlListarVeiculos.Columns.Add("Valor Locação", -2, HorizontalAlignment.Center);
            this.Controls.Add(lvlListarVeiculos);
            // 
            // Home
            //  
            this.SetBounds(
                0,
                0,
                Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height
            );
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(imagemLogo);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(linkAjuda);
            this.Controls.Add(imagemTitle);
            this.Controls.Add(lblCliente);
            this.Controls.Add(lblVeiculo);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemTitle)).EndInit();
            this.ResumeLayout(true);

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
                    this.form.Show();
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