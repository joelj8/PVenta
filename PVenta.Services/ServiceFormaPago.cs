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
    public class ServiceFormaPago
    {
        private readonly DBPVentaContext _dbcontext;
        public ServiceFormaPago()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<FormaPago> GetFormaPagos()
        {
            List<FormaPago> result = null;
            try
            {
                result = _dbcontext.FormaPagos.Where(x => !x.Inactivo).ToList();
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public FormaPago GetFormaPago(string id)
        {
            FormaPago result = null;
            try
            {
                result = _dbcontext.FormaPagos.FirstOrDefault(x => !x.Inactivo && x.ID.Equals(id));
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public MessageApp InsertFormaPago(FormaPago formaPagoNew)
        {
            MessageApp result = null;
            List<FormaPago> listFormaPagoByDescripcion = findFormaPagoDescripcion(formaPagoNew);
            if (listFormaPagoByDescripcion != null && listFormaPagoByDescripcion.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    formaPagoNew.ID = newId.ToString();
                    _dbcontext.FormaPagos.Add(formaPagoNew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                }
                catch (Exception ex)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                    // Registrar en el log de errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return result;  
        }

        public MessageApp UpdateFormaPago(FormaPago formaPagoUpd)
        {
            MessageApp result = null;
            List<FormaPago> listFormaPagoByDescripcion = findFormaPagoDescripcion(formaPagoUpd);
            if (listFormaPagoByDescripcion != null && listFormaPagoByDescripcion.Count == 0)
            {
                try
                {
                    FormaPago formaPagoUpdate = GetFormaPago(formaPagoUpd.ID);
                    if (formaPagoUpdate != null)
                    {
                        formaPagoUpdate.Descripcion = formaPagoUpd.Descripcion;
                        formaPagoUpdate.MonedaID = formaPagoUpd.MonedaID;
                        _dbcontext.Entry(formaPagoUpdate).State = System.Data.Entity.EntityState.Modified;
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

        public MessageApp DeleteFormaPago(string id)
        {
            MessageApp result = null;
            try
            {
                FormaPago formaPagoDelete = GetFormaPago(id);
                if (formaPagoDelete != null)
                {
                    formaPagoDelete.Inactivo = true;
                    _dbcontext.Entry(formaPagoDelete).State = System.Data.Entity.EntityState.Modified;
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

        private List<FormaPago> findFormaPagoDescripcion(FormaPago formaPagoFind)
        {
            List<FormaPago> formaPagoLista = null;
            try
            {
                formaPagoLista = _dbcontext.FormaPagos.Where(x => !x.Inactivo && x.ID != formaPagoFind.ID &&
                                                   x.Descripcion.Equals(formaPagoFind.Descripcion)).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return formaPagoLista;
        }
    }
}
