using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Book
    {
        public static Model.Book CreateBook (
            int IdBook,
            string Author,
            string Editor,
            string StringDate
        )
        {
            DateTime ConvertedDate = Convert.ToDateTime(StringDate);
            if (ConvertedDate > DateTime.Now.Year) 
            {
                throw new Exception ("Ano Inválido!");
            }

            Model.Book book = new Model.Book(
                Author,
                Editor,
                Date
            );
        }

        public static IEnumerable<Model.Book> ListBook ()
        {
            return Model.Book.GetBooks ();
        }

        public static Model.Book GetBook (int IdBook)
        {
            int ListLenght = Model.Book.GetCount ();

            if (IdBook < 0 || ListLenght <= IdBook) 
            {
                throw new Exception ("Id Inválido!");
            }

            return Model.Book.GetBook (IdBook);
        }
    }   
}