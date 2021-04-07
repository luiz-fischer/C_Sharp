using System;
// using System.Windows.Forms;

namespace C_Sharp
{
    public class Program
    {
        
        public static void Main()
        {
            int opcao;
            Console.WriteLine("------------- Loca Car -------------\n");
            do
            {
                Console.WriteLine("[ Digite a operação de Menu ]");
                Console.WriteLine("[ 1 ] - Cliente");
                Console.WriteLine("[ 2 ] - Veículo Pesado");
                Console.WriteLine("[ 3 ] - Veículo Leve");
                Console.WriteLine("[ 4 ] - Locação");
                Console.WriteLine("[ 5 ] - Importar Informações");
                Console.WriteLine("[ 0 ] - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        // Encerrar 
                        break;
                    case 1:
                        View.Cliente.MenuCliente();
                        break;
                    case 2:
                        View.VeiculoPesado.MenuVeiculoPesado();
                        break;
                    case 3:
                        View.VeiculoLeve.MenuVeiculoLeve();
                        break;
                    case 4:
                        View.Locacao.MenuLocacao();
                        break;
                    case 5:
                        View.Import.DBImport();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while (opcao != 0);
        }

    }
}
