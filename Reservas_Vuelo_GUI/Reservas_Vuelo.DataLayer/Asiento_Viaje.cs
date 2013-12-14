using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Vuelo.DataLayer
{
    class Asiento_Viaje
    {
        public int Id { get; set; }
        public int Id_Viaje { get; set; }
        public int Id_Asiento_Avion { get; set; }
        public int Id_Vuelo { get; set; }
        public int Id_Avion { get; set; }
    }
}
