using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try._._.Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2;
                num1 = 0;
                num2 = 0;
                Console.WriteLine("Ingrese el valor de los numeros que desea sumar: ");
                num1 = Convert.ToInt64(Console.ReadLine());
                num2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                double num1, num2;
                num1 = 0;
                num2 = 0;
                Console.WriteLine("Ingrese el valor de los numeros que desea sumar: ");
                num1 = Convert.ToInt64(Console.ReadLine());
                num2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            }
            Console.ReadKey();
        }
    }
}
