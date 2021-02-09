using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long fib3 = 2;
            long fib6 = 0;
            long resultado = 2;
            long sumado = 0;
            while (resultado < 4000000)
            {
                sumado += resultado;
                resultado = 4 * fib3 + fib6;
                fib6 = fib3;
                fib3 = resultado;
            }
            Console.Write("El Resultado es: " + sumado);
            Console.ReadKey();
        }
    }
}
