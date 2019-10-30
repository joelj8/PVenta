using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceCategoria
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceCategoria()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Categoria> GetCategorias()
        {
            var result = _dbcontext.Categorias.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Categoria GetCategoria(string id)
        {
            var result = _dbcontext.Categorias.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertCategoria(Categoria categoriaNew)
        {
            bool resultInsert = false;
            try
            {
                Guid newId = Guid.NewGuid();
                categoriaNew.ID = newId.ToString();
                _dbcontext.Categorias.Add(categoriaNew);
                _dbcontext.SaveChanges();
                resultInsert = true;
            }
            catch (Exception)
            {
                // Registrar en el log de Errores
            }

            return resultInsert;
        }

        public bool UpdateCategoria(Categoria categoriaUpd)
        {
            bool resultUpdate = false;
            try
            {
                Categoria categoriaUpdate = GetCategoria(categoriaUpd.ID);
                if (categoriaUpdate != null)
                {
                    categoriaUpdate.Descripcion = categoriaUpd.Descripcion;
                    categoriaUpdate.ImpComanda = categoriaUpd.ImpComanda;
                    _dbcontext.Entry(categoriaUpdate).State = System.Data.Entity.EntityState.Modified;
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

        public bool DeleteCategoria(string id)
        {
            bool resultDelete = false;
            try
            {
                Categoria categoriaDelete = GetCategoria(id);
                if (categoriaDelete != null)
                {
                    categoriaDelete.Inactivo = true;
                    _dbcontext.Entry(categoriaDelete).State = System.Data.Entity.EntityState.Modified;
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
