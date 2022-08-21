namespace ExtractClass
{
    public class TelefoneRefatorada
    {
        private string _ddd;
        private string _telefone;

        public string ObterNumeroTelefone()
        {
            return $"({_ddd}){_telefone}";
        }
    }
}