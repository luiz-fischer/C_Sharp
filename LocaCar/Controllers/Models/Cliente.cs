using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Repository;
using System.Windows.Forms;

namespace Model
{
    public partial class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public int DiasParaDevolucao { get; set; }
        public List<Model.Locacao> locacoes = new();


        public Cliente(
            string nome,
            string dataDeNascimento,
            string cpf,
            int diasParaDevolucao)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
            DiasParaDevolucao = diasParaDevolucao;
            locacoes = new List<Model.Locacao>();

            Context db = new();
            db.Clientes.Add(this);
            db.SaveChanges();
            throw new ArgumentException("Cadastrado Com Sucesso!");
        }

        public Cliente()
        {
        }

        public static Cliente GetCliente(int idCliente)
        {
            Context db = new();
            return (from cliente in db.Clientes
                    where cliente.IdCliente == idCliente
                    select cliente).First();
        }

        public void AdicionarLocacao(Model.Locacao locacao)
        {
            locacoes.Add(locacao);

        }

        public static List<Cliente> GetClientes()
        {
            Context db = new();
            return db.Clientes.ToList();
        }

        public static string AtualizaCliente(
            int IdCliente,
            string nome,
            string dataDeNascimento,
            string cpf,
            int diasParaDevolucao)
        {
            Context db = new();
            try
            {
                Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == IdCliente);
                cliente.Nome = nome;
                cliente.DataDeNascimento = dataDeNascimento;
                cliente.Cpf = cpf;
                cliente.DiasParaDevolucao = diasParaDevolucao;
                db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }
            return "Atualizado Com Sucesso!";
        }

        public static string DeletarCliente(int idCliente)
        {
            Context db = new();
            try
            {
                Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
                db.Remove(cliente);
                db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }
            return "Deletado Com Sucesso!";
        }
    }
}