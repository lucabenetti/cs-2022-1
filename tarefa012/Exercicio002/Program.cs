using System;

namespace Exercicio002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var array = new int[10];

                Console.WriteLine("Digite os número e 0 para encerrar a entrada");

                var entradaEhZero = false;

                for (int i = 0; !entradaEhZero; i++)
                {
                    var numero = Convert.ToInt32(Console.ReadLine());
                    entradaEhZero = numero == 0;

                    array[i] = numero;
                }
            }

            catch (FormatException exception)
            {
                Console.WriteLine("Valor informado não númerico");
            }

            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Não é possível inserir mais de 10 elementos no array");
            }
        }
    }
}
