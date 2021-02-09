using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPalindromeProduct
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, j, n, max_n = 0;

            for (i = 100; i <= 999; i++)
            {
                for (j = 100; j <= 999; j++)
                {
                    n = i * j;
                    if (n > max_n && EsPalendrome(n))
                    {
                        max_n = n;
                    }
                }
            }
            Console.WriteLine("La solucion es: " + max_n);
            Console.ReadKey();
        }

        public static bool EsPalendrome(int n)
        {
            string forward_string, reversa_string;

            forward_string = n.ToString();
            reversa_string = new string(forward_string.ToCharArray().Reverse().ToArray());

            return forward_string == reversa_string ? true : false;
        }
        
    }
}
