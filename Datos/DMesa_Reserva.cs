using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMesa_Reserva
    {
        public string Registrar(Mesa_Reserva mesas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Mesa_Reserva.Add(mesas);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Mesa_Reserva> ListarTodo(int reservaid)
        {
            List<Mesa_Reserva> mesas = new List<Mesa_Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mesas = context.Mesa_Reserva.Where(m => m.Reserva.ID_Reserva == reservaid && 
                    m.Eliminado == false &&
                    m.Reserva.Eliminado == false &&
                    m.Mesas_Inventario.Eliminado == false).ToList();
                }
                return mesas;
            }
            catch (Exception ex)
            {
                return mesas;
            }
        }
        public string Modificar(Mesa_Reserva mesas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Mesa_Reserva mesastemp = context.Mesa_Reserva.Find(mesas.ID_Mesa_Admin);
                    mesastemp.UsuarioModificacion = mesas.UsuarioModificacion;
                    mesastemp.FechaModificacion = mesas.FechaModificacion;
                    mesastemp.Mesas_Inventario_ID_Plato = mesas.Mesas_Inventario_ID_Plato;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int mesaid)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Mesa_Reserva mesastemp = context.Mesa_Reserva.Find(mesaid);
                    if (mesastemp != null)
                    {
                        mesastemp.Eliminado = true;
                        context.SaveChanges();
                        return "Eliminado correctamente";
                    }
                    return "Mesa no encontrada";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

}
