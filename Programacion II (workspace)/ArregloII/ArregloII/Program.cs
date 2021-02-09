using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloII
{
    class Program
    {
        static void Main(string[] args)
        {
            var arreglo = new int[5];
            foreach (int elemento in arreglo)
            {
                Console.WriteLine($"{elemento}");
            }
            Console.ReadKey();
        }
    }
}
