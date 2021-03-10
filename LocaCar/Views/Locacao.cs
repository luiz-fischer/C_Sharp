using System;
using System.Collections.Generic;

namespace View {
    public static class Locacao {
        public static void CriarLocacao () {
            Console.WriteLine ("Id do Cliente: ");
            string Id = Console.ReadLine ();
            Console.WriteLine ("Id do Veiculo: ");
            string IdVeiculoLeve = Console.ReadLine ();
            Console.WriteLine ("Data da Locação: ");
            string DataDeLocacao = Console.ReadLine ();
            try {
                Controller.Locacao.CriarLocacao (Id, IdVeiculoLeve, DataDeLocacao);
            } catch (Exception e) {
                Console.WriteLine ("Erro: " + e.Message);
            }
        }
        public static void ListarLocacao () {
            List<Model.Locacao> Locacaos = Controller.Locacao.GetLocacao ();
            List<Model.Cliente> clientes = Controller.Cliente.ListarCliente ();
            List<Model.VeiculoLeve> veiculosLeve = Controller.VeiculoLeve.ListarVeiculoLeve ();

            foreach (Model.Locacao Locacao in Locacaos) {
                Console.WriteLine ("----------Locações---------");
                Console.WriteLine (Locacao);
                Console.WriteLine ("------------FIM------------");
            }
        }
    }
}
