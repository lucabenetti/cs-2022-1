namespace ExtractInterface
{
    public class Bombeiro
    {
        public string _departamento;
        public string _nome;
        public string _funcao;

        public string ObterDepartamento()
        {
            return _departamento;
        }

        public string ObterNome()
        {
            return _nome;
        }

        public string ObterFuncao()
        {
            return _funcao;
        }
    }
}