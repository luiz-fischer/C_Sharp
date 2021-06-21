using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class ConsultarCliente : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvListarCliente;
        private Library.Label lblCliente;

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {

            this.btnConfirmar = new Library.Button("btnConfirmar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.lvListarCliente = new Library.ListView();
            this.lblCliente = new Library.Label();
            //
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            //
            // lblCliente 
            this.lblCliente.Text = "Selecione um Cliente para Consultar/Exlcuir/Alterar!";
            this.lblCliente.Location = new Point(470, 135);
            //
            // lvListarCliente
            foreach (Model.Cliente cliente in Controller.Cliente.GetClientes())
            {
                ListViewItem lvListaCliente = new(cliente.IdCliente.ToString());
                lvListaCliente.SubItems.Add(cliente.Nome);
                lvListaCliente.SubItems.Add(cliente.DataDeNascimento);
                lvListaCliente.SubItems.Add(cliente.Cpf);
                lvListaCliente.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lvListarCliente.Items.Add(lvListaCliente);
            }

            this.lvListarCliente.MultiSelect = false;
            this.lvListarCliente.Columns.Add("ID do Cliente", -2, HorizontalAlignment.Center);
            this.lvListarCliente.Columns.Add("Nome Completo", -2, HorizontalAlignment.Left);
            this.lvListarCliente.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lvListarCliente.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lvListarCliente.Columns.Add("Dias Para Devolução", -2, HorizontalAlignment.Center);
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
            this.Controls.Add(this.lvListarCliente);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string IdCliente = this.lvListarCliente.SelectedItems[0].Text;
                Model.Cliente cliente = Controller.Cliente.GetCliente(Int32.Parse(IdCliente));
                EditarCliente editarCliente = new(cliente);
                editarCliente.Show();
            }
            catch
            {
                MessageBox.Show("Selecionar um Cliente!");
            }
        }
    }
}