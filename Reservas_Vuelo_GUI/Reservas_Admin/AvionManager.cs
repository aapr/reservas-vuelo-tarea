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


        //public List<Avion> BuscarAvion()
        //{

        //    var data = from a in datacontext.Avions
        //               select new Avion
        //               {
        //                   Id = a.Id,
        //                   Descripcion = a.Descripcion
        //               };

        //    return data.ToList();
        //}

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

        public List<Avion> buscarAvion()
        {

            var v = datacontext.Avions.ToList();

            var data = v.Select(q => new Avion
            {
                Descripcion = q.Descripcion
            }).ToList();

            return data;
        }

        public void eliminarAvion(int i) {

            Avion a = datacontext.Avions.FirstOrDefault(q => q.Id == i);

            datacontext.Avions.DeleteOnSubmit(a);
            datacontext.SubmitChanges();
        }

    }
}
