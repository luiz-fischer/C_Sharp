using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms; 
namespace Controller {
    public static class Cliente {
        public static Model.Cliente CriarCliente (
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


           return new Model.Cliente(
                Nome,
                DataDeNascimento,
                Cpf,
                Convert.ToInt32(DiasParaDevolucao)
            );
        }
        public static IEnumerable<Model.Cliente> ListarCliente () {
            return Model.Cliente.GetClientes ();
        }

        public static Model.Cliente GetCliente (string StringId) {
            int Id = Convert.ToInt32(StringId);
            Model.Cliente LastCliente = Model.Cliente.GetLast();

            if (Id < 0 || LastCliente.Id < Id) {
                throw new Exception ("Id informado é inválido.");
            }

            return Model.Cliente.GetCliente (Id);
        }

        public static Model.Cliente AtualizarCliente( 
            Model.Cliente cliente,
            string StringCampo,
            string Valor
        ) {
            int campo = Convert.ToInt32(StringCampo);

            switch(campo) {
                case 1:
                    return Model.Cliente.AtualizarCliente(cliente, 1, Valor);
                case 2:
                    Regex rgx = new ("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
                    if (!rgx.IsMatch (Valor)) {
                        throw new Exception ("C.P.F. Inválido");
              }
                    return Model.Cliente.AtualizarCliente(cliente, 2, Valor);
                default: 
                    throw new Exception("Opção Invalida!");
                
            }
        }

        public static void DeletarCliente(int Id)
        {
            try {
                Model.Cliente.DeletarCliente(Id);
            } catch (Exception e) {
                Console.WriteLine(e.InnerException.Message);
            }
        }

         public static IEnumerable<Model.Cliente> GetNomeClientes(string Name)
        {
            return Model.Cliente.GetNomeCliente(Name);
        }
        
    }
}