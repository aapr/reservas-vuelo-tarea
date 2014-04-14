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
        Valid validado = new Valid();
        
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
        private List<CIUDAD> listarCiudad()
        {

            var v = datacontext.CIUDADs.ToList();

            var data = v.Select(q => new CIUDAD
            {
                ID = q.ID,
                NOMBRE = q.NOMBRE,
                CODIGO = q.CODIGO
            }).ToList();

            return data;
        }

        public void mostrarCiudades() {

            var lista = listarCiudad();
            Console.WriteLine("ID | Nombre | Codigo");
            foreach (var c in lista)
            {
                Console.WriteLine("{0} | {1} | {2}", c.ID, c.NOMBRE , c.CODIGO);
            };
        }

        private void editarCiudad( CIUDAD ciudad) {
            //Nombre Ciudad
            Console.WriteLine("Nombre de la ciudad:");
            ciudad.NOMBRE = Console.ReadLine();
            //Codigo Ciudad
            Console.WriteLine("Codigo de la ciudad:");
            ciudad.CODIGO = Console.ReadLine();

            datacontext.SubmitChanges();
        }

        public void editarCiudadz() {

            mostrarCiudades();

            int i; bool pass = true;
            Console.WriteLine("Id de la ciudad");
            i = validado.validNum();
            ciudad = datacontext.CIUDADs.FirstOrDefault(q => q.ID == i);

            while (pass)
            {
                if (ciudad != null)
                {
                    pass = false;
                }

                else
                {
                    Console.Clear();
                    mostrarCiudades();
                    Console.WriteLine("Id del avion invalido trate de nuevo:");
                    i = validado.validNum();
                    ciudad = datacontext.CIUDADs.FirstOrDefault(q => q.ID == i);
                }
            }
            editarCiudad(ciudad);
        }


    }
}
