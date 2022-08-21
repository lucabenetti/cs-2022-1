namespace ExtractClass
{
    public class Pessoa
    {
        private string _nome;
        private string _ddd;
        private string _telefone;

        public string ObterNumeroTelefone()
        {
            return $"({_ddd}){_telefone}";
        }
    }
}