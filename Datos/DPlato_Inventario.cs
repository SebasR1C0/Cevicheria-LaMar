using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPlatos_Inventario
    {
        public List<Platos_Inventario> ListarTodo()
        {
            List<Platos_Inventario> platos = new List<Platos_Inventario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    platos = context.Platos_Inventario.Where(p => p.Eliminado == false).ToList();
                }
                return platos;
            }
            catch (Exception ex)
            {
                return platos;
            }
        }
        public String Registrar(Platos_Inventario platos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Platos_Inventario.Add(platos);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Platos_Inventario platos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Platos_Inventario platostemp = context.Platos_Inventario.Find(platos.ID_Plato);
                    platostemp.Nombre_Plato = platos.Nombre_Plato;
                    platostemp.Precio = platos.Precio;
                    platostemp.Categoria = platos.Categoria;
                    platostemp.UsuarioModificacion = platos.UsuarioModificacion;
                    platostemp.FechaModificacion = platos.FechaModificacion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int mesaid)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Platos_Inventario platostemp = context.Platos_Inventario.Find(mesaid);
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
        public List<Platos_Inventario> ListarPlatosMasVendidos()
        {
            List<Platos_Inventario> platosMasVendidos = new List<Platos_Inventario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var platosVendidos = context.Plato_Reserva
                        .Where(pr => pr.Eliminado == false)
                        .GroupBy(pr => pr.Platos_Inventario_ID_Plato)
                        .OrderByDescending(g => g.Count())
                        .Select(g => new { PlatoId = g.Key, Cantidad = g.Count() })
                        .ToList();

                    foreach (var plato in platosVendidos)
                    {
                        var platoInfo = context.Platos_Inventario
                            .Where(p => p.ID_Plato == plato.PlatoId)
                            .FirstOrDefault();

                        if (platoInfo != null)
                        {
                            platosMasVendidos.Add(platoInfo);
                        }
                    }
                }
                return platosMasVendidos;
            }
            catch (Exception ex)
            {
                return platosMasVendidos;
            }
        }
    }
}
