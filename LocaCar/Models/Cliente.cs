using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; } 
        public string Nome { set; get; } 
        public DateTime DataDeNascimento { set; get; } 
        public string Cpf;
        public int DiasParaDevolucao { set; get; } 

        public List<Locacao> Locacoes { set; get; }

        private static readonly List<Cliente> clientes = new();

        public Cliente(
            string Nome,
            DateTime DataDeNascimento,
            string Cpf,
            int DiasParaDevolucao
        )
        {
            this.Id = Context.clientes.Count;
            this.Nome = Nome;
            this.DataDeNascimento = DataDeNascimento;
            this.Cpf = Cpf;
            this.DiasParaDevolucao = DiasParaDevolucao;
            this.Locacoes = new ();

            // clientes.Add(this);
            Context.clientes.Add (this);
        }

        public override string ToString()
        {
            return String.Format(
                 "\n|    Id: {0}" + 
                 "\n|" +
                 "\n|    Nome: {1}" + 
                 "\n|    Data de Nascimento: {2:d}" + 
                 "\n|    Devolução em: {3} dias" +
                 "\n|    Locações: {4}",
                this.Id, 
                this.Nome,
                this.DataDeNascimento,
                this.DiasParaDevolucao,
                // this.Locacoes.Count,
                Locacao.GetCount(this.Id)

            );
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Cliente cliente = (Cliente)obj;
            return this.GetHashCode() == cliente.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static IEnumerable<Cliente> GetClientes ()
        {
            return from cliente in Context.clientes select cliente;
        }

        public static Cliente GetCliente(int Id)
        {
            IEnumerable<Cliente> query = from cliente in Context.clientes where cliente.Id == Id select cliente;

            return query.First();
        }

        public static void AddCliente(Cliente cliente)
        {
            // clientes.Add(cliente);
            Context.clientes.Add (cliente);
        }

        public static int GetCount () {
            return GetClientes().Count();
        }

    }
}
