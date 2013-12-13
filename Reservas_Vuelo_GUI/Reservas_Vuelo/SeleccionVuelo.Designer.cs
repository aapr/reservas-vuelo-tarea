namespace Reservas_Vuelo
{
    partial class SeleccionVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.btnVerDestino = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lstFecha = new System.Windows.Forms.ListBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnVerFecha = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerDestino);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(19, 30);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 0;
            // 
            // btnVerDestino
            // 
            this.btnVerDestino.Location = new System.Drawing.Point(190, 28);
            this.btnVerDestino.Name = "btnVerDestino";
            this.btnVerDestino.Size = new System.Drawing.Size(75, 23);
            this.btnVerDestino.TabIndex = 1;
            this.btnVerDestino.Text = "Ver Destinos";
            this.btnVerDestino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstFecha);
            this.groupBox3.Controls.Add(this.btnReservar);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(190, 64);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // lstFecha
            // 
            this.lstFecha.FormattingEnabled = true;
            this.lstFecha.Location = new System.Drawing.Point(19, 19);
            this.lstFecha.Name = "lstFecha";
            this.lstFecha.Size = new System.Drawing.Size(121, 108);
            this.lstFecha.TabIndex = 2;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(19, 30);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 0;
            // 
            // btnVerFecha
            // 
            this.btnVerFecha.Location = new System.Drawing.Point(190, 28);
            this.btnVerFecha.Name = "btnVerFecha";
            this.btnVerFecha.Size = new System.Drawing.Size(75, 23);
            this.btnVerFecha.TabIndex = 1;
            this.btnVerFecha.Text = "Ver Fechas";
            this.btnVerFecha.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerFecha);
            this.groupBox2.Controls.Add(this.cmbDestino);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reserva de Vuelo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstFecha;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnVerFecha;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

