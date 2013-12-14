using Reservas_Vuelo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Admin
{
    class AvionManager
    {
        DataLayerDataContext datacontext = new DataLayerDataContext();
        public List<Avion> BuscarAvion()
        {

            var data = from a in datacontext.Avions
                       select new Avion
                       {
                           Id = a.Id,
                           Descripcion = a.Descripcion
                       };

            return data.ToList();
        }

        Avion avion = new Avion();


        public void agregarAvion()
        {

            if (avion != null)
            {
                //Codigo Ciudad
                Console.WriteLine("Escriba una breve descripcion del avion:");
                avion.Descripcion = Console.ReadLine();

                datacontext.Avions.InsertOnSubmit(avion);
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


        public void eliminarAvion() { }
    }
}
