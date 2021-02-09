using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            if (args.Length >= 2)
            {
                Console.WriteLine("Primer argumento:"+args[0]);
                Console.WriteLine("Segundo argumento:"+args[1]);
            }
        }
    }
}
