
namespace Presentacion
{
    partial class FormMesasEmpleado
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgMesas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaHoraModificacion = new System.Windows.Forms.Label();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblModificación = new System.Windows.Forms.Label();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.cbmesasli = new System.Windows.Forms.ComboBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 157;
            this.label3.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 155;
            this.label2.Text = "Mesas Libres:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 154;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(158, 378);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 35);
            this.btnModificar.TabIndex = 153;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(158, 334);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 35);
            this.btnEliminar.TabIndex = 152;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(158, 425);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 35);
            this.btnSalir.TabIndex = 144;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgMesas
            // 
            this.dgMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMesas.Location = new System.Drawing.Point(446, 126);
            this.dgMesas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgMesas.Name = "dgMesas";
            this.dgMesas.RowHeadersWidth = 62;
            this.dgMesas.Size = new System.Drawing.Size(789, 362);
            this.dgMesas.TabIndex = 143;
            this.dgMesas.SelectionChanged += new System.EventHandler(this.dgMesasLibres_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 58);
            this.label1.TabIndex = 142;
            this.label1.Text = "MESAS";
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioModificacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(999, 40);
            this.lblUsuarioModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioModificacion.TabIndex = 167;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(877, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 166;
            this.label5.Text = "Fecha y Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(877, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 165;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(877, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 164;
            this.label9.Text = "Modificación:";
            // 
            // FechaHoraModificacion
            // 
            this.FechaHoraModificacion.AutoSize = true;
            this.FechaHoraModificacion.BackColor = System.Drawing.Color.Transparent;
            this.FechaHoraModificacion.ForeColor = System.Drawing.Color.White;
            this.FechaHoraModificacion.Location = new System.Drawing.Point(999, 72);
            this.FechaHoraModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaHoraModificacion.Name = "FechaHoraModificacion";
            this.FechaHoraModificacion.Size = new System.Drawing.Size(0, 20);
            this.FechaHoraModificacion.TabIndex = 168;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioCreacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(623, 40);
            this.lblUsuarioCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioCreacion.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(449, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 161;
            this.label7.Text = "Fecha y Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(449, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 160;
            this.label6.Text = "Usuario:";
            // 
            // lblModificación
            // 
            this.lblModificación.AutoSize = true;
            this.lblModificación.BackColor = System.Drawing.Color.Transparent;
            this.lblModificación.ForeColor = System.Drawing.Color.White;
            this.lblModificación.Location = new System.Drawing.Point(449, 9);
            this.lblModificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificación.Name = "lblModificación";
            this.lblModificación.Size = new System.Drawing.Size(76, 20);
            this.lblModificación.TabIndex = 159;
            this.lblModificación.Text = "Creación:";
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoraCreacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(623, 72);
            this.lblFechaHoraCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblFechaHoraCreacion.TabIndex = 163;
            // 
            // cbmesasli
            // 
            this.cbmesasli.FormattingEnabled = true;
            this.cbmesasli.Items.AddRange(new object[] {
            "Mesas no disponibles"});
            this.cbmesasli.Location = new System.Drawing.Point(231, 168);
            this.cbmesasli.Name = "cbmesasli";
            this.cbmesasli.Size = new System.Drawing.Size(205, 28);
            this.cbmesasli.TabIndex = 172;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacidad.ForeColor = System.Drawing.Color.White;
            this.lblCapacidad.Location = new System.Drawing.Point(226, 226);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(18, 20);
            this.lblCapacidad.TabIndex = 173;
            this.lblCapacidad.Text = "0";
            // 
            // FormMesasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pngtree_Food_Menu_Fare_Meal_background_photo_869492;
            this.ClientSize = new System.Drawing.Size(1495, 526);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.cbmesasli);
            this.Controls.Add(this.lblUsuarioModificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaHoraModificacion);
            this.Controls.Add(this.lblUsuarioCreacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblModificación);
            this.Controls.Add(this.lblFechaHoraCreacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgMesas);
            this.Controls.Add(this.label1);
            this.Name = "FormMesasEmpleado";
            this.Text = "FormMesasEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FechaHoraModificacion;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModificación;
        private System.Windows.Forms.Label lblFechaHoraCreacion;
        private System.Windows.Forms.ComboBox cbmesasli;
        private System.Windows.Forms.Label lblCapacidad;
    }
}