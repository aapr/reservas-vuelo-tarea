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
            this.button2 = new System.Windows.Forms.Button();
            this.btnVerDestino = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSlideDestino = new System.Windows.Forms.Button();
            this.lstFecha = new System.Windows.Forms.ListBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnVerFecha = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSlideOrigen = new System.Windows.Forms.Button();
            this.reservas_VueloDataSet = new Reservas_Vuelo.DataLayer.Reservas_VueloDataSet();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_VueloDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnVerDestino);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(419, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVerDestino
            // 
            this.btnVerDestino.Location = new System.Drawing.Point(311, 34);
            this.btnVerDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerDestino.Name = "btnVerDestino";
            this.btnVerDestino.Size = new System.Drawing.Size(100, 28);
            this.btnVerDestino.TabIndex = 1;
            this.btnVerDestino.Text = "Ver Destinos";
            this.btnVerDestino.UseVisualStyleBackColor = true;
            this.btnVerDestino.Click += new System.EventHandler(this.btnVerDestino_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(25, 37);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(160, 24);
            this.cmbOrigen.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSlideDestino);
            this.groupBox3.Controls.Add(this.lstFecha);
            this.groupBox3.Controls.Add(this.btnReservar);
            this.groupBox3.Location = new System.Drawing.Point(16, 242);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(419, 174);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha";
            // 
            // btnSlideDestino
            // 
            this.btnSlideDestino.Location = new System.Drawing.Point(241, 70);
            this.btnSlideDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlideDestino.Name = "btnSlideDestino";
            this.btnSlideDestino.Size = new System.Drawing.Size(45, 28);
            this.btnSlideDestino.TabIndex = 4;
            this.btnSlideDestino.Text = "^";
            this.btnSlideDestino.UseVisualStyleBackColor = true;
            this.btnSlideDestino.Click += new System.EventHandler(this.btnSlideDestino_Click);
            // 
            // lstFecha
            // 
            this.lstFecha.FormattingEnabled = true;
            this.lstFecha.ItemHeight = 16;
            this.lstFecha.Location = new System.Drawing.Point(25, 23);
            this.lstFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFecha.Name = "lstFecha";
            this.lstFecha.Size = new System.Drawing.Size(160, 132);
            this.lstFecha.TabIndex = 2;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(311, 70);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 28);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(25, 37);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(160, 24);
            this.cmbDestino.TabIndex = 0;
            // 
            // btnVerFecha
            // 
            this.btnVerFecha.Location = new System.Drawing.Point(311, 34);
            this.btnVerFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerFecha.Name = "btnVerFecha";
            this.btnVerFecha.Size = new System.Drawing.Size(100, 28);
            this.btnVerFecha.TabIndex = 1;
            this.btnVerFecha.Text = "Ver Fechas";
            this.btnVerFecha.UseVisualStyleBackColor = true;
            this.btnVerFecha.Click += new System.EventHandler(this.btnVerFecha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSlideOrigen);
            this.groupBox2.Controls.Add(this.btnVerFecha);
            this.groupBox2.Controls.Add(this.cmbDestino);
            this.groupBox2.Location = new System.Drawing.Point(16, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(419, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // btnSlideOrigen
            // 
            this.btnSlideOrigen.Location = new System.Drawing.Point(241, 34);
            this.btnSlideOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlideOrigen.Name = "btnSlideOrigen";
            this.btnSlideOrigen.Size = new System.Drawing.Size(45, 28);
            this.btnSlideOrigen.TabIndex = 2;
            this.btnSlideOrigen.Text = "^";
            this.btnSlideOrigen.UseVisualStyleBackColor = true;
            this.btnSlideOrigen.Click += new System.EventHandler(this.btnSlideOrigen_Click);
            // 
            // reservas_VueloDataSet
            // 
            this.reservas_VueloDataSet.DataSetName = "Reservas_VueloDataSet";
            this.reservas_VueloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SeleccionVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SeleccionVuelo";
            this.Text = "Reserva de Vuelo";
            this.Load += new System.EventHandler(this.SeleccionVuelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservas_VueloDataSet)).EndInit();
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
        private System.Windows.Forms.Button btnSlideDestino;
        private System.Windows.Forms.Button btnSlideOrigen;
        private System.Windows.Forms.Button button2;
        private DataLayer.Reservas_VueloDataSet reservas_VueloDataSet;
    }
}

