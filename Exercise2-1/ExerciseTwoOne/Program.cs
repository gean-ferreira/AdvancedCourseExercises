using System;

namespace ExerciseTwoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine("Número positivo!");
            }
            else
            {
                Console.WriteLine("Número negativo!");
            }
        }
    }
}
