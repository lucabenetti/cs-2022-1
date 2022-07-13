using System;

namespace Tarefa12
{
    internal class Program
    {
        //InputMismatchException do Java => FormatException
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o primeiro número");
                var dividendo = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                var divisor = Convert.ToDecimal(Console.ReadLine());

                var resultado = (dividendo / divisor);
                Console.WriteLine(resultado);
            }

            catch (FormatException exception)
            {
                Console.WriteLine("Valor informado não númerico");
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine("Impossível dividir por zero");
            }
        }
    }
}
