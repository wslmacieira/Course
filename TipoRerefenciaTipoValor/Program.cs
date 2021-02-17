using System;

namespace TipoRerefenciaTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel apenas declarada inicia em estado não atribuida e o proprio
            //compilador não permite que ela seja acessada.
            Point p; // mesmo sendo struct precisa inicializar

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            
            p = new Point(); // recria as caixas com valo 0

            Console.WriteLine(p);
        }
    }
}
