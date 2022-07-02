using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Produto
    {
        protected string nomeLoja;

        protected decimal preco;

        protected string descricao;

        public void setNomeLoja(string nomeLoja)
        {
            this.nomeLoja = nomeLoja;
        }

        public string getNomeLoja()
        {
            return this.nomeLoja;
        }

        public void setPreco(decimal preco)
        {
            this.preco = preco;
        }

        public decimal getPreco()
        {
            return this.preco;
        }

        public virtual string getDescricao()
        {
            return "Produto de informática";
        }
    }
}
