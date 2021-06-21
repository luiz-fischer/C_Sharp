using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using System.Windows.Forms;

namespace Controller
{
    public partial class Cliente 
    {
        public static string CadastrarCliente(
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
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }
            new Model.Cliente(
                nome,
                dataNascimento,
                cpf,
                diasDevolucao
            );

            return "Cadastrado Com Sucesso!";

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
            Context db = new();
            try
            {
                Model.Cliente cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
                db.Remove(cliente);
                db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }
        }

    }
}