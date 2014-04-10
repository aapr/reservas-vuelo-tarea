using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas_Vuelo.DataLayer;

namespace Reservas_Admin
{
    class VueloManager//faltan todas las validaciones
    {
        DataLayerDataContext datacontext = new DataLayerDataContext();

        AvionManager am = new AvionManager();
        Vuelo vuelo = new Vuelo();

        public void agregarVuelos()//faltan validaciones
        {
            var lista = am.mostrarAvion();

            foreach (var c in lista)//aviones disponibles
            {
                Console.WriteLine("{0} + {1}", c.Id, c.Descripcion);
            };
    
            Console.WriteLine("Id del avion utilizado en el vuelo");
            int i;
            string v = Console.ReadLine();
            i = Convert.ToInt32(v);

            Avion a = datacontext.Avions.FirstOrDefault(q => q.Id == i);

            vuelo.Id_Avion = a.Id;
            Console.WriteLine("Origen del vuelo");
            vuelo.Origen = Console.ReadLine();
            Console.WriteLine("Destino del vuelo");
            vuelo.Destino = Console.ReadLine();
            Console.WriteLine("Hora de salida del vuelo");
            vuelo.Hora_Salida = Console.ReadLine();
            Console.WriteLine("Hora de llegada del vuelo");
            vuelo.Hora_Llegada = Console.ReadLine();

            datacontext.Vuelos.InsertOnSubmit(vuelo);
            datacontext.SubmitChanges();

        }

        public List<Vuelo> mostrarVuelos()
        {

            var v = datacontext.Vuelos.ToList();

            var data = v.Select(q => new Vuelo
            {
                Id = q.Id,
                Origen = q.Origen,
                Destino = q.Destino,
                Hora_Salida = q.Hora_Salida,
                Hora_Llegada= q.Hora_Salida,
                Id_Avion = q.Id_Avion
                
            }).ToList();

            return data;
        }

  
    }
}
