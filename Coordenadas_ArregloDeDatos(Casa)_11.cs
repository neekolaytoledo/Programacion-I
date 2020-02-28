using System;

namespace Coordenadas_ArregloDeDatos_Casa__11
{
    class Program
    {
        static void Main(string[] args)
        {
            //                   0  1  2  3
            double[] coordsX = { 0, 2, 3, 7 };

            double[] coordsY = { 0, 1, 5, 6 };

            double distanciaMayor = 0;

            double pendienteI = ((coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]));
            double pendienteII = ((coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]));
            double pendienteIII = ((coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]));

            double interseccionI = (coordsY[1] - (pendienteI * coordsX[1]));
            double interseccionII = (coordsY[2] - (pendienteII * coordsX[2]));
            double interseccionIII = (coordsY[3] - (pendienteIII * coordsX[3]));

            if((interseccionI==interseccionII&&pendienteI==pendienteII)&& (interseccionII == interseccionIII && pendienteII == pendienteIII))
            {
                Console.WriteLine("Estan en la misma recta.");
            }
            else
            {
                Console.WriteLine("No estan en la misma recta");
            }

            double distanciaI = Math.Sqrt((coordsX[1] - coordsX[0]) * (coordsX[1] - coordsX[0]) + (coordsY[1] - coordsY[0]) * (coordsY[1] - coordsY[0]));
            double distanciaII = Math.Sqrt((coordsX[2] - coordsX[1]) * (coordsX[2] - coordsX[1]) + (coordsY[2] - coordsY[1]) * (coordsY[2] - coordsY[1]));
            double distanciaIII = Math.Sqrt((coordsX[3] - coordsX[2]) * (coordsX[3] - coordsX[2]) + (coordsY[3] - coordsY[2]) * (coordsY[3] - coordsY[2]));

            if (distanciaI > distanciaMayor)
            {
                distanciaMayor = distanciaI;
            }
            if(distanciaII > distanciaMayor)
            {
                distanciaMayor = distanciaII;
            }
            if(distanciaIII > distanciaMayor)
            {
                distanciaMayor = distanciaIII;
            }

            Console.WriteLine("La mayor distancia es " + distanciaMayor);

        }
    }
}
