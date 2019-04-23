using System;

namespace ExerciseFourFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo e direi seu fatorial: ");
            int x = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= x; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
