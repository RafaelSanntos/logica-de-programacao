namespace _04OperadoresAritmeticos.Models
{
    public class OperadoresAritmeticos
    {
        public static void Aritmeticos()
        {
            Console.Clear();
        
            int n1 = 3 + 3;
            int n2 = 3 - 2;
            int n3 = 3 * 4;
            int n4 = 5 % 5; // divisão
            double n5 = 10.0 / 8; // modelo - resto da divisão 

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }
    }
}