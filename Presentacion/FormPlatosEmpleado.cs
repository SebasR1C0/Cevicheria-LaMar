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
    public partial class FormPlatosEmpleado : Form
    {
        String usuario;
        String fechahora;
        int id_reserva;
        DateTime ahorafecha2;
        private NPlato_Inventario nPlato_Inventario = new NPlato_Inventario();
        private NPlato_Reserva nplato = new NPlato_Reserva();
        private Plato_Reserva plato = new Plato_Reserva();
        public FormPlatosEmpleado(String usuario, String fechahora, int id_reserva)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            this.id_reserva = id_reserva;
            MostrarPlatos(nplato.ListarTodo(id_reserva));
            MostrarInventario(nPlato_Inventario.ListarTodo());
            cbPlato.SelectedIndexChanged += new EventHandler(cbPlato_SelectedIndexChanged);
            dgPlatos.SelectionChanged += new EventHandler(dgPlatos_SelectionChanged);
        }
        private void MostrarInventario(List<Platos_Inventario> platos)
        {
            cbPlato.DataSource = null;
            if (platos.Count == 0)
            {
                return;
            }
            cbPlato.DataSource = platos;
            cbPlato.ValueMember = "ID_Plato";
            cbPlato.DisplayMember = "Nombre_Plato";
        }
        private void cbPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlato.SelectedItem is Platos_Inventario selectedPlato)
            {
                lblCategoria.Text = selectedPlato.Categoria;
                lblPrecio.Text = selectedPlato.Precio.ToString();
            }
        }
        private void MostrarPlatos(List<Plato_Reserva> platos)
        {
            dgPlatos.DataSource = null;
            if (platos.Count == 0)
            {
                return;
            }
            else
            {
                dgPlatos.DataSource = platos;
                dgPlatos.Columns["Eliminado"].Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbPlato.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int platoadmin = int.Parse(cbPlato.SelectedValue.ToString());
            DateTime ahorafecha = DateTime.Now;
            Plato_Reserva plato = new Plato_Reserva()
            {
                Reserva_Admin_ID_Reserva_Admin = id_reserva,
                Platos_Inventario_ID_Plato = platoadmin,
                UsuarioCreacion = usuario.ToString(),
                UsuarioModificacion = usuario.ToString(),
                FechaCreacion = ahorafecha,
                FechaModificacion = ahorafecha,
                Eliminado = false
            };
            String Mensaje = nplato.Registrar(plato);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo(id_reserva));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgPlatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un plato");
            }
            int platoid = int.Parse(dgPlatos.SelectedRows[0].Cells[0].Value.ToString());
            String Mensaje = nplato.Eliminar(platoid);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo(id_reserva));
        }
 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbPlato.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            if (dgPlatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un plato");
            }
            int platoadmin = int.Parse(cbPlato.SelectedValue.ToString());
            int id = int.Parse(dgPlatos.SelectedRows[0].Cells[0].Value.ToString());
            DateTime ahorafecha = DateTime.Now;
            Plato_Reserva plato = new Plato_Reserva()
            {
                ID_Plato_Admin = id,
                Platos_Inventario_ID_Plato = platoadmin,
                UsuarioModificacion = usuario.ToString(),
                FechaModificacion = ahorafecha,
            };
            String Mensaje = nplato.Modificar(plato);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo(id_reserva));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            cbPlato.Text = null;
            lblCategoria.Text = "0";
            lblPrecio.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgPlatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPlatos.SelectedRows.Count == 0)
            {
                return;
            }
            lblUsuarioCreacion.Text = dgPlatos.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgPlatos.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            FechaHoraModificacion.Text = dgPlatos.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblUsuarioModificacion.Text = dgPlatos.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }
    }
}
