using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Controller
{
    public static class Cliente
    {
        public static void CadastrarCliente(
            string nome,
            string dataNascimento,
            string cpf,
            int diasDevolucao
        )
        {
            DateTime dtNasc;
            try
            {
                dtNasc = Convert.ToDateTime(dataNascimento);
            }
            catch
            {
                Console.WriteLine("FORMATO INVÁLIDO!");
                dtNasc = DateTime.Now;
            }

            new Model.Cliente(
                nome,
                dataNascimento,
                cpf,
                diasDevolucao
            );

        }
        public static void AtualizaCliente(
            int idCliente,
            string nome,
            string dataNascimento,
            string cpf,
            int diasDevolucao
        )

        {
            Model.Cliente.AtualizaCliente(
            idCliente,
            nome,
            dataNascimento,
            cpf,
            diasDevolucao);
        }
 
        public static Model.Cliente GetCliente(int idCliente)
        {
            return Model.Cliente.GetCliente(idCliente);
        }

        public static List<Model.Cliente> GetClientes()
        {
            return Model.Cliente.GetClientes();
        }

        public static void DeletarCliente(int idCliente)
        {
            Context db = new Context();
            try
            {
                Model.Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
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