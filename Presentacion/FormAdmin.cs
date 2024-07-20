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
    public partial class FormAdmin : Form
    {
        String usuario;
        String fechahora;

        public FormAdmin(String usuario, String fechahora)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.fechahora = fechahora;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FormReservaAdmin form = new FormReservaAdmin(usuario, fechahora);
            form.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            FormMesasAdmin form = new FormMesasAdmin(usuario, fechahora);
            form.Show();
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            FormPlatosAdmin form = new FormPlatosAdmin(usuario, fechahora);
            form.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
