using System;
using System.Collections.Generic;
namespace View
{
    public static class Book 
    {
        // List<Model.Book> Books = new ();
        public static void CreateBook ()
        {
            Console.WriteLine("Autor(a) do Livro: ");
            string Author = Console.ReadLine ();
            Console.WriteLine("Editor(a) do Livro: ");
            string Editor = Console.ReadLine ();
            Console.WriteLine("Data de Publicação: ");
            string Date = Console.ReadLine ();

            Controller.Book.CreateBook (Author, Editor, Date);
            
        }

        public static void ListBooks () {
            foreach (Model.Book book in Controller.Book.ListBook ()) {
                Console.WriteLine ("\n-----------INCIO-----------");
                Console.WriteLine (book);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
    }
}