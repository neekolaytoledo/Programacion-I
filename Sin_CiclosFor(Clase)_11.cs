using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_CiclosFor_Clase__11
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ingrese el valor de X.");
                double X = double.Parse(Console.ReadLine());
                double sinX = 0;

                for (int i = 0; i < 1000; i++)
                {
                    double sin;
                    sin = ((Math.Pow(-1, i)) / (Factorial(2*(i)+1)))*(Math.Pow(X,(2*i)+1));
                    sinX += sin;
                }
                Console.WriteLine("sin(" + X + ")=" + sinX);

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
