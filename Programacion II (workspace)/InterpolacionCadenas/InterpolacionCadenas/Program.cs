using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacionCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;
            resultado = "";
            string frase="hola";
            
            for (int i = 0; i<100; i++)
            {
                resultado+=frase;
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
