using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReserva
    {
        private DReserva dReserva = new DReserva();
        public List<Reserva> ListarTodo()
        {
            return dReserva.ListarTodo();
        }
        public String Registrar(Reserva mesas)
        {
            return dReserva.Registrar(mesas);
        }
        public String Modificar(Reserva mesas)
        {
            return dReserva.Modificar(mesas);
        }
        public String Eliminar(int mesasid)
        {
            return dReserva.Eliminar(mesasid);
        }
        public List<Reserva> FiltrarDia(DateTime fecha)
        {
            return dReserva.FiltrarPorFecha(fecha);
        }
        public List<Reserva> FiltrarPersonas(int cantidad)
        {
            return dReserva.FiltrarPorNumeroDePersonas(cantidad);
        }
        public List<Reserva> FiltrarDiayPersonas(int cantidad, DateTime fecha)
        {
            return dReserva.FiltrarPorNumeroDePersonasyFecha(cantidad, fecha);
        }
        public decimal ObtenerMontoRango(DateTime fini, DateTime ffin)
        {
            return dReserva.ObtenerMontoPorRango(fini, ffin);
        }
        public List<Reserva> ObtenerHorarioMasReservado()
        {
            var reservas = dReserva.ObtenerHorarioMasReservado();
            Console.WriteLine($"Número de reservas obtenidas en NReserva: {reservas.Count}");
            return reservas;
        }
    }
}
