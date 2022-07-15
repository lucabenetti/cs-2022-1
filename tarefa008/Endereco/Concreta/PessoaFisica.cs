using System;
using System.Collections.Generic;

namespace Endereco.Concreta
{
    /// <summary>
    /// Autor: Luca
    /// Data: 15/07/2022
    /// Classe: PessoaFisica
    /// </summary>
    public class PessoaFisica
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
}
