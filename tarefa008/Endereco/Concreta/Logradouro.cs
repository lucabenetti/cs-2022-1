using Endereco.Enum;

namespace Endereco.Concreta
{
    /// <summary>
    /// Autor: Luca
    /// Data: 15/07/2022
    /// Classe: Logradouro
    /// </summary>
    public class Logradouro
    {
        public string Nome { get; set; }

        public TipoLogradouroEnum Tipo { get; set; }
    }
}
