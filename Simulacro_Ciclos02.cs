using System;

namespace Simulacro_Ciclos02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int dado = 0;
            int puntos = 0;
            int turno = 0;
            string answer = "s";
            bool combo = false;
            bool combo2 = false;
            

            while (answer == "s") 
            {
                //Se genera el dado
                dado = random.Next(1, 13);
                //Contador de turnos y puntaje
                puntos += dado;
                turno += 1;
                Console.WriteLine("Turno=" + turno);
                Console.WriteLine("Dado=" + dado);

                //Victoria por 10 y 12 consecutivos
                if (dado == 10)
                {
                    combo = true;

                }

                if (dado == 12 && combo == true)
                {
                    combo2 = true;
                }
                else
                {
                    combo = false;
                }

                if (combo2 == true)
                {
                    Console.WriteLine("VISTORY! You did a 10+12 COMBO!");
                    Console.WriteLine("Puntaje=" + puntos);
                    answer = "n";
                }



                //Derrota por impar depues del turno3
                if (turno>3 && (dado == 1 || dado == 3 || dado == 5 || dado == 7 || dado == 9 || dado == 11))
                {
                    Console.WriteLine("Su dado es impar");
                    Console.WriteLine("GAME OVER");
                    answer = "n";
                }
                else if (puntos<100)
                {
                    Console.WriteLine("Su puntaje es de " + puntos);
                    Console.WriteLine("¿Desea continuar?(s/n)");
                    Console.ReadLine();
                }

               
                //Victoria por 100 puntos
                if (puntos >= 100)
                {
                    Console.WriteLine("VISTORY! You got 100 points");
                    Console.WriteLine("Puntaje=" + puntos);
                    answer = "n";
                }





            }

            //Variables

            
        }
    }
}
