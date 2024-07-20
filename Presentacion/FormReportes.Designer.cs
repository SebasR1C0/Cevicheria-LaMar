
namespace Presentacion
{
    partial class FormReportes
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGananciaRangoTiempo = new System.Windows.Forms.Button();
            this.btnMesasPedidas = new System.Windows.Forms.Button();
            this.btnPlatoVendido = new System.Windows.Forms.Button();
            this.bntMasReserva = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorarioRepetitivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGanaciaporRango = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(99, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 31);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGananciaRangoTiempo
            // 
            this.btnGananciaRangoTiempo.Location = new System.Drawing.Point(87, 298);
            this.btnGananciaRangoTiempo.Name = "btnGananciaRangoTiempo";
            this.btnGananciaRangoTiempo.Size = new System.Drawing.Size(121, 32);
            this.btnGananciaRangoTiempo.TabIndex = 23;
            this.btnGananciaRangoTiempo.Text = "Ganancias por Rango";
            this.btnGananciaRangoTiempo.UseVisualStyleBackColor = true;
            this.btnGananciaRangoTiempo.Click += new System.EventHandler(this.btnGananciaMes_Click);
            // 
            // btnMesasPedidas
            // 
            this.btnMesasPedidas.Location = new System.Drawing.Point(87, 87);
            this.btnMesasPedidas.Name = "btnMesasPedidas";
            this.btnMesasPedidas.Size = new System.Drawing.Size(108, 39);
            this.btnMesasPedidas.TabIndex = 22;
            this.btnMesasPedidas.Text = "Mesas más pedidas";
            this.btnMesasPedidas.UseVisualStyleBackColor = true;
            this.btnMesasPedidas.Click += new System.EventHandler(this.btnMesasPedidas_Click);
            // 
            // btnPlatoVendido
            // 
            this.btnPlatoVendido.Location = new System.Drawing.Point(88, 132);
            this.btnPlatoVendido.Name = "btnPlatoVendido";
            this.btnPlatoVendido.Size = new System.Drawing.Size(108, 34);
            this.btnPlatoVendido.TabIndex = 21;
            this.btnPlatoVendido.Text = "Platos más vendidos";
            this.btnPlatoVendido.UseVisualStyleBackColor = true;
            this.btnPlatoVendido.Click += new System.EventHandler(this.btnPlatoVendido_Click);
            // 
            // bntMasReserva
            // 
            this.bntMasReserva.Location = new System.Drawing.Point(87, 172);
            this.bntMasReserva.Name = "bntMasReserva";
            this.bntMasReserva.Size = new System.Drawing.Size(108, 39);
            this.bntMasReserva.TabIndex = 20;
            this.bntMasReserva.Text = "Horario Mas Reservado";
            this.bntMasReserva.UseVisualStyleBackColor = true;
            this.bntMasReserva.Click += new System.EventHandler(this.bntMasReserva_Click);
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(409, 110);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 62;
            this.dgReportes.Size = new System.Drawing.Size(446, 300);
            this.dgReportes.TabIndex = 19;
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.Location = new System.Drawing.Point(217, 184);
            this.Dia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(33, 13);
            this.Dia.TabIndex = 25;
            this.Dia.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Desde:";
            // 
            // lblHorarioRepetitivo
            // 
            this.lblHorarioRepetitivo.AutoSize = true;
            this.lblHorarioRepetitivo.Location = new System.Drawing.Point(264, 184);
            this.lblHorarioRepetitivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioRepetitivo.Name = "lblHorarioRepetitivo";
            this.lblHorarioRepetitivo.Size = new System.Drawing.Size(13, 13);
            this.lblHorarioRepetitivo.TabIndex = 27;
            this.lblHorarioRepetitivo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(145, 236);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpDesde.TabIndex = 29;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(145, 268);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hasta:";
            // 
            // lblGanaciaporRango
            // 
            this.lblGanaciaporRango.AutoSize = true;
            this.lblGanaciaporRango.Location = new System.Drawing.Point(170, 344);
            this.lblGanaciaporRango.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGanaciaporRango.Name = "lblGanaciaporRango";
            this.lblGanaciaporRango.Size = new System.Drawing.Size(13, 13);
            this.lblGanaciaporRango.TabIndex = 32;
            this.lblGanaciaporRango.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(145, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 39);
            this.label3.TabIndex = 140;
            this.label3.Text = "REPORTES";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pngtree_restaurant_food_menu_background_image_190820;
            this.ClientSize = new System.Drawing.Size(989, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGanaciaporRango);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHorarioRepetitivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGananciaRangoTiempo);
            this.Controls.Add(this.btnMesasPedidas);
            this.Controls.Add(this.btnPlatoVendido);
            this.Controls.Add(this.bntMasReserva);
            this.Controls.Add(this.dgReportes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGananciaRangoTiempo;
        private System.Windows.Forms.Button btnMesasPedidas;
        private System.Windows.Forms.Button btnPlatoVendido;
        private System.Windows.Forms.Button bntMasReserva;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorarioRepetitivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanaciaporRango;
        private System.Windows.Forms.Label label3;
    }
}