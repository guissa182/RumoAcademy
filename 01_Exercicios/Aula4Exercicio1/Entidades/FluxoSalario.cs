using Aula4Exercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1
{
    internal class FluxoSalario
    {
        public void Executar()
        {
            Salario salario = new Salario();

            salario.LeiaNome();
            salario.LeiaSalarioFixo();
            salario.LeiaTotalDeVendas();
            salario.CalculoSalarioFinal(float.Parse(salario.SalarioFixo), float.Parse(salario.TotalDeVendas));

            Console.WriteLine("O nome do vendedor é: " + salario.NomeDoVendedor);
            Console.WriteLine("O salário fixo dele é de: R$" + salario.SalarioFixo);
            Console.WriteLine("O salário final dele é de: R$" + salario.SalarioFinal);
        }
    }
}
