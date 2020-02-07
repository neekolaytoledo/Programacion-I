using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de votos por el partido A:");
            double va = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos por el partido B:");
            double vb = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos en blanco:");
            double blancos = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos anulados:");
            double anulados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero total de población:");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje(0% -> 100%) de la población que es mayor de edad:");
            double m = double.Parse(Console.ReadLine());

            double vab = va + vb;

            //30% de los votos de A y B combinados
            double tc = vab * 0.3;

            //Numero total de votos
            double votos = vab + blancos + anulados;

            //Numero de adultos
            double XVIII = p * (m / 100);

            //Numero de abstencion
            double abstención = XVIII - votos;

            //Diferencia de votos entre el partido 1 y 2 
            int difeab = 0;
            if (va > vb)
            {
                difeab = va - vb;
            }
            else
            {
                difeab = vb - va;
            }

            //10% de los votos totales
            double Xvotos = votos * 0.1;

            //30% de la población
            double XXXp = p * 0.3;

            bool a = votos > p;
            bool b = difeab < Xvotos;
            bool c = votos < XXXp;

            Console.WriteLine("Votos para A:" + va + "  Votos para B:" + vb + "  Votos en blanco:" + blancos + "  Votos anulados:" + anulados + "  Población:" + p + "  Mayores de edad:" + XVIII + "  Total de votantes:" + votos + "  Abstención:" + abstención);

            if ((a || b) && c)
            {
                Console.WriteLine("Se deben repetir las elecciones"); 
            }
            else
            {
                if (va > vb)
                {
                    Console.WriteLine("Ganador de las elecciones es A");
                }
                else
                {
                    Console.WriteLine("Ganador de las elecciones es B");
                }
            }
            
                
            



        }
    }
}
