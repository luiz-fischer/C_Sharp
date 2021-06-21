using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LocaCar
{
    public partial class ListarVeiculo : Form
    {

        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvVeiculos;

        public ListarVeiculo()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {

            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.lvVeiculos = new Library.ListView();
            //
            // lvVeiculos
            List<Model.Veiculo> veiculosLista = Controller.Veiculo.GetVeiculos();
            foreach (var veiculo in veiculosLista)
            {
                ListViewItem lv_ListaVeiculo = new(veiculo.IdVeiculo.ToString());
                lv_ListaVeiculo.SubItems.Add(veiculo.Marca);
                lv_ListaVeiculo.SubItems.Add(veiculo.Modelo);
                lv_ListaVeiculo.SubItems.Add(veiculo.Ano);
                lv_ListaVeiculo.SubItems.Add(veiculo.Cor);
                lv_ListaVeiculo.SubItems.Add(veiculo.Restricao);
                lv_ListaVeiculo.SubItems.Add(veiculo.Preco.ToString("C2"));
                lvVeiculos.Items.Add(lv_ListaVeiculo);
            }
            this.lvVeiculos.Size = new Size(1320, 400);
            this.lvVeiculos.Location = new Point(12, 130);
            this.lvVeiculos.MultiSelect = false;
            this.lvVeiculos.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lvVeiculos.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            this.lvVeiculos.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            this.lvVeiculos.Columns.Add("Ano", -2, HorizontalAlignment.Center);
            this.lvVeiculos.Columns.Add("Cor", -2, HorizontalAlignment.Center);
            this.lvVeiculos.Columns.Add("Restricao", -2, HorizontalAlignment.Center);
            this.lvVeiculos.Columns.Add("Valor Locação", -2, HorizontalAlignment.Center);
            // 
            // imagemLogo
            this.imagemLogo.Location = new Point(12, 550);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lvVeiculos);
            this.Text = "       LISTAR VEÍCULOS";
        }
    }
}