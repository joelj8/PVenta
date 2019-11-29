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
    public class ServiceTypeInformacion
    {
        private readonly DBPVentaContext _dbcontext;
        public ServiceTypeInformacion()
        {
             _dbcontext = new DBPVentaContext();
        }

        public List<TypeInformacion> GetTypeInformacions()
        {
            List<TypeInformacion> result = null;
            try
            {
                result = _dbcontext.TypeInformaciones.Where(x => !x.Inactivo).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public TypeInformacion GetTypeInformacion(string id)
        {
            TypeInformacion result = null;
            try
            {
                result = _dbcontext.TypeInformaciones.FirstOrDefault(x => !x.Inactivo && x.ID == id);
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public MessageApp InsertTypeInformacion(TypeInformacion typeInformacionnew)
        {
            MessageApp result = null;
            List<TypeInformacion> listTypeInformacionByNombre = findTypeInformacionNombre(typeInformacionnew);
            if (listTypeInformacionByNombre != null && listTypeInformacionByNombre.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    typeInformacionnew.ID = newId.ToString();
                    _dbcontext.TypeInformaciones.Add(typeInformacionnew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                }
                catch (Exception ex)
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

        public MessageApp UpdateTypeInformacion(TypeInformacion typeInformacionupd)
        {
            MessageApp result = null;
            List<TypeInformacion> listTypeInformacionByNombre = findTypeInformacionNombre(typeInformacionupd);
            if (listTypeInformacionByNombre != null && listTypeInformacionByNombre.Count == 0)
            {
                try
                {
                    TypeInformacion typeInformacionUpdate  = GetTypeInformacion(typeInformacionupd.ID);
                    if (typeInformacionUpdate != null)
                    {
                        typeInformacionUpdate.Descripcion = typeInformacionupd.Descripcion;
                        _dbcontext.Entry(typeInformacionUpdate).State = System.Data.Entity.EntityState.Modified;
                        _dbcontext.SaveChanges();
                        result = new MessageApp(ServiceEventApp.GetEventByCode("RS00002"));
                    }
                    else
                    {
                        result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                    }
                }
                catch (Exception ex)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00002"));
                    // Registrar en el log de Errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return result;
        }

        public MessageApp DeleteTypeInformacion(string id)
        {
            MessageApp result = null;
            try
            {
                TypeInformacion typeInformacionUpdate = GetTypeInformacion(id);
                if (typeInformacionUpdate != null)
                {
                    typeInformacionUpdate.Inactivo = true;
                    _dbcontext.Entry(typeInformacionUpdate).State = System.Data.Entity.EntityState.Modified;
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
                // Registrar en el log de Errores
            }

            return result;
        }

        private List<TypeInformacion> findTypeInformacionNombre(TypeInformacion typeInformacionfind)
        {
            List<TypeInformacion> typeInformacionLista = null;
            try
            {
                typeInformacionLista = _dbcontext.TypeInformaciones
                                       .Where(x => !x.Inactivo && 
                                       x.ID != typeInformacionfind.ID &&
                                       x.Descripcion.ToLower().Equals(typeInformacionfind.Descripcion.ToLower())).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }
            return typeInformacionLista;
        }
    }
}
