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
    public class ServicePermisosRol
    {
        private readonly DBPVentaContext _dbcontext;

        public ServicePermisosRol()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<PermisosRol> GetPermisosRoles()
        {
            var result = _dbcontext.PermisosRols.Include("Rol").Include("OpcionesSist").Where(x => !x.Inactivo).ToList();
            return result;
        }

        public PermisosRol GetPermisosRol(string id)
        {
            var result = _dbcontext.PermisosRols.Include("Rol").Include("OpcionesSist").FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public MessageApp InsertPermisosRol(PermisosRol permisosRolNew)
        {
            MessageApp result = null;
           
            try
            {
                var findRegistr = _dbcontext.PermisosRols
                    .Where(x => x.OpcionId == permisosRolNew.OpcionId &&
                           x.RolId == permisosRolNew.RolId && !x.Inactivo).FirstOrDefault();

                if (findRegistr == null)
                {
                    Guid newId = Guid.NewGuid();
                    permisosRolNew.ID = newId.ToString();
                    _dbcontext.PermisosRols.Add(permisosRolNew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                } 
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
                }
                
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                // Registrar en el log de Errores
            }

            return result;
        }

        public MessageApp UpdatePermisosRol(PermisosRol permisosRolUpd)
        {
            MessageApp result = null;
            var findRegistr = _dbcontext.PermisosRols
                    .Where(x => x.OpcionId == permisosRolUpd.OpcionId &&
                           x.RolId == permisosRolUpd.RolId && 
                           x.ID != permisosRolUpd.ID &&
                           !x.Inactivo).FirstOrDefault();
            if (findRegistr == null)
            {
                PermisosRol permisosRolUpdate = GetPermisosRol(permisosRolUpd.ID);
                if (permisosRolUpdate != null)
                {
                    try
                    {
                        permisosRolUpdate.OpcionId = permisosRolUpd.OpcionId;
                        permisosRolUpdate.RolId = permisosRolUpd.RolId;
                        _dbcontext.Entry(permisosRolUpdate).State = System.Data.Entity.EntityState.Modified;
                        _dbcontext.SaveChanges();
                        result = new MessageApp(ServiceEventApp.GetEventByCode("RS00002"));
                    }
                    catch (Exception ex)
                    {
                        result = new MessageApp(ServiceEventApp.GetEventByCode("ER00002"));
                        // Registrar en el log de Errores
                    }

                } 
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return result;
        }

        public MessageApp DeletePermisosRol(string id)
        {
            MessageApp result = null;
            PermisosRol permisosRolDelete = GetPermisosRol(id);
            if (permisosRolDelete != null)
            {
                try
                {
                    permisosRolDelete.Inactivo = true;
                    _dbcontext.Entry(permisosRolDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00003"));
                }
                catch (Exception ex)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00003"));
                    // Registrar en el log de Errores
                }
            } 
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
            }
            return result;
        }

    }
}
