using System;
using System.Collections.Generic;

namespace View {
    public class VeiculoPesado {
        public static void CriarVeiculo () {
            Console.WriteLine ("Marca do Veículo: ");
            string Marca = Console.ReadLine ();
            Console.WriteLine ("Modelo do Veículo: ");
            string Modelo = Console.ReadLine ();
            Console.WriteLine ("Ano do Veículo: ");
            string Ano = Console.ReadLine ();
            Console.WriteLine ("Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine ();
            Console.WriteLine ("Restrições do Veículo: ");
            string Restricoes = Console.ReadLine ();

            Controller.VeiculoPesado.CriarVeiculoPesado (Marca, Modelo, Ano, Preco, Restricoes);
        }

        public static void ListarVeiculos () {
            foreach (Model.VeiculoPesado veiculo in Controller.VeiculoPesado.GetVeiculoPesado ()) {
                Console.WriteLine ("\n---------INíCIO---------");
                Console.WriteLine (veiculo);
                Console.WriteLine ("\n--------------FIM--------------");

            }
        }
    }
}
