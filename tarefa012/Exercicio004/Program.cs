using System;

namespace Exercicio004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contaBancaria = new ContaBancaria();

            try
            {
                contaBancaria.Depositar(2);
                contaBancaria.Sacar(10);
            }

            catch (SaldoInsuficienteException exception)
            {
                Console.Write("Saldo insuficiente");
            }
        }
    }
}
