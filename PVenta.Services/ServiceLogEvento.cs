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
    public class ServiceLogEvento
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceLogEvento()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<LogEvento> GetLogEventos()
        {
            var result = _dbcontext.LogEventos.Include("Usuario").Include("ErrorList").ToList();
            return result;
        }

        public LogEvento GetLogEvento(string id)
        {
            var result = _dbcontext.LogEventos.Include("Usuario").Include("ErrorList").Where(x => x.ID == id).FirstOrDefault();
            return result;
        }

        public MessageApp InsertLogEvento(LogEvento logEventoNew)
        {
            MessageApp result = null;
            try
            {
                Guid newId = Guid.NewGuid();
                logEventoNew.ID = newId.ToString();
                _dbcontext.LogEventos.Add(logEventoNew);
                _dbcontext.SaveChanges();
                result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                // Registrar en el log de Errores
            }

            return result;
        }
    
        public MessageApp UpdateLogEvento(LogEvento logEventoUpd)
        {
            MessageApp result = null;

            try
            {
                LogEvento logEventoUpdate = GetLogEvento(logEventoUpd.ID);
                if (logEventoUpdate != null)
                {
                    logEventoUpdate.Fecha = logEventoUpd.Fecha;
                    logEventoUpdate.UserId = logEventoUpd.UserId;
                    logEventoUpdate.TipoEvento = logEventoUpd.TipoEvento;
                    logEventoUpdate.ErrorListId = logEventoUpd.ErrorListId;
                    _dbcontext.Entry(logEventoUpdate).State = System.Data.Entity.EntityState.Modified;
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


            return result;
        }
    
    }
}
