using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocaCar
{
    partial class EditarCliente : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnDeletar;
        private Library.Button btnAlterar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.RichTextBox txtCliente;
        private Library.Label lblDadosCliente;

        int idCliente;
        Model.Cliente Cliente;

        public EditarCliente(Model.Cliente cliente)
        {
            InitializeComponent(cliente);
        }

        public void InitializeComponent(Model.Cliente cliente)
        {
            this.btnDeletar = new Library.Button("btnDeletar");
            this.btnAlterar = new Library.Button("btnAlterar");
            this.btnCancelar = new Library.Button("btnCancelar");
            this.imagemLogo = new Library.PictureBox("imagemLogo");
            this.imagemTitle = new Library.PictureBox("imagemTitle");
            this.linkAjuda = new Library.LinkLabelAjuda();
            this.txtCliente = new Library.RichTextBox();
            this.lblDadosCliente = new Library.Label();
            //
            // btnAlterar
            this.btnAlterar.Click += new EventHandler(this.btnAlterar_Click);
             //
            // btnDeletar
            this.btnDeletar.Click += new EventHandler(this.btnDeletar_Click);
            // 
            // lblDadosCliente
            this.lblDadosCliente.Text = "DADOS DO CLIENTE";
            this.lblDadosCliente.ForeColor = Color.Blue;
            this.lblDadosCliente.Location = new Point(600, 220);
            this.lblDadosCliente.Size = new Size(220, 25);
            this.lblDadosCliente.Font = new Font(FontFamily.GenericSansSerif, 14F, FontStyle.Bold);
            //
            // txtCliente
            this.txtCliente.Text =
                "\n\n ID do Cliente:                "        + cliente.IdCliente +
                "\n Nome:                            "       + cliente.Nome +
                "\n Data Nascimento:         "               + cliente.DataDeNascimento +
                "\n CPF:                              "      + cliente.Cpf +
                "\n Dias Para Devolução:    "                + cliente.DiasParaDevolucao;
            this.txtCliente.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Bold);
            this.txtCliente.Location = new Point(500, 250);
            this.txtCliente.Size = new Size(430, 200);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblDadosCliente);
            this.Text = "       EDITAR CLIENTE";
            this.idCliente = cliente.IdCliente;
            this.Cliente = cliente;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente(idCliente);
            criarCliente.Show();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Realmente Exluir Esse Cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Controller.Cliente.DeletarCliente(idCliente);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}