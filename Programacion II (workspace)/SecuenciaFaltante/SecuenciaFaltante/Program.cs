using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaFaltante
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] {1, 2, 4};
            var A2 = new int[] {1,3};
            var A3 = new int[] { 1, 2, 3 };
            Console.WriteLine("El numero(s) faltante de la matriz A son: ");
            Console.WriteLine(A.Count());
            Console.WriteLine("El numero(s) faltante de la matriz A2 son: ");
            Console.WriteLine(A2.Count());
            Console.WriteLine("El numero(s) faltante de la matriz A3 son: ");
            Console.WriteLine(A3.Count());

            Console.ReadKey();

        }

    }
}
