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
            foreach (Model.Cliente cliente in Controller.Cliente.ListarCliente ()) {
                Console.WriteLine ("\n-----------INCIO-----------");
                Console.WriteLine (cliente);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
    }
}
