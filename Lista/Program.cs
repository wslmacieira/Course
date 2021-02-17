using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //1 - Inserir elemento na lista: Add, Insert
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana"); // Add insere ao final da lista
            list.Insert(2, "Marco"); // Insert insere na posição do array especificada

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //2 - Tamanho da lista: Count
            Console.WriteLine("List count: " + list.Count);

            //3 - Encontrar primeiro e último elementos da lista: 
            // list.Find, list.Find

            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);

            s1 = list.Find(x => x[0] == 'A'); // Expressão Lambda (espressão anonima)
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            static bool Test(string s)
            {
                return s[0] == 'A';
            }

            //4 - Encontrar primeira ou última posição de elementos da lista: 
            // list.FindIndex, list.FindLastIndex
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //5 Filtrar lista com base em um predicado: list.FindAll

            List<string> listFilter = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------");

            foreach (string obj2 in listFilter)
            {
                Console.WriteLine(obj2);
            }

            //6 - Remover com base em um predicado, Remove, RemoveAll, RemoveRange
            list.RemoveAt(3); // remove o Bob na posição 3
            Console.WriteLine("-----------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-----------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");

            list.RemoveRange(2, 2); // remove na posição 2 e remove Alex e Bob
            Console.WriteLine("-----------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
