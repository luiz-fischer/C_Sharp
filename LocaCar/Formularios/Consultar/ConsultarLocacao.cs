using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace LocaCar
{
    partial class ConsultarLocacao : Form
    {
        private Library.PictureBox imagemTitle;
        private Library.PictureBox imagemLogo;
        private Library.Button btnConfirmar;
        private Library.Button btnCancelar;
        private Library.LinkLabelAjuda linkAjuda;
        private Library.ListView lvListaLocacoes;
        private Library.Label lblLocacao;
        public ConsultarLocacao()
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
            this.lvListaLocacoes = new Library.ListView();
            this.lblLocacao = new Library.Label();
            // 
            // btnConfirmar
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            //
            // lblLocacao
            this.lblLocacao.Text = "Selecione uma Locação para Consultar/Exlcuir/Alterar!";
            this.lblLocacao.Location = new Point(470, 135);
            //
            // lvListarVeiculo
            List<Model.Locacao> locacoesLista = Controller.Locacao.GetLocacoes();
            foreach (Model.Locacao locacao in locacoesLista)
            {

                ListViewItem lvListaLocacao = new ListViewItem(locacao.IdLocacao.ToString());
                Model.Cliente cliente = Controller.Cliente.GetCliente(locacao.IdCliente);
                Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(locacao.IdLocacao);
                lvListaLocacao.SubItems.Add(cliente.Nome.ToString());
                lvListaLocacao.SubItems.Add(cliente.Cpf.ToString());
                lvListaLocacao.SubItems.Add(locacao.DataLocacao.ToString("dd/MM/yyyy"));
                lvListaLocacao.SubItems.Add(locacao.GetDataDevolucao().ToString("dd/MM/yyyy"));
                lvListaLocacao.SubItems.Add(cliente.DiasParaDevolucao.ToString());
                lvListaLocacao.SubItems.Add(veiculo.Preco.ToString("C2"));
                lvListaLocacao.SubItems.Add(locacao.ValorTotalLocacao().ToString("C2"));
                lvListaLocacoes.Items.Add(lvListaLocacao);
            }
            this.lvListaLocacoes.MultiSelect = false;
            this.lvListaLocacoes.Columns.Add("ID Cliente", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Nome Completo", -2, HorizontalAlignment.Left);
            this.lvListaLocacoes.Columns.Add("C.P.F.", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Data Da Locação", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Data Da Devolução", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Quantidade de Dias", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Valor da Diária", -2, HorizontalAlignment.Center);
            this.lvListaLocacoes.Columns.Add("Valor Total Locação", -2, HorizontalAlignment.Center);
            // 
            // Home
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.imagemTitle);
            this.Controls.Add(this.imagemLogo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblLocacao);
            this.Controls.Add(this.lvListaLocacoes);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string idLocacao = this.lvListaLocacoes.SelectedItems[0].Text;
                Model.Locacao locacao = Controller.Locacao.GetLocacao(Int32.Parse(idLocacao));
                EditarLocacao editarLocacao = new EditarLocacao(locacao);
                editarLocacao.Show();
            }
            catch
            {
                MessageBox.Show("Selecione uma Locação!");
            }
        }
    }
}