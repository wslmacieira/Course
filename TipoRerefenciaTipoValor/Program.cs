using System;

namespace TipoRerefenciaTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel apenas declarada inicia em estado não atribuida e o proprio
            //compilador não permite que ela seja acessada.
            /*   Point p; // mesmo sendo struct precisa inicializar

               p.X = 10;
               p.Y = 20;

               Console.WriteLine(p);

               p = new Point(); // recria as caixas com valo 0

               Console.WriteLine(p);
            */

            //Nullable

            //double x = null; // tipos structs não aceitam null

           /* double? x = null; //Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
           */

            // Operador de coalescência nula

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
