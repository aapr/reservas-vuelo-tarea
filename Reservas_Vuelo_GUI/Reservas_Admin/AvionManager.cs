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
        DataLayerDataContext datacontext = new DataLayerDataContext();

        Avion avion = new Avion();
       

        public void agregarAvion()
        {

            if (avion != null)
            {
                //nombre avion
                Console.WriteLine("Escriba el nombre del avion:");
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

        public List<Avion> mostrarAvion()
        {

            var v = datacontext.Avions.ToList();

            var data = v.Select(q => new Avion
            {
                Id = q.Id,
                Descripcion = q.Descripcion
            }).ToList();

            return data;
        }


        public void editarAvion(int i) {
            Avion a = datacontext.Avions.FirstOrDefault(q => q.Id == i);

            a.Descripcion = Console.ReadLine();

            datacontext.Avions.InsertOnSubmit(a);
            datacontext.SubmitChanges();

        }

    }
}
