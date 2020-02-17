using System;

namespace SimulacroCiclos_Clase__09
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dado = 0;
            int dadoII = 0;
            int NdadoII = 2;
            int puntos = 0;
            int turno = 0;
            int pretruno = 1;
            int Is = 0;
            int VIs = 0;
            int life = 3;
            string answer = "s";
            string NewDado = "s";

            while (answer == "s")
            {
                //Se genera el dado
                dado = random.Next(1, 7);
                //Contador de turnos y puntaje
                turno += 1;
                pretruno += 1;
                Console.WriteLine("Turno=" + turno);
                Console.WriteLine("Dado=" + dado);

                if (NdadoII > 0)
                {
                    Console.WriteLine("¿Desea usar el dado especial(12 caras)? (s/n)");
                    Console.ReadLine();

                    if (NewDado == "s")
                    {
                        NdadoII -= 1;
                        dadoII = random.Next(1, 13);
                        Console.WriteLine("DadoII=" + dadoII);
                    }
                } 
                if (dado == 1)
                {
                    Is += 1;
                }
                if (Is == 2)
                {
                    life -= 1;
                    puntos -= 10;
                }

                if (dado == 6)
                {
                    VIs += 1;
                    pretruno -= 1;
                }
                if (VIs == 2 && turno == pretruno)
                {
                    life += 1;
                }
                else if (turno != pretruno)
                {
                    pretruno += 1;
                }
                Console.WriteLine("Vidas=" + life);

                if (puntos < 100)
                {
                    puntos += dado + dadoII;
                    Console.WriteLine("Puntaje=" + puntos);
                    Console.WriteLine("¿Desea continuar?(s/n)");
                    Console.ReadLine();
                }
                
                if (puntos >= 100)
                {
                    Console.WriteLine("VISTORY! You got 100 points");
                    //Console.WriteLine("Puntaje=" + puntos);
                    answer = "n";
                }

                if (life < 0)
                {
                    Console.WriteLine("GAME OVER! Te quedaste sin vidas!");
                    answer = "n";
                }
            }

            Console.WriteLine("Gracias por participar!");
        }
    }
}
