using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            Console.WriteLine("Circunferência: " + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + Volume(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }

    }
}
