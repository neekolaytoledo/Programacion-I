using System;

namespace _04Desafio02
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
                Console.WriteLine("El valor de su cuota moderadora es de: $3200.");
            }
            else
            {
                if (a == 2)
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa B.");
                    Console.WriteLine("El valor de su cuota moderadora es de: $12700.");
                }
                else if (2 <= a && a <= 4)
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa B.");
                    Console.WriteLine("El valor de su cuota moderadora es de: $12700.");
                }
                else
                {
                    Console.WriteLine("Su tarifa en la Caja de Compensasion Familiar es: Tarifa C.");
                    Console.WriteLine("El valor de su cuota moderadora es de: $33500.");
                }
            }

            Console.WriteLine("Su numero de salarios minimos mensuales vigentes es: " + a);
        }
    }
}
