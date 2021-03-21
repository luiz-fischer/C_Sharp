using System;
using System.Collections.Generic;

namespace Controller
{
    public class Book
    {
        public static Model.Book CreateBook(
            string Name,
            string Author,
            string Editor,
            string StringDate
        )
        {
            DateTime ConvertedDate = Convert.ToDateTime(StringDate);

            if (ConvertedDate.Year > DateTime.Now.Year)
            {
                throw new Exception("Ano Inválido!");
            }

            return new Model.Book(
                Name,
                Author,
                Editor,
                ConvertedDate
            );
        }

        public static IEnumerable<Model.Book> GetBooks()
        {
            return Model.Book.GetBooks();
        }

        public static Model.Book GetBook(int IdBook)
        {
            int ListLenght = Model.Book.GetCount();

            if (IdBook < 0 || ListLenght <= IdBook)
            {
                throw new Exception("Id Inválido!");
            }

            return Model.Book.GetBook(IdBook);
        }
    }
}