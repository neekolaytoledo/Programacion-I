using System;

namespace DESAFIO141
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((z) * (z) + (y) * (y));

            double brad = b * (Math.PI / 180);

            double crad = Math.Asin(z / t);
            double c = crad * (180 / Math.PI);

            double a = 180 - 90 - c;
            double arad = a * (Math.PI / 180);

            double e = 180 - c;

            double d = 180 - e - b;

            double w = z / (Math.Cos(brad + arad));

            double x = ((Math.Sin(brad + arad) * w) - 2);

            Console.WriteLine("B=" + b + "°" + " A=" + a + "°" + " C=" + c + "°" + " D=" + d + "°" + " E=" + e + "°" + " z=" + z + " y=" + y + " t=" + t + " x=" + x + " w=" + w);

        }
    }
}
