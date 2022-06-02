using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        class Alumno
        {
            public string nombre;
            public int edad;
            public string genero;
            public string carrera;

            public Alumno(string nombre, int edad, string genero, string carrera)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.genero = genero;
                this.carrera = carrera;
            }

            public void DesplegarDatos()
            {
                Console.WriteLine("El nombre del alumno es: {0}", nombre);
                Console.WriteLine("La edad del alumno es: {0}",edad);
                Console.WriteLine("El genero del alumno es de tipo: {0}",genero);
                Console.WriteLine("La carrera a estudiar es: {0}",carrera);
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("DocumentoAlumnos.txt", true);
            //si el archo no existe lo creará
            //si ya existe, escribira en él

            //declaracion de varaibles:
            string nombre, genero, carrera;
            int edad;

            //captura de variables:
            Console.Write("¿Cuál es el nombre del alumno?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es la edad del alumno?: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("¿Cual su genero?: ");
            genero = Console.ReadLine();
            Console.Write("¿Cuál es la carrera que está estudiando el alumno?: ");
            carrera = Console.ReadLine();
            Console.Clear();
            //Creacion del Objeto de la Clase Alumno
            Alumno A1 = new Alumno(nombre, edad, genero, carrera);

            A1.DesplegarDatos();

            Console.WriteLine("Presione Enter para finalizar. ");
            Console.ReadKey();
            Console.Clear();

            sw.WriteLine("El nombre del alumno es: {0}", A1.nombre);//escribe en el archivo 
            sw.WriteLine("La edad del alumno es: {0}", A1.edad);
            sw.WriteLine("El genero del alumno es de tipo: {0}", A1.genero);
            sw.WriteLine("La carrera a estudiar es: {0}", A1.carrera);

            sw.Close(); // se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo..");
            Console.ReadLine();
        }
    }
}
