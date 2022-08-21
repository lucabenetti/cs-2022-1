namespace ExtractMethod
{
    public class Impressora
    {
        private string _nome;
        private string _detalhes;

        public void Imprimir()
        {
            Console.WriteLine(_nome);
            Console.WriteLine(_detalhes);
        }
    }
}