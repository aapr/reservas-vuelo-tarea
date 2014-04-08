using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas_Vuelo.DataLayer;
namespace Reservas_Admin
{
    class ViajeManager
    {
        DataLayerDataContext datacontext = new DataLayerDataContext();
        Viaje viaje = new Viaje();
        VueloManager vueloM = new VueloManager();

        public void agregarViaje() {

            var listav = vueloM.mostrarVuelos();
            foreach (var c in listav)
            {
                Console.WriteLine("id:{0} idAvion:{1} Origen{2} Destino{3} Hora Salida:{4} Hora LLegada:{5}"
                    , c.Id, c.Id_Avion, c.Origen, c.Destino, c.Hora_Salida, c.Hora_Llegada);
            };

            Console.WriteLine("Id del vuelo utilizado en este viaje");
            int i;
            string v = Console.ReadLine();
            i = Convert.ToInt32(v);

            Vuelo a = datacontext.Vuelos.FirstOrDefault(q => q.Id == i);

            viaje.Id_Vuelo = a.Id;

            Console.WriteLine("Escriba la fecha del viaje:");
            string date = Console.ReadLine();
            viaje.Fecha = Convert.ToDateTime(date);

            datacontext.Viajes.InsertOnSubmit(viaje);
            datacontext.SubmitChanges();

        }

    }
}
