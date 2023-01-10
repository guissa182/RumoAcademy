using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class FluxoVendas
    {
        public void Executar()
        {
            List<Vendas> vendas = new List<Vendas>();

            while (true)
            {
                Console.WriteLine("Digite o nome do produto (ou 'q' para sair):");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine();
                if (nomeProduto == "q")
                {
                    break;
                }

                Console.WriteLine("Digite o preço de custo do produto:");
                decimal precoCusto = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço de venda do produto:");
                decimal precoVenda = decimal.Parse(Console.ReadLine());

                vendas.Add(new Vendas(nomeProduto, precoCusto, precoVenda));
            }

            var lucroPorProduto = from venda in vendas
                                  group venda by venda.NomeProduto into grupoProduto
                                  select new
                                  {
                                      NomeProduto = grupoProduto.Key,
                                      LucroTotal = grupoProduto.Sum(s => s.Lucro)
                                  };

            foreach (var item in lucroPorProduto)
            {
                Console.WriteLine("Produto: " + item.NomeProduto);
                Console.WriteLine("Total de lucro: R$" + item.LucroTotal);
                Console.WriteLine();
            }
            Console.WriteLine("pausa");
        }
    
    }
}
