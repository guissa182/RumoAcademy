using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class FluxoPositivo
    {
        public void Executar()
        {
            Positivos numerosPositivos= new Positivos();
            numerosPositivos.PopulandoVetor();
            numerosPositivos.EscrevePositivos(numerosPositivos.Numeros);
        }

    }
}
