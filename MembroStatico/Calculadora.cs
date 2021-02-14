using System;

namespace MembroStatico
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double VolumeCircunferencia(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3); // mesma coisa que r * r * r
        }
    }
}
