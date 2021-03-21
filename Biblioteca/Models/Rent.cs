using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Rent
    {
        public int IdRent { set; get; }
        public int IdStudent { set; get; }
        public Student Student { set; get; }
        public DateTime RentDate { set; get; }

        public Rent(
            Student Student,
            DateTime RentDate,
            List<Book> Books
        )
        {
            this.IdRent = Context.rents.Count;
            this.Student = Student;
            this.IdStudent = Student.IdStudent;
            this.RentDate = RentDate;

            foreach (Book book in Books) {
                RentBooks rentBooks = new (this, book);
            }

            Context.rents.Add(this);
        }

        public override string ToString()
        {
            string Print = String.Format(
                "\n|    +++++ Aluno +++++    {0}" +
                "\n|    Data da Locação: {1:d}" +
                "\n|    Data da Devolução: {2:d}",
                this.Student,
                this.RentDate,
                this.GetReturnDate(),
                Controller.Rent.GetRent()

            );
            Print += "\n| ==> Livros Alugados <== ";
            if (RentBooks.GetCount(this.IdRent) > 0)
            {
                foreach (RentBooks book in RentBooks.GetBooks(this.IdRent))
                {
                    Print += "\n|" + book.Book;
                }
            }
            else
            {
                Print += "\n\n  ==> Sem Registro <==  ";
            }

            return Print;
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
            Rent rent = (Rent)obj;
            return this.GetHashCode() == rent.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.IdRent);
        }
        public static IEnumerable<Rent> GetRent()
        {
            return from rent in Context.rents select rent;
        }

        public static int GetCount(int IdStudent)
        {
            return (
                from rent in Context.rents where rent.IdStudent == IdStudent select rent
            ).Count();
        }

        public DateTime GetReturnDate()
        {
            int DaysForReturn = this.Student.RentedDays;

            return this.RentDate.AddDays(DaysForReturn);
        }

    }
}