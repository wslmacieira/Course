using System;
using System.Globalization;

namespace MembroStatico
{
    class Program
    {

        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);

            double volume = VolumeCircunferencia(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double VolumeCircunferencia(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3); // mesma coisa que r * r * r
        }
    }
}
