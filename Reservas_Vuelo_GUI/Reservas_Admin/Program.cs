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
            //#region prueba de agregado de ciudad
            //AgregarCiudad c = new AgregarCiudad();
 
            //Console.WriteLine("==============================");    
            //Console.WriteLine("===LLENANDO LA TABLA CIUDAD===");
            //Console.WriteLine("==============================");
            //c.agregarCiudad();
            // #endregion

            AvionManager am = new AvionManager();

            #region prueba de agregado de avion
            //Console.WriteLine("==============================");
            //Console.WriteLine("===LLENANDO LA TABLA AVION====");
            //Console.WriteLine("==============================");
            //am.agregarAvion();
            #endregion

            #region Listado Avion
            //Console.WriteLine("==============================");
            //Console.WriteLine("=======LISTA DE AVIONES=======");
            //Console.WriteLine("==============================");
            //var lista = am.buscarAvion();

            //foreach( var c in lista){

            //    Console.WriteLine("{0}", c.Descripcion);
            //};

            //Console.ReadLine();
            #endregion

            #region Eliminar Avion
            Console.WriteLine("==============================");
            Console.WriteLine("=======ELIMINAR AVION=========");
            Console.WriteLine("==============================");

            am.eliminarAvion(1);
            
            #endregion

        }


            // Mostramos cruceros y viajes
              

        }
}

