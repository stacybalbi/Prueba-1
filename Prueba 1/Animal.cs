using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_1
{
    internal class Animal : IAcciones
    {
        public void Caminar()
        {
            Console.WriteLine("El animal puede caminar");
        }
        public void Comer(string comida)
        {

            Console.WriteLine("El animal puede comer " + comida);
        }

        public void Ver()
        {
            Console.WriteLine("El animal puede ver");
        }

    }
}
