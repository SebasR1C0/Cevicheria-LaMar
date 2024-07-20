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
    public partial class FormPlatosAdmin : Form
    {
        String usuario;
        String fechahora;
        DateTime ahorafecha;
        DateTime ahorafecha2;
        private NPlato_Inventario nplato = new NPlato_Inventario();
        private Platos_Inventario plain = new Platos_Inventario();
        public FormPlatosAdmin(String usuario, String fechahora)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            MostrarPlatos(nplato.ListarTodo());
        }
        private void MostrarPlatos(List<Platos_Inventario> platos)
        {
            dgplatos.DataSource = null;
            if (platos.Count == 0)
            {
                return;
            }
            else
            {
                dgplatos.DataSource = platos;
                dgplatos.Columns["Eliminado"].Visible = false;
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgplatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un plato");
            }
            int platoid = int.Parse(dgplatos.SelectedRows[0].Cells[0].Value.ToString());
            String Mensaje = nplato.Eliminar(platoid);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || cbCategoria.Text == ""|| tbPrecio.Text=="")
            {
                MessageBox.Show("Ingrese el campo vacio");
                return;
            }
            decimal precio = 0;
            try
            {
                precio = decimal.Parse(tbPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un número válido");
            }
            if (dgplatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
            }
            ahorafecha2 = DateTime.Now;
            int platoid = int.Parse(dgplatos.SelectedRows[0].Cells[0].Value.ToString());
            Platos_Inventario plato = new Platos_Inventario()
            {
                ID_Plato = platoid,
                Precio = precio,
                Categoria = cbCategoria.Text,
                Nombre_Plato = tbNombre.Text,
                FechaModificacion = ahorafecha2,
                UsuarioModificacion = usuario
            };
            String Mensaje = nplato.Modificar(plato);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            tbPrecio.Text = "";
            tbNombre.Text = "";
        }
        private void dgPlatossAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgplatos.SelectedRows.Count == 0)
            {
                return;
            }
            cbCategoria.SelectedIndex = cbCategoria.Items.IndexOf(dgplatos.SelectedRows[0].Cells["Categoria"].Value.ToString());
            tbNombre.Text = dgplatos.SelectedRows[0].Cells["Nombre_Plato"].Value.ToString();
            tbPrecio.Text = dgplatos.SelectedRows[0].Cells["Precio"].Value.ToString();
            lblUsuarioCreacion.Text = dgplatos.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgplatos.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            FechaHoraModificacion.Text = dgplatos.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblUsuarioModificacion.Text = dgplatos.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecio.Text == "" || cbCategoria.Text == "")
            {
                MessageBox.Show("Ingrese el campo vacio");
                return;
            }
            ahorafecha = DateTime.Now;
            decimal precio = 0;
            try
            {
                precio = decimal.Parse(tbPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un número válido");
            }
            Platos_Inventario plato = new Platos_Inventario()
            {
                Nombre_Plato = tbNombre.Text.Trim(),
                Precio = precio,
                Categoria = cbCategoria.Text,
                UsuarioCreacion = usuario.ToString(),
                UsuarioModificacion = usuario.ToString(),
                FechaCreacion = ahorafecha,
                FechaModificacion = ahorafecha,
                Eliminado = false,

            };
            String Mensaje = nplato.Registrar(plato);
            MessageBox.Show(Mensaje);
            MostrarPlatos(nplato.ListarTodo());
        }
    }
}
