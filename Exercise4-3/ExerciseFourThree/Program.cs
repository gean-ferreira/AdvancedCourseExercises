using System;
using System.Globalization;

namespace ExerciseFourThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos de testes você quer calcular a média ponderada? ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= x; i++)
            {
                Console.Write("Teste {0}: ", i);
                string[] note = Console.ReadLine().Split(' ');
                double a = double.Parse(note[0], CultureInfo.InvariantCulture);
                double b = double.Parse(note[1], CultureInfo.InvariantCulture);
                double c = double.Parse(note[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine("Média: " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
