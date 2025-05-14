namespace PadroesProjeto.Factory
{
    public class ContaPoupanca : IConta
    {
        public void Transferir(decimal valor, string contaDestino)
        {
            Console.WriteLine($"{this} - Transferindo {valor:C2} para a conta {contaDestino}");
        }
    }
}
