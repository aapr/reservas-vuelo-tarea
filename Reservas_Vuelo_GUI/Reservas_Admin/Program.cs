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
        

        public static void AgregarCiudad()
        {

            DataLayerDataContext dataContext = new DataLayerDataContext();
            Ciudad ciudad = new Ciudad();
            
            Console.WriteLine("Nombre de la ciudad:");

            string nombre= Console.ReadLine();
            Console.WriteLine("Nombre de la ciudad:");
            string codigo= Console.ReadLine();

            ciudad.Nombre  = nombre;
            ciudad.Codigo = codigo;

            dataContext.Ciudads.InsertOnSubmit(ciudad);
            dataContext.SubmitChanges();
            
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine("VAMOS A AGREGAR UNA CIUDAD");
            AgregarCiudad();

        }
    }
}
