using Reservas_Vuelo.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservas_Vuelo {
    public partial class SeleccionVuelo : Form {
        private static DataLayerDataContext datacontext = new DataLayerDataContext();

        public SeleccionVuelo() {
            InitializeComponent();
            this.Height = 135;
        }

        private void btnVerFecha_Click(object sender, EventArgs e) {
            SlideTo(400);
            cmbDestino.Enabled = false;
        }
        private void SlideTo(int height) {
            int step = 5;
            if (this.Height > height) {
                step = -step;
            }
            while (Math.Abs(this.Height - height) > 5) {
                this.Height += step;
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnSlideOrigen_Click(object sender, EventArgs e) {
            SlideTo(135);
            cmbOrigen.Enabled = true;
        }

        private void btnSlideDestino_Click(object sender, EventArgs e) {
            SlideTo(230);
            cmbDestino.Enabled = true;
        }

        private void btnVerDestino_Click(object sender, EventArgs e) {
            var destinos = (from v in datacontext.Vuelos
                                     where v.Origen == cmbOrigen.Text
                                     select v.Origen);
            cmbDestino.Items.AddRange(destinos.ToArray());
            SlideTo(230);
            cmbOrigen.Enabled = false;
        }

        private void SeleccionVuelo_Load(object sender, EventArgs e) {

            List<string> origenes = (from v in datacontext.Vuelos
                            select v.Origen).Distinct().ToList();
            cmbOrigen.Items.AddRange(origenes.ToArray());
            
        }

        private void btnReservar_Click(object sender, EventArgs e) {
            SeleccionAsiento sa = new SeleccionAsiento();
            sa.Show();
            sa.Previous = this;
            this.Hide();
        }
    }
}
