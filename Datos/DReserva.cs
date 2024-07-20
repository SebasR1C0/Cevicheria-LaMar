using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReserva
    {
        public List<Reserva> ListarTodo()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.Where(r => r.Eliminado == false).ToList();
                }
                return reservas;
            }
            catch (Exception ex)
            {
                return reservas;
            }
        }
        public String Registrar(Reserva reservas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Reserva.Add(reservas);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Reserva reservas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Reserva reservatemp = context.Reserva.Find(reservas.ID_Reserva);
                    reservatemp.Nombre_Cliente = reservas.Nombre_Cliente;
                    reservatemp.Numero_Personas = reservas.Numero_Personas;
                    reservatemp.FechayHora_Reserva = reservas.FechayHora_Reserva;
                    reservatemp.Estado = reservas.Estado;
                    reservatemp.UsuarioModificacion = reservas.UsuarioModificacion;
                    reservatemp.FechaModificacion = reservas.FechaModificacion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int reservaid)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Reserva reservatemp = context.Reserva.Find(reservaid);
                    reservatemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Reserva> FiltrarPorNumeroDePersonas(int numeropersonas)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.Where(r => r.Numero_Personas == numeropersonas).ToList();
                }
                return reservas;
            }
            catch (Exception ex)
            {
                return reservas;
            }
        }
        public List<Reserva> FiltrarPorFecha(DateTime fecha)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.Where(r => r.FechayHora_Reserva.Day == fecha.Day &&
                    r.Eliminado == false).ToList();
                }
                return reservas;
            }
            catch (Exception ex)
            {
                return reservas;
            }
        }
        public List<Reserva> FiltrarPorNumeroDePersonasyFecha(int numeropersonas, DateTime fecha)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.Where(r => r.Numero_Personas == numeropersonas
                    && r.FechayHora_Reserva.Day == fecha.Day &&
                    r.Eliminado == false).ToList();
                }
                return reservas;
            }
            catch (Exception ex)
            {
                return reservas;
            }
        }
        public decimal ObtenerMontoPorRango(DateTime fechaIni, DateTime fechaFin)
        {
            decimal monto = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    monto = context.Plato_Reserva.Where(p => p.Eliminado == false &&
                    p.Reserva.Estado.Equals("Confirmada") && p.Reserva.Eliminado == false &&
                    p.Reserva.FechayHora_Reserva.Day >= fechaIni.Day && p.Reserva.FechayHora_Reserva.Day <= fechaFin.Day).Sum(p => p.Platos_Inventario.Precio);
                }
                return monto;
            }
            catch (Exception ex)
            {
                return monto;
            }
        }
        public List<Reserva> ObtenerHorarioMasReservado()
        {
            List<Reserva> reservasConHorarioMasReservado = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    var horarioMasReservado = context.Reserva
                        .Where(r => !r.Eliminado && (r.Estado == "Pendiente" || r.Estado == "Confirmada"))
                        .GroupBy(r => r.FechayHora_Reserva.Hour)
                        .OrderByDescending(g => g.Count())
                        .Select(g => g.Key)
                        .FirstOrDefault();

                    if (horarioMasReservado != default)
                    {
                        reservasConHorarioMasReservado = context.Reserva
                            .Where(r => !r.Eliminado &&
                                        (r.Estado == "Pendiente" || r.Estado == "Confirmada") &&
                                        r.FechayHora_Reserva.Hour == horarioMasReservado)
                            .ToList();
                    }
                    return reservasConHorarioMasReservado;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el horario más reservado: {ex.Message}");
                return new List<Reserva>();
            }
        }
    }
}
