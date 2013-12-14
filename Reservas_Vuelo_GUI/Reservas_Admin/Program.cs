using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Reservas_Vuelo.DataLayer;

namespace Reservas_Admin
{
    class Program
    {

        static void Main(string[] args)
        {
             AgregarCiudad c = new AgregarCiudad();
        

            Console.WriteLine("==============================");
            Console.WriteLine("===LLENANDO LA TABLA CIUDAD===");
            Console.WriteLine("==============================");

            c.agregarCiudad();

        }
    }
}
