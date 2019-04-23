using System;
using System.Globalization;

namespace ExerciseOneFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Id do funcionário: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas: ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hours * valuePerHour;

            Console.WriteLine("ID = " + id);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
