using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservas_Vuelo.DataLayer;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VENTA venta = VentaManager.Instance.venta;
            venta.NOMBRE = txtNombre.Text;
            venta.APELLIDO = txtApellido.Text;
            venta.TARJETA = txtNumero.Text;
            venta.CCV= txtCCV.Text;
            venta.EXPE =dtExpiracion.Value.Ticks;
            venta.DIR_COBRO = txtCorreo.Text;
            VentaManager.Instance.agregarVenta();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
