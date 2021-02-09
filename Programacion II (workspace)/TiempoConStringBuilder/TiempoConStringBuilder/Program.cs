using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoConStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new StringBuilder();   
            int limite;
            limite = 100000;
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            string frase = "lalalalalalalalalalala";
            for (int i = 0; i < limite; i++)
            {
                resultado.Append(frase);
            }
            Console.WriteLine(resultado);
            stop = new TimeSpan(DateTime.Now.Ticks);     
            Console.WriteLine("Tiempo de ejecucion: "+stop.Subtract(start).TotalMinutes);
            Console.ReadKey();
        }
    }
}
