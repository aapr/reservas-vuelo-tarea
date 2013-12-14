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

        /// <summary>
        /// Retorna el indice de la respuesta
        /// </summary>
        /// <param name="Preguntas"></param>
        /// <returns></returns>
         int GenerarPreguntas(string Pregunta, string[] Preguntas)
        {
            int respuesta = 0;
            bool correct = false;
            while (!correct)
            {
                Console.WriteLine(Pregunta);

                for (int c = 0; c < Preguntas.Length; c++)
                {
                    Console.WriteLine((c + 1).ToString() + ")" + Preguntas[c]);
                }

                string respuestaTemportal = Console.ReadLine();

                int.TryParse(respuestaTemportal, out respuesta);
                if (respuesta >= 1 && respuesta <= Preguntas.Length)
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Opcion incorrecto. Intente nuevamente");
                }
            }

            return respuesta;
        }

        static void Main(string[] args)
        {
            #region prueba de agregadod e ciudad
            AgregarCiudad c = new AgregarCiudad();
 
            Console.WriteLine("==============================");    
            Console.WriteLine("===LLENANDO LA TABLA CIUDAD===");
            Console.WriteLine("==============================");
            c.agregarCiudad();
             #endregion

            AvionManager am = new AvionManager();

            var lista = am.BuscarAvion();
          
            // Mostramos cruceros y viajes
              

        }
    }
}
