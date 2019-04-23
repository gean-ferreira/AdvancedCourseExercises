using System;

namespace ExerciseThreeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pesquisa:");
            Console.WriteLine("Qual é o produto mais usado nos postos de gasolina?");
            Console.WriteLine("'1' para álcool");
            Console.WriteLine("'2' para gasolina");
            Console.WriteLine("'3' para diesel");
            Console.WriteLine("'4' FIM");

            Console.WriteLine();
            Console.Write("Produto: ");
            int x = int.Parse(Console.ReadLine());

            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            while (x != 4)
            {
                switch (x)
                {
                    case 1:
                        alcohol += 1;
                        break;
                    case 2:
                        gasoline += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }

                Console.Write("Produto: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Álcool: " + alcohol);
            Console.WriteLine("Gasolina: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
