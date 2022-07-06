using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio002
{
    public class Agenda
    {
        private List<Contato> Contatos { get; } = new();

        public void AdicionarContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public Contato BuscarContatoPorEmail(string email)
        {
            return Contatos.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }

        public Contato BuscarContatoPorNome(string nome)
        {
            return Contatos.FirstOrDefault(x => x.Nome.ToUpper() == nome.ToUpper());
        }

        public List<Contato> ObterTodos()
        {
            return Contatos;
        }

        public void RemoverContatoPorNome(string nome)
        {

        }
    }
}
