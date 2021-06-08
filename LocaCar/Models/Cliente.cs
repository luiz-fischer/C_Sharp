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
        // [Required] - Exige que campo seja preenchido.
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public int DiasParaDevolucao { get; set; }

        public List<Locacao> locacoes = new List<Locacao>();


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
            locacoes = new List<Locacao>();

            Context db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public Cliente()
        {

        }

        public static Cliente GetCliente(int idCliente)
        {
            Context db = new Context();
            return (from cliente in db.Clientes
                    where cliente.IdCliente == idCliente
                    select cliente).First();
        }

        public override string ToString()
        {
            return $"-------------------===[ CLIENTE ]===-------------------\n" +
                    $"--> Nº ID DO CLIENTE: {IdCliente}\n" +
                    $"-> Nome COMPLETO: {Nome}\n" +
                    $"-> DATA DE NASCIMENTO: {DataDeNascimento}\n" +
                    $"-> Cpf: {Cpf}\n" +
                    $"-> DIAS P/ DEVOLUÇÃO: {DiasParaDevolucao}\n" +
                    $"-------------------------------------------------------";
        }

        public void AdicionarLocacao(Locacao locacao)
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
            string Nome,
            string DataDeNascimento,
            string Cpf,
            int DiasParaDevolucao)
        {
            Context db = new Context();
            try
            {
                Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == IdCliente);
                cliente.Nome = Nome;
                cliente.DataDeNascimento = DataDeNascimento;
                cliente.Cpf = Cpf;
                cliente.DiasParaDevolucao = DiasParaDevolucao;
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