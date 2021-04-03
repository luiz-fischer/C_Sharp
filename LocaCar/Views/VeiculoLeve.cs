using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoLeve
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
            Console.WriteLine("Cor do Veículo: ");
            string Cor = Console.ReadLine();

            Controller.VeiculoLeve.CriarVeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
        }

<<<<<<< Updated upstream
        public static void ListarVeiculos () {
            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.ListarVeiculoLeve ()) {
                Console.WriteLine ("\n----------INíCIO----------");
                Console.WriteLine (veiculo);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
=======
        public static void ListarVeiculos()
        {
            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.GetVeiculosLeve())
            {
                Console.WriteLine("\n----------INíCIO----------");
                Console.WriteLine(veiculo);
                Console.WriteLine("\n-------------FIM-------------");

            }
        }

        public static void AtualizarVeiculoLeve()
        {
            Model.VeiculoLeve veiculoLeve;
            try
            {
                Console.WriteLine("Escreva o ID: ");
                string Id = Console.ReadLine();
                veiculoLeve = Controller.VeiculoLeve.GetVeiculoLeve(Convert.ToInt32(Id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            Console.WriteLine("Escolha uma Opção para alterar:\n [1] Marca \n [2] Modelo \n [3] Ano \n [4] Cor \n [5] Preço");
            string campo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string valor = Console.ReadLine();
            try
            {
                Controller.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, campo, valor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeletarVeiculoLeve()
        {
            try
            {
                Console.WriteLine("Informe o ID do Veiculo Leve: ");
                string Id = Console.ReadLine();
                Controller.VeiculoLeve.DeletarVeiculoLeve(Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void MenuVeiculoLeve () 
        {
            int opcao;

            do {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("\n [ 1 ] Cadastrar Veiculo Leve");
                Console.WriteLine("\n [ 2 ] Atualizar Informações do Veiculo Leve");
                Console.WriteLine("\n [ 3 ] Deletar Veiculo Leve");
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
                        AtualizarVeiculoLeve();
                        break;
                    case 3:
                        DeletarVeiculoLeve();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }

            } while (opcao !=0);
        }
>>>>>>> Stashed changes
    }
}
