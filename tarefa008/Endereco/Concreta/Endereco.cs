using Endereco.Enum;

namespace Endereco.Concreta
{
    /// <summary>
    /// Autor: Luca
    /// Data: 15/07/2022
    /// Classe: Endereco
    /// </summary>
    public class Endereco
    {
        public Bairro Bairro { get; set; }

        public Logradouro Logradouro { get; set; }

        public TipoEnderecoEnum Tipo { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public int CEP { get; set; }
    }
}
