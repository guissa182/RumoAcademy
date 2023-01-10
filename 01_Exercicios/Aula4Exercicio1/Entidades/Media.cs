using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class Media
    {
        public int NumeroAlunos { get; set; }
        public string[] Notas { get; set; }
        public float NotaMedia { get; set; }
        public void DefinirNumeroDeAlunos()
        {
            Console.WriteLine("Digite o numero de alunos na turma: ");
            string alunos = Console.ReadLine();
            this.NumeroAlunos = int.Parse(alunos);
        }
        public void ColetandoNotas(int numeroAlunos)
        {
            this.Notas= new string[numeroAlunos];
            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.WriteLine("Escreva a nota do aluno de numero " + i);
                this.Notas[i] = Console.ReadLine();
            }
        }
        public void CalculoMedia(string[] notas, int numeroAlunos)
        {
            float somaDasNotas = 0;
            for (int i = 0; i < numeroAlunos; i++)
            {
                somaDasNotas = somaDasNotas + float.Parse(notas[i]);
            }
            this.NotaMedia = somaDasNotas/numeroAlunos;
        }

    }
}
