using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoPesado
    {
        public static void CriarVeiculo()
        {
            Console.WriteLine("Marca do Veículo: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo do Veículo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Ano do Veículo: ");
            string Ano = Console.ReadLine();
            Console.WriteLine("Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine();
            Console.WriteLine("Restrições do Veículo: ");
            string Restricoes = Console.ReadLine();

            Controller.VeiculoPesado.CriarVeiculoPesado(Marca, Modelo, Ano, Preco, Restricoes);
        }

        public static void ListarVeiculos()
        {
            foreach (Model.VeiculoPesado veiculo in Controller.VeiculoPesado.GetVeiculoPesado())
            {
                Console.WriteLine("\n---------INíCIO---------");
                Console.WriteLine(veiculo);
                Console.WriteLine("\n--------------FIM--------------");

            }
        }
        public static void AtualizarVeiculoPesado()
        {
            Model.VeiculoPesado veiculoPesado;
            try
            {
                Console.WriteLine("Escreva o ID: ");
                string Id = Console.ReadLine();
                veiculoPesado = Controller.VeiculoPesado.GetVeiculoPesado(Convert.ToInt32(Id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            Console.WriteLine("Escolha uma Opção para alterar:\n [1] Marca \n [2] Modelo \n [3] Ano \n [4] Restrições \n [5] Preço");
            string campo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string valor = Console.ReadLine();
            try
            {
                Controller.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeletarVeiculoPesado()
        {
            try
            {
                Console.WriteLine("Informe o ID do Veiculo Pesado: ");
                string Id = Console.ReadLine();
                Controller.VeiculoPesado.DeletarVeiculoPesado(Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void MenuVeiculoPesado () 
        {
            int opcao;

            do {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("\n [ 1 ] Cadastrar Veiculo Pesado");
                Console.WriteLine("\n [ 2 ] Atualizar Informações do Veiculo Pesado");
                Console.WriteLine("\n [ 3 ] Deletar Veiculo Pesado");
                Console.WriteLine("\n [ 0 ] Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        //fechar
                        break;
                    case 1:
                        CriarVeiculo();
                        break;
                    case 2:
                        AtualizarVeiculoPesado();
                        break;
                    case 3:
                        DeletarVeiculoPesado();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }

            } while (opcao !=0);
        }
    }
}
