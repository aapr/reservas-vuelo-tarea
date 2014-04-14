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
        DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();

        AvionManager am = AvionManager.Instance;
        VUELO vuelo = new VUELO();
        Valid validado = new Valid();
        
        public void agregarVuelos()//faltan validaciones
        {
            am.mostrarAvions();

            int i; bool pass = true;
            Console.WriteLine("Id del avion");
            i = validado.validNum();
            AVION avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);

            while (pass)
            {
                if (avion != null)
                {
                    pass = false;
                }

                else
                {
                    Console.Clear();
                    am.mostrarAvions();
                    Console.WriteLine("Id del avion invalido trate de nuevo:");
                    i = validado.validNum();
                    avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);
                }
            }

            vuelo.ID_AVION = avion.ID;
            Console.WriteLine("Origen del vuelo");
            vuelo.ORIGEN = Console.ReadLine();
            Console.WriteLine("Destino del vuelo");
            vuelo.DESTINO = Console.ReadLine();
            Console.WriteLine("Hora de salida del vuelo");
            vuelo.HORA_SALIDA = Console.ReadLine();
            Console.WriteLine("Hora de llegada del vuelo");
            vuelo.HORA_LLEGADA = Console.ReadLine();

            datacontext.VUELOs.InsertOnSubmit(vuelo);
            datacontext.SubmitChanges();

        }

        private List<VUELO> mostrarVuelos()
        {

            var v = datacontext.VUELOs.ToList();

            var data = v.Select(q => new VUELO
            {
                ID = q.ID,
                ORIGEN = q.ORIGEN,
                DESTINO = q.DESTINO,
                HORA_SALIDA = q.HORA_SALIDA,
                HORA_LLEGADA = q.HORA_SALIDA,
                ID_AVION = q.ID_AVION

            }).ToList();

            return data;
        }
        public void mostrarVueloz()
        {
            var lista = mostrarVuelos();
            Console.WriteLine("id:| idAvion: | Origen: | Destin: | Hora: | Salida: | Hora LLegada:");
            foreach (var c in lista)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}"
                    , c.ID, c.ID_AVION, c.ORIGEN, c.DESTINO, c.HORA_SALIDA, c.HORA_LLEGADA);
            };
        }


        private void editarVuelos(VUELO vuelox)
        {
            int i; bool pass = true;
            Console.WriteLine("Id del avion");
            i = validado.validNum();
            AVION avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);
            
            while (pass)
            {
                if (avion != null)
                {
                    pass = false;
                }

                else
                {
                    Console.Clear();
                    am.mostrarAvions();
                    Console.WriteLine("Id del avion invalido trate de nuevo:");
                    i = validado.validNum();
                    avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);
                }
            }

            vuelox.ID_AVION = avion.ID;

            Console.WriteLine("Origen del vuelo");
            vuelox.ORIGEN = Console.ReadLine();
            Console.WriteLine("Destino del vuelo");
            vuelox.DESTINO = Console.ReadLine();
            Console.WriteLine("Hora de salida del vuelo");
            vuelox.HORA_SALIDA = Console.ReadLine();
            Console.WriteLine("Hora de llegada del vuelo");
            vuelox.HORA_LLEGADA = Console.ReadLine();

            datacontext.SubmitChanges();

        }

        public void editarVueloz() {
            int i; bool pass = true;
            mostrarVueloz();


            Console.WriteLine("Id del vuelo a modificar:");
            i = validado.validNum();
            vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == i);
            while (pass)
            {
                if (vuelo != null)
                {
                    pass = false;
                    editarVuelos(vuelo);
                }

                else
                {
                    Console.WriteLine("Id del vuelo invalido trate de nuevo:");
                    i = validado.validNum();
                    vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == i);
                }
            }
            
        }

    }
}
