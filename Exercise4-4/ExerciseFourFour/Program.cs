using System;
using System.Globalization;

namespace ExerciseFourFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas divisões você quer fazer? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write("{0}: ", i);
                string[] numbers = Console.ReadLine().Split(' ');
                double a = double.Parse(numbers[0]);
                double b = double.Parse(numbers[1]);

                if (b != 0.0)
                {
                    double result = a / b;
                    Console.WriteLine("Resultado: " + result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão Impossível");
                }
            }
        }
    }
}
