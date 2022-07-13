namespace Exercicio004
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if ((Saldo - valor) < 0)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
        }
    }
}
