﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos3y5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    suma += i;
                }
            }
            Console.WriteLine("La suma es: "+suma);
            Console.ReadKey();
        }
    }
}