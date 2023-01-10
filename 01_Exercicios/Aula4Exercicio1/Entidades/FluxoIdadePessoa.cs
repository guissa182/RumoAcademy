using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class FluxoIdadePessoa
    {
        public void Executar()
        {
            List<IdadePessoa> pessoas= new List<IdadePessoa>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome da pessoa: " + (i + 1) + ":");
                string nome = Console.ReadLine();
              
                Console.WriteLine("Digite a idade da pessoa: " + (i + 1) + ":");         
                int idade = int.Parse(Console.ReadLine());  
                
                pessoas.Add(new IdadePessoa(nome, idade));
            }

            IdadePessoa pessoaMaisVelha = pessoas[0];
            foreach (IdadePessoa person in pessoas)
            {
                if (person.Idade > pessoaMaisVelha.Idade)
                {
                    pessoaMaisVelha = person;
                }
            }
            Console.WriteLine($"A pessoa mais velha é:  {pessoaMaisVelha.Nome} " +
                $"e ele tem {pessoaMaisVelha.Idade} anos.");
        }
    }
}
