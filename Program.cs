using System.Globalization;

using PadroesProjeto.Factory;

namespace PadroesProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Singleton
            //neste momento vamos pagar a 
            //conta do cafe da manha
            var contaCM = Singleton.ContaCorrente.ObterInstancia();

            contaCM.Debitar(45.50m);

            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;

            Console.WriteLine($"Saldo: {contaCM.Saldo:C2}");

            var contaAlmoco = Singleton.ContaCorrente.ObterInstancia();
            contaAlmoco.Debitar(52.25m);
            Console.WriteLine($"Saldo: {contaAlmoco.Saldo:C2}");

            //Exemplo de container de DI
            //HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            //builder.Services.AddSingleton<ContaCorrente>(); 
            #endregion

            //IConta contaCorrente = new ContaCorrente();
            //IConta contaPoupanca = new ContaPoupanca();
            //IConta contaInvestimento = new ContaInvestimento();
            //IConta contaInternacional = new ContaInternacional();


            Console.WriteLine(@"Selecione a conta que deseja usar: \n
            1 - Conta Corrente \n
            2 - Conta Poupança \n
            3 - Conta Investimento \n
            4 - Conta Internacional \n
            ");

            var opcaoSelecionada = Console.ReadLine();

            IConta contaSelecionada = FabricaContas.CriarConta(opcaoSelecionada);
            contaSelecionada.Transferir(1000, "123456");            

            //if (opcaoSelecionada == "1")
            //{
            //    contaCorrente.Transferir(1000, "123456");
            //}
            //else if (opcaoSelecionada == "2")
            //{
            //    contaPoupanca.Transferir(1000, "123456");
            //}
            //else if (opcaoSelecionada == "3")
            //{
            //    contaInvestimento.Transferir(1000, "123456");
            //}
            //else if (opcaoSelecionada == "4")
            //{
            //    contaInternacional.Transferir(1000, "123456");
            //}
            //else
            //{
            //    Console.WriteLine("Opção inválida.");
            //}
        }
    }
}
