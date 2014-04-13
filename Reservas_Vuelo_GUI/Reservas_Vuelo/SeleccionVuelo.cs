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
        private static DataClassesReservasDataContext datacontext = new DataClassesReservasDataContext();

        public SeleccionVuelo() {
            InitializeComponent();
            this.Height = 135;
        }

        private void btnVerFecha_Click(object sender, EventArgs e) {
            SlideTo(500);
            cmbDestino.Enabled = false;
            var value = cmbDestino.SelectedItem;
                        
            var fechas = (from v in datacontext.VIAJEs
                          join  vu in datacontext.VUELOs on v.ID_VUELO equals vu.ID
                          where v.FECHA > DateTime.Now
                            && vu.ORIGEN==cmbOrigen.Text
                            && vu.DESTINO == cmbDestino.Text
                          select v.FECHA).ToList();
            lstFecha.Items.Clear();
            foreach (var fecha in fechas)
            {
                lstFecha.Items.Add(fecha);
            }
            
            cmbOrigen.Enabled = false;
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
            
            cmbDestino.SelectedItem=null;
            cmbDestino.Items.Clear(); 
            SlideTo(135);
            cmbOrigen.Enabled = true;
        }

        private void btnSlideDestino_Click(object sender, EventArgs e) {
            SlideTo(230);
            cmbDestino.Enabled = true;
        }

        private void btnVerDestino_Click(object sender, EventArgs e) {
            var destinos = (from v in datacontext.VUELOs
                                     where v.ORIGEN == cmbOrigen.Text
                                     select v.DESTINO);
            cmbDestino.Items.AddRange(destinos.ToArray());
            SlideTo(300);
            cmbOrigen.Enabled = false;
        }

        private void SeleccionVuelo_Load(object sender, EventArgs e) {

            List<string> origenes = (from v in datacontext.VUELOs
                            select v.ORIGEN).Distinct().ToList();
            cmbOrigen.Items.AddRange(origenes.ToArray());
            
        }

        private void btnReservar_Click(object sender, EventArgs e) {
            SeleccionAsiento sa = new SeleccionAsiento();
            sa.Show();
            sa.Previous = this;
            this.Hide();
        }

        private void lstFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
