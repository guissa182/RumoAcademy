using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class FluxoMedia
    {
        public void Executar()
        {
            Media media = new Media();
            media.DefinirNumeroDeAlunos();
            media.ColetandoNotas(media.NumeroAlunos);
            media.CalculoMedia(media.Notas, media.NumeroAlunos);

            Console.WriteLine("A nota média da turma é de: " + media.NotaMedia.ToString("N2"));

        }
    }
}