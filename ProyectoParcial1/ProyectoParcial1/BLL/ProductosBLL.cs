using ProyectoParcial1.DAL;
using ProyectoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos Producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Producto.Add(Producto) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Productos Producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Producto).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Producto.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos Producto;

            try
            {
                Producto = db.Producto.Find(id); 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Producto;
        }
    }
}
