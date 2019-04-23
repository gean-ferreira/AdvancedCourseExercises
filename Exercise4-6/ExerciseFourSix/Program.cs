using System;

namespace ExerciseFourSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo que direi seus divisores: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
