using System;
using System.Globalization;

namespace ExerciseTwoSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 0 a 100: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           if (x < 0.0 || x > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (x <= 25.0) {
                Console.WriteLine("Intervalo [0,25)");
            }
            else if (x <= 50.0) {
                Console.WriteLine("Intervalo (25,50)");
            }
            else if (x <= 75.0) {
                Console.WriteLine("Intervalo (50,75)");
            }
            else {
                Console.WriteLine("Intervalo (75,100)");
            }
        }
    }
}
