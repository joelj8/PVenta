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

        public MessageApp InsertMoneda(Moneda monedaNew)
        {
            MessageApp result = null;
            List<Moneda> listMonedaByDescripcion = findMonedaDescripcion(monedaNew);
            if (listMonedaByDescripcion != null && listMonedaByDescripcion.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    monedaNew.ID = newId.ToString();
                    _dbcontext.Monedas.Add(monedaNew);
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

        public MessageApp UpdateMoneda(Moneda monedaUpd)
        {
            MessageApp result = null;
            List<Moneda> listMonedaByDescripcion = findMonedaDescripcion(monedaUpd);
            if (listMonedaByDescripcion != null && listMonedaByDescripcion.Count == 0)
            {
                try
                {
                    Moneda monedaUpdate = GetMoneda(monedaUpd.ID);
                    if (monedaUpdate != null)
                    {
                        monedaUpdate.Descripcion = monedaUpd.Descripcion;
                        monedaUpdate.Valor = monedaUpd.Valor;
                        _dbcontext.Entry(monedaUpdate).State = System.Data.Entity.EntityState.Modified;
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
                    // Registrar en el log de errores
                }
            } 
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
               
            return result;
        }

        public MessageApp DeleteMoneda(string id)
        {
            MessageApp result = null;
            try
            {
                Moneda monedaDelete = GetMoneda(id);
                if (monedaDelete != null)
                {
                    
                    monedaDelete.Inactivo = true;
                    _dbcontext.Entry(monedaDelete).State = System.Data.Entity.EntityState.Modified;
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

        public List<Moneda> findMonedaDescripcion(Moneda monedafind)
        {
            List<Moneda> monedaLista = null;
            try
            {
                monedaLista = _dbcontext.Monedas.Where(x => !x.Inactivo && x.ID != monedafind.ID &&
                                                       (x.Descripcion.Equals(monedafind.Descripcion) ||
                                                        x.Valor.Equals(monedafind.Valor))).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return monedaLista;
        }
    
    }
}
