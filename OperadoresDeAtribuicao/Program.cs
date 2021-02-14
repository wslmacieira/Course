using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de atribuição
            /* int a = 10;
             Console.WriteLine(a);

             a += 2; // concatenação cumulativa
             Console.WriteLine(a);

             a *= 3;
             Console.WriteLine(a);

             string s = "ABC";
             Console.WriteLine(s);

             s += "DEF"; // concatenação cumulativa de string
             Console.WriteLine(s);*/

            //Operadores aritiméticos / atribuição

            /* int a = 10;
             a--;
             Console.WriteLine(a);*/

            int a = 10;
            //int b = a++; // primeiro passa o valor de a para b depois ele incrementa o a
            int b = ++a; // primeiro incrementa o a depois passa o valor para b
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
