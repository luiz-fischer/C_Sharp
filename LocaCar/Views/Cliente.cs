using System;
using System.Collections.Generic;

namespace View {
    public class Cliente {
        public static void CriarCliente () {
            Console.WriteLine ("Nome e Sobrenome: ");
            string Nome = Console.ReadLine ();
            Console.WriteLine ("Data de Nascimento: ");
            string DataDeNascimento = Console.ReadLine ();
            Console.WriteLine ("CPF do Cliente: ");
            string Cpf = Console.ReadLine ();
            Console.WriteLine ("Informe a quantidade de dias de locação: ");
            string DiasParaDevolucao = Console.ReadLine ();
            try {
                Controller.Cliente.CriarCliente (Nome, DataDeNascimento, Cpf, DiasParaDevolucao);
            } catch (Exception e) {
                Console.WriteLine ("Erro: " + e.Message);
            }
        }

        public static void AtualizarCliente() {
            Model.Cliente cliente;
            try {
                Console.WriteLine("Escreva o ID: ");
                string Id = Console.ReadLine();
                cliente = Controller.Cliente.GetCliente(Id);
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
            
            Console.WriteLine("Escolha uma Opção para alterar: [1] Nome [2] CPF");
            string campo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string valor = Console.ReadLine();
            try {
                Controller.Cliente.AtualizarCliente(cliente, campo, valor);
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }

        public static void DeletarCliente() {
            try {
                Console.WriteLine("Informe o ID do Cliente: ");
                string Id = Console.ReadLine();
                Controller.Cliente.DeletarCliente(Convert.ToInt32(Id));
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        } 
        public static void ListarCliente () {
            foreach (Model.Cliente cliente in Controller.Cliente.ListarCliente ()) {
                Console.WriteLine ("\n-----------INCIO-----------");
                Console.WriteLine (cliente);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }

        public static void ListarClientePeloNome() 
        {
            Console.WriteLine("Nome do Cliente: ");
            string NomeCliente = Console.ReadLine ();
            Controller.Cliente.GetNomeClientes(NomeCliente);
            
            foreach (Model.Cliente cliente in Controller.Cliente.GetNomeClientes(NomeCliente))
            {
                Console.WriteLine("\n----");
                Console.WriteLine(cliente);
                Console.WriteLine("\n-------");
            }
            
        }

        public static void MenuCliente () 
        {
            int opcao;

            do {
                Console.WriteLine("[   ] Escolha uma opção ");
                Console.WriteLine("[ 1 ] Cadastrar Cliente");
                Console.WriteLine("[ 2 ] Atualizar Informações do Cliente");
                Console.WriteLine("[ 3 ] Deletar Cliente");
                Console.WriteLine("[ 4 ] Listar Clientes");
                Console.WriteLine("[ 5 ] Pesquisar Clientes Pelo Nome");
                Console.WriteLine("[ 0 ] Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        //fechar
                        break;
                    case 1:
                        CriarCliente();
                        break;
                    case 2:
                        AtualizarCliente();
                        break;
                    case 3:
                        DeletarCliente();
                        break;
                    case 4:
                        ListarCliente();
                        break;
                    case 5:
                        ListarClientePeloNome();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }

            } while (opcao !=0);
        }
    }
}
