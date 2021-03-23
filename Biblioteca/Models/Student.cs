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

        public Student(
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
                 "\n|    Id do Aluno: {0}" + 
                 "\n|    Nome: {1}" + 
                 "\n|    Email: {2}" + 
                 "\n|    Dias de Locação: {3:d} dia(s)" +
                 "\n|    Qtd. Locações: {4}",
                this.IdStudent, 
                this.Name,
                this.Email,
                this.RentedDays,
                Rent.GetCount(this.IdStudent)

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
            Student student = (Student)obj;
            return this.GetHashCode() == student.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.IdStudent.GetHashCode();
                return hash;
            }
        }

        public static Student GetStudent(int IdStudent) 
        {
            IEnumerable<Student> query = from student in Context.students where student.IdStudent == IdStudent select student;

            return query.First ();
        }

        public static IEnumerable<Student> GetStudentNames (string Name) 
        {
          return (
                from student in Context.students
                where student.Name.ToLower().Contains(Name)
                orderby student.Name
                select student
            ).ToList();
        }

        public static IEnumerable<Student> GetStudents() 
        {
            return from student in Context.students select student;
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