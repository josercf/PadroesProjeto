namespace PadroesProjeto.Singleton
{
    public class ContaCorrente
    {
        private static ContaCorrente _instance;

        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; private set; }

        private ContaCorrente(string numero, string agencia, decimal saldo)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public static ContaCorrente ObterInstancia()
        {
            if(_instance == null)
            {
                _instance = new ContaCorrente("1", "2025", 560.60m);
            }
            return _instance;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }

        public void Debitar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }
    }
}
