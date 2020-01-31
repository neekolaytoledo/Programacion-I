using System;

namespace _04Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su mensual legal vigente: ");
            double s = double.Parse(Console.ReadLine());

            double a = s / 877803;

            if (a < 2)
            {
                Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa A.");
            }
            else
            {
                if (a==2)
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa B.");
                }
                else if (2 <= a && a <= 4)
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa B.");
                }
                else 
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa C.");
                }
            }

            Console.WriteLine("Su numero de salarios minimos mensuales vigentes es: " + a);
        }
    }
}
