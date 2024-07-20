using System;
using Datos;
using Negocio;
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
    public partial class FormMesasEmpleado : Form
    {
        String usuario;
        String fechahora;
        int id_reserva;
        int cant;
        DateTime ahorafecha;
        DateTime ahorafecha2;
        DateTime fechaHoraReserva;
        private NMesa_Inventario nMesa_Inventario = new NMesa_Inventario();
        private  NMesa_Reserva nmesar = new NMesa_Reserva();
        private Mesa_Reserva mesare = new Mesa_Reserva();

        public FormMesasEmpleado(String usuario, String fechahora, int id_reserva, DateTime fechaHoraReserva, int cant)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            this.id_reserva = id_reserva;
            this.fechaHoraReserva = fechaHoraReserva;
            this.cant = cant;

            MostrarMesas(nmesar.ListarTodo(id_reserva));
            MostrarInventario(nMesa_Inventario.ListarMesasLibres(fechaHoraReserva, cant));
            cbmesasli.SelectedIndexChanged += new EventHandler(cbmesasli_SelectedIndexChanged);

        }
        private void MostrarInventario(List<Mesas_Inventario> mesas)
        {
            cbmesasli.DataSource = null;
            if (mesas.Count == 0)
            {
                return;
            }
            cbmesasli.DataSource = mesas;
            cbmesasli.ValueMember = "ID_Mesa";
            cbmesasli.DisplayMember = "Codigo";
        }
        private void cbmesasli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmesasli.SelectedItem is Mesas_Inventario selectedMesa)
            {
                lblCapacidad.Text = selectedMesa.Capacidad.ToString();
            }
        }
        private void MostrarMesas(List<Mesa_Reserva> mesas)
        {
            dgMesas.DataSource = null;
            if (mesas.Count == 0)
            {
                return;
            }
            else
            {
                dgMesas.DataSource = mesas;
                dgMesas.Columns["Eliminado"].Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmesasli.Text == "")
            {
                MessageBox.Show("Ingrese los campos vacios");
                return;
            }
            int mesaadmin = 0;
            try
            {
                 mesaadmin = int.Parse(cbmesasli.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay mesas disponibles");
                return;
            }
            ahorafecha = DateTime.Now;
            Mesa_Reserva mesa_Reserva = new Mesa_Reserva()
            {
                Reserva_Admin_ID_Reserva_Ad = id_reserva,
                Mesas_Inventario_ID_Plato = mesaadmin,
                UsuarioCreacion = usuario.ToString(),
                FechayHora_Reserva = fechaHoraReserva,
                UsuarioModificacion = usuario.ToString(),
                FechaCreacion = ahorafecha,
                FechaModificacion = ahorafecha,
                Eliminado = false
            };

            String mensaje = nmesar.Registrar(mesa_Reserva, id_reserva);
            MessageBox.Show(mensaje);
            MostrarMesas(nmesar.ListarTodo(id_reserva));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgMesas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una mesa");
            }
            int mesaid = int.Parse(dgMesas.SelectedRows[0].Cells[0].Value.ToString());
            String Mensaje = nmesar.Eliminar(mesaid);
            MessageBox.Show(Mensaje);
            MostrarMesas(nmesar.ListarTodo(id_reserva));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbmesasli.Text == "")
            {
                MessageBox.Show("Ingrese el campo vacio");
                return;
            }
            if (dgMesas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
            }
            int mesaadmin = int.Parse(cbmesasli.SelectedValue.ToString());
            int id = int.Parse(dgMesas.SelectedRows[0].Cells[0].Value.ToString());
            Mesa_Reserva mesa = new Mesa_Reserva()
            {
                ID_Mesa_Admin = id,
                Mesas_Inventario_ID_Plato = mesaadmin,
                FechaModificacion = DateTime.Now,
                UsuarioModificacion = usuario,
            };
            String Mensaje = nmesar.Modificar(mesa);
            MessageBox.Show(Mensaje);
            MostrarMesas(nmesar.ListarTodo(id_reserva));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgMesasLibres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMesas.SelectedRows.Count == 0)
            {
                return;
            }

            lblUsuarioCreacion.Text = dgMesas.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgMesas.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            FechaHoraModificacion.Text = dgMesas.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblUsuarioModificacion.Text = dgMesas.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }
    }
}
