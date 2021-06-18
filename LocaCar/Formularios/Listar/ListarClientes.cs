using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LocaCar
{
    public partial class ListarCliente : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvCliente;

        public ListarCliente()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.lvCliente = new Library.ListView();
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            // 
            // lvlListaCliente
            List<Model.Cliente> clientesLista = Controller.Cliente.GetClientes();
            foreach (var cliente in clientesLista)
            {
                ListViewItem lvlListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lvlListaCliente.SubItems.Add(cliente.Nome);
                lvlListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lvlListaCliente.SubItems.Add(cliente.Cpf);
                lvlListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lvCliente.Items.Add(lvlListaCliente); 
            }
            this.lvCliente.Size = new Size(1320, 400);
            this.lvCliente.Location = new Point(12, 130);
            this.lvCliente.MultiSelect = false;
            this.lvCliente.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvCliente.Columns.Add("Nome Completo", -2, HorizontalAlignment.Left);
            this.lvCliente.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lvCliente.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lvCliente.Columns.Add("Dias Devolução", -2, HorizontalAlignment.Center);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lvCliente);
            this.Text = "       LISTAR CLIENTE";
        }
    }
}