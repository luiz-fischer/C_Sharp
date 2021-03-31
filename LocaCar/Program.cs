using System;

namespace csharp_vehicles
{
    public class Program
    {
        public static void Main()
        {
            int opcao;
            Console.WriteLine("------------- Loca Car -------------");
            do {
                Console.WriteLine("Digite a operação de Menu");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Lista de Clientes");
                Console.WriteLine("3 - Atualizar Inf. Clientes");
                Console.WriteLine("4 - Deletar Cliente");
                Console.WriteLine("5 - Cadastrar Veículo Pesado");
                Console.WriteLine("6 - Lista de Veículos Pesados");
                Console.WriteLine("7 - Cadastrar Veículo Leve");
                Console.WriteLine("8 - Lista de Veículos Leves");
                Console.WriteLine("9 - Cadastrar Locação");
                Console.WriteLine("10 - Lista de Locações");
                Console.WriteLine("11 - Importar Informações");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao) {
                    case 0:
                        // Encerrar 
                        break;
                    case 1:
                        View.Cliente.CriarCliente();
                        break;
                    case 2:
                        View.Cliente.ListarCliente();
                        break;
                    case 3:
                        View.Cliente.AtualizarCliente();
                        break;
                    case 4:
                        break;
                    case 5:
                        View.VeiculoPesado.CriarVeiculo();
                        break;
                    case 6:
                        View.VeiculoPesado.ListarVeiculos();
                        break;
                    case 7:
                        View.VeiculoLeve.CriarVeiculo();
                        break;
                    case 8:
                        View.VeiculoLeve.ListarVeiculos();
                        break;
                    case 9:
                        View.Locacao.CriarLocacao ();
                        break;
                    case 10:
                        View.Locacao.ListarLocacao ();
                        break;
                    case 11:
                        View.Import.DBImport ();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while(opcao != 0);
        }

    }
}
