using System;

namespace DESAFIO144
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese C: ");
            double c = double.Parse(Console.ReadLine());
       
            double crad = c * (Math.PI / 180);
            double y = t * Math.Cos(crad);
            double z = t * Math.Sin(crad);
                
            double arad = Math.Asin(y / t);
            double a = arad * (180 / Math.PI);

            double e = 180 - c;

            double brad = (Math.Acos(z / w)) - arad;
            double b = brad * (180 / Math.PI);

            double x = ((Math.Sin(arad + brad) * w) - y);

            Console.WriteLine("C=" + c + "°" + " A=" + a + "°" + " B=" + b + "°" + " w=" + w + " t=" + t + " z=" + z + " y=" + y + " x=" + x);
        }
    }
}
