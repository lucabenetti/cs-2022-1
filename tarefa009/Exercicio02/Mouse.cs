namespace Exercicio02
{
    public class Mouse : Produto
    {
        private string tipo;
        public Mouse(string descricao, string tipo)
        {
            this.descricao = descricao;
            this.tipo = tipo;
        }
        public override string getDescricao()
        {
            return base.getDescricao() + " " + tipo;
        }
    }
}
