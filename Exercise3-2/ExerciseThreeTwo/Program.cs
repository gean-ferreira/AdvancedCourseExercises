using System;

namespace ExerciseThreeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite apenas números inteiros para o plano:");
            Console.Write("Ponto x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ponto y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Plano Q1");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Plano Q4");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Plano Q2");
                }
                else
                {
                    Console.WriteLine("Plano Q3");
                }

                Console.Write("Ponto x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Ponto y: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NULA");
        }
    }
}
