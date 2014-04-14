using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Admin
{
    class Menus
    {
        Valid validado = new Valid();
        AvionManager A = AvionManager.Instance;
        VueloManager V = new VueloManager();
        CiudadManager C = new CiudadManager();

        public void menuPrincipal()
        {
            Console.WriteLine("Administrar:");
            Console.WriteLine("1)-----Avion");
            Console.WriteLine("2)-----Vuelo");
            Console.WriteLine("3)-----Viaje");
            Console.WriteLine("4)-----Ciudad");
            Console.WriteLine("5)-----Salir");
        }


        #region Menu Avion
        public void menuAvion()
        {
            Console.Clear();
            int op; bool pass = true;
            Console.WriteLine("AvionManager:");
            Console.WriteLine("1)-----Agregar avion");
            Console.WriteLine("2)-----Editar avion");
            Console.WriteLine("3)-----Mostrar aviones");
            Console.WriteLine("4)-----Salir");

            op = validado.validNum();

            while (pass)
            {
                switch (op)
                {
                    case 1:
                        A.agregarAvion();
                        pass = false;
                        break;
                    case 2:
                        A.editarAvions();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 3:
                        A.mostrarAvions();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 4:
                        pass = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es una opcion valida");
                        op = validado.validNum();
                        break;
                }

            }

        }
        #endregion




        #region Menu Vuelo
        public void menuVuelo() {
            Console.Clear();
            int op; bool pass = true;
            Console.WriteLine("VueloManager:");
            Console.WriteLine("1)-----Agregar vuelo");
            Console.WriteLine("2)-----Editar vuelo");
            Console.WriteLine("3)-----Mostrar vuelos");
            Console.WriteLine("4)-----Salir");

            op = validado.validNum();

            while (pass)
            {
                switch (op)
                {
                    case 1:
                        V.agregarVuelos();
                        pass = false;
                        break;
                    case 2:
                        V.editarVueloz();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 3:
                        V.mostrarVueloz();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 4:
                        pass = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es una opcion valida");
                        op = validado.validNum();
                        break;
                        
                }
                
            }
        }
        #endregion




        #region Menu Ciudad
        public void menuCiudad()
        {
            Console.Clear();
            int op; bool pass = true;
            Console.WriteLine("CiudadManager:");
            Console.WriteLine("1)-----Agregar ciudad");
            Console.WriteLine("2)-----Editar ciudad");
            Console.WriteLine("3)-----Mostrar ciudad");
            Console.WriteLine("4)-----Salir");

            op = validado.validNum();

            while (pass)
            {
                switch (op)
                {
                    case 1:
                        C.agregarCiudad();
                        pass = false;
                        break;
                    case 2:
                        C.editarCiudadz();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 3:
                        C.mostrarCiudades();
                        Console.ReadKey();
                        pass = false;
                        break;
                    case 4:
                        pass = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es una opcion valida");
                        op = validado.validNum();
                        break;
                }

            }

        }
        #endregion



    }
}