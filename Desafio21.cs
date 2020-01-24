using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((y * y) + (z * z));

            double a = (Math.Asin(y / t)) * (180/Math.PI);
            double c = (Math.Asin(z / t)) * (180/Math.PI);

            Console.WriteLine(" y= " + y + " z= " + z + " t= " + t + " A= " + a + "°" + " C= " + c + "°");


        }
    }
}
