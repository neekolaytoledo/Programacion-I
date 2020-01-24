using System;

namespace Desafio22
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            double arad = a * (Math.PI / 180);
            double y = ((Math.Sin(arad) * t));

            double z = Math.Cos(arad) * t;
            double c = 180 - 90 - a;

            Console.WriteLine(" y= " + y + " z= " + z + " t= " + t + " A= " + a + "°" + " C= " + c + "°" );
        }
    }
}
