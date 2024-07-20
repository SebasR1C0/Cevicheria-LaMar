
namespace Presentacion
{
    partial class FormReservaAdmin
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
            this.BTNFiltrarAmbas = new System.Windows.Forms.Button();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.svsef = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.lblModificación = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgReservas = new System.Windows.Forms.DataGridView();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaHoraModificacion = new System.Windows.Forms.Label();
            this.lblusuarioModificacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sfesf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BTNFiltrarDia = new System.Windows.Forms.Button();
            this.BTNFiltrarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNFiltrarAmbas
            // 
            this.BTNFiltrarAmbas.Location = new System.Drawing.Point(54, 371);
            this.BTNFiltrarAmbas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNFiltrarAmbas.Name = "BTNFiltrarAmbas";
            this.BTNFiltrarAmbas.Size = new System.Drawing.Size(273, 35);
            this.BTNFiltrarAmbas.TabIndex = 150;
            this.BTNFiltrarAmbas.Text = "Filtrar por n° de personas y dia";
            this.BTNFiltrarAmbas.UseVisualStyleBackColor = true;
            this.BTNFiltrarAmbas.Click += new System.EventHandler(this.BTNFiltrarAmbas_Click);
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoraCreacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(654, 57);
            this.lblFechaHoraCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblFechaHoraCreacion.TabIndex = 146;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioCreacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(654, 24);
            this.lblUsuarioCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioCreacion.TabIndex = 145;
            // 
            // svsef
            // 
            this.svsef.AutoSize = true;
            this.svsef.BackColor = System.Drawing.Color.Transparent;
            this.svsef.ForeColor = System.Drawing.Color.White;
            this.svsef.Location = new System.Drawing.Point(536, 57);
            this.svsef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.svsef.Name = "svsef";
            this.svsef.Size = new System.Drawing.Size(108, 20);
            this.svsef.TabIndex = 143;
            this.svsef.Text = "Fecha y Hora:";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.BackColor = System.Drawing.Color.Transparent;
            this.ss.ForeColor = System.Drawing.Color.White;
            this.ss.Location = new System.Drawing.Point(576, 24);
            this.ss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(68, 20);
            this.ss.TabIndex = 142;
            this.ss.Text = "Usuario:";
            // 
            // lblModificación
            // 
            this.lblModificación.AutoSize = true;
            this.lblModificación.BackColor = System.Drawing.Color.Transparent;
            this.lblModificación.ForeColor = System.Drawing.Color.White;
            this.lblModificación.Location = new System.Drawing.Point(469, 24);
            this.lblModificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificación.Name = "lblModificación";
            this.lblModificación.Size = new System.Drawing.Size(76, 20);
            this.lblModificación.TabIndex = 141;
            this.lblModificación.Text = "Creación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 139;
            this.label6.Text = "Día:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(110, 438);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 35);
            this.btnSalir.TabIndex = 138;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // dgReservas
            // 
            this.dgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservas.Location = new System.Drawing.Point(447, 126);
            this.dgReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgReservas.Name = "dgReservas";
            this.dgReservas.RowHeadersWidth = 62;
            this.dgReservas.Size = new System.Drawing.Size(846, 368);
            this.dgReservas.TabIndex = 136;
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(177, 171);
            this.tbPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(180, 26);
            this.tbPersona.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 134;
            this.label4.Text = "Personas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(99, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 58);
            this.label1.TabIndex = 133;
            this.label1.Text = "RESERVA";
            // 
            // lblFechaHoraModificacion
            // 
            this.lblFechaHoraModificacion.AutoSize = true;
            this.lblFechaHoraModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoraModificacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraModificacion.Location = new System.Drawing.Point(1029, 57);
            this.lblFechaHoraModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraModificacion.Name = "lblFechaHoraModificacion";
            this.lblFechaHoraModificacion.Size = new System.Drawing.Size(0, 20);
            this.lblFechaHoraModificacion.TabIndex = 156;
            // 
            // lblusuarioModificacion
            // 
            this.lblusuarioModificacion.AutoSize = true;
            this.lblusuarioModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblusuarioModificacion.ForeColor = System.Drawing.Color.White;
            this.lblusuarioModificacion.Location = new System.Drawing.Point(1030, 24);
            this.lblusuarioModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuarioModificacion.Name = "lblusuarioModificacion";
            this.lblusuarioModificacion.Size = new System.Drawing.Size(0, 20);
            this.lblusuarioModificacion.TabIndex = 155;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(913, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 153;
            this.label11.Text = "Fecha y Hora:";
            // 
            // sfesf
            // 
            this.sfesf.AutoSize = true;
            this.sfesf.BackColor = System.Drawing.Color.Transparent;
            this.sfesf.ForeColor = System.Drawing.Color.White;
            this.sfesf.Location = new System.Drawing.Point(954, 24);
            this.sfesf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sfesf.Name = "sfesf";
            this.sfesf.Size = new System.Drawing.Size(68, 20);
            this.sfesf.TabIndex = 152;
            this.sfesf.Text = "Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(845, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 151;
            this.label13.Text = "Modificación:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(177, 263);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(180, 26);
            this.dtpFecha.TabIndex = 157;
            // 
            // BTNFiltrarDia
            // 
            this.BTNFiltrarDia.Location = new System.Drawing.Point(27, 297);
            this.BTNFiltrarDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNFiltrarDia.Name = "BTNFiltrarDia";
            this.BTNFiltrarDia.Size = new System.Drawing.Size(132, 35);
            this.BTNFiltrarDia.TabIndex = 137;
            this.BTNFiltrarDia.Text = "Filtrar por dia";
            this.BTNFiltrarDia.UseVisualStyleBackColor = true;
            this.BTNFiltrarDia.Click += new System.EventHandler(this.BTNFiltrarDia_Click);
            // 
            // BTNFiltrarPersona
            // 
            this.BTNFiltrarPersona.Location = new System.Drawing.Point(27, 218);
            this.BTNFiltrarPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNFiltrarPersona.Name = "BTNFiltrarPersona";
            this.BTNFiltrarPersona.Size = new System.Drawing.Size(183, 35);
            this.BTNFiltrarPersona.TabIndex = 148;
            this.BTNFiltrarPersona.Text = "Filtrar n° de personas";
            this.BTNFiltrarPersona.UseVisualStyleBackColor = true;
            this.BTNFiltrarPersona.Click += new System.EventHandler(this.BTNFiltrarPersona_Click);
            // 
            // FormReservaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pngtree_Food_Menu_Fare_Meal_background_photo_869492;
            this.ClientSize = new System.Drawing.Size(1476, 522);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFechaHoraModificacion);
            this.Controls.Add(this.lblusuarioModificacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sfesf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BTNFiltrarAmbas);
            this.Controls.Add(this.BTNFiltrarPersona);
            this.Controls.Add(this.lblFechaHoraCreacion);
            this.Controls.Add(this.lblUsuarioCreacion);
            this.Controls.Add(this.svsef);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.lblModificación);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BTNFiltrarDia);
            this.Controls.Add(this.dgReservas);
            this.Controls.Add(this.tbPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormReservaAdmin";
            this.Text = "FormReservaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNFiltrarAmbas;
        private System.Windows.Forms.Label lblFechaHoraCreacion;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.Label svsef;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label lblModificación;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgReservas;
        private System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaHoraModificacion;
        private System.Windows.Forms.Label lblusuarioModificacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sfesf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button BTNFiltrarDia;
        private System.Windows.Forms.Button BTNFiltrarPersona;
    }
}