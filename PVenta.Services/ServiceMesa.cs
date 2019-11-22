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
    public class ServiceMesa
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceMesa()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Mesa> GetMesas()
        {
            var result = _dbcontext.Mesas.Where(x => !x.Inactivo).OrderBy(s => s.Orden).ToList();
            return result;
        }

        public Mesa GetMesa(string id)
        {
            var result = _dbcontext.Mesas.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public MessageApp InsertMesa(Mesa mesaNew)
        {
            MessageApp result = null;
            List<Mesa> listMesaByName = findMesaName(mesaNew);
            if (listMesaByName != null && listMesaByName.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    mesaNew.ID = newId.ToString();
                    _dbcontext.Mesas.Add(mesaNew);
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

        public MessageApp UpdateMesa(Mesa mesaUpd)
        {
            MessageApp result = null;
            List<Mesa> listMesaByName = findMesaName(mesaUpd);
            if (listMesaByName != null && listMesaByName.Count == 0)
            {
                try
                {
                    Mesa mesaUpdate = GetMesa(mesaUpd.ID);
                    if (mesaUpdate != null)
                    {
                        mesaUpdate.Descripcion = mesaUpd.Descripcion;
                        mesaUpdate.Orden = mesaUpd.Orden;
                        _dbcontext.Entry(mesaUpdate).State = System.Data.Entity.EntityState.Modified;
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
                    // Registrar en el log de Errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
            
            return result;
        }

        public MessageApp DeleteMesa(string id)
        {
            MessageApp result = null;
            try
            {
                Mesa mesaDelete = GetMesa(id);
                if (mesaDelete != null)
                {
                    mesaDelete.Inactivo = true;
                    _dbcontext.Entry(mesaDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00003"));
                } 
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
            }
            catch (Exception)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00003"));
                // Registrar en el log de Errores
            }

            return result;
        }

        private List<Mesa> findMesaName(Mesa mesafind)
        {
            List<Mesa> resultList = null;
            try
            {
                resultList = _dbcontext.Mesas.Where(x => !x.Inactivo && x.ID != mesafind.ID &&
                                                    x.Descripcion.Equals(mesafind.Descripcion)).ToList();
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return resultList;
        }
    }
}
