using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio1.Entidades
{
    internal class Salario
    {
        public string NomeDoVendedor { get; set; }
        public string SalarioFixo { get; set; }
        public string TotalDeVendas { get; set; }
        public float SalarioFinal { get; set; }

        public void LeiaNome()
        {
            Console.WriteLine("Digite o nome do vendedor: ");
            this.NomeDoVendedor = Console.ReadLine();
        }
        public void LeiaSalarioFixo()
        {    
            Console.WriteLine("Digite o salário fixo deste vendedor: ");
            this.SalarioFixo = Console.ReadLine();
           
        }
        public void LeiaTotalDeVendas()
        {   
            Console.WriteLine("Digite o total de vendas efetuadas por este vendedor: ");
            this.TotalDeVendas = Console.ReadLine();
        }
        public void CalculoSalarioFinal(float salarioFixo, float totalDeVendas)
        {
            this.SalarioFinal =(float) (salarioFixo + (totalDeVendas * 0.15));
        }
       
    }
}
