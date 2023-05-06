using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Clase_Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora();
            com.PreguntarEncendido();
            if (com.Encendido1)
            {
                Console.WriteLine("Digite la capacidad: ");
                com.Capacidad1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el espacio disponible: ");
                com.EspacioDisco1 = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Dite la cantidad de datos a añadir: ");
                    int n = int.Parse(Console.ReadLine());
                    com.AnadirDatos(n);
                    Console.WriteLine("Dite la cantidad de datos a añadir: ");
                    int m = int.Parse(Console.ReadLine());
                    com.EliminarDato(m);
                    com.PreguntarApagado();
                } while (com.Encendido1);

            }
        }

    }
}
}
