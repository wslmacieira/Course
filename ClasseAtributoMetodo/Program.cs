using System;
using System.Globalization;

namespace ClasseAtributoMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro Problema
        /*    Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }*/

            // Exercicio 01

            /*    Pessoa p1, p2;

                p1 = new Pessoa();
                p2 = new Pessoa();

                Console.WriteLine("Entre com os dados da primeira pessoa:");
                p1.Nome = Console.ReadLine();
                p1.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com os dados da segunda pessoa:");
                p2.Nome = Console.ReadLine();
                p2.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da primeira pessoa:");
                Console.WriteLine("Nome: " + p1.Nome);
                Console.WriteLine("Idade: " + p1.Idade);

                Console.WriteLine("Dados da segunda pessoa:");
                Console.WriteLine("Nome: " + p2.Nome);
                Console.WriteLine("Idade: " + p2.Idade);

                if (p1.Idade > p2.Idade)
                {
                    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
                }
                else
                {
                    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
                }*/

            // exercicio 02

            /* Funcionario f1, f2;

             f1 = new Funcionario();
             f2 = new Funcionario();

             Console.WriteLine("Entre com os dados do primeiro funcionario:");
             f1.Nome = Console.ReadLine();
             f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Entre com os dados do segundo funcionario:");
             f2.Nome = Console.ReadLine();
             f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             double mediaSalario = (f1.Salario + f2.Salario) / 2;

             Console.WriteLine("Dados do primeiro funcionario: ");
             Console.WriteLine("Nome: " + f1.Nome);
             Console.WriteLine("Salário: " + f1.Salario.ToString("F2", CultureInfo.InvariantCulture));

             Console.WriteLine("Dados do primeiro funcionario: ");
             Console.WriteLine("Nome: " + f2.Nome);
             Console.WriteLine("Salário: " + f2.Salario.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Salário médio = " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));*/

            // Segundo problema

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
