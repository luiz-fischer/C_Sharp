using System;
using System.Collections.Generic;

namespace View
{
    public static class Student 
    {
        public static void CreateStudent ()
        {
            Console.WriteLine ("Escreva o seu Nome:");
            string Name = Console.ReadLine ();
            Console.WriteLine ("Escreva o seu E-Mail:");
            string Email = Console.ReadLine ();
            Console.WriteLine ("Escreva a quantidade de dias:");
            string RentedDays = Console.ReadLine ();
            try {
                Controller.Student.CreateStudent (Name, Email, RentedDays);
            } catch (Exception e) {
                Console.WriteLine ("Erro" + e.Message);
            }
        }

         public static void ListStudentByName() 
        {
            Console.WriteLine("Nome do Aluno: ");
            string StudentName = Console.ReadLine ();
            Controller.Student.GetStudentNames(StudentName);
            
            foreach (Model.Student book in Controller.Student.GetStudentNames(StudentName))
            {
                Console.WriteLine("\n----");
                Console.WriteLine(book);
                Console.WriteLine("\n-------");
            }
            
        }

        public static void ListStudent () {
            foreach (Model.Student student in Controller.Student.ListStudent ()) {
                Console.WriteLine ("\n-----------INCIO-----------");
                Console.WriteLine (student);
                Console.WriteLine ("\n-------------FIM-------------");

            }
        }
    }
}