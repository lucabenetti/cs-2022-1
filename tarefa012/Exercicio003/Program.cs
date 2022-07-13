using System;

namespace Exercicio003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o usuario 'teste'");
            var usuario = Console.ReadLine();

            Console.WriteLine("Digite a senha '12345'");
            var senha = Console.ReadLine();

            var login = new Login()
            {
                Usuario = usuario,
                Senha = senha
            };

            try
            {
                login.FazerLogin();
                Console.WriteLine("Login realizado com sucesso");
            }

            catch (LoginInvalidoException exception)
            {
                Console.WriteLine("Usuário e senha incorretos");
            }
        }
    }
}
