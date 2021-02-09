using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacionCadenasAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new StringBuilder();
            int limite;
            limite = 100;
            string frase = "lalalalalalalalalalala";
            for(int i=0; i<limite; i++)
            {
                resultado.Append(frase);
            }
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
