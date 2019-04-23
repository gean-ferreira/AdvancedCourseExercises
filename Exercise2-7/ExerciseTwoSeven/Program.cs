using System;
using System.Globalization;

namespace ExerciseTwoSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores com apenas uma casa decimal:");
            Console.Write("Ponto x: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Ponto y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Plano Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Plano Q4");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Plano Q2");
            }
            else
            {
                Console.WriteLine("Plano Q3");
            }
        }
    }
}
