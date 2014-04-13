using Reservas_Vuelo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Admin
{
    class AvionManager//faltan todas las validaciones
    {
        DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();

        AVION avion = new AVION();

        private static AvionManager instance;

        private AvionManager() { }

        public static AvionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AvionManager();
                }
                return instance;
            }
        }
        public void agregarAvion()
        {

            if (avion != null)
            {
                //nombre avion
                Console.WriteLine("Escriba el nombre del avion:");
                avion.DESCRIPCION = Console.ReadLine();

                datacontext.AVIONs.InsertOnSubmit(avion);
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

        public List<AVION> mostrarAvion()
        {

            var v = datacontext.AVIONs.ToList();

            var data = v.Select(q => new AVION
            {
                ID = q.ID,
                DESCRIPCION = q.DESCRIPCION
            }).ToList();

            return data;
        }


        public void editarAvion(int i)
        {
            AVION a = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);

            a.DESCRIPCION = Console.ReadLine();

            datacontext.AVIONs.InsertOnSubmit(a);
            datacontext.SubmitChanges();

        }

    }
}
