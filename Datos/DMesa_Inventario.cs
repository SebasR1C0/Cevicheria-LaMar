using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMesas_Inventario
    {
        public List<Mesas_Inventario> ListarTodo()
        {
            List<Mesas_Inventario> mesas = new List<Mesas_Inventario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mesas = context.Mesas_Inventario.Where(e => e.Eliminado == false).ToList();
                }
                return mesas;
            }
            catch (Exception ex)
            {
                return mesas;
            }
        }
        public List<Mesas_Inventario> ListarMesasLibres(DateTime fechaHoraReserva, int numeroPersonas)
        {
            List<Mesas_Inventario> mesasLibres = new List<Mesas_Inventario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    DateTime intervaloInicio = fechaHoraReserva.AddHours(-3);
                    DateTime intervaloFin = fechaHoraReserva.AddHours(3);

                    var todasLasMesas = context.Mesas_Inventario
                        .Where(m => m.Eliminado == false && m.Capacidad <= numeroPersonas)
                        .ToList();

                    var mesasReservadas = context.Mesa_Reserva
                        .Where(m => m.FechayHora_Reserva >= intervaloInicio &&
                                    m.FechayHora_Reserva <= intervaloFin &&
                                    m.Eliminado == false &&
                                    m.Mesas_Inventario.Eliminado == false &&
                                    m.Reserva.Estado != "Cancelada")
                        .Select(m => m.Mesas_Inventario.ID_Mesa)
                        .ToList();

                    mesasLibres = todasLasMesas
                        .Where(m => !mesasReservadas.Contains(m.ID_Mesa))
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar mesas libres: {ex.Message}");
            }
            return mesasLibres;
        }


        public string Registrar(Mesas_Inventario mesas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Mesas_Inventario.Add(mesas);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Mesas_Inventario mesas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Mesas_Inventario mesastemp = context.Mesas_Inventario.Find(mesas.ID_Mesa);
                    if (mesastemp != null)
                    {
                        mesastemp.Capacidad = mesas.Capacidad;
                        mesastemp.Codigo = mesas.Codigo;
                        mesastemp.UsuarioModificacion = mesas.UsuarioModificacion;
                        mesastemp.FechaModificacion = mesas.FechaModificacion;
                        context.SaveChanges();
                        return "Modificado correctamente";
                    }
                    return "Mesa no encontrada";
                }
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
                    Mesas_Inventario mesastemp = context.Mesas_Inventario.Find(mesaid);
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
        public List<Mesas_Inventario> MesasMasPedidas()
        {
            List<Mesas_Inventario> MesasPedidas = new List<Mesas_Inventario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var mesasmaspedidas = context.Mesa_Reserva
                        .Where(mr => mr.Eliminado == false)
                        .GroupBy(mr => mr.Mesas_Inventario_ID_Plato)
                        .OrderByDescending(g => g.Count())
                        .Select(g => new { ID_Mesa = g.Key, Cantidad = g.Count() })
                        .ToList();

                    foreach (var mesa in mesasmaspedidas)
                    {
                        var mesainfo = context.Mesas_Inventario
                            .Where(m => m.ID_Mesa == mesa.ID_Mesa)
                            .FirstOrDefault();

                        if (mesainfo != null)
                        {
                            MesasPedidas.Add(mesainfo);
                        }
                    }
                }
                return MesasPedidas;
            }
            catch (Exception ex)
            {
                return MesasPedidas;
            }
        }
    }
}
