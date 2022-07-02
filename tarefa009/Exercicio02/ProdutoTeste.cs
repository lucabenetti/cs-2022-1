using System;
using System.Collections.Generic;

namespace Exercicio02
{
    public class ProdutoTeste
    {
        public static void Testar()
        {
            var carrinho = new List<Produto>()
            {
                new Mouse("Mouse ótico, Saída USB. 1.600 dpi", "ótico"),
                new Livro("Stephen King", "Novembro de 63")
            };

            foreach (var produto in carrinho)
            {
                Console.WriteLine(produto.getDescricao());
            }
        }
    }
}
