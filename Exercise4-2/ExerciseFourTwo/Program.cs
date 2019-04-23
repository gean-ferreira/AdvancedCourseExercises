using System;

namespace ExerciseFourTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            Console.WriteLine("Determine um intervalo");
            Console.WriteLine("Exemplo: [10,20] ; [30,50] ; [50,100] ; ...");

            Console.WriteLine();
            Console.Write("Valor mínimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Valor máximo: ");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Quantos valores inteiros serão digitados para saber se estão dentro do intervalo? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write(i + ": ");
                int number = int.Parse(Console.ReadLine());

                if (number < min || number > max)
                {
                    fora += 1;
                }
                else
                {
                    dentro += 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
