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
    public partial class FormReservaAdmin : Form
    {
        String usuario;
        String fechahora;
        private NReserva nReserva = new NReserva();
        public FormReservaAdmin(String usuario, String fechahora)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            MostrarReservas(nReserva.ListarTodo());
            dgReservas.SelectionChanged += new EventHandler(dgReservas_SelectionChanged);
        }

        private void MostrarReservas(List<Reserva> reservas)
        {
            dgReservas.DataSource = null;
            if (reservas.Count == 0)
            {

                return;
            }
            else
            {
                dgReservas.DataSource = reservas;
                dgReservas.Columns["Eliminado"].Visible = false;
            }
        }

        private void BTNFiltrarAmbas_Click(object sender, EventArgs e)
        {
            if (tbPersona.Text == "" )
            {
                MessageBox.Show("Ingrese una cantidad");
                return;
            }
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(tbPersona.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return;
            }
            List<Reserva> reservas = nReserva.FiltrarDiayPersonas(cantidad, dtpFecha.Value);
            MostrarReservas(reservas);
        }

        private void BTNFiltrarDia_Click(object sender, EventArgs e)
        {
            MostrarReservas(nReserva.FiltrarDia(dtpFecha.Value));
        }

        private void BTNFiltrarPersona_Click(object sender, EventArgs e)
        {
            if (tbPersona.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad");
                return;
            }
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(tbPersona.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un numero");
                return;
            }
            MostrarReservas(nReserva.FiltrarPersonas(cantidad));
        }
        private void dgReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                return;
            }
            lblUsuarioCreacion.Text = dgReservas.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgReservas.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            lblFechaHoraModificacion.Text = dgReservas.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblusuarioModificacion.Text = dgReservas.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
