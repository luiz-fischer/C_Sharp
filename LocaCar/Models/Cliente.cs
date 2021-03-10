using System;
using System.Collections.Generic;

namespace Model
{
    public class Cliente
    {
        private int Id { set; get; } 
        private string Nome { set; get; } 
        private string DataDeNascimento { set; get; } 
        private string Cpf;
        private int DiasParaDevolucao { set; get; } 

        private static readonly List<Cliente> clientes = new();

        public Cliente(
            string Nome,
            string DataDeNascimento,
            string Cpf,
            int DiasParaDevolucao
        )
        {
            this.Id = clientes.Count;
            this.Nome = Nome;
            this.DataDeNascimento = DataDeNascimento;
            this.Cpf = Cpf;
            this.DiasParaDevolucao = DiasParaDevolucao;

            clientes.Add(this);
        }

        public override string ToString()
        {
            return "\nId: " + this.Id +
                   "\nNome: " + this.Nome;
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

        public static List<Cliente> GetCliente()
        {
            return clientes;
        }

        public static Cliente GetCliente(int Id)
        {
            return clientes[Id];
        }

        public static bool VerifyCliente(int Id)
        {
            return Id >= clientes.Count;
        }

        public static void AddCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
    }
}
