namespace ExtractClass
{
    public class PessoaRefatorada
    {
        private string _nome;
        private TelefoneRefatorada _telefone;

        public string ObterNumeroTelefone()
        {
            return _telefone.ObterNumeroTelefone();
        }
    }
}