using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class Vendas
    {
        public string NomeProduto { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Lucro { get { return PrecoVenda - PrecoCusto; } }

        public Vendas(string nomeProduto, decimal precoCusto, decimal precoVenda)
        {
            NomeProduto = nomeProduto;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
        }
    }
}
