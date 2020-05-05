using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            const int quantidadeQuartosTotal = 10;
            Quarto[] quartos = new Quarto[quantidadeQuartosTotal];

            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeQuartosAlugados = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < quantidadeQuartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i + 1));

                Quarto quarto = new Quarto();

                Console.Write("Nome: ");
                quarto.Nome = Console.ReadLine();

                Console.Write("Email: ");
                quarto.Email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                quartos[numero] = quarto;
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quantidadeQuartosTotal; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                }
            }

        }

    }
}
