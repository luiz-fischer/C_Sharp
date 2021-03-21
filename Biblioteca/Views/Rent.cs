using System;
using System.Collections.Generic;
namespace View
{
    public static class Rent
    {
        public static void CreateRent()
        {
            List<Model.Book> Books = new();

            Console.WriteLine("Escreva o Id do Aluno:");
            string IdStudent = Console.ReadLine();
            Console.WriteLine("Data Da Locação: ");
            string RentDate = Console.ReadLine();

            Console.WriteLine("Informe Id do Livro: ");
            try
            {
                int IdBook = Convert.ToInt32(Console.ReadLine());
                Model.Book book = Controller.Book.GetBook(IdBook);
                Books.Add(book);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Livro" + e.Message);
            }
            try
            {
                Controller.Rent.CreateRent(IdStudent, RentDate, Books);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de Cadastro" + e.Message);
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