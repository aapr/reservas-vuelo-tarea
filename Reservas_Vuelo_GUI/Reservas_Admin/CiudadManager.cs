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
        DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();
        CIUDAD ciudad = new CIUDAD();

        
        /// <summary>
        /// Agrega los datos a la tabla ciudad NOTA: FALTA VALIDACION
        /// </summary>
        public void agregarCiudad() {

            if (ciudad != null)
            {
                //Nombre Ciudad
                Console.WriteLine("Nombre de la ciudad:");
                ciudad.NOMBRE = Console.ReadLine();
                //Codigo Ciudad
                Console.WriteLine("Codigo de la ciudad:");
                ciudad.CODIGO = Console.ReadLine();

                datacontext.CIUDADs.InsertOnSubmit(ciudad);
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
        public List<CIUDAD> listarCiudad()
        {

            var v = datacontext.CIUDADs.ToList();

            var data = v.Select(q => new CIUDAD
            {
                NOMBRE = q.NOMBRE,
                CODIGO = q.CODIGO
            }).ToList();

            return data;
        }

    }
}
