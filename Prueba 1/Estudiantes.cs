using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_1
{
    //Base Classes
    internal class Estudiantes : Persona
    {
        //Field
        string asignatura = "Español";
        public Estudiantes(string Nombre, int edad) : base (Nombre, edad)
        {

        }

        public void estudiar()
        {
            //Properties
            string libro = "María";

            Console.WriteLine("El estudiante por inercia estudia antes");
            Console.WriteLine("La materia favorita del estudiante es: " + asignatura);
            Console.WriteLine("El libro favorito del estudiante es el de: " + libro);
        }
    }
}
