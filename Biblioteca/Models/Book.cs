using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model 
{

    public class Book 
    {
        public int IdBook { set; get; }
        public string Name { set; get; }
        public string Author { set; get; }
        public string Editor { set; get; }
        public DateTime Date { set; get; }
        private static readonly List<Book> books = new();

        public Book(
            string Name,
            string Author,
            string Editor,
            DateTime Date
        ) 
        {
            this.IdBook = Context.books.Count;
            this.Name = Name;
            this.Author = Author;
            this.Editor = Editor;
            this.Date = Date;

            Context.books.Add (this);
        }

        public override string ToString()
        {
            return String.Format(
                 "\n|    Id do Livro: {0}" + 
                 "\n|    Nome Do Livro: {1}" +
                 "\n|    Autor: {2}" + 
                 "\n|    Editor: {3}" + 
                 "\n|    Data da Publicação: {4:d} ",
                this.IdBook, 
                this.Name,
                this.Author,
                this.Editor,
                this.Date

            );
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Book book = (Book)obj;
            return this.GetHashCode() == book.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.IdBook.GetHashCode();
                return hash;
            }
        }
        public static IEnumerable<Book> GetBooks () 
        {
            return from book in Context.books select book;
        }
        public static Book GetBook (int IdBook) 
        {
          return (
                from book in Context.books
                where book.IdBook == IdBook
                select book
            ).First();
        }

        public static IEnumerable<Book> GetBookNames (string Name) 
        {
          return (
                from book in Context.books
                where book.Name.ToLower().Contains(Name)
                orderby book.Name
                select book
            ).ToList();
        }
        public static int GetCount () 
        {
            return GetBooks().Count();
        }
    }

}