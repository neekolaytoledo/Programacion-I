using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosFor_Clase__11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de X.");
            double X = double.Parse(Console.ReadLine());
            double eulerX = 0;

            for(int i = 0; i < 100; i++)
            {
                double euler;
                euler = (Math.Pow(X,i)) / (Factorial(i));
                eulerX += euler;
            }
            Console.WriteLine("e^" + X + "=" + eulerX);

        }

        public static double Factorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
