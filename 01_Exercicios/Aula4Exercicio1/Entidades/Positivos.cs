using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class Positivos
    {
        public float[] Numeros { get; set; }
        public void PopulandoVetor()
        {
            Numeros = new float[15];
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine($"Digite o valor: {i + 1} de {Numeros.Length}.");
                Numeros[i] = float.Parse(Console.ReadLine());
            }
        }
        public void EscrevePositivos(float[] numero)
        {
            Console.WriteLine("\n");
            foreach (float element in numero)
            {
                if (element > 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
