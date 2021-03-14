using System;
using System.Collections.Generic;

namespace View {
    public class VeiculoLeve {
        public static void CriarVeiculo () {
            Console.WriteLine ("Marca do Veículo: ");
            string Marca = Console.ReadLine ();
            Console.WriteLine ("Modelo do Veículo: ");
            string Modelo = Console.ReadLine ();
            Console.WriteLine ("Ano do Veículo: ");
            string Ano = Console.ReadLine ();
            Console.WriteLine ("Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine ();
            Console.WriteLine ("Cor do Veículo: ");
            string Cor = Console.ReadLine ();

            Controller.VeiculoLeve.CriarVeiculoLeve (Marca, Modelo, Ano, Preco, Cor);
        }

        public static void ListarVeiculos () {
            List<Model.VeiculoLeve> VeiculosLeve = Controller.VeiculoLeve.ListarVeiculoLeve ();

            foreach (Model.VeiculoLeve veiculo in VeiculosLeve) {
                Console.WriteLine ("\n--------Veículos Leve--------");
                Console.WriteLine (veiculo);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
    }
}
