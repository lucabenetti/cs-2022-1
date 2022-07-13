namespace Exercicio003
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool FazerLogin()
        {
            if (!(Usuario == "teste" && Senha == "12345"))
            {
                throw new LoginInvalidoException();
            };

            return true;
        }
    }
}
