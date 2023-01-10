/*
1. Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário final do mês.
*/

programa
{
	inclua biblioteca Matematica
	inclua biblioteca Tipos
	inclua biblioteca Texto

	
	funcao inicio()
	{
		escreva("Calculadora de Salário Final: \n\n")
	
		cadeia nomeVendedor, salarioFixo, vendasEfetuadas
		
		escreva("Digite o nome do vendedor: \n")
		leia(nomeVendedor)
		se(ValidarNome(nomeVendedor) == "erro"){
			retorne
		}
		
		escreva("Digite o salário fixo: \n")
		leia(salarioFixo)
		se(ValidarFormatarValores(salarioFixo) < 0){
			retorne
		}

		real salarioFixoFormatado = ValidarFormatarValores(salarioFixo)
		
		escreva("Digite o total de vendas efetuadas em Real $: \n")
		leia(vendasEfetuadas)
		se(ValidarFormatarValores(vendasEfetuadas) < 0){
			retorne
		}

		real vendasEfetuadasFormatado = ValidarFormatarValores(vendasEfetuadas)
		
		cadeia salarioFixoFinal = (Texto.substituir
		(Tipos.real_para_cadeia
		(Matematica.arredondar
		(salarioFixoFormatado, 2)
		), ".",","))
		
		cadeia salarioFinalFinalMesmo = (Texto.substituir
		(Tipos.real_para_cadeia
		(Matematica.arredondar
		(SalarioFinal(salarioFixoFormatado, vendasEfetuadasFormatado),2)
		), ".",","))

		escreva("\n O nome do vendedor é: ", nomeVendedor,"\n Seu salário fixo é de R$",salarioFixoFinal, 
		"\n E o seu salário final do mês foi de: ", salarioFinalFinalMesmo,"\n")

	}
	
	
	funcao cadeia ValidarNome(cadeia nome)
	{
		se(Tipos.cadeia_e_caracter(nome) == falso 
			e Tipos.cadeia_e_inteiro(nome, 10) == falso 
			e Tipos.cadeia_e_real(nome) == falso 
			e Tipos.cadeia_e_logico(nome) ==falso )
		{
			retorne nome
		}
		senao
		{
			escreva("O nome digitado deve ser uma cadeia!")
			cadeia erro = "erro"
			retorne erro
		}
	}
	
	funcao real ValidarFormatarValores(cadeia valorEmTexto)
	{
	cadeia valorEmTextoFormatado = Texto.substituir(valorEmTexto, ",", ".")
	logico isReal = Tipos.cadeia_e_real(valorEmTextoFormatado)
	logico isNumero = Tipos.cadeia_e_inteiro(valorEmTextoFormatado, 10)
	se(isReal == falso e isNumero == falso)
	{
		escreva("Numero digitado está incorreto! Digite Novamente!")
		retorne -1.00
	}
	real valorFormatado = Tipos.cadeia_para_real(valorEmTextoFormatado)
	se( valorFormatado <= 0)
		{
			escreva("Digite um valor maior do que 0")
			retorne -1.00		
		}
		retorne valorFormatado
	}

	funcao real SalarioFinal(real salarioFixo, real vendasEfetuadas)
		{
			real salarioFinal = salarioFixo + (0.15 * vendasEfetuadas)
			retorne salarioFinal
		}
}


/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 389; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */