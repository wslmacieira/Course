using System;

namespace EscopoInicializacao
{
    class Program
    {
        // escopo do program
        static void Main(string[] args)
        {
            // variavel do escopo maio e visivel para os escopo menor
            /* double preco = double.Parse(Console.ReadLine());
             double desconto = 0.0;

             if (preco > 100)
             {
                 // variavel do escopo menor não e visivel para o escopo maior
                 //double desconto = preco * 0.1;
                 desconto = preco * 0.1;
             }

             Console.WriteLine(desconto);*/

            // Funções
            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        // escopo do metodo
        static int Maior(int n1, int n2, int n3)
        {
            int maior;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}
