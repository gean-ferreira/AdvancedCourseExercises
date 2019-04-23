using System;
using System.Globalization;

namespace ExerciseTwoFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código do produto: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Quantos? ");
            int quantity = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (code == 1)
            {
                price += 4.0;
            }
            else if (code == 2)
            {
                price += 4.5;
            }
            else if (code == 3)
            {
                price +=5.0;
            }
            else if (code == 4)
            {
                price += 2.0;
            }
            else
            {
                price += 1.5;
            }

            double total = price * quantity;
            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
