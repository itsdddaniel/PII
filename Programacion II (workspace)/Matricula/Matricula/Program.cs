using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("Jose", "20181001234", "Ing. Sistemas");

            alumno.GetNombre();
            alumno.NumeroCuenta = "20025";
            alumno.Carrera = "Medicina";

            Console.WriteLine(alumno);

            var alumno2 = alumno;
            alumno2.NumeroCuenta = "45678";

            Console.WriteLine($"Alumno1: {alumno}\nAlumno2: {alumno2}");

            Console.ReadKey();
        }

    }
}
