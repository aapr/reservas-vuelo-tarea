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
    public partial class SeleccionAsiento : Form {
        public Form Previous { get; set; }
        public SeleccionAsiento() {
            InitializeComponent();
        }

        private void SeleccionAsiento_Load(object sender, EventArgs e) {
            dtExpiracion.MinDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e) {
            Previous.Show();
            this.Hide();
        }
    }
}
