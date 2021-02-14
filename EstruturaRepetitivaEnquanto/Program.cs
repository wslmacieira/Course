using System;
using System.Globalization;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // While (Enquanto)
            /*  Console.Write("Digite um número: ");
              double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              while (x >= 0.0)
              {
                  double raiz = Math.Sqrt(x);
                  Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                  Console.Write("Digite outro número: ");
                  x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              }

              Console.WriteLine("Número negativo!");*/

            // For (Para)

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i); // Placeholder
                int valor = int.Parse(Console.ReadLine());
                //soma = soma + valor;
                soma += valor;  // mesma coisa que soma = soma + valor;
            }

            Console.WriteLine("Soma = " + soma); // Concatenar
        }
    }
}
