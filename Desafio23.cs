using System;

namespace Desafio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            double t = z/Math.Sin(c);

            double y = t * Math.Cos(c);
            double a = 180 - (90 + c);

            Console.WriteLine(" y= " + y + " z= " + z + " t= " + t + " A= " + a + "° " + " C= " + c + "° ");
        }
    }
}
