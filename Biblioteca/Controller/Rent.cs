using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Rent
    {
        public static Model.Rent CreateRent(
            string IdStudent,
            string StringRentDate,
            List<Model.Book> Books
        )
        {

            Model.Student Student = Controller.Student.GetStudent (Convert.ToInt32 (IdStudent));

            DateTime RentDate;

            try
            {
                RentDate = Convert.ToDateTime(StringRentDate);
            }
            catch
            {
                RentDate = DateTime.Now;
            }

            if (RentDate.Year > DateTime.Now.Year)
            {
                throw new Exception("\n--Ano superior ao atual!");
            }

            if (RentDate.Year < DateTime.Now.Year)
            {
                throw new Exception("\n--Ano inferior ao atual!");
            }

            if (RentDate.Month < DateTime.Now.Month)
            {
                throw new Exception("\n--Mês inválido");
            }

            if (RentDate.Day < DateTime.Now.Day)
            {
                throw new Exception("\n--Dia inválido");
            }

           return new Model.Rent (Student, RentDate, Books);
        }

        public static IEnumerable<Model.Rent> GetRent()
        {
            return Model.Rent.GetRent();
        }
    }
}