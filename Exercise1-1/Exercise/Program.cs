using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine("Soma: {0}", sum);
        }
    }
}
