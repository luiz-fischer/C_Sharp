using System;
using System.Collections.Generic;

namespace View {
    public static class Cliente {
        public static void CriarCliente () {
            Console.WriteLine ("Nome e Sobrenome: ");
            string Nome = Console.ReadLine ();
            Console.WriteLine ("Data de Nascimento: ");
            string DataDeNascimento = Console.ReadLine ();
            Console.WriteLine ("CPF do Cliente: ");
            string Cpf = Console.ReadLine ();
            Console.WriteLine ("Informe a quantidade de dias de locação: ");
            string DiasParaDevolucao = Console.ReadLine ();
            try {
                Controller.Cliente.CriarCliente (Nome, DataDeNascimento, Cpf, DiasParaDevolucao);
            } catch (Exception e) {
                Console.WriteLine ("Erro: " + e.Message);
            }
        }
        public static void ListarCliente () {
            List<Model.Cliente> clientes = Controller.Cliente.ListarCliente ();

            foreach (Model.Cliente Cliente in clientes) {
                Console.WriteLine ("-----------Cliente-----------");
                Console.WriteLine (Cliente);
                Console.WriteLine ("-------------FIM-------------");

            }
        }
    }
}
