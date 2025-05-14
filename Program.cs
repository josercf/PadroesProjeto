using System.Globalization;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using PadroesProjeto.Singleton;

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
            var contaCM = ContaCorrente.ObterInstancia();

            contaCM.Debitar(45.50m);

            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;

            Console.WriteLine($"Saldo: {contaCM.Saldo:C2}");

            var contaAlmoco = ContaCorrente.ObterInstancia();
            contaAlmoco.Debitar(52.25m);
            Console.WriteLine($"Saldo: {contaAlmoco.Saldo:C2}");

            //Exemplo de container de DI
            //HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            //builder.Services.AddSingleton<ContaCorrente>(); 
            #endregion


        }
    }
}
