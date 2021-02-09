using System.Collections.Generic;

namespace Matricula
{
    class Alumno
    {
        // Atributos
        private string nombre;
        string numeroCuenta;
        int indiceAnterior;
        string carrera;
        string contraseña;
        bool pagoMatricula;
        string centroEstudios;
        List<string> asignaturas;
        enum categorias
        {
            PrimerIngreso, Prosene, Deportes, Cultural, ExcelenciaAcademica,
            PorEgresar, PorIndice
        }

        // Metodos (Funciones)

        // Constructor
        public Alumno(string nombre, string numeroCuenta, string carrera)
        {
            this.nombre = nombre;
            this.numeroCuenta = numeroCuenta;
            this.carrera = carrera;
        }

        // Metodo get (lectura)
        public string GetNombre()
        {
            return this.nombre;
        }

        // Metodo set (escritura)
        private void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodo ToString()
        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nCuenta: {this.numeroCuenta}\nCarrera: {this.carrera}\n";
        }

        // Propiedad
        public string NumeroCuenta
        {
            get
            {
                return this.numeroCuenta;
            }

            set
            {
                this.numeroCuenta = value;
            }
        }

        public string Carrera
        {
            get;
            set;
        }

    }
}