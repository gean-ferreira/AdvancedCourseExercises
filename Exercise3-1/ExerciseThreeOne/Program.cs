using System;

namespace ExerciseThreeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int truePassword = 2002;

            Console.Write("Digite a senha de 4 dígitos: ");
            int password = int.Parse(Console.ReadLine());

            while (password != truePassword)
            {
                Console.WriteLine("Senha Inválida. Tente Novamente");
                Console.Write("Digite a senha de 4 dígitos: ");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
