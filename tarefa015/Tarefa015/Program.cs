using System;

namespace Tarefa015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RegexLogin.Validar("aB#123"));
            Console.WriteLine(RegexLogin.Validar("123"));
            Console.WriteLine(RegexSenha.Validar("AAAbbb"));
            Console.WriteLine(RegexSenha.Validar("AAAbbb#"));
            Console.WriteLine(RegexSenha.Validar("AAAbbb#123"));
        }
    }
}
