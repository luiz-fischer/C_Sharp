using System;
using System.Collections.Generic;

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
            this.Id = clientes.Count;
            this.Nome = Nome;
            this.DataDeNascimento = DataDeNascimento;
            this.Cpf = Cpf;
            this.DiasParaDevolucao = DiasParaDevolucao;
            this.Locacoes = new ();

            clientes.Add(this);
        }

        public override string ToString()
        {
            return String.Format(
                 "\n|    Id: {0}" + 
                 "\n|    Nome: {1}" + 
                 "\n|    Data de Nascimento: {2:d}" + 
                 "\n|    Devolução em: {3} dias" +
                 "\n|    Locações: {4}",
                this.Id, 
                this.Nome,
                this.DataDeNascimento,
                this.DiasParaDevolucao,
                this.Locacoes.Count

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

        public static List<Cliente> GetClientes ()
        {
            return clientes;
        }

        public static Cliente GetCliente(int Id)
        {
            return clientes[Id];
        }

        public static void AddCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
    }
}
