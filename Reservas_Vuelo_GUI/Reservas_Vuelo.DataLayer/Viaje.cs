using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Vuelo.DataLayer
{
    class Viaje
    {
        public int Id { get; set; }
        public int Id_Vuelo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
