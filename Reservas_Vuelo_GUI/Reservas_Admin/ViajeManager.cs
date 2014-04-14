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
        Valid validado = new Valid();
        VUELO vuelo = new VUELO();

        public void agregarViaje() {

            vueloM.mostrarVueloz();


            int i; bool pass = true;         
            Console.WriteLine("Id del vuelo utilizado en este:");
            i = validado.validNum();
            vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == i);
            while (pass)
            {
                if (vuelo != null)
                {
                    pass = false;
                }

                else
                {
                    Console.WriteLine("Id del vuelo invalido trate de nuevo:");
                    i = validado.validNum();
                    vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == i);
                }
            }

            viaje.ID_VUELO= vuelo.ID;

            Console.WriteLine("Escriba la fecha del viaje:");
            string date = Console.ReadLine();
            viaje.FECHA = Convert.ToDateTime(date);

            datacontext.VIAJEs.InsertOnSubmit(viaje);
            datacontext.SubmitChanges();

        }

        private List<VIAJE> mostrarViaje() {
            var v = datacontext.VIAJEs.ToList();
            var data = v.Select(q => new VIAJE
            {
                ID = q.ID,
                ID_VUELO= q.ID_VUELO,
                FECHA = q.FECHA
            }).ToList();

            return data;
        }


        public void mostrarViajes() {

            var lista = mostrarViaje();
            Console.WriteLine("ID | ID Vuelo | Fecha");
            foreach (var c in lista)
            {
                Console.WriteLine("{0} | {1} | {2}", c.ID, c.ID_VUELO, c.FECHA);
            };
        }


        private void editarViaje(int i) {
            bool pass = true;
            viaje = datacontext.VIAJEs.FirstOrDefault(q => q.ID == i);
            while (pass)
            {
                if (viaje != null)
                {
                    pass = false;
                }

                else
                {
                    Console.WriteLine("Id del viaje invalido trate de nuevo:");
                    i = validado.validNum();
                    viaje = datacontext.VIAJEs.FirstOrDefault(q => q.ID == i);
                }
            }
            pass = true;
            Console.Clear();
            Console.WriteLine("Actual({0})| Id del nuevo vuelo: ", viaje.ID_VUELO);
            int x = validado.validNum();
            vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == x);
            while (pass)
            {
                if (vuelo != null)
                {
                    pass = false;
                }

                else
                {
                    Console.WriteLine("Id del vuelo invalido trate de nuevo:");
                    x = validado.validNum();
                    vuelo = datacontext.VUELOs.FirstOrDefault(q => q.ID == x);
                }
            }

            Console.WriteLine("Escriba la nueva fecha del viaje:");
            string date = Console.ReadLine();
            viaje.FECHA = Convert.ToDateTime(date);

            datacontext.SubmitChanges();
        }

        public void editarViajez() {
            Console.Clear();
            mostrarViajes();

            Console.WriteLine("id del Viaje a editar");
            int op = validado.validNum();

            editarViaje(op);
        }

    }
}
