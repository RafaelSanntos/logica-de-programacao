/*
Console.ReadLine()
   Lê até a quebra de linha (quando o usuário aperta a tecla "Enter").
   Retorna os dados lidos na forma de string.
*/

namespace _01EntradaDeDados.Models
{
    public class EntradaDeDados
    {
        public static void Entrada()
        {   
            Console.WriteLine("Digite seu primeiro nome:");
            string nome = Console.ReadLine();

            Console.WriteLine();
            
            Console.WriteLine($"Certo, {nome}! Agora digite sua primeira cor favorita:");
            string cor1 = Console.ReadLine();
            
            Console.WriteLine("Agora digite a sua 2 cor favorita:");
            string cor2 = Console.ReadLine();

            Console.WriteLine("E por ultimo digite a sua 3 cor favorita:");
            string cor3 = Console.ReadLine();

            Console.WriteLine($"{nome}, sua primeira cor favoria é {cor1}, a segunda é {cor2} e a terceira é {cor3}.");
        }

        public static void VetorDeString()
        {
            Console.WriteLine("Digite suas 3 comidas favoritas ex: Pizza Sorvete Coxinha");
        //utilizando o comando Split ele reconhe os espaços em brancos (conforme defino entre aspas simples) de uma frase e divide ela por palavras.
            string[] vetor = Console.ReadLine().Split(' ');
            string comidaFavorita1 = vetor[0];
            string comidaFavorita2 = vetor[1];
            string comidaFavorita3 = vetor[2];

            Console.WriteLine("A sua lista de comidas favoritas é:");
            Console.WriteLine("1° " + comidaFavorita1);
            Console.WriteLine("2° " + comidaFavorita2);
            Console.WriteLine("3° " + comidaFavorita3);
        }
    }
}