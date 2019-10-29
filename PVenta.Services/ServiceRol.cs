using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceRol
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceRol()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Rol> GetRoles()
        {
            var result = _dbcontext.Rols.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Rol GetRol(string id)
        {
            var result = _dbcontext.Rols.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertRol(Rol rolNew)
        {
            bool result = false;
            try
            {
                Guid newId = Guid.NewGuid();
                rolNew.ID = newId.ToString();
                _dbcontext.Rols.Add(rolNew);
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return result;
        }

        public bool UpdateRol(Rol rolUpd)
        {
            bool result = false;

            try
            {
                Rol rolUpdate = GetRol(rolUpd.ID);
                rolUpdate.Nombre = rolUpd.Nombre;
                rolUpdate.Modificable = rolUpd.Modificable;
                _dbcontext.Entry(rolUpdate).State = System.Data.Entity.EntityState.Modified;
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }


            return result;
        }

        public bool DeleteRol(string id)
        {
            bool result = false;

            try
            {
                Rol rolUpdate = GetRol(id);
                rolUpdate.Inactivo = true;
                _dbcontext.Entry(rolUpdate).State = System.Data.Entity.EntityState.Modified;
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }


            return result;
        }

    }
}
