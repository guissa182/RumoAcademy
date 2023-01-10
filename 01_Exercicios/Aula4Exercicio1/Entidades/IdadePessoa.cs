using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    public class IdadePessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public IdadePessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
