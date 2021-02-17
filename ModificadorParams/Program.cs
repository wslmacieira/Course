using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum 
            int s1 = Calculator.Sum(2, 3 ); // com params não precisa instanciar
            int s2 = Calculator.Sum(new int[] { 2, 3, 4 }); // mais verboso

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //Triple

            int a = 10;

            //Calculator.Triple(a);// Main scope resultado vai ser 10
            //Console.WriteLine(a); 

            Calculator.Triple(ref a);// ref exige que a variavel seja iniciada
            Console.WriteLine(a); 

            int b = 10;
            int triple;

            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
