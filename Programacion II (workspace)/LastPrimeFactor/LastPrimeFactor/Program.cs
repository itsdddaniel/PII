using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            int largo = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    n /= i;
                    largo = i;
                }
            }
            Console.WriteLine(largo);
            Console.ReadKey();
        }
    }
}
