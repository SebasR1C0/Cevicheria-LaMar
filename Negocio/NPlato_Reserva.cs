using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPlato_Reserva
    {
        private DPlato_Reserva dplato = new DPlato_Reserva();
        public String Registrar(Plato_Reserva platos)
        {
            return dplato.Registrar(platos);
        }
        public String Modificar(Plato_Reserva platos)
        {
            return dplato.Modificar(platos);
        }
        public String Eliminar(int id)
        {
            return dplato.Eliminar(id);
        }
        public List<Plato_Reserva> ListarTodo(int reservaid)
        {
            return dplato.ListarTodo(reservaid);
        }
    }
}
