using PVenta.DAL;
using PVenta.Models.Model;
using PVenta.Utility;
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

        public MessageApp InsertCategoria(Categoria categoriaNew)
        {
            MessageApp result = null;
            List<Categoria> listCategoriaByDescripcion = findCategoriaDescripcion(categoriaNew);
            if (listCategoriaByDescripcion != null && listCategoriaByDescripcion.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    categoriaNew.ID = newId.ToString();
                    _dbcontext.Categorias.Add(categoriaNew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                }
                catch (Exception)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                    // Registrar en el log de Errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
            return result;
        }

        public MessageApp UpdateCategoria(Categoria categoriaUpd)
        {
            MessageApp result = null;
            List<Categoria> listCategoriaByDescripcion = findCategoriaDescripcion(categoriaUpd);
            if (listCategoriaByDescripcion != null && listCategoriaByDescripcion.Count == 0)
            {
                try
                {
                    Categoria categoriaUpdate = GetCategoria(categoriaUpd.ID);
                    if (categoriaUpdate != null)
                    {
                        categoriaUpdate.Descripcion = categoriaUpd.Descripcion;
                        categoriaUpdate.ImpComanda = categoriaUpd.ImpComanda;
                        _dbcontext.Entry(categoriaUpdate).State = System.Data.Entity.EntityState.Modified;
                        _dbcontext.SaveChanges();
                        result = new MessageApp(ServiceEventApp.GetEventByCode("RS00002"));
                    }
                    else
                    {
                        result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                    }
                }
                catch (Exception)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00002"));
                    // Registrar en el log de errores
                }
            } 
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
            return result;
        }

        public MessageApp DeleteCategoria(string id)
        {
            MessageApp result = null;
            try
            {
                Categoria categoriaDelete = GetCategoria(id);
                if (categoriaDelete != null)
                {
                    categoriaDelete.Inactivo = true;
                    _dbcontext.Entry(categoriaDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00003"));
                }
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00003"));
                // Registrar en el log de errores
            }
            return result;
        }

        public List<Categoria> findCategoriaDescripcion(Categoria categoriafind)
        {
            List<Categoria> categoriaLista = null;
            try
            {
                categoriaLista = _dbcontext.Categorias.Where(x => !x.Inactivo && x.ID != categoriafind.ID &&
                                                          x.Descripcion.Equals(categoriafind.Descripcion)).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return categoriaLista;
        }
    }
}
