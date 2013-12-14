using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservas_Vuelo
{
    public partial class SeleccionVuelo : Form
    {
        public SeleccionVuelo()
        {
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
            while (Math.Abs(this.Height-height)>5) {
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
            SlideTo(230);
            cmbOrigen.Enabled = false;
        }

        private void SeleccionVuelo_Load(object sender, EventArgs e) {

        }
    }
}
