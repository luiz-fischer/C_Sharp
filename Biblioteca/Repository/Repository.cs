using System.Collections.Generic;
using Model;

namespace Repository
{
    public class Context 
    {
        public static readonly List<Book> books = new ();
        public static readonly List<Rent> rents = new ();
        public static readonly List<Student> students = new ();
        public static readonly List<RentBooks> rentBooks = new ();

    }
}