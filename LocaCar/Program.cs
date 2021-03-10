using System;

namespace csharp_vehicles
{
    public class Program
    {
        /// <summary>
        /// Start the system
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {
            int opt;
            Console.WriteLine("------------- Loca Car -------------");
            // Always repeat until the user leaves
            do {
                Console.WriteLine("Digite a operação de Menu");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Lista de Clientes");
                Console.WriteLine("3 - Cadastrar Veículo Pesado");
                Console.WriteLine("4 - Lista de Veículos Pesados");
                Console.WriteLine("5 - Cadastrar Veículo Leve");
                Console.WriteLine("6 - Lista de Veículos Leves");
                Console.WriteLine("7 - Cadastrar Locação");
                Console.WriteLine("8 - Lista de Locações8");
                Console.WriteLine("0 - Sair");
                // Get the user option
                opt = Convert.ToInt32(Console.ReadLine());
                switch(opt) {
                    case 0:
                        // Close system
                        break;
                    case 1:
                        View.Cliente.CriarCliente();
                        break;
                    case 2:
                        View.Cliente.ListarCliente();
                        break;
                    case 3:
                        View.VeiculoPesado.CriarVeiculo();
                        break;
                    case 4:
                        View.VeiculoPesado.ListarVeiculos();
                        break;
                    case 5:
                        View.VeiculoLeve.CriarVeiculo();
                        break;
                    case 6:
                        View.VeiculoLeve.ListarVeiculos();
                        break;
                    case 7:
                        View.Locacao.CriarLocacao ();
                        break;
                    case 8:
                        View.Locacao.ListarLocacao ();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while(opt != 0);
        }

    }
}
