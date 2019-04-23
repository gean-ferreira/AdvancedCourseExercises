using System;

namespace ExerciseTwoThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois números inteiros: ");
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não são Múltiplos");
            }
        }
    }
}
