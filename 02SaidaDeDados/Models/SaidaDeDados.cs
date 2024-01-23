using System.Globalization;

namespace _02SaidaDeDados.Models
{
    public class SaidaDeDados
    {
        public static void Saida()
        {
			Console.Clear();
	// Console.WriteLine(Valor) - Imprime a mensagem e coloca uma quebra de linha no final dela.
	// Console.Write(Valor) - Imprime a mensagem sem quebra de linha no final.
			Console.WriteLine("Olá, Rafael. Bem vindo ao primeiro teste.");
			Console.WriteLine("Veja que no console estou escrito na linha de baixo.");
			Console.Write("Bom dia! Não faço quebra de linha.");
			Console.Write("Eu to junto com o de cima ;/");
        }

        public static void ImprimindoVariaveisComInterpolacao()
        {
            Console.Clear();

			string nome = "Rafael";
			int idade = 21;
			double saldo = 10.35784;
			double saldoComVirgula = 15.555;

	    //para indicar inteporlação (uma das formas de imprimir variaveis, tem a concatenacao e placeholder também) usa-se $ e {} para identificar as variaveis.
			Console.WriteLine($"Meu nome é {nome}, eu tenho {idade} anos e tenho um saldo de {saldo}.");

	    //:F2 é uma funçao do método ToString usado para formatar o número de casas decimais de um dado, nesse exemplo estamos colocamos o 2 casas decimais
			Console.WriteLine($"Na verdade meu saldo é R${saldo:F2} kkkkk");

	    //Para imprimir o número com "." ao inves de "," importamos um namespace chamado "Globalization", ela desconsidera qualquer formatação especifica de países.
			Console.WriteLine($"Mas eu queria que meu saldo fosse R${saldoComVirgula.ToString(CultureInfo.InvariantCulture)} kkkkk");
        }
    }
}