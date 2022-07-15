namespace Endereco.Interface
{
    /// <summary>
    /// Autor: Luca
    /// Data: 15/07/2022
    /// Classe: IEndereco
    /// </summary>
    public interface IEndereco
    {
        public Concreta.Endereco ConsultaPorCep();
    }
}
