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
        Valid validado = new Valid();

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

        private List<AVION> mostrarAvion()
        {

            var v = datacontext.AVIONs.ToList();
            Console.WriteLine("Id  | Despricion");
            var data = v.Select(q => new AVION
            {
                ID = q.ID,
                DESCRIPCION = q.DESCRIPCION
            }).ToList();

            return data;
        }

        public void mostrarAvions() {
            var lista = mostrarAvion();

            foreach (var c in lista)
            {
             Console.WriteLine("{0} | {1}", c.ID, c.DESCRIPCION);
            };

        }


        private void editarAvion(int i)
        {
            bool pass = true;
            avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);
            while (pass)
            {
                if (avion != null)
                {
                    pass = false;
                }

                else
                {
                    Console.WriteLine("Id del avion invalido trate de nuevo:");
                    i = validado.validNum();
                    avion = datacontext.AVIONs.FirstOrDefault(q => q.ID == i);
                }
            }
            
            Console.WriteLine("Introdusca una nueva descipcion:");
            avion.DESCRIPCION = Console.ReadLine();

            datacontext.SubmitChanges();

        }


        public void editarAvions() {
            Console.Clear();
            mostrarAvions();

            Console.WriteLine("id del avion a editar");
            int op = validado.validNum();

            editarAvion(op);
        }

    }
}
