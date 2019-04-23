using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio de um círculo: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.15159;
            double area = Math.Pow(x,2.0) * pi;
            Console.WriteLine("Área: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
