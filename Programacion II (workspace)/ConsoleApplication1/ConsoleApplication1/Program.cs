using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arreglo = new int[3, 3];
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write("Ingrese un numero: ");
                    arreglo[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + arreglo[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
