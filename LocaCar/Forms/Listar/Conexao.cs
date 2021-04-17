using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;
  using MySql.Data.MySqlClient;

  namespace teste
  {
      public partial class Form1 : Form
      {
          //private System.Windows.Forms.DataGrid datagrid;
          private MySqlConnection conexao;
          private MySqlDataAdapter adapter;
          private DataSet dataset;

          public Form1()
          {
              InitializeComponent();

              dataset = new DataSet();

              conexao = new MySqlConnection("Persist Security Info=False;" +
                "                          server=localhost;" +
                "                          database=teste;" +
                "                          uid=root;" +
                "                          pwd=;" +
                "                          SslMode=none;");

              try
              {
                  conexao.Open();

                  // Verifica se a conexao esta aberta
                  if (conexao.State == ConnectionState.Open)
                  {
                      // Cria um adapter para acessar a tabela Clientes
                      adapter = new MySqlDataAdapter("SELECT * FROM clientes", conexao);
                      // Preenche o dataset via adapter
                      adapter.Fill(dataset, "clientes");
                      // Atribui o resultado a propriedade DataSource do DataGrid
                      //datagrid.DataSource = dataset;
                      //datagrid.DataMember = "Clientes";

                      dataGridView1.DataSource = dataset;//.Tables[0].DefaultView;
                      dataGridView1.DataMember = "clientes";
                  }
              }
              catch(Exception e)
              {
                  MessageBox.Show(e.Message.ToString());
              }
              finally
              {
                  if (conexao.State == ConnectionState.Open)
                  {
                      conexao.Close();
                  }
              }            
          }
      }}