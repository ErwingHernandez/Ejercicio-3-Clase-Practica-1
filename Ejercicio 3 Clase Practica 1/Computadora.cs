using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Clase_Practica_1
{
    internal class Computadora
    {
        int Capacidad;
        int EspacioDisco;
        bool Encendido;
        public Computadora() { }
        public Computadora(int capacidad, int espacioDisco, bool Encendido)
        {
            Capacidad1 = capacidad;
            EspacioDisco1 = espacioDisco;
            this.Encendido = Encendido;
        }

        public int Capacidad1 { get => Capacidad; set => Capacidad = value; }
        public int EspacioDisco1 { get => EspacioDisco; set => EspacioDisco = value; }
        public bool Encendido1 { get => this.Encendido; set => this.Encendido = value; }

        public void PreguntarEncendido()
        {
            if (this.Encendido)
            {
                Console.WriteLine("La computadora no se ha encendido");

            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("Bienvenido");
            }
            Console.ReadLine();
        }
        public void PreguntarApagado()
        {
            Console.WriteLine("Desea apagar el equipo: ");
            string c = Console.ReadLine();
            if (c == "S" || c == "s")
            {
                this.Encendido = false;
                Console.WriteLine("La computadora se apago");
            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("La computadora continua encendida");
            }
            Console.ReadLine();
        }
        public void AnadirDatos(int datos)
        {
            if (this.Encendido)
            {
                if (datos <= this.Capacidad)
                {
                    this.EspacioDisco = this.Capacidad - datos;
                    Console.WriteLine("Se añadio el archivo {0} y el espacio disponible es: {1}", datos, this.EspacioDisco);
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible..");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta apagada..");
            }
        }
        public void EliminarDato(int datos)
        {
            if (this.Encendido)
            {
                if (datos <= this.EspacioDisco)
                {
                    this.EspacioDisco = this.Capacidad + datos;
                    Console.WriteLine("EL espacio disponible se ha reestablecido: " + this.EspacioDisco);
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible..");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta apagada..");
            }
        }
    }
}
