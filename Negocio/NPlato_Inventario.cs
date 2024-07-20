using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPlato_Inventario
    {
        private DPlatos_Inventario dplatos = new DPlatos_Inventario();
        public List<Platos_Inventario> ListarTodo()
        {
            return dplatos.ListarTodo();
        }
        public String Registrar(Platos_Inventario platos)
        {
            return dplatos.Registrar(platos);
        }
        public String Modificar(Platos_Inventario platos)
        {
            return dplatos.Modificar(platos);
        }
        public String Eliminar(int platosid)
        {
            return dplatos.Eliminar(platosid);
        }
        public List<Platos_Inventario> ListarPlatosMasVendidos()
        {
            return dplatos.ListarPlatosMasVendidos();
        }
    }
}
