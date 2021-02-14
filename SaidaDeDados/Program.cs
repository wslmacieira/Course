using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saida de Dados
            char genero = 'F';
            int idade = 41;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Bom tarde!");
            Console.WriteLine("Bom noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            /*int idade = 41;
            double saldo = 10.35784;
            string nome = "Maria";*/

            //Placeholder
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

            //Exercicio de fixação
            /* string produto1 = "Computador";
             string produto2 = "Mesa de escritório";

             byte idade = 30;
             int codigo = 5290;
             char genero = 'M';

             double preco1 = 2100.0;
             double preco2 = 650.50;
             double medida = 53.234567;

             Console.WriteLine("Produtos:");
             Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
             Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);
             Console.WriteLine();
             Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
             Console.WriteLine();
             Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
             Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
             Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
             */
        }
    }
}
