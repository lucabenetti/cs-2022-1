namespace ExtractMethod
{
    public class ImpressoraRefatorada
    {
        private string _nome;
        private string _detalhes;

        public void Imprimir()
        {
            ImprimirNome();
            ImprimirDetalhes();
        }

        private void ImprimirDetalhes()
        {
            Console.WriteLine(_detalhes);
        }

        private void ImprimirNome()
        {
            Console.WriteLine(_nome);
        }
    }
}