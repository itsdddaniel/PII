using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloI
{
    class Program
    {
        static void Main(string[] args) 
        {
            const int n = 3;
            var arreglo = new  int[n];
            for(int i=0; i<arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"{arreglo[i]} ");
            }
            Console.ReadKey();
        }
    }
}

