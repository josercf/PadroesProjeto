namespace PadroesProjeto.Factory
{
    public static class FabricaContas
    {
        public static IConta CriarConta(string tipoConta)
        {
            return tipoConta switch
            {
                "1" => new ContaCorrente(),
                "2" => new ContaPoupanca(),
                "3" => new ContaInvestimento(),
                "4" => new ContaInternacional(),
                _ => throw new ArgumentException("Tipo de conta inválido.")
            };
        }
    }
}
