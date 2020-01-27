using System;

namespace DESAFIO142
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese D: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            double e = 180 - d - b;

            double c = 180 - e;
            double crad = c * (Math.PI / 180);

            double t = y / Math.Cos(crad);

            double z = (Math.Tan(crad) * y);

            double a = 180 - 90 - c;
            double arad = a * (Math.PI / 180);

            double brad = b * (Math.PI / 180);
            double x = (Math.Tan(brad + arad) * z) - y;

            double drad = d * (Math.PI / 180);
            double w = (x + y) / Math.Cos(drad);

            Console.WriteLine("B=" + b + "°" + " A=" + a + "°" + " C=" + c + "°" + " D=" + d + "°" + " E=" + e + "°" + " z=" + z + " y=" + y + " t=" + t + " x=" + x + " w=" + w);
        }
    }
}
