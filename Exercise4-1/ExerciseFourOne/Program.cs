using System;

namespace ExerciseFourOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 0 a 1000: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
