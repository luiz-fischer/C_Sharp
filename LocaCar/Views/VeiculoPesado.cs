using System;
using System.Collections.Generic;

namespace View {
    public class VeiculoPesado {
        public static void CriarVeiculo () {
            Console.WriteLine ("Marca do Veículo: ");
            string Brand = Console.ReadLine ();
            Console.WriteLine ("Modelo do Veículo: ");
            string Model = Console.ReadLine ();
            Console.WriteLine ("Ano do Veículo: ");
            string Year = Console.ReadLine ();
            Console.WriteLine ("Preço de Locação do Veículo: ");
            string Price = Console.ReadLine ();
            Console.WriteLine ("Restrições do Veículo: ");
            string Restrictions = Console.ReadLine ();

            Controller.VeiculoPesado.CriarVeiculoPesado (Brand, Model, Year, Price, Restrictions);
        }

        public static void ListarVeiculos () {
            List<Model.VeiculoPesado> veiculosPesado = Controller.VeiculoPesado.GetVeiculoPesado ();

            foreach (Model.VeiculoPesado veiculo in veiculosPesado) {
                Console.WriteLine ("--------Veículos Pesado--------");
                Console.WriteLine (veiculo);
                Console.WriteLine ("--------------FIM--------------");

            }
        }
    }
}
