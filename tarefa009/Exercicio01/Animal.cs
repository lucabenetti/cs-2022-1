using System;
using System.Collections.Generic;

namespace Tarefa009
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public abstract string Movimentar();

        public abstract string EmitirSom();
    }
}
