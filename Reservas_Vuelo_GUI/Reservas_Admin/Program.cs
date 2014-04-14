using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Reservas_Vuelo.DataLayer;

namespace Reservas_Admin
{



    class Program
    {

        static void Main(string[] args)
        {
            Menus m = new Menus(); bool pass = true;
            Valid validado = new Valid();
            m.menuPrincipal();
            int op = validado.validNum();

            while (pass)
            {
                switch (op)
                {
                    case 1:
                        m.menuAvion();
                        pass = false;
                        break;
                    case 2:
                        m.menuVuelo();
                        pass = false;
                        break;
                    case 3:
                        pass = false;
                        break;
                    case 4:
                        m.menuCiudad();
                        pass = false;
                        break;
                    case 5:
                        pass = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es una opcion valida");
                        m.menuPrincipal();
                        op = validado.validNum();
                        break;
                }
                
            }
        
        }

    }
}

