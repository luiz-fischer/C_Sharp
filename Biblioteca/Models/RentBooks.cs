using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class RentBooks
    {
        public int IdRentBooks { set; get; }
        public int IdRent { set; get; }
        public Rent Rent { set; get; }
        public int IdBook { set; get; }
        public Book Book { set; get; }

        public RentBooks(
            Rent Rent,
            Book Book
        )
        {
            this.IdRentBooks = Context.rentBooks.Count;
            this.Rent = Rent;
            this.IdRent = Rent.IdRent;
            this.Book = Book;
            this.IdBook = Book.IdBook;

            Context.rentBooks.Add(this);
        }

        public static IEnumerable<RentBooks> GetBooks(int IdRent)
        {
            return from book in Context.rentBooks where book.IdRent == IdRent select book;
        }
        public static int GetCount(int IdRent)
        {
            return GetBooks(IdRent).Count();
        }
    }
}