using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMesa_Inventario
    {
        private DMesas_Inventario dmesas = new DMesas_Inventario();
        public List<Mesas_Inventario> ListarTodo()
        {
            return dmesas.ListarTodo();
        }

        public String Registrar(Mesas_Inventario mesas)
        {
            List<Mesas_Inventario> mesa = dmesas.ListarTodo();
            foreach (Mesas_Inventario m in mesa)
            {
                if (mesas.Codigo == m.Codigo)
                {
                    return "Codido repetido";
                }
            }
            return dmesas.Registrar(mesas);
        }
        public String Modificar(Mesas_Inventario mesas)
        {
            List<Mesas_Inventario> mesa = dmesas.ListarTodo();
            foreach (Mesas_Inventario m in mesa)
            {
                if (mesas.Codigo == m.Codigo && mesas.ID_Mesa != m.ID_Mesa)
                {
                    return "Código repetido";
                }
            }
            return dmesas.Modificar(mesas);
        }
        public String Eliminar(int mesasid)
        {
            return dmesas.Eliminar(mesasid);
        }
        public List<Mesas_Inventario> ListarMesasLibres(DateTime fechaHoraReserva, int num)
        {
            return dmesas.ListarMesasLibres(fechaHoraReserva, num);
        }
        public List<Mesas_Inventario> MesasMasPedidas()
        {
            return dmesas.MesasMasPedidas();
        }
    }
}
