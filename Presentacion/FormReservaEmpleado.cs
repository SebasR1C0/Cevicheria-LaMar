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
    public partial class FormReservaEmpleado : Form
    {
        String usuario;
        String fechahora;
        DateTime ahorafecha;
        DateTime ahorafecha2;
        DateTime fechayHora_Reserva;
        private Reserva reserin = new Reserva();
        private NReserva nReserva = new NReserva();
        public FormReservaEmpleado(String usuario, String fechahora)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            MostrarReservas(nReserva.ListarTodo());
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPersona.Text == ""||cbEstado.Text =="")
            {
                MessageBox.Show("Ingrese los campos vacios");
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
            ahorafecha = DateTime.Now;
            Reserva reserva = new Reserva()
            {
                Nombre_Cliente = tbNombre.Text,
                Estado = cbEstado.Text,
                Numero_Personas = cantidad,
                FechayHora_Reserva = dtpFecha.Value,
                UsuarioCreacion = usuario.ToString(),
                UsuarioModificacion = usuario.ToString(),
                FechaCreacion = ahorafecha,
                FechaModificacion = ahorafecha,
                Eliminado = false,
            };
            String mensaje = nReserva.Registrar(reserva);
            MessageBox.Show(mensaje);
            MostrarReservas(nReserva.ListarTodo());
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPersona.Text == "")
            {
                MessageBox.Show("Ingrese los campos vacios");
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
            if (dgReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elige una reserva");
                return;
            }
            ahorafecha2 = DateTime.Now;
            int reservaid = int.Parse(dgReservas.SelectedRows[0].Cells[0].Value.ToString());
            Reserva reserva = new Reserva()
            {
                ID_Reserva = reservaid,
                Nombre_Cliente = tbNombre.Text.Trim(),
                Numero_Personas = cantidad,
                Estado= cbEstado.Text,
                FechayHora_Reserva = dtpFecha.Value,
                FechaModificacion = ahorafecha2,
                UsuarioModificacion = usuario
            };
            String mensaje = nReserva.Modificar(reserva);
            MessageBox.Show(mensaje);
            MostrarReservas(nReserva.ListarTodo());
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elige una reserva");
                return;
            }
            int reservaid = int.Parse(dgReservas.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nReserva.Eliminar(reservaid);
            MessageBox.Show(mensaje);
            MostrarReservas(nReserva.ListarTodo());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elige una reserva");
                return;
            } 
            DateTime dateTime = DateTime.Now;
            int cant = 0;
            int reservaid = int.Parse(dgReservas.SelectedRows[0].Cells[0].Value.ToString());
            List<Reserva> reserva = nReserva.ListarTodo();
            foreach (Reserva r in reserva)
            {
                if (reservaid == r.ID_Reserva)
                {
                    dateTime = r.FechayHora_Reserva;
                    cant = r.Numero_Personas;
                }
            }
            FormMesasEmpleado form = new FormMesasEmpleado(usuario, fechahora, reservaid, dateTime, cant);
            form.Show();
        }

        private void btnPlato_Click(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elige una reserva");
                return;
            }
            int reservaid = int.Parse(dgReservas.SelectedRows[0].Cells[0].Value.ToString());
            FormPlatosEmpleado form = new FormPlatosEmpleado(usuario, fechahora, reservaid); 
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbPersona.Text = "";
        }
        private void dgReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                return;
            }
            cbEstado.SelectedIndex = cbEstado.Items.IndexOf(dgReservas.SelectedRows[0].Cells["Estado"].Value.ToString());
            tbPersona.Text = dgReservas.SelectedRows[0].Cells["Numero_Personas"].Value.ToString();
            tbNombre.Text = dgReservas.SelectedRows[0].Cells["Nombre_Cliente"].Value.ToString();
            lblUsuarioCreacion.Text = dgReservas.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgReservas.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            FechaHoraModificacion.Text = dgReservas.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblUsuarioModificacion.Text = dgReservas.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }
    }
}
