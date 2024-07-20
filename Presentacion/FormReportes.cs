using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReportes : Form
    {
        private NReserva nreserva = new NReserva();
        private NPlato_Inventario nplato = new NPlato_Inventario();
        private NMesa_Inventario nmesa = new NMesa_Inventario();
        public FormReportes()
        {
            InitializeComponent();
        }
        private void MostrarMesas(List<Mesas_Inventario> mesas)
        {
            dgReportes.DataSource = null;
            if (mesas.Count == 0)
            {
                return;
            }
            else
            {
                dgReportes.DataSource = mesas;
                dgReportes.Columns["Eliminado"].Visible = false;
            }
        }
        private void MostrarReservas(List<Reserva> reservas)
        {
            dgReportes.DataSource = null;
            if (reservas.Count == 0)
            {

                return;
            }
            else
            {
                dgReportes.DataSource = reservas;
                dgReportes.Columns["Eliminado"].Visible = false;
            }
        }
        private void MostrarPlatos(List<Platos_Inventario> platos)
        {
            dgReportes.DataSource = null;
            if (platos.Count == 0)
            {

                return;
            }
            else
            {
                dgReportes.DataSource = platos;
                dgReportes.Columns["Eliminado"].Visible = false;
            }

        }
        private void bntMasReserva_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón 'Horario Más Reservado' clicado");
            var reservasConHorarioMasReservado = nreserva.ObtenerHorarioMasReservado();

            if (reservasConHorarioMasReservado != null && reservasConHorarioMasReservado.Count > 0)
            {
                var horaMasReservada = reservasConHorarioMasReservado[0].FechayHora_Reserva.ToString("HH");
                lblHorarioRepetitivo.Text = horaMasReservada;
                Console.WriteLine($"Hora más reservada: {horaMasReservada}");
                Console.WriteLine($"Número de reservas obtenidas en FormReportes: {reservasConHorarioMasReservado.Count}");
                MostrarReservas(reservasConHorarioMasReservado);
            }
            else
            {
                lblHorarioRepetitivo.Text = "No se encontraron registros.";
                Console.WriteLine("No se encontraron horarios más reservados.");
            }
            lblGanaciaporRango.Text = "0";
        }

        private void btnPlatoVendido_Click(object sender, EventArgs e)
        {
            MostrarPlatos(nplato.ListarPlatosMasVendidos());
            lblGanaciaporRango.Text = "0";
            lblHorarioRepetitivo.Text = "0";
        }

        private void btnMesasPedidas_Click(object sender, EventArgs e)
        {
            MostrarMesas(nmesa.MesasMasPedidas());
            lblGanaciaporRango.Text = "0";
            lblHorarioRepetitivo.Text = "0";
        }

        private void btnGananciaMes_Click(object sender, EventArgs e)
        {
            lblGanaciaporRango.Text = (nreserva.ObtenerMontoRango(dtpDesde.Value, dtpHasta.Value)).ToString();
            lblHorarioRepetitivo.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
