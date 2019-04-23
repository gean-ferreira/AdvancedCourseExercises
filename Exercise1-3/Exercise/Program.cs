using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro números inteiros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int result = (a * b) - (c * d);
            Console.WriteLine("DIFERENCA: " + result);
        }
    }
}
