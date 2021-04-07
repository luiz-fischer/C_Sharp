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

        private static readonly List<Cliente> Clientes = new();

        public Cliente()
        {

        }
        public Cliente(
            string Nome,
            DateTime DataDeNascimento,
            string Cpf,
            int DiasParaDevolucao
        )
        {
            Context db = new Context();
            // this.Id = Context.Clientes.Count;
            this.Nome = Nome;
            this.DataDeNascimento = DataDeNascimento;
            this.Cpf = Cpf;
            this.DiasParaDevolucao = DiasParaDevolucao;
            this.Locacoes = new();

            db.Clientes.Add(this);
            db.SaveChanges();
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

        public static IEnumerable<Cliente> GetClientes()
        {
            Context db = new Context();
            return from cliente in db.Clientes select cliente;
        }

        public static Cliente GetCliente(int Id)
        {
            Context db = new Context();
            IEnumerable<Cliente> query = from cliente in db.Clientes where cliente.Id == Id select cliente;

            return query.First();
        }

        public static void AddCliente(Cliente cliente)
        {
            Context db = new Context();
            db.Clientes.Add(cliente);
        }

        public static int GetCount()
        {
            return GetClientes().Count();
        }


        public static Cliente AtualizarCliente(
            Cliente cliente,
            int Campo,
            string Valor
        )
        {
            switch (Campo)
            {
                case 1:
                    cliente.Nome = Valor;
                    break;
                case 2:
                    cliente.Cpf = Valor;
                    break;

            }
            Context db = new Context();
            db.Clientes.Update(cliente);
            db.SaveChanges();

            return cliente;
        }

        public static Cliente GetLast()
        {
            return GetClientes().Last();
        }

        public static Cliente DeletarCliente(int Id)
        {
            Cliente cliente = GetCliente(Id);
            Context db = new Context();
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return cliente;

        }

        public static IEnumerable<Cliente> GetNomeCliente (string Nome) 
        {
            // Cliente cliente = GetNomeCliente(Nomes);
            Context db = new Context();

            return ( from cliente in db.Clientes where cliente.Nome.ToLower().Contains(Nome) orderby cliente.Nome select cliente).ToList();
        }

    }
}
