using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Admin
{
    class Valid
    {

        public int validNum() {
            int op; bool pass = true;
            do
            {
                Console.Write("Escriba el numero:");
                string t = Console.ReadLine();

                if (int.TryParse(t, out op))
                {
                    op = Convert.ToInt32(t);
                    pass = false;
                }
                else
                {
                    Console.WriteLine("Solo numeros son adminitidos:");
                }
            } while (pass == true);

            return op;
        
        }

    }
}
