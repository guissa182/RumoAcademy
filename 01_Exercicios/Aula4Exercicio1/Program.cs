using Aula4Exercicio1.Entidades;

namespace Aula4Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção desejada\n");
            Console.WriteLine("a) Executar código de salario\n" +
                "b) Executar código de media\n" +
                "c) Executar código de positivos\n"+
                "d) Executar código de pessoa mais velha\n"+
                "e) Executar código de vendas.");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "a":
                    FluxoSalario fluxoSalario = new FluxoSalario();
                    fluxoSalario.Executar();
                break;
                case "b":
                    FluxoMedia fluxoMedia = new FluxoMedia();
                    fluxoMedia.Executar();
                break;
                case "c":
                    FluxoPositivo fluxoPositivo = new FluxoPositivo();
                    fluxoPositivo.Executar();
                break;
                case "d":
                    FluxoIdadePessoa fluxoIdadePessoa = new FluxoIdadePessoa();
                    fluxoIdadePessoa.Executar();
                break;
                case "e":
                    FluxoVendas fluxoVendas = new FluxoVendas();
                    fluxoVendas.Executar();
                break;
            }       
        }
    }
}