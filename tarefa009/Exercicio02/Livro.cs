namespace Exercicio02
{
    public class Livro : Produto
    {
        private string autor;
        public Livro(string descricao, string autor)
        {
            this.descricao = descricao;
            this.autor = autor;
        }

        public override string getDescricao()
        {
            return base.getDescricao() + " " + autor;
        }
    }
}
