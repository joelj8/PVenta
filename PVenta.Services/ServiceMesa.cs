using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceMesa
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceMesa()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Mesa> GetMesas()
        {
            var result = _dbcontext.Mesas.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Mesa GetMesa(string id)
        {
            var result = _dbcontext.Mesas.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertMesa(Mesa mesaNew)
        {
            bool resultInsert = false;
            try
            {
                Guid newId = Guid.NewGuid();
                mesaNew.ID = newId.ToString();
                _dbcontext.Mesas.Add(mesaNew);
                _dbcontext.SaveChanges();
                resultInsert = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }

            return resultInsert;
        }

        public bool UpdateMesa(Mesa mesaUpd)
        {
            bool resultUpdate = false;
            try
            {
                Mesa mesaUpdate = GetMesa(mesaUpd.ID);
                if (mesaUpdate != null)
                {
                    mesaUpdate.Descripcion = mesaUpd.Descripcion;
                    _dbcontext.Entry(mesaUpdate).State = System.Data.Entity.EntityState.Modified;
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

        public bool DeleteMesa(string id)
        {
            bool resultDelete = false;
            try
            {
                Mesa mesaDelete = GetMesa(id);
                if (mesaDelete != null)
                {
                    mesaDelete.Inactivo = true;
                    _dbcontext.Entry(mesaDelete).State = System.Data.Entity.EntityState.Modified;
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
