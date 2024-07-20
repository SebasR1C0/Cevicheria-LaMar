using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public List<Usuario> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }
    }
}
