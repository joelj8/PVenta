using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceProducto
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceProducto()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Producto> GetProductos()
        {
            var result = _dbcontext.Productos.Include("Categoria").Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Producto GetProducto(string id)
        {
            var result = _dbcontext.Productos.Include("Categoria").FirstOrDefault(x => !x.Inactivo && x.ID == id);
            return result;
        }

        public bool InsertProducto(Producto productoNew)
        {
            bool resultInsert = false;
            try
            {
                Guid newId = Guid.NewGuid();
                productoNew.ID = newId.ToString();
                _dbcontext.Productos.Add(productoNew);
                _dbcontext.SaveChanges();
                resultInsert = true;
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }
            return resultInsert;
        }

        public bool UpdateProducto(Producto productoUpd)
        {
            bool resultUpdate = false;
            try
            {
                Producto productoUpdate = GetProducto(productoUpd.ID);
                if (productoUpdate != null)
                {
                    productoUpdate.Nombre = productoUpd.Nombre;
                    productoUpdate.NombreCorto = productoUpd.NombreCorto;
                    productoUpdate.Precio = productoUpd.Precio;
                    productoUpdate.CategoriaId = productoUpd.CategoriaId;
                    productoUpdate.esAdicional = productoUpd.esAdicional;
                    productoUpdate.ImpComanda = productoUpd.ImpComanda;
                    _dbcontext.Entry(productoUpdate).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultUpdate = true;
                }
            }
            catch (Exception)
            {

                // Registrar en el log de errores
            }
            return resultUpdate;
        }

        public bool DeleteProducto(string id)
        {
            bool resultDelete = false;
            try
            {
                Producto productoDelete = GetProducto(id);
                if (productoDelete != null)
                {
                    productoDelete.Inactivo = true;
                    _dbcontext.Entry(productoDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultDelete = true;
                }
            }
            catch (Exception)
            {

                // Registrar en el log de errores
            }
            return resultDelete;
        }


    }
}
