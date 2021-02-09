using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            var arregloA = new int[] { 1, 2, -3, -4 };
            var arregloA2 = new int[] { 5, 6, -7, -8 };
            var arregloB = new int[] {0,0,0,0};
            Console.WriteLine("El Arreglo B es: ");
            Console.WriteLine();
            for(int i=0; i<4; i++)
            {
                if (arregloA[i] > 0 || arregloA2[i] > 0||arregloA[i] < 0 || arregloA2[i] < 0||arregloA ==null||arregloA2==null)
                {
                    arregloB[i] = arregloA[i] + arregloA2[i];
                }
                Console.Write(" " + arregloB[i]);
            }
            Console.ReadKey();
        }
    }
}
