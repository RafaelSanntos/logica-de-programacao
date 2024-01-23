/*

Operador   exemplo       significado

+=         a += 2;         a RECEBE a + 2
-=         a -+ 2;         a RECEBE a - 2
*=         a *= 2;         a RECEBE a * 2
/=         a /= 2;         a RECEBE a / 2
%=         a %= 2;         a RECEBE a % 2      % significa resto da divisão

++         ++a;            a = a + 1
--         --a;            a = a - 1

*/

namespace _03OperadoresDeAtribuicao.Models
{
    public class OperadoresDeAtribuicao
    {
        public static void Atribuicao()
        {
            Console.Clear();
    
        //Atribuindo um valor 10 para uma variavel "a" e imprimindo ela no console.
            int a = 10;
            Console.WriteLine($"Tenho um número {a}");

        //Somando 2 ao valor 10 dentro da variavel "a" e imprimindo ela no console.
            a += 2;
            Console.WriteLine($"Agora tenho {a}");
        //Subtraindo 2 ao valor que era 10 e agora é 12 dentro da variavel "a" e imprimindo ela no console.
            a -= 2;
            Console.WriteLine($"Agora tenho {a}");

        //Multiplicando por 2 o valor que era 12 e agora é 10 dentro da variavel "a" e imprimindo ela no console.
            a *= 2;
            Console.WriteLine($"Agora tenho {a}");

        //Dividindo por 2 o valor que era 10 e agora é 20 dentro da variavel "a" e imprimindo ela no console.
            a /= 2;
            Console.WriteLine($"Agora tenho {a}");

        //Resto da divisao por 2 do valor que era 10 e agora é 0 dentro da variavel "a" e imprimindo ela no console. 0/0 = 0 nao existe resto da divisao.
            a %= 2;
            Console.WriteLine($"Agora tenho {a}");

        //Pegando o valor zero da variavel "a" e adicionando mais 1 e imprimindo no console.
            ++a;
            Console.WriteLine(a);

        //Pegando o valor 1 da variavel "a" e subtraindo menos 1 e imprimindo no console.
            --a;
            Console.WriteLine(a);
        }

        public static void Conversoes()
        {
        //Exemplo de Conversao Explicita(Casting)
        //Quando um dado de tipo maior (double 8bits e float 4bits) faz uma conversao para um tipo de dado menor.
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

        //Ja no exemplo abaixo nao funcionaria pois o double aguenta armazenar uma quantidade de informacao maior que o float.
        //Podendo ocorrer uma perda de informação na hora de compilar.

            // double a = 5.1;
            // float b = a;

        //Para fazer essa conversao forçada e sabendo dos riscos teriamos que usar a Conversao Implicita.
        //Para isso, basta colocar o nome do dado com menor bits entre parenteses.

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
        }
    }
}