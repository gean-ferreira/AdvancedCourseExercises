using System;
using System.Globalization;

namespace ExerciseTwoEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seu salário: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax = 0.0;

            if (salary <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if (salary > 2000.0 && salary <= 3000.0)
            {
                double ir = (salary - 2000.0) * 0.08;
                tax += ir;
            }
            else if (salary > 3000.0 && salary <= 4500.0)
            {
                double ir = 1000.0 * 0.08 + 0.18 * (salary - 3000.0);
                tax += ir;
            }
            else
            {
                double ir = 1000.0 * 0.08 + 0.18 * 1500.0 + 0.28 * (salary - 4500.0);
                tax += ir;
            }

            Console.WriteLine("R$ {0}", tax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
