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
    public partial class FormLogin : Form
    {
        private NUsuario nusuario = new NUsuario();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbContrasena.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Usuario usuario = new Usuario()
            {
                Nombre_Usuario = tbUsuario.Text.Trim(),
                Contrasena = tbContrasena.Text.Trim(),
            };
            string fechahora = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            List<Usuario> ususariotemp = nusuario.ListarTodo();
            Usuario usuarioEncontrado = ususariotemp.FirstOrDefault(u => u.Nombre_Usuario == usuario.Nombre_Usuario && u.Contrasena == usuario.Contrasena);

            if (usuarioEncontrado != null)
            {
                usuario.Rol = usuarioEncontrado.Rol.Trim();

                switch (usuario.Rol)
                {
                    case "Administrador":
                        FormAdmin formAdmin = new FormAdmin(tbUsuario.Text.Trim(), fechahora);
                        formAdmin.Show();
                        break;

                    case "Empleado":
                        FormReservaEmpleado formEmpleado = new FormReservaEmpleado(tbUsuario.Text.Trim(), fechahora);
                        formEmpleado.Show();
                        break;

                    default:
                        MessageBox.Show("Datos Incorrectos");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


