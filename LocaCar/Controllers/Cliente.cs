using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller {
    public static class Cliente {
        public static void CriarCliente (
            string Nome,
            string DataDeNascimento,
            string Cpf,
            string DiasParaDevolucao
        ) {
            // Metodo para verificar o formato do CPF 999.999.999-99
            Regex rgx = new ("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch (Cpf)) {
                throw new Exception ("C.P.F. Inválido");
            }

            // Metodo para verificar formatado da dada dd/MM/yyyy
            Regex rgxDate = new ("^\\d{2}\\/\\d{2}\\/\\d{4}$");
            if (!rgxDate.IsMatch (DataDeNascimento)) {
                throw new Exception ("Data de Nascimento Inválida");
            }

           Model.Cliente cliente = new Model.Cliente(
                Nome,
                DataDeNascimento,
                Cpf,
                Convert.ToInt32(DiasParaDevolucao)
            );
            List<Model.Cliente> clientes = Model.Cliente.GetCliente();
            foreach (Model.Cliente item in clientes)
            {
                if (item.Equals(cliente)) {
                    throw new Exception("ID Inválido. Digite novamente.");
                }
            }
            Model.Cliente.AddCliente(cliente);
        }
        public static List<Model.Cliente> ListarCliente () {
            return Model.Cliente.GetCliente ();
        }
    }
}
