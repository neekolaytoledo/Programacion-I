using System;

namespace DESAFIO143
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese D: ");
            double d = double.Parse(Console.ReadLine());

            double drad = d * (Math.PI / 180);
            double y = (Math.Cos(drad) * w) - x;

            Console.WriteLine("D=" + d + "°" + " x=" + x + " w=" + w + " y=" + y);

        }
    }
}
