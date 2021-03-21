using System;
using View;


namespace ShowCase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("------------- Biblioteca -------------");
            do {
                Console.WriteLine("Digite a operação de Menu");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Lista de Alunos");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Lista de Livros");
                Console.WriteLine("5 - Cadastrar Locação");
                Console.WriteLine("6 - Lista de Locações");
                Console.WriteLine("7 - Importar Informações");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao) {
                    case 0:
                        // Encerrar 
                        break;
                    case 1:
                        View.Student.CreateStudent();
                        break;
                    case 2:
                        View.Student.ListStudent();
                        break;
                    case 3:
                        View.Book.CreateBook();
                        break;
                    case 4:
                        View.Book.ListBooks();
                        break;
                    case 5:
                        View.Rent.CreateRent();
                        break;
                    case 6:
                        View.Rent.ListRent();
                        break;
                    case 7:
                        View.Import.DBImport();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while(opcao != 0);
        }
    }
}
