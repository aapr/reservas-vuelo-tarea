using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas_Vuelo.DataLayer;
namespace Reservas_Vuelo
{
    class VentaManager
    {
        DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();
        private static VentaManager instance;

        private VentaManager() { }

        public static VentaManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VentaManager();
                }
                return instance;
            }
        }

        public VENTA venta = new VENTA();

        public void agregarVenta()
        {
            if (string.IsNullOrEmpty(venta.NOMBRE)) {
            
            }
            datacontext.VENTAs.InsertOnSubmit(venta);
            datacontext.SubmitChanges();

            venta = new VENTA();
        }
    }


}
