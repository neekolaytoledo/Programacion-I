using System;

namespace BlackJack_ValidacionArregloDeDatos_Casa__12
{
    using System;

    namespace BlackJack_ValidacionCiclos_Casa__10
    {
        class Program
        {
            static void Main(string[] args)
            {

                Random aleatorio = new Random();

                //Variables

                int jugador = 0;
                int carta1 = 0;
                int carta2 = 0;
                int n = 600;
                string mascarta = "";

                //Inicio programa
                Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡¡¡Incio!!!!!!!!!!!!!");


                Console.WriteLine("Desea seguir(s/n): ");
                string answer = Console.ReadLine();

                int[] puntajes = new int[n];


                for (int i = 0; i < puntajes.Length; i++)
                {
                    //Validación respuesta s y n
                    while (answer != "s" && answer != "n")
                    {
                        Console.WriteLine("\nError. Respuesta incorrecta. Solo permitido s/n");
                        Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                        answer = Console.ReadLine();
                    }

                    if (answer == "n")
                    {

                        mascarta = "n";
                        Console.WriteLine("Gracias por participar");
                        Console.WriteLine("Fin");
                    }

                    while (answer == "s" && mascarta != "s" && mascarta != "n")
                    {

                        Console.WriteLine("\nIngrese el número de jugadores (mínimo 2 jugadores y máximo 5)");
                        int nplayer = int.Parse(Console.ReadLine());

                        //Validación de cantidad de jugadores.

                        while (nplayer < 2 || nplayer > 5)
                        {//Si es menor que 2 o mayor que 5

                            Console.WriteLine("\nError. Respuesta incorrecta.Solo permitido número de jugadores entre 2 y 5");
                            Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                            nplayer = int.Parse(Console.ReadLine());
                        }

                        while (jugador < nplayer)
                        {

                            Console.WriteLine("\n-----------------Bienvenido al juego----------------- ");
                            Console.WriteLine("\n                 (Jugador #" + (jugador + 1) + ")");


                            carta1 = aleatorio.Next(1, 11);
                            carta2 = aleatorio.Next(1, 11);

                            //Valores primeras cartas (salida)
                            Console.WriteLine("\nCartaI=" + carta1);
                            Console.WriteLine("CartaII=" + carta2);

                            //Varialble nueva carta y puntaje
                            int ncarta;
                            int total = carta1 + carta2;

                            Console.WriteLine("\nTotal: " + total); //Salida total

                            //Mientras el total sea menor que 21
                            while ((answer == "s" || mascarta == "s") && total < 21)
                            {

                                ncarta = aleatorio.Next(1, 11); //Nueva carta aleatoria
                                Console.Write("\n¿Desea una nueva carta? (s/n): ");
                                mascarta = Console.ReadLine();

                                total += ncarta;

                                //Validación respuesta más carta (s/n)
                                while (mascarta != "s" && mascarta != "n")
                                {

                                    Console.WriteLine("\n----------Error. Respuesta incorrecta. Solo permitido s/n------------");
                                    Console.WriteLine("------------Por favor ingrese nuevamente los datos---------");
                                    mascarta = Console.ReadLine();
                                }

                                if (mascarta == "n")
                                {
                                    mascarta = "n";
                                    break;
                                }

                                Console.WriteLine("\nNueva carta: " + ncarta); //Salida nueva carta
                                Console.WriteLine("Total: " + total); //Salida total

                                //Condición de ganar

                                if (total == 21)
                                {

                                    Console.WriteLine("\n        VICTORY!");
                                    break;
                                }

                                //Condición de perder

                                if (total > 21)
                                {

                                    Console.WriteLine("\n     Your score is more than 21!!");
                                    Console.WriteLine("        GAME OVER!");
                                    break;
                                }

                                if (answer == "n") break;

                            }

                            jugador++;
                            Console.WriteLine("\nGracias por participar jugador #" + jugador);
                            Console.WriteLine("THE END");

                            puntajes[i] = total;
                        }

                    }
                    
                }
                int max = 0;
                int indmax = 0;
                double min = 200;
                double min2 = 200;
                double indmin = 0;
                int indicer = 0;

                for (int i = 0; i < puntajes.Length; i++)
                {
                    if (puntajes[i] > max)
                    {

                        max = puntajes[i];
                        indmax = i;

                    }
                }

                Console.WriteLine("\n                 Ganador, jugador " + (indmax + 1));
                Console.WriteLine("\n                 Puntaje de " + puntajes[indmax]);

            }

        }
    }
}
