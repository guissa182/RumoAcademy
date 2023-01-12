using Exercicio5.Entidades;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Utilitarios;
using Exercicio5.Fluxo;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("*----------------- Sistema Pet Shop -----------------*\n \n");
                Console.WriteLine("Digite a opção desejeda e aperte 'Enter': \n");
                Console.WriteLine("a) Cadastrar clientes.\n" +
                    "b) Listar clientes.\n" +
                    "c) Buscar um cliente por CPF.\n" +
                    "d) Listar os aniversariantes do mês.\n");
                Console.WriteLine("q) Para sair.\n");
                char opcao = char.Parse(Console.ReadLine());
                Console.Clear();


                FluxoPrograma fluxo = new FluxoPrograma();

                switch (opcao)
                {
                    case 'a':
                        Cliente cliente = fluxo.ExecutarCadastro();
                        listaDeClientes.Add(cliente);
                        break; 
                    case 'b':
                        fluxo.ExecutarListarClientes(listaDeClientes);
                        break;
                    case 'c':
                        Console.Write("Digite o CPF do cliente: ");
                        string cpf = "";
                        while (true)
                        {
                            cpf = Console.ReadLine();
                            cpf = Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})",
                                                     "$1.$2.$3-$4");
                            if (Uteis.ValidaCPFBusca(cpf))
                                break;
                            else
                                Console.WriteLine("O cpf deve ter 11 digitos! Digite novamente.");
                        }
                        fluxo.ExecutarBuscarCliente(cpf, listaDeClientes);
                        break;
                    case 'd':
                        fluxo.ExecutarBuscaAniversariantes(listaDeClientes);
                        break;
                }

                if(opcao == 'q') 
                {
                    break;
                }
                
            }
        }
    }
}