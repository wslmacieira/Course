using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3 ); // com params não precisa instanciar
            int s2 = Calculator.Sum(new int[] { 2, 3, 4 }); // mais verboso

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
