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

        public static readonly List<RentBooks> dataBase = new ();

        public RentBooks (
            Rent rent,
            Book Book
        )
        {
            this.Rent = Rent;
            this.IdRent = Rent.IdRent;
            this.Book = Book;
            this.IdBook = Book.IdBook;

            Context.rentBooks.Add (this);
        }

        public static IEnumerable<RentBooks> GetBooks (int IdRent)
        {
            return from book in Context.rentBooks where book.IdRent == IdRent select book;
        }
        public static int GetCount(int IdRent) {
            return GetVeiculos(IdRent).Count();
        }
    }
}