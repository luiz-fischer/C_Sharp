using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public static class Student
    {
        public static Model.Student CreateStudent(
            string Name,
            string Email,
            string RentedDays
        )
        {
            return new Model.Student(
                Name,
                Email,
                Convert.ToInt32(RentedDays)
            );
        }

        public static IEnumerable<Model.Student> ListStudent()
        {
            return Model.Student.GetStudents();
        }

        public static IEnumerable<Model.Student> GetStudentNames(string Name)
        {
            return Model.Student.GetStudentNames(Name);
        }

        public static Model.Student GetStudent(int IdStudent)
        {
            int ListLenght = Model.Student.GetCount();

            if (IdStudent < 0 || ListLenght <= IdStudent)
            {
                throw new Exception("Id Inválido!");
            }

            return Model.Student.GetStudent(IdStudent);
        }
    }

}