using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas_Vuelo.DataLayer;

namespace Reservas_Admin
{
    class CiudadManager
    {
        DataLayerDataContext datacontext = new DataLayerDataContext();
        Ciudad ciudad = new Ciudad();

        
        /// <summary>
        /// Agrega los datos a la tabla ciudad NOTA: FALTA VALIDACION
        /// </summary>
        public void agregarCiudad() {

            if (ciudad != null)
            {
                //Nombre Ciudad
                Console.WriteLine("Nombre de la ciudad:");
                ciudad.Nombre = Console.ReadLine();
                //Codigo Ciudad
                Console.WriteLine("Codigo de la ciudad:");
                ciudad.Codigo = Console.ReadLine();

                datacontext.Ciudads.InsertOnSubmit(ciudad);
                datacontext.SubmitChanges();


                Console.WriteLine("Exito");
                Console.ReadKey();
        
            }
            else
            {
                Console.WriteLine("Error: 000");
                Console.ReadKey();
                
            }
        }

        //Posiblemente no se utilize
        public List<Ciudad> listarCiudad()
        {

            var v = datacontext.Ciudads.ToList();

            var data = v.Select(q => new Ciudad
            {
                Nombre = q.Nombre,
                Codigo = q.Codigo
            }).ToList();

            return data;
        }

    }
}
