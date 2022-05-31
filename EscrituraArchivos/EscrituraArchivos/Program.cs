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
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archo no existe lo creará
            //si ya existe, escribira en él

            string[] lines = new string[3];

            Console.WriteLine("¿Cuál es el nombre del usuario?: ");
            lines[0] = Console.ReadLine();
            Console.WriteLine("¿Cual es la edad?: ");
            lines[1] = Console.ReadLine();
            Console.WriteLine("¿Cual su genero?: ");

            lines[2] = Console.ReadLine(); 

            //recorrer el arreglo 
            foreach (string line in lines)
            {
                sw.WriteLine(line);//escribe en el archivo 
            }
            sw.Close(); // se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo..");
            Console.ReadLine();
        }
    }
}
