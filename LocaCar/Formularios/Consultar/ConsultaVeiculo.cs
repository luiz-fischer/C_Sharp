using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class ConsultarVeiculo : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvListaVeiculos;
        private Library.Label lblVeiculo;
        public ConsultarVeiculo()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {

            this.btnConfirmar = new Library.Button("btnConfirmar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.lblVeiculo = new Library.Label();
            this.lvListaVeiculos = new Library.ListView();
            //
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            //
            // lblVeiculo
            this.lblVeiculo.Text = "Selecione um Veículo para Consultar/Exlcuir/Alterar!";
            this.lblVeiculo.Location = new Point(470, 135);
            //
            // lvListarVeiculo
            foreach (Model.Veiculo veiculo in Controller.Veiculo.GetVeiculos())
            {
                ListViewItem lvListaVeiculo = new ListViewItem(veiculo.IdVeiculo.ToString());
                lvListaVeiculo.SubItems.Add(veiculo.Marca);
                lvListaVeiculo.SubItems.Add(veiculo.Modelo);
                lvListaVeiculo.SubItems.Add(veiculo.Ano);
                lvListaVeiculo.SubItems.Add(veiculo.Cor);
                lvListaVeiculo.SubItems.Add(veiculo.Restricao);
                lvListaVeiculo.SubItems.Add(veiculo.Preco.ToString("C2"));
                lvListaVeiculos.Items.Add(lvListaVeiculo);
            }
            this.lvListaVeiculos.MultiSelect = false;
            this.lvListaVeiculos.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Ano", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Cor", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Restrição", -2, HorizontalAlignment.Center);
            this.lvListaVeiculos.Columns.Add("Valor Locação", -2, HorizontalAlignment.Center);
            // 
            // Home 
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lvListaVeiculos);
            this.Controls.Add(this.lblVeiculo);
            this.Text = "       CONSULTAR VEÍCULO";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string IdVeiculo = this.lvListaVeiculos.SelectedItems[0].Text;
                Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(Int32.Parse(IdVeiculo));
                EditarVeiculo editarVeiculo = new EditarVeiculo(veiculo);
                editarVeiculo.Show();
            }
            catch
            {
                MessageBox.Show("Selecionar um Veículo!");
            }
        }
    }
}