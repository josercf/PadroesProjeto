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

            #region Abstract Method
            //IConta contaCorrente = new ContaCorrente();
            //IConta contaPoupanca = new ContaPoupanca();
            //IConta contaInvestimento = new ContaInvestimento();
            //IConta contaInternacional = new ContaInternacional();


            Console.WriteLine(@"Selecione a conta que deseja usar: \n
            1 - Conta Corrente
            2 - Conta Poupança
            3 - Conta Investimento
            4 - Conta Internacional
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
            #endregion

            #region Builder

            var notebook = new Notebook();
            var notebookBuilder = new NotebookBuilder(notebook);
            notebookBuilder.BuildModel("Dell Inspiron 15");
            notebookBuilder.BuildProcessor(new IntelProcessor
            {
                Model = "i7",
                Speed = 3
            });
            var notebookFinal = notebookBuilder.GetNotebook();


            #endregion

            Notebook notebook2 = new Notebook();
            notebook2.Model = "Dell Inspiron 15";
            notebook2.Processor = new IntelProcessor
            {
                Model = "i7",
                Speed = 3
            };

            //Notebook notebook3 = notebook2;
            //notebook3.Model = "Dell Inspiron 17";

            //Console.WriteLine($"Notebook 2: {notebook2.Model}");

            Notebook notebook4 = notebook2.Clone();
            notebook4.Model = "Dell Inspiron 18";
            Console.WriteLine($"Notebook 2: {notebook2.Model}");
            Console.WriteLine($"Notebook 4: {notebook4.Model}");
        }
    }
}
