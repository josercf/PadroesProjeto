namespace PadroesProjeto.Factory
{
    public interface IConta
    {
        void Transferir(decimal valor, string contaDestino);
    }
}