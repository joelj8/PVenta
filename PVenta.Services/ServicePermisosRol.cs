using PVenta.DAL;
using PVenta.Models.Model;
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

        public bool InsertPermisosRol(PermisosRol permisosRolNew)
        {
            bool resultInsert = false;
           
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
                    resultInsert = true;
                }
                
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return resultInsert;
        }

        public bool UpdatePermisosRol(PermisosRol permisosRolUpd)
        {
            bool resultUpdate = false;
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
                    permisosRolUpdate.OpcionId = permisosRolUpd.OpcionId;
                    permisosRolUpdate.RolId = permisosRolUpd.RolId;
                    _dbcontext.Entry(permisosRolUpdate).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultUpdate = true;
                }
            }

            return resultUpdate;
        }

        public bool DeletePermisosRol(string id)
        {
            bool resultDelete = false;
            PermisosRol permisosRolDelete = GetPermisosRol(id);
            if (permisosRolDelete != null)
            {
                permisosRolDelete.Inactivo = true;
                _dbcontext.Entry(permisosRolDelete).State = System.Data.Entity.EntityState.Modified;
                _dbcontext.SaveChanges();
                resultDelete = true;
            }
            return resultDelete;
        }

    }
}
