using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoConString
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            int limite;
            limite = 100000;
            string resultado;
            resultado = "";
            string frase = "lalalalalalalalalalalalala";

            for (int i = 0; i < limite; i++)
            {
                resultado += frase;
            }
            Console.WriteLine(resultado);
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stop.Subtract(start).TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
