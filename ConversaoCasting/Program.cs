using System;

namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversão implicita de tipos
            float x = 4.5f; // 4 bytes

            double y = x; // 8 bytes

            Console.WriteLine(y);

            double a;
            float b;
            int c;

            a = 5.1; // 8 bytes
            // casting conversão explicita de tipo
            b = (float)a; // 4 bytes

            c = (int)a; // os valores depois da virgula vão ser truncados

            Console.WriteLine(b);
            Console.WriteLine(c);

            int n1 = 5;
            int n2 = 2;

            //double resultado = n1 / n2; // considera a divisão por inteiro perde casa decimal
            double resultado = (double) n1 / n2; //casting n1 divisão de double por inteiro retorna um double

            Console.WriteLine(resultado);
        }
    }
}
