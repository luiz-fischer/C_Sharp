using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Repository;

namespace Model
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public int DiasParaDevolucao { get; set; }
        public List<Model.Locacao> locacoes = new List<Model.Locacao>();


        public Cliente(
            string nome,
            string dataDeNascimento,
            string cpf,
            int diasParaDevolucao
            )
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
            DiasParaDevolucao = diasParaDevolucao;
            locacoes = new List<Model.Locacao>();

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public Cliente()
        {

        }

        public static Model.Cliente GetCliente(int idCliente)
        {
            Context db = new Context();
            return (from cliente in db.Clientes
                    where cliente.IdCliente == idCliente
                    select cliente).First();
        }

        public void AdicionarLocacao(Model.Locacao locacao)
        {
            locacoes.Add(locacao);

        }

        public static List<Model.Cliente> GetClientes()
        {
            var db = new Context();
            return db.Clientes.ToList();
        }

        public static void AtualizaCliente(
            int IdCliente,
            string nome,
            string dataDeNascimento,
            string cpf,
            int diasParaDevolucao)
        {
            var db = new Context();
            try
            {
                Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == IdCliente);
                cliente.Nome = nome;
                cliente.DataDeNascimento = dataDeNascimento;
                cliente.Cpf = cpf;
                cliente.DiasParaDevolucao = diasParaDevolucao;
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public static void DeleteCliente(int idCliente)
        {
            Context db = new Context();
            try
            {
                Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
                db.Remove(cliente);
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}