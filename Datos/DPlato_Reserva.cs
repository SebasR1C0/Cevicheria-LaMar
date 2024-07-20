using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPlato_Reserva
    {
        public string Registrar(Plato_Reserva platos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Plato_Reserva.Add(platos);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Plato_Reserva platos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Plato_Reserva platoTemp = context.Plato_Reserva.Find(platos.ID_Plato_Admin);
                    platoTemp.Platos_Inventario_ID_Plato = platos.Platos_Inventario_ID_Plato;
                    platoTemp.UsuarioModificacion = platos.UsuarioModificacion;
                    platoTemp.FechaModificacion = platos.FechaModificacion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int platoid)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Plato_Reserva platostemp = context.Plato_Reserva.Find(platoid);
                    platostemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Plato_Reserva> ListarTodo(int reservaid)
        {
            List<Plato_Reserva> platos = new List<Plato_Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    platos = context.Plato_Reserva.Where(p => p.Reserva_Admin_ID_Reserva_Admin == reservaid &&
                    p.Eliminado == false &&
                    p.Reserva.Eliminado == false &&
                    p.Platos_Inventario.Eliminado == false).ToList();
                }
                return platos;
            }
            catch (Exception ex)
            {
                return platos;
            }
        }
    }



}
