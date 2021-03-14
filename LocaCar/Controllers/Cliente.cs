using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller {
    public static class Cliente {
        public static void CriarCliente (
            string Nome,
            string StringDataDeNascimento,
            string Cpf,
            string DiasParaDevolucao
        ) {
            // Metodo para verificar o formato do CPF 999.999.999-99
            Regex rgx = new ("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch (Cpf)) {
                throw new Exception ("C.P.F. Inválido");
            }

            DateTime DataDeNascimento;

            try {
                DataDeNascimento = Convert.ToDateTime (StringDataDeNascimento);
            } catch {
                throw new Exception ("Data de Nascimento Inválida");
            }


           Model.Cliente cliente = new Model.Cliente(
                Nome,
                DataDeNascimento,
                Cpf,
                Convert.ToInt32(DiasParaDevolucao)
            );
        }
        public static List<Model.Cliente> ListarCliente () {
            return Model.Cliente.GetClientes ();
        }

        public static Model.Cliente GetCliente (int Id) {
            int ListLenght = Model.Cliente.GetClientes ().Count;

            if (Id < 0 || ListLenght <= Id) {
                throw new Exception ("Id informado é inválido.");
            }

            return Model.Cliente.GetCliente (Id);
        }
        
    }
}