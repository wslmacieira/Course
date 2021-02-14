using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 10;

            if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa noite!");*/

            /* Console.WriteLine("Entre com um número inteiro:");

             int x = int.Parse(Console.ReadLine());

             if (x % 2 == 0)
             {
                 Console.WriteLine("Par!");
             }
             else
             {
                 Console.WriteLine("Impar!");
             }*/

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            // se for true ele continua executando os outros if!
            // não para o programa
       /*     if (hora < 12) 
            {
                Console.WriteLine("Bom Dia!");
            }

            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }

            if (hora >= 18)
            {
                Console.WriteLine("Boa Noite!");
            }*/

            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
