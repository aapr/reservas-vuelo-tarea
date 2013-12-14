using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas_Vuelo.DataLayer
{
    class Venta
    {
        public int Id { get; set; }
        public string Nombe { get; set; }
        public string Apellido { get; set; }
        public string Tarjeta { get; set; }
        public string Ccv { get; set; }
        public DateTime Exp { get; set; }
        public string Dir_Cobro { get; set; }
    }
}
