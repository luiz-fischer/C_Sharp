using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model 
{

    public class Book 
    {
        public int IdBook {set; get; }
        public string Author { set; get; }
        public string Editor { set; get; }

        public DateTime Date { set; get; }

        private static readonly List<Book> books = new();

        public Book(
            string Author,
            string Editor,
            DateTime Date
        ) 
        {
            this.IdBook = Context.books.Count;
            this.Author = Author;
            this.Editor = Editor;
            this.Date = Date;

            Context.books.Add (this);
        }

        public override string ToString()
        {
            return String.Format(
                 "\n|    Id: {0}" + 
                 "\n|" +
                 "\n|    Autor: {1}" + 
                 "\n|    Editor: {2}" + 
                 "\n|    Data: {3:d} dias",
                this.IdBook, 
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
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }
        public static IEnumerable<Book> GetBooks () 
        {
            return from book in Context.books select book;
        }
        public static Book GetBook (int IdBook) 
        {
            IEnumerable<Book> query = from book in Context.books where Book.IdBook == IdBook select book;

            return query.First ();
        }

        public static int GetCount () 
        {
            return GetBooks().Count();
        }
    }

}