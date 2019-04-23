using System;
using System.Globalization;

namespace ExerciseOneFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Botar o código do produto, a quantidade e o valor unitário. Segue exemplo abaixo:");
            Console.WriteLine("Produto1 = xx xx xx.xx");

            Console.Write("Produto2 = ");
            string[] productTwo = Console.ReadLine().Split(' ');
            int a = int.Parse(productTwo[0]);
            int b = int.Parse(productTwo[1]);
            double c = double.Parse(productTwo[2], CultureInfo.InvariantCulture);

            Console.Write("Produto3 = ");
            string[] productThree = Console.ReadLine().Split(' ');
            int d = int.Parse(productThree[0]);
            int e = int.Parse(productThree[1]);
            double f = double.Parse(productThree[2], CultureInfo.InvariantCulture);

            double totalValue = b * c + e * f;

            Console.WriteLine();
            Console.WriteLine("VALOR A PAGAR: " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
