using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double numero2;
            double resultado;
            numero = 0;
            numero2 = 0;
            resultado = 0;
            for(int i=0; i<101; i++)
            {
                numero += (Math.Pow(i, 2));
            }
            Console.WriteLine("La suma de cuadrados es: " + numero);

            for (int i=0; i<101; i++)
            {
                numero2 += i*(Math.Pow(i, 2));
            }
            Console.WriteLine("El cuadrado de la suma es: " + numero2);
            resultado = numero2 - numero;
            Console.WriteLine("La diferencia es: " + resultado);
            Console.ReadKey();
        }
    }
}
