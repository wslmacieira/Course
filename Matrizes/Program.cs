using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);// quantos elementos a matriz tem no total

            Console.WriteLine(mat.Rank);// quanto e a quantidade de linhas

            Console.WriteLine(mat.GetLength(0));//primeira dimensão da matriz linhas
            Console.WriteLine(mat.GetLength(1));//primeira dimensão da matriz colunas
        }
    }
}
