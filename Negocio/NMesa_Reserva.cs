using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMesa_Reserva
    {
        private DMesa_Reserva dmesas = new DMesa_Reserva();
        public String Registrar(Mesa_Reserva mesas, int id)
        {
            List<Mesa_Reserva> mesa = dmesas.ListarTodo(id);
            foreach (Mesa_Reserva m in mesa)
            {
                if (mesas.Mesas_Inventario_ID_Plato == m.Mesas_Inventario_ID_Plato)
                {
                    return "Mesa ya elegida";
                }
            }
            return dmesas.Registrar(mesas);
        }
        public List<Mesa_Reserva> ListarTodo(int reservaid)
        {
            return dmesas.ListarTodo(reservaid);
        }
        public String Modificar(Mesa_Reserva mesas)
        {
            return dmesas.Modificar(mesas);
        }
        public String Eliminar(int mesasid)
        {
            return dmesas.Eliminar(mesasid);
        }
    }
}
