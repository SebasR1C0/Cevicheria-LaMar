
namespace Presentacion
{
    partial class FormReservaEmpleado
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
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlato = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgReservas = new System.Windows.Forms.DataGridView();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaHoraModificacion = new System.Windows.Forms.Label();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModificación = new System.Windows.Forms.Label();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(138, 368);
            this.BTNModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(132, 35);
            this.BTNModificar.TabIndex = 146;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(138, 411);
            this.BTNEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(132, 35);
            this.BTNEliminar.TabIndex = 145;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Location = new System.Drawing.Point(138, 455);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(132, 35);
            this.btnMesas.TabIndex = 144;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFecha.Location = new System.Drawing.Point(208, 223);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(180, 26);
            this.dtpFecha.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Día y Hora:";
            // 
            // btnPlato
            // 
            this.btnPlato.Location = new System.Drawing.Point(138, 502);
            this.btnPlato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlato.Name = "btnPlato";
            this.btnPlato.Size = new System.Drawing.Size(132, 35);
            this.btnPlato.TabIndex = 134;
            this.btnPlato.Text = "Platos";
            this.btnPlato.UseVisualStyleBackColor = true;
            this.btnPlato.Click += new System.EventHandler(this.btnPlato_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(138, 546);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 35);
            this.btnSalir.TabIndex = 133;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 323);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 35);
            this.btnAgregar.TabIndex = 132;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(208, 146);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(180, 26);
            this.tbNombre.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "Nombre:";
            // 
            // dgReservas
            // 
            this.dgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservas.Location = new System.Drawing.Point(430, 134);
            this.dgReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgReservas.Name = "dgReservas";
            this.dgReservas.RowHeadersWidth = 62;
            this.dgReservas.Size = new System.Drawing.Size(846, 420);
            this.dgReservas.TabIndex = 129;
            this.dgReservas.SelectionChanged += new System.EventHandler(this.dgReservas_SelectionChanged);
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(208, 186);
            this.tbPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(180, 26);
            this.tbPersona.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 127;
            this.label4.Text = "Personas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(113, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 58);
            this.label1.TabIndex = 126;
            this.label1.Text = "RESERVA";
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioModificacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(1062, 59);
            this.lblUsuarioModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioModificacion.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(888, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 158;
            this.label5.Text = "Fecha y Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(888, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 157;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(888, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 156;
            this.label9.Text = "Modificación:";
            // 
            // FechaHoraModificacion
            // 
            this.FechaHoraModificacion.AutoSize = true;
            this.FechaHoraModificacion.BackColor = System.Drawing.Color.Transparent;
            this.FechaHoraModificacion.ForeColor = System.Drawing.Color.White;
            this.FechaHoraModificacion.Location = new System.Drawing.Point(1062, 91);
            this.FechaHoraModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaHoraModificacion.Name = "FechaHoraModificacion";
            this.FechaHoraModificacion.Size = new System.Drawing.Size(0, 20);
            this.FechaHoraModificacion.TabIndex = 160;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioCreacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(635, 59);
            this.lblUsuarioCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioCreacion.TabIndex = 154;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(461, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 153;
            this.label7.Text = "Fecha y Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(461, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 152;
            this.label2.Text = "Usuario:";
            // 
            // lblModificación
            // 
            this.lblModificación.AutoSize = true;
            this.lblModificación.BackColor = System.Drawing.Color.Transparent;
            this.lblModificación.ForeColor = System.Drawing.Color.White;
            this.lblModificación.Location = new System.Drawing.Point(461, 27);
            this.lblModificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificación.Name = "lblModificación";
            this.lblModificación.Size = new System.Drawing.Size(76, 20);
            this.lblModificación.TabIndex = 151;
            this.lblModificación.Text = "Creación:";
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoraCreacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(635, 91);
            this.lblFechaHoraCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblFechaHoraCreacion.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 161;
            this.label10.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Confirmada",
            "Cancelada",
            "Pendiente"});
            this.cbEstado.Location = new System.Drawing.Point(208, 272);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(180, 28);
            this.cbEstado.TabIndex = 162;
            // 
            // FormReservaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pngtree_Food_Menu_Fare_Meal_background_photo_869492;
            this.ClientSize = new System.Drawing.Size(1551, 594);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUsuarioModificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaHoraModificacion);
            this.Controls.Add(this.lblUsuarioCreacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblModificación);
            this.Controls.Add(this.lblFechaHoraCreacion);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPlato);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgReservas);
            this.Controls.Add(this.tbPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormReservaEmpleado";
            this.Text = "FormReservaEmpleado";
            this.SizeChanged += new System.EventHandler(this.dgReservas_SelectionChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPlato;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgReservas;
        private System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FechaHoraModificacion;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModificación;
        private System.Windows.Forms.Label lblFechaHoraCreacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}