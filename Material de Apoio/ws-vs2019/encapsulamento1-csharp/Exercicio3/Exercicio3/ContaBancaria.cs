using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio3
{
    class ContaBancaria
    {
        private double _taxa = 5.00;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.00;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + _taxa);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", " +
                   "Titular: " + Titular + ", " +
                   "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
