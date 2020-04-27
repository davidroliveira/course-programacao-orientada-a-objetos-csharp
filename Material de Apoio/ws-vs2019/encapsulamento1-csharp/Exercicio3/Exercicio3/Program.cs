using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(s / n) ? ");
            bool haveraDepositoInicial = Console.ReadLine().ToLower() == "s";           

            if (haveraDepositoInicial)
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                contaBancaria = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

        }
    }
}
