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
        

        public void AgregarCiudad()
        {
            string nombre = string.Empty;
            string codigo= string.Empty;

            Ciudad ciudad = new Ciudad();
            
            Console.WriteLine("Nombre de la ciudad:");
            ciudad.Nombre = Console.ReadLine();
            Console.WriteLine("Nombre de la ciudad:");
            ciudad.Codigo = Console.ReadLine();
        }


    }
}
