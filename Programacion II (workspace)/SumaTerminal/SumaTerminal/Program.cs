using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encontrar que tiene el arreglo tiene 3 o mas elementos
            if(args.Length>=3)
            {
                int numero1, numero2, resultado;
                string operador;
                //transformar un numero
                numero1 = Convert.ToInt16(args[0]);
                numero2 = Convert.ToInt16(args[1]);
                operador = args[2];
                resultado = 0;

                switch(operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("El resultado es: " + resultado);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Argumentos insuficientes");
            }
            Console.ReadKey();
        }
    }
}
