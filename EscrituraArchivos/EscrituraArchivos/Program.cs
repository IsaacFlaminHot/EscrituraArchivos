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
            StreamWriter sw = new StreamWriter("ejemplo.txt");
            //si el archo no existe lo creará
            //si ya existe, escribira en él

            string[] lines =
            {
                "Esta es la informacón de la primea línea",
                "Esta es la segunda línea",
                "Fin del texto"
            };

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close(); // se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo..");
            Console.ReadLine();
        }
    }
}
