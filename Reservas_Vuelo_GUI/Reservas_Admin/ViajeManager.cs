using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas_Vuelo.DataLayer;
namespace Reservas_Admin
{
    class ViajeManager//faltan todas las validaciones
    {
        DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();
        VIAJE viaje = new VIAJE();
        VueloManager vueloM = new VueloManager();

        public void agregarViaje() {

            vueloM.mostrarVueloz();

            Console.WriteLine("Id del vuelo utilizado en este viaje");
            int i;            
            string v = Console.ReadLine();
            i = Convert.ToInt32(v);

            VUELO a = datacontext.VUELOs.FirstOrDefault(q => q.ID == i);

            viaje.ID_VUELO= a.ID;

            Console.WriteLine("Escriba la fecha del viaje:");
            string date = Console.ReadLine();
            viaje.FECHA = Convert.ToDateTime(date);

            datacontext.VIAJEs.InsertOnSubmit(viaje);
            datacontext.SubmitChanges();

        }

        public List<VIAJE> mostrarViaje() {
            var v = datacontext.VIAJEs.ToList();
            var data = v.Select(q => new VIAJE
            {
                ID = q.ID,
                ID_VUELO= q.ID_VUELO,
                FECHA = q.FECHA
            }).ToList();

            return data;
        }

        public void editarViaje(int i) { 

            VIAJE v = datacontext.VIAJEs.FirstOrDefault(q => q.ID == i);
            

            Console.WriteLine("Nuevo id_vuelo");
            int x = Convert.ToInt32(Console.ReadLine());
            AVION a = datacontext.AVIONs.FirstOrDefault(q => q.ID == x);
            v.ID_VUELO = a.ID;

            Console.WriteLine("Escriba la nueva fecha del viaje:");
            string date = Console.ReadLine();
            viaje.FECHA = Convert.ToDateTime(date);

            datacontext.VIAJEs.InsertOnSubmit(v);
            datacontext.SubmitChanges();
        }

    }
}
