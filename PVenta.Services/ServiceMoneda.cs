using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceMoneda
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceMoneda()
        {
            _dbcontext = new DBPVentaContext();
        }
   
        public List<Moneda> GetMonedas()
        {
            var result = _dbcontext.Monedas.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Moneda GetMoneda(string id)
        {
            var result = _dbcontext.Monedas.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertMoneda(Moneda monedaNew)
        {
            bool resultInsert = false;
            try
            {
                Guid newId = Guid.NewGuid();
                monedaNew.ID = newId.ToString();
                _dbcontext.Monedas.Add(monedaNew);
                _dbcontext.SaveChanges();
                resultInsert = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }

            return resultInsert;
        }

        public bool UpdateMoneda(Moneda monedaUpd)
        {
            bool resultUpdate = false;
            try
            {
                Moneda monedaUpdate = GetMoneda(monedaUpd.ID);
                if (monedaUpdate != null)
                {
                    monedaUpdate.Descripcion = monedaUpd.Descripcion;
                    monedaUpdate.Valor = monedaUpd.Valor;
                    _dbcontext.Entry(monedaUpdate).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultUpdate = true;
                }
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }
            return resultUpdate;
        }

        public bool DeleteMoneda(string id)
        {
            bool resultDelete = false;
            try
            {
                Moneda monedaDelete = GetMoneda(id);
                if (monedaDelete != null)
                {
                    
                    monedaDelete.Inactivo = true;
                    _dbcontext.Entry(monedaDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    resultDelete = true;
                }
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }
            return resultDelete;
        }

    
    }
}
