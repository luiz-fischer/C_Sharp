using System;
using System.Collections.Generic;

namespace View {
    public static class Locacao {
        public static void CriarLocacao () {
            int opcao;
            int opcaoVeiculoLeve;
            int opcaoVeiculoPesado;
            List<Model.VeiculoLeve> VeiculosLeve = new ();
            List<Model.VeiculoPesado> VeiculosPesado = new ();
            
            Console.WriteLine("Id do Cliente: ");
            string IdCliente = Console.ReadLine ();
            Console.WriteLine("Data Da Locação: ");
            string DataDeLocacao = Console.ReadLine ();

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("\n[1] - Veículos Leve" + "\n[2] - Veículos Pesados" + "\n[0] - CANCELAR");
            Console.WriteLine("\n-------------------------");

            opcao = Convert.ToInt32(Console.ReadLine());
            switch(opcao) {
                    case 0:
                        // Encerrar
                        break;
                    case 1:
                    do {
                            Console.WriteLine ("Informe o Id do Veículo Leve: ");
                            try {
                                int IdVeiculo = Convert.ToInt32 (Console.ReadLine ());
                                Model.VeiculoLeve veiculo = Controller.VeiculoLeve.GetVeiculoLeve (IdVeiculo);
                                VeiculosLeve.Add (veiculo);
                            } catch (Exception e) {
                                Console.WriteLine ("Erro Veiculo Leve" + e.Message);
                            }
                            Console.WriteLine ("Deseja informar outro veículo?" + "\n[1] Sim" + "    [2] Não");
                            opcaoVeiculoLeve = Convert.ToInt32 (Console.ReadLine ());
                    } while (opcaoVeiculoLeve == 1);
                        break;
                    case 2:
                            do {
                                Console.WriteLine ("Informe o Id do Veículo Pesado: ");
                                try {
                                    int IdVeiculoPesado = Convert.ToInt32 (Console.ReadLine ());
                                    Model.VeiculoPesado veiculo = Controller.VeiculoPesado.GetVeiculoPesado (IdVeiculoPesado);
                                    VeiculosPesado.Add (veiculo);
                                } catch (Exception e) {
                                    Console.WriteLine ("Erro Veículo Pesado" + e.Message);
                                }
                                Console.WriteLine ("Deseja informar outro veículo? \n[1] Sim" + "    [2] Não");
                                opcaoVeiculoPesado = Convert.ToInt32 (Console.ReadLine ());
                            } while (opcaoVeiculoPesado == 1);
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
            }

            
            try {
                Controller.Locacao.CriarLocacao (IdCliente, DataDeLocacao, VeiculosLeve, VeiculosPesado);
            } catch (Exception e) {
                Console.WriteLine ("Erro de Cadastro: " + e.Message);
            }
        }
        public static void ListarLocacao () {
            foreach (Model.Locacao Locacao in Controller.Locacao.GetLocacao ()) {
                Console.WriteLine ("\n----------INíCIO---------");
                Console.WriteLine (Locacao);
                Console.WriteLine ("\n------------FIM------------");
            }
        }
    }
}
