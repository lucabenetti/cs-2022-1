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
                var dividendo = Convert.ToDecimal(Console.ReadLine());
                var divisor = Convert.ToDecimal(Console.ReadLine());
                var resultado = (dividendo / divisor);
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
