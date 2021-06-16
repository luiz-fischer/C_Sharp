using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());
            Console.WriteLine("Informe o valor do lado do quadrado em metros.");
            q.Lado = Convert.ToInt32(Console.ReadLine());
            q.CalcularArea();
            q.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");
            Console.ReadKey();
        }
    }

    public abstract class Forma
    {
        private double _area;
        private string _cor;
        private double _perimetro;

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        public double Area
        {
            get
            {return _area;}
            set
            {_area = value;}

        }
        
        public double Perimetro
        {
            get
            {return _perimetro;}
            set
            { _perimetro = value; }
        }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Sou a classe abstrata Forma.";
        }
    }

    public class Quadrado : Forma
    {
        private double lado;

       
        public double Lado
        {
            get
            {return lado;}
            set
            {lado = value;}
        }

        public override void CalcularArea()
        {
            this.Area = lado * lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
        }
    }

}
