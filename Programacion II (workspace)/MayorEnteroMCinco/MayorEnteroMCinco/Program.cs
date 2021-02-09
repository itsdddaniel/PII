using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorEnteroMCinco
{
    class Program
    {
        static int[] CercanoACinco(int[] numeros)
        {

            var arregloA = new double[3] { 34.5, 24.5, 14.3 };
            arregloA[0] = Math.Ceiling(arregloA[0]);
            arregloA[1] = Math.Ceiling(arregloA[1]);
            arregloA[2] = Math.Ceiling(arregloA[2]);
            var arregloB = new double[3] {0,0,0};
            arregloB[0] = arregloA[0];
            arregloB[1] = arregloA[1];
            arregloB[2] = arregloA[2];
            for(int i=0; i<3; i++)
            {
                if (arregloA[i] % 5 == 0)
                {
                    Console.WriteLine(" " + arregloB[i]);
                } 
            }
            Console.ReadKey();
        }
    }
}
