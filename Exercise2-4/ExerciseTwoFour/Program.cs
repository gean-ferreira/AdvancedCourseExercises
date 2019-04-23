using System;

namespace ExerciseTwoFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hora inicial do jogo: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Término do jogo: ");
            int y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                int total = y - x;
                Console.WriteLine("O jogo durou {0} hora(s)", total);
            }
            else
            {
                int total = 24 - (x - y);
                Console.WriteLine("O jogo durou {0} hora(s)", total);
            }
        }
    }
}
