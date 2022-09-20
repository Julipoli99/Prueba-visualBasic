using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Persona p = new Persona();

            p.setNombre("Julian");
            p.setApellido("Polimeni");

            Console.WriteLine(p.nombreCompleto());
            Console.WriteLine("Prueba");
        }
    }

    class Persona
    {
        private string nombre;
        private string apellido;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        private string getNombre()
        {
            return this.nombre;
        }

        private string getApellido()
        {
            return this.apellido;
        }


        public string nombreCompleto()
        {
            return getNombre() + " " + getApellido();
        }
    }
}
