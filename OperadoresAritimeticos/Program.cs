using System;

namespace OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * + adição
             * - subtração
             * * multiplicação
             * / divisão
             * % mod (resto da divisão)
             */

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10 / 8; // compilador entende que quer fazer uma divisão de inteiros
            double n5 = 10.0 / 8; // especificando pelo menos um numero com n.0
            double n6 = (double)10 / 8; // casting divisão de double por inteiro retorna um double

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            //formula de baskara
            double a = 1.0, b = -3.0, c = -4.0;

            //double delta = b * b - 4.0 * a * c; // calculo de delta
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // calculo de delta

            //double x1 = -b + Math.Sqrt(delta) / 2.0 * a; // divisão e multiplicação tem precedencia
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
