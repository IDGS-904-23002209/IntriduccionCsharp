using System;
using System.Collections.Generic;
using System.Text;

namespace IntriduccionCsharp.Models
{
    /*
     * class [nombre]{
     * [atributos o variables]
     * [metodos o funciones]
     */
    class Practica2
    {
        string nombre;
        private int edad;
        protected string carrera;

        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();

        }
    }
}
