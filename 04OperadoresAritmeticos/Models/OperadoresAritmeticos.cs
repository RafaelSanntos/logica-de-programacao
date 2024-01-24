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
            double n5 = 10.0 / 8; // model - resto da divisão 

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }

        public static void FormulaDeBhaskara()
        {
        //valores de A, B e C.

            double a = 1.0, b = -3.0, c = -4.0;

        //1) Calcula-se o Delta.
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
        
        //2) Descobre-se o primeiro x usando a formula de Bhaskara.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

        //3) Descobre-se o segundo x usando a formula de Bhaskara.
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        //Resultado:
            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);    
        }
    }
}