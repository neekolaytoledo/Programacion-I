using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Variables

            int carta1 = random.Next(1, 11);
            int carta2 = random.Next(1, 11);


            //Valores cartas (salida)
            Console.WriteLine("Su primera carta fue: " + carta1);
            Console.WriteLine("Su segunda carta fue: " + carta2);

            //Varialble nueva carta y puntaje
            int newcarta;
            int total = carta1 + carta2;

            //Respuesta (entrada)
            string respuesta = "s";
            string mascarta = "s";

            //El total sea menor que 21

            while (respuesta == "s" && total < 21)
            {
                newcarta = random.Next(1, 11); //Nueva carta aleatoria
                Console.Write("¿Desea una nueva carta? (s/n): ");
                mascarta = Console.ReadLine();
                Console.WriteLine("Nueva carta: " + newcarta); //Muestra la nueva carta
                total += newcarta;
                Console.WriteLine("Total: " + total); //SMuestra el total

                //Si el nuevo total sigue siendo menor o igual que 21
                if (mascarta == "S" && total <= 21)
                {

                    Console.WriteLine("Nueva carta: " + newcarta); //Muestra la nueva carta
                    Console.WriteLine("Total: " + total); //Muestra el total
                    Console.Write("¿Desea una nueva carta? (s/n): ");
                    respuesta = Console.ReadLine();
                }
                if (total > 21)
                {
                    Console.WriteLine("Fin del juego");
                    mascarta = "n";
                }
            }
            Console.WriteLine("Gracias por participar");
        }

    }
}
