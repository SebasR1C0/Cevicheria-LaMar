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
    public partial class FormMesasAdmin : Form
    {
        String usuario;
        String fechahora;
        DateTime ahorafecha;
        DateTime ahorafecha2;
        private NMesa_Inventario nmesa = new NMesa_Inventario();
        private Mesas_Inventario mesain = new Mesas_Inventario();

        public FormMesasAdmin(String usuario, String fechahora)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
            MostrarMesas(nmesa.ListarTodo());
        }

        private void MostrarMesas(List<Mesas_Inventario> mesas)
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbCapacidad.Text == "" || TBCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el campo vacio");
                return;
            }
            ahorafecha = DateTime.Now;
            int capacidad = 0;
            try
            {
                capacidad = int.Parse(tbCapacidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un número válido");
            }
            Mesas_Inventario mesa = new Mesas_Inventario()
            {
                Codigo = TBCodigo.Text.Trim(),
                Capacidad = capacidad,
                UsuarioCreacion = usuario.ToString(),
                UsuarioModificacion = usuario.ToString(),
                FechaCreacion = ahorafecha,
                FechaModificacion = ahorafecha,
                Estado = "Libre",
                Eliminado = false,

            };
            String Mensaje = nmesa.Registrar(mesa);
            MessageBox.Show(Mensaje);
            MostrarMesas(nmesa.ListarTodo());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgMesas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una mesa");
            }
            int mesaid = int.Parse(dgMesas.SelectedRows[0].Cells[0].Value.ToString());
            String Mensaje = nmesa.Eliminar(mesaid);
            MessageBox.Show(Mensaje);
            MostrarMesas(nmesa.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbCapacidad.Text == "" || TBCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el campo vacio");
                return;
            }
            int capacidad = 0;
            try
            {
                capacidad = int.Parse(tbCapacidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un número válido");
            }
            if (dgMesas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
            }
            ahorafecha2 = DateTime.Now;
            int mesaid = int.Parse(dgMesas.SelectedRows[0].Cells[0].Value.ToString());
            Mesas_Inventario mesa = new Mesas_Inventario()
            {
                ID_Mesa = mesaid,
                Capacidad = capacidad,
                Codigo = TBCodigo.Text.Trim(),
                FechaModificacion =ahorafecha2,
                UsuarioModificacion = usuario
            };
            String Mensaje = nmesa.Modificar(mesa);
            MessageBox.Show(Mensaje);
            MostrarMesas(nmesa.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            tbCapacidad.Text = "";
            TBCodigo.Text = "";
        }
        private void dgMesasAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMesas.SelectedRows.Count == 0)
            {
                return;
            }
            tbCapacidad.Text = dgMesas.SelectedRows[0].Cells["Capacidad"].Value.ToString();
            TBCodigo.Text = dgMesas.SelectedRows[0].Cells["Codigo"].Value.ToString();
            lblUsuarioCreacion.Text = dgMesas.SelectedRows[0].Cells["UsuarioCreacion"].Value.ToString();
            lblFechaHoraCreacion.Text = dgMesas.SelectedRows[0].Cells["FechaCreacion"].Value.ToString();
            FechaHoraModificacion.Text = dgMesas.SelectedRows[0].Cells["FechaModificacion"].Value.ToString();
            lblUsuarioModificacion.Text = dgMesas.SelectedRows[0].Cells["UsuarioModificacion"].Value.ToString();
        }

    }
}
