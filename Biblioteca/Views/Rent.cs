using System;
using System.Collections.Generic;
namespace View
{
    public static class Rent
    {
        public static void CreateRent()
        {
            int opt;
            int optBook;
            List<Model.Book> Books = new();

            Console.WriteLine("Escreva o Id do Aluno:");
            string IdStudent = Console.ReadLine();
            Console.WriteLine("Data Da Locação: ");
            string RentDate = Console.ReadLine();


            Console.WriteLine ("Foram locados Livros? [1] Sim [2] Não");
            opt = Convert.ToInt32 (Console.ReadLine ());
            if (opt == 1) {
                do {
                    Console.WriteLine ("Informe o Id do Livro: ");
                    try {
                        int IdBook = Convert.ToInt32 (Console.ReadLine ());
                        Model.Book book = Controller.Book.GetBook (IdBook);
                        Books.Add (book);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    Console.WriteLine ("Deseja informar outro Livro? [1] Sim [2] Não");
                    optBook = Convert.ToInt32 (Console.ReadLine ());
                } while (optBook == 1);
            }

            try {
                Controller.Rent.CreateRent (IdStudent, RentDate, Books);
            } catch (Exception e) {
                Console.WriteLine ("Informações digitadas são incorretas: " + e.Message);
            }
        }

        public static void ListRent()
        {
            foreach (Model.Rent Rent in Controller.Rent.GetRent())
            {
                Console.WriteLine("\n-----------INCIO-----------");
                Console.WriteLine(Rent);
                Console.WriteLine("\n-------------FIM-------------");

            }
        }
    }

}