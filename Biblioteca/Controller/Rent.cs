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
            Model.Student Student = Model.Student.GetStudent(Convert.ToInt32(IdStudent));

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
                throw new Exception("Ano superior ao atual!");
            }

            if (RentDate.Year < DateTime.Now.Year)
            {
                throw new Exception("Ano inferior ao atual!");
            }

            if (RentDate.Month < DateTime.Now.Month)
            {
                throw new Exception("Mês inválido");
            }

            if (RentDate.Day < DateTime.Now.Day)
            {
                throw new Exception("Dia inválido");
            }

            return new Model.Rent(
                Student,
                RentDate,
                Books
            );
        }

        public static IEnumerable<Model.Rent> GetRent()
        {
            return Model.Rent.GetRent();
        }
    }
}