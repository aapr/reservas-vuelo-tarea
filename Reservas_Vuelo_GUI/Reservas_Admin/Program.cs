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

            DataLayerDataContext datacontext = new DataLayerDataContext();

            Ciudad ciudad = new Ciudad();

            if (ciudad != null)
            {

                ciudad.Nombre = "santo domingo";
                ciudad.Codigo = "sdq";

                datacontext.Ciudads.InsertOnSubmit(ciudad);
                datacontext.SubmitChanges();
            }
            else
            {
                Console.WriteLine("ciudad es null");
                Console.ReadKey();

            }


        }
    }
}
