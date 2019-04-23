using System;
using System.Globalization;

namespace Exercise16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float a1, a2, a3, triangulo, circulo, trapezio, quadrado, retangulo;
            float pi = 3.14159f;

            Console.WriteLine("Digite três valores com ponto flutuante conforme exemplo abaixo:");
            Console.WriteLine("xx.xx xx.xx xx.xx");
            string[] valores = Console.ReadLine().Split( ' ' );
            a1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            a2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            a3 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a1 * a3 / 2;
            circulo = a3 * a3 * pi;
            trapezio = (a1+a2)/2 * a3;
            quadrado = a2 * a2;
            retangulo = a1 * a2;

            Console.WriteLine("TRIANGULO: {0:F3}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0:F3}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0:F3}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0:F3}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0:F3}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
