using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceOpcionesSist
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceOpcionesSist()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<OpcionesSist> GetOpcionesSists()
        {
            var result = _dbcontext.OpcionesSists.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public OpcionesSist GetOpcionesSist(string id)
        {
            var result = _dbcontext.OpcionesSists.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertOpcionesSist(OpcionesSist opcionesSistNew)
        {
            bool result = false;
            try
            {
                Guid newId = Guid.NewGuid();
                opcionesSistNew.ID = newId.ToString();
                _dbcontext.OpcionesSists.Add(opcionesSistNew);
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return result;
        }

        public bool UpdateOpcionesSist(OpcionesSist opcionesSistUpd)
        {
            bool resultUpdate = false;
            try
            {
                OpcionesSist opcionesSistUpdate = GetOpcionesSist(opcionesSistUpd.ID);
                if (opcionesSistUpdate != null)
                {
                    opcionesSistUpdate.Codigo = opcionesSistUpd.Codigo;
                    opcionesSistUpdate.Descripcion = opcionesSistUpd.Descripcion;
                    _dbcontext.Entry(opcionesSistUpdate).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultUpdate = true;
                }
            }
            catch (Exception)
            {
                // Registrar en el log de Errores
            }

            return resultUpdate;
        }

        public bool DeleteOpcionesSist(string id)
        {
            bool resultDelete = false;
            try
            {
                OpcionesSist opcionesSistDelete = GetOpcionesSist(id);
                if (opcionesSistDelete != null)
                {
                    opcionesSistDelete.Inactivo = true;
                    _dbcontext.Entry(opcionesSistDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultDelete = true;
                }
            }
            catch (Exception)
            {
                // Registrar en el log de Errores
            }

            return resultDelete;
        }


    }
}
