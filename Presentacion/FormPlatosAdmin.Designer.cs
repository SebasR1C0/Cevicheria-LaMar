
namespace Presentacion
{
    partial class FormPlatosAdmin
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgplatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgplatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 157;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 155;
            this.label2.Text = "Categoria:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 334);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 35);
            this.btnAgregar.TabIndex = 154;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(152, 422);
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
            this.btnEliminar.Location = new System.Drawing.Point(152, 377);
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
            this.btnSalir.Location = new System.Drawing.Point(152, 468);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 35);
            this.btnSalir.TabIndex = 144;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgplatos
            // 
            this.dgplatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgplatos.Location = new System.Drawing.Point(470, 135);
            this.dgplatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgplatos.Name = "dgplatos";
            this.dgplatos.RowHeadersWidth = 62;
            this.dgplatos.Size = new System.Drawing.Size(830, 383);
            this.dgplatos.TabIndex = 143;
            this.dgplatos.SelectionChanged += new System.EventHandler(this.dgPlatossAdmin_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 58);
            this.label1.TabIndex = 142;
            this.label1.Text = "Platos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 159;
            this.label4.Text = "Precio:";
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioModificacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(995, 55);
            this.lblUsuarioModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioModificacion.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(880, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 168;
            this.label5.Text = "Fecha y Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(880, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 167;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(880, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 166;
            this.label9.Text = "Modificación:";
            // 
            // FechaHoraModificacion
            // 
            this.FechaHoraModificacion.AutoSize = true;
            this.FechaHoraModificacion.BackColor = System.Drawing.Color.Transparent;
            this.FechaHoraModificacion.ForeColor = System.Drawing.Color.White;
            this.FechaHoraModificacion.Location = new System.Drawing.Point(995, 87);
            this.FechaHoraModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaHoraModificacion.Name = "FechaHoraModificacion";
            this.FechaHoraModificacion.Size = new System.Drawing.Size(0, 20);
            this.FechaHoraModificacion.TabIndex = 170;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioCreacion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(646, 55);
            this.lblUsuarioCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioCreacion.TabIndex = 164;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(470, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 163;
            this.label7.Text = "Fecha y Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(470, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 162;
            this.label6.Text = "Usuario:";
            // 
            // lblModificación
            // 
            this.lblModificación.AutoSize = true;
            this.lblModificación.BackColor = System.Drawing.Color.Transparent;
            this.lblModificación.ForeColor = System.Drawing.Color.White;
            this.lblModificación.Location = new System.Drawing.Point(470, 24);
            this.lblModificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificación.Name = "lblModificación";
            this.lblModificación.Size = new System.Drawing.Size(76, 20);
            this.lblModificación.TabIndex = 161;
            this.lblModificación.Text = "Creación:";
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoraCreacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(646, 87);
            this.lblFechaHoraCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(0, 20);
            this.lblFechaHoraCreacion.TabIndex = 165;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Entrada Marina",
            "Plato Marino",
            "Postre Marino"});
            this.cbCategoria.Location = new System.Drawing.Point(201, 182);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(180, 28);
            this.cbCategoria.TabIndex = 172;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(201, 135);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(180, 26);
            this.tbNombre.TabIndex = 171;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(201, 246);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(180, 26);
            this.tbPrecio.TabIndex = 173;
            // 
            // FormPlatosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pngtree_Food_Menu_Fare_Meal_background_photo_869492;
            this.ClientSize = new System.Drawing.Size(1447, 529);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.tbNombre);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgplatos);
            this.Controls.Add(this.label1);
            this.Name = "FormPlatosAdmin";
            this.Text = "FormPlatosAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgplatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgplatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecio;
    }
}