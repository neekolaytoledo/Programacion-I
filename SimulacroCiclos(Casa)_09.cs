using System;

namespace SimulacroCiclos_Casa__09
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dadoI = 0;
            int dadoII = 0;
            int turno = 0;
            int puntos = 0;
            int life = 3;
            string answer = "s";

            while (life > 0 && answer == "s")
            {
                //Se genera el dado
                dadoI = random.Next(1, 7);
                //Contador de turnos y puntaje
                puntos += dadoI;
                turno += 1;
                Console.WriteLine("Turno=" + turno);
                Console.WriteLine("Vidas=" + life);
                Console.WriteLine("Dado=" + dadoI);

                if(turno==3|| turno == 6|| turno ==9|| turno ==12|| turno ==15|| turno ==18|| turno ==21|| turno ==24|| turno ==27|| turno == 30)
                {
                    life -= 1;
                }
                else if(turno == 4 || turno == 7 || turno == 10 || turno == 13 || turno == 16 || turno == 19 || turno == 22 || turno == 25 || turno == 28 || turno == 31)
                {
                    dadoII = random.Next(1, 7);
                    puntos += dadoI + dadoII;
                    Console.WriteLine("DadoII=" + dadoII);

                    if (dadoI == dadoII)
                    {
                        Console.WriteLine("VICTORY!, Dados Dobles.");
                        answer = "n";

                    }
                }

                if(puntos < 100||life==0)
                {
                    Console.WriteLine("Su puntaje es de " + puntos);
                    Console.WriteLine("¿Desea continuar?(s/n)");
                    Console.ReadLine();
                } else if (puntos >= 100)
                {
                    Console.WriteLine("VICTORY!, 100 POINTS!");
                    answer = "n";
                }
            }

        }
    }
}
