using System;

namespace Exercicio002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var agenda = new Agenda();

            var contato = new Contato()
            {
                Nome = "Nome",
                Email = "email@teste.com"
            };

            agenda.AdicionarContato(contato);

            ObterContatoPorNome(agenda);
            ObterContatoPorEmail(agenda);
            ObterTodosContatos(agenda);
            RemoverContato(agenda);
            ObterTodosContatos(agenda);
        }

        private static void RemoverContato(Agenda agenda)
        {
            agenda.RemoverContatoPorNome("Nome");
        }

        private static void ObterTodosContatos(Agenda agenda)
        {
            var contatos = agenda.ObterTodos();

            foreach (var contato in contatos)
            {
                ImprimirContato(contato);
            }
        }

        private static void ObterContatoPorNome(Agenda agenda)
        {
            var contato = agenda.BuscarContatoPorNome("Nome");
            ImprimirContato(contato);
        }

        private static void ImprimirContato(Contato contato)
        {
            Console.WriteLine($"{contato.Nome} - {contato.Email}");
        }

        private static void ObterContatoPorEmail(Agenda agenda)
        {
            var contato = agenda.BuscarContatoPorEmail("email@teste.com");
            ImprimirContato(contato);
        }
    }
}
