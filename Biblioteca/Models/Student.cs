using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model 
{
    public class Student
    {
        public int IdStudent { set; get; } 
        public string Name { set; get; } 
        public string Email { set; get; }
        public int RentedDays { set; get; }
        public List<Rent> Rents { set; get; }

        public static readonly List<Student> students = new ();

        public Student(
            int IdStudent,
            string Name,
            string Email,
            int RentedDays
        )
        {
            this.IdStudent = Context.students.Count;
            this.Name = Name;
            this.Email = Email;
            this.RentedDays = RentedDays;

            Context.students.Add (this);
        }

        public override string ToString()
        {
            return String.Format(
                 "\n|    Id: {0}" + 
                 "\n|" +
                 "\n|    Nome: {1}" + 
                 "\n|    Email: {2}" + 
                 "\n|    Dias de Locação: {3:d} dias",
                this.Id, 
                this.Name,
                this.Email,
                this.RentedDays

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
            Student book = (Student)obj;
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

        public static IEnumerable<Student> GetStudents() 
        {
            return from student in Context.students select student;
        }

        public static GeStudent (int IdStudent) 
        {
            IEnumerable<Book> query = from student in Context.students where Student.IdStudent == IdStudent select student;

            return query.First ();
        }

        public static int GetCount ()
        {
            return GetStudents().Count();
        }

        public static void AddStudent (Student student) 
        {
            Context.students.Add (student);
        }
    }
}