using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LocaCar
{
    public partial class ListarLocacoes : Form
    {
        private Library.PictureBox imagemLogo;
        private Library.PictureBox imagemTitle;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvlLocacoes;

        public ListarLocacoes()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.lvlLocacoes = new Library.ListView();
            // 
            // lvlLocacoes
            List<Model.Locacao> locacoesLista = Controller.Locacao.GetLocacoes();
            foreach (var locacao in locacoesLista)
            {
                ListViewItem listaVeiculos = new ListViewItem(locacao.IdLocacao.ToString());
                Model.Cliente cliente = Controller.Cliente.GetCliente(locacao.IdCliente);
                Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(locacao.IdLocacao);
                listaVeiculos.SubItems.Add(cliente.Nome.ToString());
                listaVeiculos.SubItems.Add(cliente.Cpf.ToString());
                listaVeiculos.SubItems.Add(locacao.DataLocacao.ToString("dd/MM/yyyy"));
                listaVeiculos.SubItems.Add(locacao.GetDataDevolucao().ToString("dd/MM/yyyy"));
                listaVeiculos.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                listaVeiculos.SubItems.Add(veiculo.Preco.ToString("C2"));
                listaVeiculos.SubItems.Add(locacao.ValorTotalLocacao().ToString("C2"));
                lvlLocacoes.Items.Add(listaVeiculos);
            }
            this.lvlLocacoes.Size = new Size(1320, 400);
            this.lvlLocacoes.Location = new Point(12, 130);
            this.lvlLocacoes.MultiSelect = false;
            this.lvlLocacoes.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Nome Completo", -2, HorizontalAlignment.Left);
            this.lvlLocacoes.Columns.Add("C.P.F.", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Data Da Locação", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Data Da Devolução", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Quantidade de Dias", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Valor da Diária", -2, HorizontalAlignment.Center);
            this.lvlLocacoes.Columns.Add("Valor Total Locação", -2, HorizontalAlignment.Center);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lvlLocacoes);
            this.Text = "       LISTAR LOCAÇÕES";
        }
    }
}