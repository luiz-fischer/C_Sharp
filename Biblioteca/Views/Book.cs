using System;
using System.Collections.Generic;
namespace View
{
    public static class Book 
    {
        public static void CreateBook ()
        {
            Console.WriteLine("Nome do Livro: ");
            string Name = Console.ReadLine ();
            Console.WriteLine("Autor(a) do Livro: ");
            string Author = Console.ReadLine ();
            Console.WriteLine("Editor(a) do Livro: ");
            string Editor = Console.ReadLine ();
            Console.WriteLine("Data de Publicação: ");
            string Date = Console.ReadLine ();

            Controller.Book.CreateBook (Name, Author, Editor, Date);
            
        }

        public static void ListBooks () {
            foreach (Model.Book book in Controller.Book.GetBooks ()) {
                Console.WriteLine ("\n-----------INCIO-----------");
                Console.WriteLine (book);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }

        public static void ListBookByName() 
        {
            Console.WriteLine("Nome do Livro: ");
            string BookName = Console.ReadLine ();
            Controller.Book.GetBookNames(BookName);
            
            foreach (Model.Book book in Controller.Book.GetBookNames(BookName))
            {
                Console.WriteLine("\n----");
                Console.WriteLine(book);
                Console.WriteLine("\n-------");
            }
            
        }

    }
}