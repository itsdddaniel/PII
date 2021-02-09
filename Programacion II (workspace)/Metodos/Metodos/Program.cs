using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tiendita = new Tienda();
            tiendita.lapices = 100;
            Console.WriteLine(tiendita.lapices);
            Console.ReadKey();

        }
    }
}
